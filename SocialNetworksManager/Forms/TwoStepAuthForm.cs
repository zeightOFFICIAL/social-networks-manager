


namespace SocialNetworksManager.Forms
{
    public partial class TwoStepAuthForm : Form
    {
        public TwoStepAuthForm()
        {
            InitializeComponent();
        }

        private void ButtonDeny_MouseEnter(object sender, EventArgs e)
        {
            buttonDeny.ForeColor = SystemColors.Control;
            buttonDeny.BackColor = Color.DarkRed;
        }

        private void ButtonDeny_MouseLeave(object sender, EventArgs e)
        {
            buttonDeny.ForeColor = Color.DarkRed;
            buttonDeny.BackColor = SystemColors.Control;
        }

        private void ButtonDeny_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonTryApply_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonTryApply_MouseEnter(object sender, EventArgs e)
        {
            buttonTryApply.ForeColor = SystemColors.Control;
            buttonTryApply.BackColor = Color.DarkRed;
        }

        private void ButtonTryApply_MouseLeave(object sender, EventArgs e)
        {
            buttonTryApply.ForeColor = Color.DarkRed;
            buttonTryApply.BackColor = SystemColors.Control;
        }
    }
}
