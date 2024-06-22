


namespace SocialNetworksManager.Sources
{
    interface IContact
    {
        Guid Id { get; set; }
        string? ContactName { get; set; }
        ISocialNetwork? SocialNetwork { get; }
        List<MessageWrap>? MessagesList { get; set; }        
        DateTime? LastMessageTime { get; set; }
        string? AgoMessageTime { get; set; }
        DateTime? LastOnlineTime { get; set; }
        string? SideColor { get; }
        long APIId { get; set; }
        string? ContactType { get; set; }
        public byte[] ProfilePicture { get; set; }

        Task<List<MessageWrap>> GetInitialPackMessages();
        List<MessageWrap> GetAllPackMessage();
        MessageWrap GetLastMessage();
        MessageWrap GetMessageAt(int index);
        MessageUnwrap CreateMessage(IMessage mesg);
        Task<bool> SendMessage(MessageUnwrap mesgWrap, long userId);        
    }

    class AnyContactType : IContact
    {
        public Guid Id { get; set; } = new Guid();
        public string? ContactName { get; set; }
        public ISocialNetwork? SocialNetwork { get; }
        public List<MessageWrap>? MessagesList { get; set; }
        public DateTime? LastMessageTime { get; set; }
        public string? AgoMessageTime { get; set; }
        public DateTime? LastOnlineTime { get; set; }
        public string? SideColor { get; set; }
        public long APIId { get; set; }
        public string? ContactType { get; set; }
        public byte[]? ProfilePicture { get; set; }

        public AnyContactType(int DefaultType = 1)
        {
            Id = Guid.NewGuid();
            switch (DefaultType)
            {
                case 1:
                    ContactName = "Debug Andrew";
                    SocialNetwork = new TelegramSocialNetwork();
                    SideColor = Color.DarkBlue.ToString();
                    break;
                case 2:
                    ContactName = "Debug John";
                    SocialNetwork = new VKSocialNetwork();
                    SideColor = Color.SkyBlue.ToString();
                    break;
                case 4:
                    ContactName = "";
                    SocialNetwork = new TelegramSocialNetwork();
                    SideColor = SystemColors.Control.ToString();
                    break;
            }
        }

        public MessageUnwrap CreateMessage(IMessage mesg)
        {
            return new MessageUnwrap(-1, 'o', (AnyMessageType)mesg);
        }

        public async Task<bool> SendMessage(MessageUnwrap mesg, long userId)
        {
            if (ContactType == "chatTG")
            {
                await TelegramSocialNetwork.SendMessage(userId, mesg, ContactType);
                return true;
            }
            else if (ContactType == "userTG")
            {
                await TelegramSocialNetwork.SendMessage(userId, mesg, ContactType);
                return true;
            }
            return false;
        }

        public List<MessageWrap> GetAllPackMessage()
        {
            throw new NotImplementedException();
        }

        public MessageWrap GetLastMessage()
        {
            throw new NotImplementedException();
        }

        public MessageWrap GetMessageAt(int index)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MessageWrap>> GetInitialPackMessages()
        {
            return await TelegramSocialNetwork.GetMessages(APIId, 0, 30, ContactType);
        }
    }
}