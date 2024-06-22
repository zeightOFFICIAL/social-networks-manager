


namespace SocialNetworksManager.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void ButtonClose_MouseEnter(object sender, EventArgs e)
        {
            buttonClose.ForeColor = SystemColors.Control;
            buttonClose.BackColor = Color.FromArgb(247, 148, 29);
        }

        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            buttonClose.BackColor = SystemColors.Control;
            buttonClose.ForeColor = Color.FromArgb(247, 148, 29);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
