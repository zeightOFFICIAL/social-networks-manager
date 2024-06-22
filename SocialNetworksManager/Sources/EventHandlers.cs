


using SocialNetworksManager.Sources;
using SocialNetworksManager.Forms;
using SocialNetworksManager.Configuration;



namespace SocialNetworksManager
{
    public partial class MainForm : Form
    {
        private void TextBoxSearchContact_Leave(object sender, EventArgs e)
        {
            textBoxSearchContact.Text = "Поиск ⚲";
        }
        
        private void LabelResetContactsButton_Click(object sender, EventArgs e)
        {
            labelResetContactsButton.Focus();
            textBoxSearchContact.Text = "Поиск ⚲";

            anyContactTypeBindingSource.DataSource = ActiveContacts;
            ContactsGridView.Refresh();

            if (ContactsGridView.Rows.Count > 0)
            {
                ContactsGridView.Rows[ContactsGridView.Rows.Count - 1].Selected = true;
                ContactsGridView.Rows[ContactsGridView.Rows.Count - 1].Visible = false;
            }
            else
            {
                return;
            }
        }

        private void LabelResetContactsButton_MouseEnter(object sender, EventArgs e)
        {
            labelResetContactsButton.ForeColor = SystemColors.Control;
            labelResetContactsButton.BackColor = _foreColorThird;
        }

        private void LabelResetContactsButton_MouseLeave(object sender, EventArgs e)
        {
            labelResetContactsButton.ForeColor = _foreColorThird;
            labelResetContactsButton.BackColor = SystemColors.Control;
        }

        private void TextBoxSearchContact_MouseEnter(object sender, EventArgs e)
        {
            textBoxSearchContact.ForeColor = SystemColors.Control;
            textBoxSearchContact.BackColor = _foreColorThird;
        }

        private void TextBoxSearchContact_MouseLeave(object sender, EventArgs e)
        {
            textBoxSearchContact.ForeColor = _foreColorThird;
            textBoxSearchContact.BackColor = SystemColors.Control;
        }

        private void TextBoxSearchContact_Click(object sender, EventArgs e)
        {
            textBoxSearchContact.Text = "";
        }

        private void TextBoxSearchContact_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchContact.Text == "Поиск ⚲" || textBoxSearchContact.Text == "⚲" || ContactsGridView.RowCount <= 0)
            {
                return;
            }

            var searchText = textBoxSearchContact.Text.ToLower();
            var filteredList = ActiveContacts.Where(item => item.ContactName.ToLower().Contains(searchText)).ToList();
            filteredList.Add(new AnyContactType(4));
            anyContactTypeBindingSource.DataSource = filteredList;
            ContactsGridView.Refresh();

