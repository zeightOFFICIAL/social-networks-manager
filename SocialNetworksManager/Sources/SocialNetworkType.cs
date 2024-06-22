


using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

using TL;
using WTelegram;

using VkNet;
using VkNet.Model;
using VkNet.Enums.Filters;

using SocialNetworksManager.Configuration;
using SocialNetworksManager.Forms;



namespace SocialNetworksManager.Sources
{
    interface ISocialNetwork
    {
        static abstract Guid Id { get; }
        static abstract string? Name { get; }
        static abstract Color BaseColor { get; }
        static abstract Color SecondColor { get; }
        static abstract void Connect();
        static abstract void Disconnect();
        static abstract void GetContacts();
        static abstract Task<List<MessageWrap>> GetMessages(long APIId, int offset, int limit, string contactType);
        static abstract Task<bool> SendMessage(long user, MessageUnwrap mesg, string contactType);
    }

    class TelegramSocialNetwork : ISocialNetwork
    {
        public static Guid Id { get; } = new Guid();
        public static string? Name { get; } = "Telegram";
        public static Color BaseColor { get; } = Color.SkyBlue;
        public static Color SecondColor { get; } = Color.White;


        private static Client? apiClient;
        private static IConfigurationRoot? aggregationConfiguration;
        private static TgApiConfig? tgApiConfiguration;

        public static void Connect()
        {
            GetAggregationConfiguration();
            apiClient = new Client(ParseTgConfiguration);
        }

        public static void Disconnect() 
        { 

        }

        private static string? ParseTgConfiguration(string argument)
        {
            return argument switch
            {
                "api_id" => tgApiConfiguration?.ApiId,
                "api_hash" => tgApiConfiguration?.ApiHash,
                "phone_number" => tgApiConfiguration?.Phone,
                "verification_code" => tgApiConfiguration.Code,
                "first_name" => tgApiConfiguration?.FirstName,
                "last_name" => tgApiConfiguration?.LastName,
                "password" => tgApiConfiguration?.Password,
                "server_address" => tgApiConfiguration?.Server,
                _ => null,
            };
        }

        private static void GetAggregationConfiguration()
        {
            var builder = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("Configs/aggregation.json", optional: false, reloadOnChange: true);

            aggregationConfiguration = builder.Build();
            tgApiConfiguration = aggregationConfiguration.GetSection("TgConfig").Get<TgApiConfig>();
        }

        public static async Task<(IEnumerable<TL.User> users, IEnumerable<ChatBase> chats, Dictionary<long, MessageBase> lastMessages)> GetAllContacts()
        {
            _ = await apiClient.LoginUserIfNeeded();

            var dialogs = await apiClient.Messages_GetAllDialogs();
            var usersList = new List<TL.User>();
            var chatsList = new List<TL.Chat>();
            var lastMessagesByIdDict = new Dictionary<long, MessageBase>();

            foreach (var dialog in dialogs.dialogs)
            {
                switch (dialogs.UserOrChat(dialog))
                {
                    case TL.User user when user.IsActive:
                        usersList.Add(user);

                        var lastMesgForUser = await apiClient.Messages_GetHistory(user, limit: 1);
                        if (lastMesgForUser.Messages.Length > 0)
                        {
                            lastMessagesByIdDict[user.ID] = lastMesgForUser.Messages[0];
                        }

                        break;

                    case TL.Chat chat when chat.IsActive:
                        chatsList.Add(chat);

                        var lastMesgForChat = await apiClient.Messages_GetHistory(chat, limit: 1);
                        if (lastMesgForChat.Messages.Length > 0)
                        {
                            lastMessagesByIdDict[chat.ID] = lastMesgForChat.Messages[0];
                        }

                        break;
                }
            }
            return (usersList, chatsList, lastMessagesByIdDict);
        }

        public static async Task<List<MessageWrap>> GetMessages(long APIId, int offset, int limit, string contactType)
        {
            _ = await apiClient.LoginUserIfNeeded();
            InputPeer peer;
            var totalFetched = 0;

            if (contactType == "userTG")
            {
                var dialogs = await apiClient.Messages_GetAllDialogs();
                peer = dialogs.users[APIId];
            }
            else
            {
                var chats = await apiClient.Messages_GetAllChats();
                peer = chats.chats[APIId];
            }

            return await FetchMessages(offset, limit, peer, totalFetched);
        }

        private static async Task<List<MessageWrap>> FetchMessages(int offset, int limit, InputPeer peer, int totalFetched)
        {
            List<MessageWrap> messagesList = new List<MessageWrap>();

            for (int add_offset = offset; totalFetched < limit;)
            {
                var history = await apiClient.Messages_GetHistory(peer, offset_id: 0, add_offset: add_offset, limit: limit - totalFetched);
                if (history.Messages.Length == 0) break;

                foreach (var msgBase in history.Messages)
                {
                    var from = history.UserOrChat(msgBase.From ?? msgBase.Peer);
                    char flag = 'u';

                    if (from.ID != apiClient.UserId)
                    {
                        flag = 'i';
                    }
                    else
                    {
                        flag = 'o';
                    }

                    if (msgBase is TL.Message msg)
                    {
                        AnyMessageType mt = new AnyMessageType(msg.message + " " + msg.media, 'p', msgBase.Date.ToLocalTime());
                        MessageWrap mw = new(msgBase.ID, flag, mt);
                        messagesList.Add(mw);
                    }
                    else if (msgBase is MessageService ms)
                    {
                        AnyMessageType mt = new AnyMessageType(ms.action.GetType().Name[13..], 's', ms.date.ToLocalTime());
                        MessageWrap mw = new(ms.ID, flag, mt);
                        messagesList.Add(mw);                        
                    }
                }

                int fetchedCount = history.Messages.Length;
                totalFetched += fetchedCount;
                add_offset += fetchedCount;
            }

            return messagesList;
        }

