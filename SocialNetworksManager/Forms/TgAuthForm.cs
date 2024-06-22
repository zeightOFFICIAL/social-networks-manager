


namespace SocialNetworksManager.Forms
{
    public partial class TgAuthForm : Form
    {
        public TgAuthForm()
        {
            InitializeComponent();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCancel_MouseEnter(object sender, EventArgs e)
        {
            buttonCancel.ForeColor = SystemColors.Control;
            buttonCancel.BackColor = Color.DarkRed;
        }

        private void ButtonCancel_MouseLeave(object sender, EventArgs e)
        {
            buttonCancel.ForeColor = Color.DarkRed;
            buttonCancel.BackColor = SystemColors.Control;
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            TwoStepAuthForm taf = new TwoStepAuthForm();
            taf.Show();
        }

        private void ButtonNext_MouseEnter(object sender, EventArgs e)
        {
            buttonNext.ForeColor = SystemColors.Control;
            buttonNext.BackColor = Color.DarkRed;
        }

        private void ButtonNext_MouseLeave(object sender, EventArgs e)
        {
            buttonNext.ForeColor = Color.DarkRed;
            buttonNext.BackColor = SystemColors.Control;
        }
    }
}
