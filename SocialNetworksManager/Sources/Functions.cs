


using Microsoft.Extensions.Configuration;

using System.Text.RegularExpressions;

using SocialNetworksManager.Configuration;
using SocialNetworksManager.Sources;
using System.Timers;
using System.Diagnostics;



namespace SocialNetworksManager
{
    public partial class MainForm : Form
    {
        private void ScrollToLastRow()
        {
            if (MessageGridView.Rows.Count > 0)
            {
                var lastRowIndex = MessageGridView.Rows.Count - 2;
                MessageGridView.FirstDisplayedScrollingRowIndex = lastRowIndex;
            }
        }

        private void GetStatsConfiguration()
        {
            var builder = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("Configs/stats.json", optional: false, reloadOnChange: true);

            statsConfiguration = builder.Build();
            statsMapConfiguration = statsConfiguration.GetSection("FirstTierStats").Get<StatsConfig>();
        }

        private void ParseStatsToLabel()
        {
            var text = $"Отправлено с помощью SNM: {statsMapConfiguration?.TotalSend}\r\n" +
                       $"Прочитано с помощью SNM: {statsMapConfiguration?.TotalRead}\r\n" +
                       $"Всего контактов: {statsMapConfiguration?.TotalContacts}\r\n";

            labelRightSightStats.Text = text;
        }

        private void MouseEnter_Enlarge(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                lbl.Font = new Font(labelMinimizeButton.Font.Name, 22);
            }
        }

        private void MouseLeave_Small(object sender, EventArgs e)
        {
            if (sender is Label lbl)
            {
                lbl.Font = new Font(labelMinimizeButton.Font.Name, 14);
            }
        }

        private void MaxMinFormWindowed()
        {
            if (Size.Height == 630)
            {
                Size = Screen.PrimaryScreen.WorkingArea.Size;
                Location = new Point(0, 0);
            }
            else
            {
                Size = new Size(865, 630);
                CenterToScreen();
            }
        }

        private void MinFormWindowed(object sender, MouseEventArgs e)
        {
            if (Size == Screen.PrimaryScreen.WorkingArea.Size)
            {
                Size = new Size(865, 630);
                Location = new Point(e.X - 432, e.Y);
            }
        }

        private async Task UpdateContacts()
        {
            var (users, chats, lastMessages) = await TelegramSocialNetwork.GetAllContacts();
            var (friends, lastMessagesTimeVK) = await VKSocialNetwork.GetContacts();

            var newContacts = new List<AnyContactType>();

            newContacts.AddRange(users.Select(user => new AnyContactType
            {
                ContactName = user.first_name + " " + user.last_name,
                SideColor = TelegramSocialNetwork.BaseColor.ToString(),
                AgoMessageTime = TimeAgo(lastMessages[key: user.ID].Date),
                LastMessageTime = lastMessages[key: user.ID].Date,
                APIId = user.ID,
                ContactType = "userTG",
            }));

            newContacts.AddRange(chats.Select(chat => new AnyContactType
            {
                ContactName = chat.Title,
                SideColor = TelegramSocialNetwork.BaseColor.ToString(),
                AgoMessageTime = TimeAgo(lastMessages[key: chat.ID].Date),
                LastMessageTime = lastMessages[key: chat.ID].Date,
                APIId = chat.ID,
                ContactType = "chatTG",
            }));

            newContacts.AddRange(friends.Select(friend => new AnyContactType
            {
                ContactName = friend.FirstName + " " + friend.LastName,
                SideColor = VKSocialNetwork.BaseColor.ToString(),
                AgoMessageTime = TimeAgo(lastMessagesTimeVK[key: friend.Id]),
                LastMessageTime = lastMessagesTimeVK[key: friend.Id],
                APIId = friend.Id,
                ContactType = "friendVK",
            }));

            newContacts = newContacts.OrderByDescending(c => c.LastMessageTime).ToList();

            ActiveContacts.Clear();
            ActiveContacts.AddRange(newContacts);
            ActiveContacts.Add(new AnyContactType(4));
            anyContactTypeBindingSource.DataSource = null;
            anyContactTypeBindingSource.DataSource = ActiveContacts;
            anyContactTypeBindingSource.ResetBindings(false);
            ContactsGridView.Refresh();
        }

        private string TimeAgo(DateTime? dateTime)
        {
            DateTime dateTime1 = dateTime ?? DateTime.Now;
            var timeSpan = DateTime.UtcNow - dateTime1.ToUniversalTime();

            if (timeSpan <= TimeSpan.FromMinutes(1))
                return "только что";
            if (timeSpan <= TimeSpan.FromHours(1))
            {
                int minutes = timeSpan.Minutes;
                return $"{minutes} минут{GetMinuteSuffix(minutes)} назад";
            }
            if (timeSpan <= TimeSpan.FromDays(1))
            {
                int hours = timeSpan.Hours;
                return $"{hours} час{GetHourSuffix(hours)} назад";
            }
            int days = timeSpan.Days;

            return $"{days} д{GetDaySuffix(days)} назад";
        }

        private static string GetMinuteSuffix(int minutes)
        {
            if (minutes >= 11 && minutes <= 14) return "";
            switch (minutes % 10)
            {
                case 1: return "а";
                case 2:
                case 3:
                case 4: return "ы";
                default: return "";
            }
        }

        private static string GetHourSuffix(int hours)
        {
            if (hours >= 11 && hours <= 14) return "ов";
            switch (hours % 10)
            {
                case 1: return "";
                case 2:
                case 3:
                case 4: return "а";
                default: return "ов";
            }
        }

        private static string GetDaySuffix(int days)
        {
            if (days >= 11 && days <= 14) return "ней";
            switch (days % 10)
            {
                case 1: return "ень";
                case 2: return "ня";
                case 3: return "ня";
                case 4: return "ня";
                default: return "ней";
            }
        }

        public static DateTime ParseTimeAgo(string timeAgo)
        {
            var now = DateTime.Now;
            var minuteMatch = Regex.Match(timeAgo, @"(\d+) минут(?:а|ы)? назад");
            var hourMatch = Regex.Match(timeAgo, @"(\d+) час(?:а|ов)? назад");
            var dayMatch = Regex.Match(timeAgo, @"(\d+) д(?:ня|ней|ень|)? назад");

            if (string.IsNullOrWhiteSpace(timeAgo)) return now;

            if (timeAgo == "только что")
            {
                return now;
            }     
            
            if (minuteMatch.Success)
            {
                var minutes = int.Parse(minuteMatch.Groups[1].Value);
                return now.AddMinutes(-minutes);
            }
            
            if (hourMatch.Success)
            {
                var hours = int.Parse(hourMatch.Groups[1].Value);
                return now.AddHours(-hours);
            }
                        
            if (dayMatch.Success)
            {
                var days = int.Parse(dayMatch.Groups[1].Value);
                return now.AddDays(-days);
            }

            return now;
        }

        private AnyMessageType CreateMessage()
        {
            var text = richBoxTextSendMessageField.Text;
            var flag = 'o';
            var time = DateTime.Now;

            richBoxTextSendMessageField.Clear();

            return new AnyMessageType(text, flag, time);
        }
        
        private void SetRandomTimer(int left, int right, Func<Task> task)
        {
            int interval = _random.Next(left, right);

            if (_timer == null)
            {
                _timer = new System.Timers.Timer(interval);
                _timer.Elapsed += async (sender, e) =>
                {
                    _timer.Stop();
                    await task();
                };
                _timer.AutoReset = false;
                _timer.Start();
            }
            else
            {
                _timer.Interval = interval;
                _timer.Start();
            }
        }
    }
}