        public static async Task<bool> SendMessage(long user, MessageUnwrap mesg, string contactType) 
        {
            if (contactType == "userTG")
            {
                var dialogs = await apiClient.Messages_GetAllDialogs();
                await apiClient.SendMessageAsync(dialogs.users[user], mesg.Data);
                return true;
            }
            else if (contactType == "chatTG")
            {
                var chats = await apiClient.Messages_GetAllChats();
                await apiClient.SendMessageAsync(chats.chats[user], mesg.Data);
                return true;
            }

            return false;
        }

        static void ISocialNetwork.GetContacts()
        {
            throw new NotImplementedException();
        }
    }

    class VKSocialNetwork : ISocialNetwork
    {
        public static Guid Id { get; } = new Guid();
        public static string? Name { get; } = "VK";
        public static Color BaseColor { get; } = Color.MediumBlue;
        public static Color SecondColor { get; } = Color.White;


        private static VkApi? apiClient;
        private static IConfigurationRoot? aggregationConfiguration;
        private static VkApiConfig? vkApiConfiguration;

        public static void Connect()
        {
            GetVkConfiguration();
            apiClient = new VkApi();
            apiClient.Authorize(ParseVkConfiguration());
        }

        public static void Disconnect()
        {

        }

        private static ApiAuthParams? ParseVkConfiguration()
        {
            return new ApiAuthParams
            {
                UserId = vkApiConfiguration.UserId,
                Login = vkApiConfiguration?.Login,
                AccessToken = vkApiConfiguration?.AccessToken,
                ApplicationId = vkApiConfiguration.AppId,
                Password = vkApiConfiguration?.Password,
                Settings = Settings.All,
            };
        }

        public static void GetVkConfiguration()
        {
            var builder = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("Configs/aggregation.json", optional: false, reloadOnChange: true);

            aggregationConfiguration = builder.Build();
            vkApiConfiguration = aggregationConfiguration.GetSection("VkConfig").Get<VkApiConfig>();
        }

        public static async Task<(IEnumerable<VkNet.Model.User> friends, Dictionary<long, DateTime?> lastMessages)> GetContacts()
        {
            var lastMessagesByIdDict = new Dictionary<long, DateTime?>();
            Random randomGen = new Random();
            DateTime startRandom = new DateTime(2023, 8, 1);
            var friends = await apiClient.Friends.GetAsync(new FriendsGetParams
            {
                UserId = vkApiConfiguration.UserId,
                Fields = ProfileFields.All
            });
            
            foreach (var friend in friends)
            {
                var lastMessageTimes = GetLastMessageTime(randomGen, startRandom);                
                lastMessagesByIdDict[friend.Id] = lastMessageTimes;
            }

            return (friends, lastMessagesByIdDict);
        }

        private static DateTime? GetLastMessageTime(Random gen, DateTime start)
        {
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        static Task<List<MessageWrap>> ISocialNetwork.GetMessages(long APIId, int offset, int limit, string contactType)
        {
            throw new NotImplementedException();
        }

        static Task<bool> ISocialNetwork.SendMessage(long user, MessageUnwrap mesg, string contactType)
        {
            throw new NotImplementedException();
        }

        static void ISocialNetwork.GetContacts()
        {
            throw new NotImplementedException();
        }
    }

    class OkSocialNetwork : ISocialNetwork
    {
        public static Guid Id { get; } = new Guid();
        public static string? Name { get; } = "OK";
        public static Color BaseColor { get; } = Color.Orange;
        public static Color SecondColor { get; } = Color.White;

        static void ISocialNetwork.Connect()
        {
            throw new NotImplementedException();
        }

        static void ISocialNetwork.Disconnect()
        {
            throw new NotImplementedException();
        }

        static void ISocialNetwork.GetContacts()
        {
            throw new NotImplementedException();
        }

        static Task<List<MessageWrap>> ISocialNetwork.GetMessages(long APIId, int offset, int limit, string contactType)
        {
            throw new NotImplementedException();
        }

        static Task<bool> ISocialNetwork.SendMessage(long user, MessageUnwrap mesg, string contactType)
        {
            throw new NotImplementedException();
        }
    }

    class ViSocialNetwork : ISocialNetwork
    {
        public static Guid Id { get; } = new Guid();
        public static string? Name { get; } = "Vi";
        public static Color BaseColor { get; } = Color.DeepPink;
        public static Color SecondColor { get; } = Color.Gray;

        static void ISocialNetwork.Connect()
        {
            throw new NotImplementedException();
        }

        static void ISocialNetwork.Disconnect()
        {
            throw new NotImplementedException();
        }

        static void ISocialNetwork.GetContacts()
        {
            throw new NotImplementedException();
        }

        static Task<List<MessageWrap>> ISocialNetwork.GetMessages(long APIId, int offset, int limit, string contactType)
        {
            throw new NotImplementedException();
        }

        static Task<bool> ISocialNetwork.SendMessage(long user, MessageUnwrap mesg, string contactType)
        {
            throw new NotImplementedException();
        }
    }
}