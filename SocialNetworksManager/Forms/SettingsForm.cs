


namespace SocialNetworksManager.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void ButtonCancelSettings_MouseEnter(object sender, EventArgs e)
        {
            buttonCancelSettings.ForeColor = SystemColors.Control;
            buttonCancelSettings.BackColor = Color.FromArgb(247, 148, 29);
        }

        private void ButtonCancelSettings_MouseLeave(object sender, EventArgs e)
        {
            buttonCancelSettings.ForeColor = Color.FromArgb(247, 148, 29);
            buttonCancelSettings.BackColor = SystemColors.Control;
        }

        private void ButtonApplySettings_MouseEnter(object sender, EventArgs e)
        {
            buttonApplySettings.ForeColor = SystemColors.Control;
            buttonApplySettings.BackColor = Color.FromArgb(247, 148, 29);
        }

        private void ButtonApplySettings_MouseLeave(object sender, EventArgs e)
        {
            buttonApplySettings.ForeColor = Color.FromArgb(247, 148, 29);
            buttonApplySettings.BackColor = SystemColors.Control;
        }

        private void ButtonCancelSettings_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonApplySettings_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonTgAgg_MouseEnter(object sender, EventArgs e)
        {
            buttonTgAgg.ForeColor = SystemColors.Control;
            buttonTgAgg.BackColor = SystemColors.MenuHighlight;
        }

        private void ButtonTgAgg_MouseLeave(object sender, EventArgs e)
        {
            buttonTgAgg.ForeColor = SystemColors.MenuHighlight;
            buttonTgAgg.BackColor = SystemColors.Control;
        }

        private void ButtonVkAgg_MouseEnter(object sender, EventArgs e)
        {
            buttonVkAgg.ForeColor = SystemColors.Control;
            buttonVkAgg.BackColor = SystemColors.HotTrack;
        }

        private void ButtonVkAgg_MouseLeave(object sender, EventArgs e)
        {
            buttonVkAgg.ForeColor = SystemColors.HotTrack;
            buttonVkAgg.BackColor = SystemColors.Control;
        }

        private void ButtonOkAgg_MouseEnter(object sender, EventArgs e)
        {
            buttonOkAgg.ForeColor = SystemColors.Control;
            buttonOkAgg.BackColor = Color.Orange;
        }

        private void ButtonOkAgg_MouseLeave(object sender, EventArgs e)
        {
            buttonOkAgg.ForeColor = Color.Orange;
            buttonOkAgg.BackColor = SystemColors.Control;
        }

        private void ButtonViAgg_MouseEnter(object sender, EventArgs e)
        {
            buttonViAgg.ForeColor = SystemColors.Control;
            buttonViAgg.BackColor = Color.MediumPurple;
        }

        private void ButtonViAgg_MouseLeave(object sender, EventArgs e)
        {
            buttonViAgg.ForeColor = Color.MediumPurple;
            buttonViAgg.BackColor = SystemColors.Control;
        }

        private void ButtonOpenSettings_MouseEnter(object sender, EventArgs e)
        {
            buttonOpenSettings.ForeColor = SystemColors.Control;
            buttonOpenSettings.BackColor = Color.DarkRed;
        }

        private void ButtonOpenSettings_MouseLeave(object sender, EventArgs e)
        {
            buttonOpenSettings.ForeColor = Color.DarkRed;
            buttonOpenSettings.BackColor = SystemColors.Control;
        }

        private void ButtonOpenGeneral_MouseEnter(object sender, EventArgs e)
        {
            buttonOpenGeneral.ForeColor = SystemColors.Control;
            buttonOpenGeneral.BackColor = Color.DarkRed;
        }

        private void ButtonOpenGeneral_MouseLeave(object sender, EventArgs e)
        {
            buttonOpenGeneral.ForeColor = Color.DarkRed;
            buttonOpenGeneral.BackColor = SystemColors.Control;
        }

        private void ButtonOpenFilters_MouseEnter(object sender, EventArgs e)
        {
            buttonOpenFilters.ForeColor = SystemColors.Control;
            buttonOpenFilters.BackColor = Color.DarkRed;
        }

        private void ButtonOpenFilters_MouseLeave(object sender, EventArgs e)
        {
            buttonOpenFilters.ForeColor = Color.DarkRed;
            buttonOpenFilters.BackColor = SystemColors.Control;
        }

        private void ButtonStats_MouseEnter(object sender, EventArgs e)
        {
            buttonStats.ForeColor = SystemColors.Control;
            buttonStats.BackColor = Color.DarkRed;
        }

        private void ButtonStats_MouseLeave(object sender, EventArgs e)
        {
            buttonStats.ForeColor = Color.DarkRed;
            buttonStats.BackColor = SystemColors.Control;
        }

        private void ButtonTgAgg_Click(object sender, EventArgs e)
        {
            TgAuthForm taf = new TgAuthForm();
            taf.Show();
        }

        private void ButtonVkAgg_Click(object sender, EventArgs e)
        {
            VkAuthForm vaf = new VkAuthForm();
            vaf.Show();
        }

        private void ButtonLightTheme_Click(object sender, EventArgs e)
        {

        }

        private void ButtonLightTheme_MouseEnter(object sender, EventArgs e)
        {
            buttonLightTheme.ForeColor = Color.Wheat;
            buttonLightTheme.BackColor = SystemColors.ControlText;
        }

        private void ButtonLightTheme_MouseLeave(object sender, EventArgs e)
        {
            buttonLightTheme.ForeColor = SystemColors.ControlText;
            buttonLightTheme.BackColor = Color.Wheat;
        }

        private void ButtonNightTheme_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNightTheme_MouseEnter(object sender, EventArgs e)
        {
            buttonNightTheme.ForeColor = Color.MidnightBlue;
            buttonNightTheme.BackColor = Color.White;
        }

        private void ButtonNightTheme_MouseLeave(object sender, EventArgs e)
        {
            buttonNightTheme.ForeColor = Color.White;
            buttonNightTheme.BackColor = Color.MidnightBlue;
        }

        private void ButtonRoyalTheme_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRoyalTheme_MouseEnter(object sender, EventArgs e)
        {
            buttonRoyalTheme.ForeColor = Color.Indigo;
            buttonRoyalTheme.BackColor = Color.White;
        }

        private void ButtonRoyalTheme_MouseLeave(object sender, EventArgs e)
        {
            buttonRoyalTheme.ForeColor = Color.White;
            buttonRoyalTheme.BackColor = Color.Indigo;
        }

        private void ButtonAddRule_MouseEnter(object sender, EventArgs e)
        {
            buttonAddRule.ForeColor = SystemColors.Control;
            buttonAddRule.BackColor = Color.DarkGreen;
        }

        private void ButtonAddRule_MouseLeave(object sender, EventArgs e)
        {
            buttonAddRule.ForeColor = Color.DarkGreen;
            buttonAddRule.BackColor = SystemColors.Control;
        }

        private void ButtonRemoveRule_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRemoveRule_MouseEnter(object sender, EventArgs e)
        {
            buttonRemoveRule.ForeColor = SystemColors.Control;
            buttonRemoveRule.BackColor = Color.DarkRed;
        }

        private void ButtonRemoveRule_MouseLeave(object sender, EventArgs e)
        {
            buttonRemoveRule.ForeColor = Color.DarkRed;
            buttonRemoveRule.BackColor = SystemColors.Control;
        }

        private void ButtonOpenSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
