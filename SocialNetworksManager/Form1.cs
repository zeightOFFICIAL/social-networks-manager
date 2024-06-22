


using System.Timers;

using SocialNetworksManager.Sources;
using SocialNetworksManager.Forms;
using SocialNetworksManager.Configuration;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;



namespace SocialNetworksManager
{
    public partial class MainForm : Form
    {
        private readonly Color _foreColorPrimary = Color.FromArgb(247, 148, 29);
        private readonly Color _foreColorSecond = Color.FromArgb(0, 0, 0);
        private readonly Color _foreColorThird = Color.FromArgb(139, 0, 0);
        private readonly Color _backColorPrimary = Color.FromArgb(242, 242, 242);
        private readonly Color _backColorSecond = Color.FromArgb(255, 255, 255);

        private List<AnyContactType> ActiveContacts = [];
        private List<MessageUnwrap> ActiveMessages = [];

        private static IConfigurationRoot? statsConfiguration;
        private static StatsConfig? statsMapConfiguration;

        private static DataGridViewRow? selectedRow;
        private static string? selectedId;

        private static System.Timers.Timer _timer;
        private static readonly Random _random = new Random();

        public MainForm()
        {
            InitializeComponent();
            GetStatsConfiguration();
            InitialParseConfigs();
            ParseStatsToLabel();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TelegramSocialNetwork.Connect();
            VKSocialNetwork.Connect();
            //OkSocialNetwork.Connect();
            //ViSocialNetwork.Connect();

            InitialLoadContacts();
        }

        private async void InitialLoadContacts()
        {
            await UpdateContacts();
            if (ContactsGridView.RowCount > 0)
            {
                ContactsGridView.Rows[ContactsGridView.Rows.Count - 1].Selected = true;
                ContactsGridView.Rows[ContactsGridView.Rows.Count - 1].Visible = false;
            }
        }

        private void InitialParseConfigs()
        {

        }
    }
}