            if (ContactsGridView.RowCount > 0)
            {
                ContactsGridView.Rows[ContactsGridView.Rows.Count - 1].Selected = true;
                ContactsGridView.Rows[ContactsGridView.Rows.Count - 1].Visible = false;
            }
        }
       
        private void LabelLastMessageButton_MouseEnter(object sender, EventArgs e)
        {
            labelLastMessageButton.ForeColor = SystemColors.Control;
            labelLastMessageButton.BackColor = _foreColorThird;
        }

        private void LabelLastMessageButton_MouseLeave(object sender, EventArgs e)
        {
            labelLastMessageButton.ForeColor = _foreColorThird;
            labelLastMessageButton.BackColor = SystemColors.Control;
        }

        private void LabelLastMessageButton_Click(object sender, EventArgs e)
        {
            ScrollToLastRow();
        }

        private void LabelCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LabelMaximizeButton_Click(object sender, EventArgs e)
        {
            MaxMinFormWindowed();
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel7.Dock = DockStyle.Fill;
        }

        private void LabelMinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LabelMinimizeButton_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_Enlarge(sender, e);
        }

        private void LabelMinimizeButton_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave_Small(sender, e);
        }

        private void LabelMaximizeButton_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_Enlarge(sender, e);
        }

        private void LabelMaximizeButton_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave_Small(sender, e);
        }

        private void LabelCloseButton_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_Enlarge(sender, e);
        }

        private void LabelCloseButton_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave_Small(sender, e);
        }

        private void TableLayoutPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            MinFormWindowed(sender, e);
            DragWindow(sender, e);
        }

        private void TableLayoutPanel2_MouseDown(object sender, MouseEventArgs e)
        {
            MinFormWindowed(sender, e);
            DragWindow(sender, e);
        }

        private void TableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            MinFormWindowed(sender, e);
            DragWindow(sender, e);
        }

        private void LabelSettingsButton_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_Enlarge(sender, e);
        }

        private void LabelSettingsButton_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave_Small(sender, e);
        }

        private void LabelAboutButton_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_Enlarge(sender, e);
        }

        private void LabelAboutButton_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave_Small(sender, e);
        }

        private void LabelInfoButton_MouseEnter(object sender, EventArgs e)
        {
            MouseEnter_Enlarge(sender, e);
        }

        private void LabelInfoButton_MouseLeave(object sender, EventArgs e)
        {
            MouseLeave_Small(sender, e);
        }
        
        private void LabelOpenBrowser_MouseEnter(object sender, EventArgs e)
        {
            labelOpenBrowser.ForeColor = SystemColors.Control;
            labelOpenBrowser.BackColor = Color.DarkRed;
        }

        private void LabelOpenBrowser_MouseLeave(object sender, EventArgs e)
        {
            labelOpenBrowser.ForeColor = Color.DarkRed;
            labelOpenBrowser.BackColor = SystemColors.Control;
        }
        
        private void LabelOpenBrowser_Click(object sender, EventArgs e)
        {

        }

        private void ContactsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.Value == null)
                {
                    return;
                }

                if (e.Value.ToString() == "Color [MediumBlue]")
                {
                    e.CellStyle.BackColor = Color.MediumBlue;
                    e.CellStyle.ForeColor = Color.MediumBlue;
                    e.CellStyle.SelectionForeColor = Color.MediumBlue;
                    e.CellStyle.SelectionBackColor = Color.MediumBlue;
                }
                else if (e.Value.ToString() == "Color [SkyBlue]")
                {
                    e.CellStyle.BackColor = Color.SkyBlue;
                    e.CellStyle.ForeColor = Color.SkyBlue;
                    e.CellStyle.SelectionForeColor = Color.SkyBlue;
                    e.CellStyle.SelectionBackColor = Color.SkyBlue;
                }
                else if (e.Value.ToString() == "Color [Orange]")
                {
                    e.CellStyle.BackColor = Color.Orange;
                    e.CellStyle.ForeColor = Color.Orange;
                    e.CellStyle.SelectionForeColor = Color.Orange;
                    e.CellStyle.SelectionBackColor = Color.Orange;
                }
                else if (e.Value.ToString() == "Color [SkyBlue]")
                {
                    e.CellStyle.BackColor = Color.DeepPink;
                    e.CellStyle.ForeColor = Color.DeepPink;
                    e.CellStyle.SelectionForeColor = Color.DeepPink;
                    e.CellStyle.SelectionBackColor = Color.DeepPink;
                }
            }
        }

        private void ContactsGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;

            if (e.ColumnIndex == 1 || e.ColumnIndex == 2)
            {
                ContactsGridView.Cursor = Cursors.Hand;
            }

            ContactsGridView[1, rowIndex].Style.BackColor = Color.White;
            ContactsGridView[2, rowIndex].Style.BackColor = Color.White;

        }

        private void ContactsGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = e.RowIndex;

            ContactsGridView.Cursor = Cursors.Arrow;

            ContactsGridView[1, rowIndex].Style.BackColor = SystemColors.Control;
            ContactsGridView[2, rowIndex].Style.BackColor = SystemColors.Control;
        }
        
        private void ContactsGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ContactsGridView.SelectedRows.Count > 0)
            {
                if (ContactsGridView.Rows[ContactsGridView.Rows.Count - 1].Selected)
                {
                    ContactsGridView.Columns[2].Visible = true;
                    tableLayoutPanel2.ColumnStyles[1].Width = 392;
                    tableLayoutPanel2.ColumnStyles[2].Width = 413;
                    tableLayoutPanel4.ColumnStyles[0].Width = 50;

                    tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 2, 1);
                    tableLayoutPanel7.Dock = DockStyle.Fill;
                    tableLayoutPanel7.Visible = true;
                    tableLayoutPanel5.Visible = false;

                    labelLastMessageButton.Visible = false;
                    labelOpenBrowser.Visible = false;
                }
                else
                {

                    ContactsGridView.Columns[2].Visible = false;
                    tableLayoutPanel2.ColumnStyles[1].Width = 240;
                    tableLayoutPanel2.ColumnStyles[2].SizeType = SizeType.Percent;
                    tableLayoutPanel2.ColumnStyles[2].Width = 100;
                    tableLayoutPanel4.ColumnStyles[0].Width = 100;

                    tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 2, 1);
                    tableLayoutPanel5.Dock = DockStyle.Fill;
                    tableLayoutPanel7.Visible = false;
                    tableLayoutPanel5.Visible = true;

                    labelLastMessageButton.Visible = true;
                    labelOpenBrowser.Visible = true;
                }
            }
        }
        
        private async void ContactsGridView_Click(object sender, EventArgs e)
        {
            if (ContactsGridView.Rows.Count > 0)
            {
                if (ContactsGridView.Rows[ContactsGridView.Rows.Count - 1].Selected)
                {
                    textBoxSearchContact.Text = "Поиск ⚲";

                    selectedRow = null;
                    selectedId = null;

                    return;
                }
                else
                {
                    textBoxSearchContact.Text = "⚲";

                    selectedRow = ContactsGridView.SelectedRows[0];
                    selectedId = selectedRow.Cells[4].Value.ToString();
                    await LoadMessages(sender, e);
                }
            }
        }

        private async Task LoadMessages(object sender, EventArgs e)
        {
            var newMessages = new List<MessageUnwrap>();
            AnyContactType? selectedContact = ActiveContacts.FirstOrDefault(c => c.Id.ToString() == selectedId);
            List<MessageWrap> ActiveMessageWrapped = await selectedContact.GetInitialPackMessages();

            ActiveMessages.Clear();

            newMessages.AddRange(ActiveMessageWrapped
                .Select(mesgWrap => new MessageUnwrap(
                mesgWrap.Id,
                mesgWrap.OuterFlag,
                mesgWrap.Message
                )).ToList());

            ActiveMessages = newMessages.OrderByDescending(c => c.Time).Reverse().ToList();
            ActiveMessages.Add(new MessageUnwrap());
            ActiveMessages = ActiveMessages
                .Where(mesg => !string.IsNullOrWhiteSpace(mesg.Data))
                .ToList();

            messageUnwrapBindingSource.DataSource = null;
            messageUnwrapBindingSource.DataSource = ActiveMessages;
            messageUnwrapBindingSource.ResetBindings(false);
            LabelLastMessageButton_Click(sender, e);
        }

        private void LabelSettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }
        
        private void LabelInstructionButton_Click(object sender, EventArgs e)
        {

        }
        
        private void LabelSendMessageButton_MouseEnter(object sender, EventArgs e)
        {

            labelSendMessageButton.Text = "▶";
        }

        private void LabelSendMessageButton_MouseLeave(object sender, EventArgs e)
        {

            labelSendMessageButton.Text = "▷";
        }

        private void RichBoxTextSendMessageField_DoubleClick(object sender, EventArgs e)
        {
            richBoxTextSendMessageField.Clear();
        }

        private void LabelSendMessageButton_MouseDown(object sender, MouseEventArgs e)
        {
            labelSendMessageButton.Text = "⋙";
        }
        
        private void MessageGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var rowIndex = e.RowIndex;
            var colIndex = e.ColumnIndex;

            if (MessageGridView.Rows[rowIndex].Cells[5].Value == null)
            {
                return;
            }

            if (MessageGridView.Rows[rowIndex].Cells[5].Value.ToString() == 'i'.ToString())
            {
                MessageGridView.Rows[rowIndex].Cells[0].Value = "i";

                MessageGridView.Rows[rowIndex].Cells[0].Style.BackColor = _foreColorPrimary;
                MessageGridView.Rows[rowIndex].Cells[0].Style.ForeColor = _foreColorPrimary;
                MessageGridView.Rows[rowIndex].Cells[0].Style.SelectionBackColor = _foreColorPrimary;
                MessageGridView.Rows[rowIndex].Cells[0].Style.SelectionForeColor = _foreColorPrimary;

                MessageGridView.Rows[rowIndex].Cells[4].Style.BackColor = SystemColors.Control;
                MessageGridView.Rows[rowIndex].Cells[4].Style.ForeColor = SystemColors.Control;
                MessageGridView.Rows[rowIndex].Cells[4].Style.SelectionBackColor = SystemColors.Control;
                MessageGridView.Rows[rowIndex].Cells[4].Style.SelectionForeColor = SystemColors.Control;

                MessageGridView.Rows[rowIndex].Cells[1].Style.BackColor = Color.White;
                MessageGridView.Rows[rowIndex].Cells[1].Style.ForeColor = Color.White; ;
                MessageGridView.Rows[rowIndex].Cells[1].Style.SelectionBackColor = Color.White; ;
                MessageGridView.Rows[rowIndex].Cells[1].Style.SelectionForeColor = Color.White; ;

                MessageGridView.Rows[rowIndex].Cells[3].Style.BackColor = Color.White; ;
                MessageGridView.Rows[rowIndex].Cells[3].Style.ForeColor = _foreColorPrimary;
                MessageGridView.Rows[rowIndex].Cells[3].Style.SelectionBackColor = Color.White; ;
                MessageGridView.Rows[rowIndex].Cells[3].Style.SelectionForeColor = _foreColorPrimary;
            }
            else if (MessageGridView.Rows[rowIndex].Cells[5].Value.ToString() == 'o'.ToString())
            {
                MessageGridView.Rows[rowIndex].Cells[4].Value = "o";

                MessageGridView.Rows[rowIndex].Cells[4].Style.BackColor = _foreColorPrimary;
                MessageGridView.Rows[rowIndex].Cells[4].Style.ForeColor = _foreColorPrimary;
                MessageGridView.Rows[rowIndex].Cells[4].Style.SelectionBackColor = _foreColorPrimary;
                MessageGridView.Rows[rowIndex].Cells[4].Style.SelectionForeColor = _foreColorPrimary;

                MessageGridView.Rows[rowIndex].Cells[0].Style.BackColor = SystemColors.Control;
                MessageGridView.Rows[rowIndex].Cells[0].Style.ForeColor = SystemColors.Control;
                MessageGridView.Rows[rowIndex].Cells[0].Style.SelectionBackColor = SystemColors.Control;
                MessageGridView.Rows[rowIndex].Cells[0].Style.SelectionForeColor = SystemColors.Control;

                MessageGridView.Rows[rowIndex].Cells[3].Style.BackColor = Color.White; ;
                MessageGridView.Rows[rowIndex].Cells[3].Style.ForeColor = Color.White; ;
                MessageGridView.Rows[rowIndex].Cells[3].Style.SelectionBackColor = Color.White; ;
                MessageGridView.Rows[rowIndex].Cells[3].Style.SelectionForeColor = Color.White; ;

                MessageGridView.Rows[rowIndex].Cells[1].Style.BackColor = Color.White; ;
                MessageGridView.Rows[rowIndex].Cells[1].Style.ForeColor = _foreColorPrimary;
                MessageGridView.Rows[rowIndex].Cells[1].Style.SelectionBackColor = Color.White; ;
                MessageGridView.Rows[rowIndex].Cells[1].Style.SelectionForeColor = _foreColorPrimary;
            }
        }
        
        private void LabelTitleHeader_MouseDown(object sender, MouseEventArgs e)
        {
            MinFormWindowed(sender, e);
            DragWindow(sender, e);
        }
        
        private void PictureBoxTitleHeader_MouseDown(object sender, MouseEventArgs e)
        {
            MinFormWindowed(sender, e);
            DragWindow(sender, e);
        }
        
        private void LabelInfoButton_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }
        
        private void LabelSendMessageButton_MouseUp(object sender, MouseEventArgs e)
        {
            labelSendMessageButton.Text = "▶";
        }

        private void LabelSendMessageButton_Click(object sender, EventArgs e)
        {
            var mesg = CreateMessage();
            var selectContact = ActiveContacts.FirstOrDefault(item => item.Id.ToString() == ContactsGridView.SelectedRows[0].Cells[4].Value.ToString());
            var mesgUnwrap = selectContact.CreateMessage(mesg);
            var userId = ContactsGridView.SelectedRows[0].Cells[5].Value.ToString();

            selectContact.SendMessage(mesgUnwrap, long.Parse(userId));
            LoadMessages(sender, e);
        }
    }
}
