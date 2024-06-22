using SocialNetworksManager.Sources;
using System.ComponentModel;

namespace SocialNetworksManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelCloseButton;
        private System.Windows.Forms.Label labelMaximizeButton;
        private System.Windows.Forms.Label labelMinimizeButton;
        private System.Windows.Forms.Label labelSettingsButton;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label labelTitleHeader;
        private System.Windows.Forms.Label labelInstructionButton;
        private System.Windows.Forms.Label labelInfoButton;
        private System.Windows.Forms.Panel PnlContactList;
        private System.Windows.Forms.DataGridView ContactsGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RichTextBox richBoxTextSendMessageField;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            PnlContactList = new Panel();
            ContactsGridView = new DataGridView();
            SideColor = new DataGridViewTextBoxColumn();
            ContactName = new DataGridViewTextBoxColumn();
            agoMessageTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastMessageTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            APIId = new DataGridViewTextBoxColumn();
            ContactType = new DataGridViewTextBoxColumn();
            anyContactTypeBindingSource = new BindingSource(components);
            tableLayoutPanel4 = new TableLayoutPanel();
            textBoxSearchContact = new TextBox();
            labelResetContactsButton = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            labelLastMessageButton = new Label();
            labelOpenBrowser = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            richBoxTextSendMessageField = new RichTextBox();
            labelSendMessageButton = new Label();
            MessageGridView = new DataGridView();
            messageUnwrapBindingSource = new BindingSource(components);
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelCloseButton = new Label();
            tableLayoutPanel7 = new TableLayoutPanel();
            pictureBoxRightSideLogo = new PictureBox();
            labelRightSightStats = new Label();
            labelMaximizeButton = new Label();
            labelMinimizeButton = new Label();
            labelSettingsButton = new Label();
            labelTitleHeader = new Label();
            labelInstructionButton = new Label();
            labelInfoButton = new Label();
            pictureBoxTitleHeader = new PictureBox();
            LblVersion = new Label();
            LBound = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            RBound = new DataGridViewTextBoxColumn();
            OuterFlag = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            PnlContactList.SuspendLayout();
            ((ISupportInitialize)ContactsGridView).BeginInit();
            ((ISupportInitialize)anyContactTypeBindingSource).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((ISupportInitialize)MessageGridView).BeginInit();
            ((ISupportInitialize)messageUnwrapBindingSource).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((ISupportInitialize)pictureBoxRightSideLogo).BeginInit();
            ((ISupportInitialize)pictureBoxTitleHeader).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(LblVersion, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94.04153F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.958471F));
            tableLayoutPanel1.Size = new Size(863, 628);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.MouseDown += TableLayoutPanel1_MouseDown;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 392F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Controls.Add(PnlContactList, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel8, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 53);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(857, 537);
            tableLayoutPanel2.TabIndex = 0;
            tableLayoutPanel2.MouseDown += TableLayoutPanel2_MouseDown;
            // 
            // PnlContactList
            // 
            PnlContactList.Controls.Add(ContactsGridView);
            PnlContactList.Dock = DockStyle.Fill;
            PnlContactList.Location = new Point(33, 43);
            PnlContactList.Name = "PnlContactList";
            PnlContactList.Size = new Size(386, 471);
            PnlContactList.TabIndex = 0;
            // 
            // ContactsGridView
            // 
            ContactsGridView.AllowUserToResizeColumns = false;
            ContactsGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            ContactsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ContactsGridView.AutoGenerateColumns = false;
            ContactsGridView.BackgroundColor = SystemColors.Control;
            ContactsGridView.BorderStyle = BorderStyle.None;
            ContactsGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ContactsGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ContactsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ContactsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ContactsGridView.ColumnHeadersVisible = false;
            ContactsGridView.Columns.AddRange(new DataGridViewColumn[] { SideColor, ContactName, agoMessageTimeDataGridViewTextBoxColumn, lastMessageTimeDataGridViewTextBoxColumn, Id, APIId, ContactType });
            ContactsGridView.DataSource = anyContactTypeBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            ContactsGridView.DefaultCellStyle = dataGridViewCellStyle4;
            ContactsGridView.Dock = DockStyle.Fill;
            ContactsGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            ContactsGridView.GridColor = SystemColors.Control;
            ContactsGridView.Location = new Point(0, 0);
            ContactsGridView.MultiSelect = false;
            ContactsGridView.Name = "ContactsGridView";
            ContactsGridView.ReadOnly = true;
            ContactsGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ContactsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ContactsGridView.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            ContactsGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            ContactsGridView.RowTemplate.DefaultCellStyle.BackColor = SystemColors.Control;
            ContactsGridView.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            ContactsGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.ActiveCaption;
            ContactsGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            ContactsGridView.RowTemplate.DividerHeight = 10;
            ContactsGridView.RowTemplate.Height = 55;
            ContactsGridView.ScrollBars = ScrollBars.Vertical;
            ContactsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ContactsGridView.ShowCellErrors = false;
            ContactsGridView.ShowCellToolTips = false;
            ContactsGridView.ShowEditingIcon = false;
            ContactsGridView.ShowRowErrors = false;
            ContactsGridView.Size = new Size(386, 471);
            ContactsGridView.TabIndex = 0;
            ContactsGridView.TabStop = false;
            ContactsGridView.VirtualMode = true;
            ContactsGridView.CellFormatting += ContactsGridView_CellFormatting;
            ContactsGridView.CellMouseEnter += ContactsGridView_CellMouseEnter;
            ContactsGridView.CellMouseLeave += ContactsGridView_CellMouseLeave;
            ContactsGridView.SelectionChanged += ContactsGridView_SelectionChanged;
            ContactsGridView.Click += ContactsGridView_Click;
            // 
            // SideColor
            // 
            SideColor.DataPropertyName = "SideColor";
            SideColor.HeaderText = "SideColor";
            SideColor.Name = "SideColor";
            SideColor.ReadOnly = true;
            SideColor.Width = 5;
            // 
            // ContactName
            // 
            ContactName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ContactName.DataPropertyName = "ContactName";
            dataGridViewCellStyle3.Padding = new Padding(7, 0, 0, 0);
            ContactName.DefaultCellStyle = dataGridViewCellStyle3;
            ContactName.HeaderText = "ContactName";
            ContactName.MinimumWidth = 235;
            ContactName.Name = "ContactName";
            ContactName.ReadOnly = true;
            // 
            // agoMessageTimeDataGridViewTextBoxColumn
            // 
            agoMessageTimeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            agoMessageTimeDataGridViewTextBoxColumn.DataPropertyName = "AgoMessageTime";
            agoMessageTimeDataGridViewTextBoxColumn.HeaderText = "AgoMessageTime";
            agoMessageTimeDataGridViewTextBoxColumn.MinimumWidth = 149;
            agoMessageTimeDataGridViewTextBoxColumn.Name = "agoMessageTimeDataGridViewTextBoxColumn";
            agoMessageTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastMessageTimeDataGridViewTextBoxColumn
            // 
            lastMessageTimeDataGridViewTextBoxColumn.DataPropertyName = "LastMessageTime";
            lastMessageTimeDataGridViewTextBoxColumn.HeaderText = "LastMessageTime";
            lastMessageTimeDataGridViewTextBoxColumn.Name = "lastMessageTimeDataGridViewTextBoxColumn";
            lastMessageTimeDataGridViewTextBoxColumn.ReadOnly = true;
            lastMessageTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // APIId
            // 
            APIId.DataPropertyName = "APIId";
            APIId.HeaderText = "APIId";
            APIId.Name = "APIId";
            APIId.ReadOnly = true;
            APIId.Visible = false;
            // 
            // ContactType
            // 
            ContactType.DataPropertyName = "ContactType";
            ContactType.HeaderText = "ContactType";
            ContactType.Name = "ContactType";
            ContactType.ReadOnly = true;
            ContactType.Visible = false;
            // 
            // anyContactTypeBindingSource
            // 
            anyContactTypeBindingSource.DataSource = typeof(AnyContactType);
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(textBoxSearchContact, 1, 0);
            tableLayoutPanel4.Controls.Add(labelResetContactsButton, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(33, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(386, 34);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // textBoxSearchContact
            // 
            textBoxSearchContact.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearchContact.BackColor = SystemColors.Control;
            textBoxSearchContact.Cursor = Cursors.IBeam;
            textBoxSearchContact.Font = new Font("JetBrains Mono", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearchContact.ForeColor = Color.DarkRed;
            textBoxSearchContact.Location = new Point(196, 3);
            textBoxSearchContact.Margin = new Padding(3, 3, 20, 3);
            textBoxSearchContact.Multiline = true;
            textBoxSearchContact.Name = "textBoxSearchContact";
            textBoxSearchContact.ShortcutsEnabled = false;
            textBoxSearchContact.Size = new Size(170, 28);
            textBoxSearchContact.TabIndex = 2;
            textBoxSearchContact.TabStop = false;
            textBoxSearchContact.Text = "Поиск ⚲";
            textBoxSearchContact.TextAlign = HorizontalAlignment.Center;
            textBoxSearchContact.WordWrap = false;
            textBoxSearchContact.Click += TextBoxSearchContact_Click;
            textBoxSearchContact.TextChanged += TextBoxSearchContact_TextChanged;
            textBoxSearchContact.Leave += TextBoxSearchContact_Leave;
            textBoxSearchContact.MouseEnter += TextBoxSearchContact_MouseEnter;
            textBoxSearchContact.MouseLeave += TextBoxSearchContact_MouseLeave;
            // 
            // labelResetContactsButton
            // 
            labelResetContactsButton.AutoSize = true;
            labelResetContactsButton.Cursor = Cursors.Hand;
            labelResetContactsButton.Dock = DockStyle.Fill;
            labelResetContactsButton.Font = new Font("JetBrains Mono", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelResetContactsButton.ForeColor = Color.DarkRed;
            labelResetContactsButton.Location = new Point(20, 3);
            labelResetContactsButton.Margin = new Padding(20, 3, 3, 3);
            labelResetContactsButton.Name = "labelResetContactsButton";
            labelResetContactsButton.Size = new Size(170, 28);
            labelResetContactsButton.TabIndex = 3;
            labelResetContactsButton.Text = "Контакты ↺";
            labelResetContactsButton.TextAlign = ContentAlignment.MiddleCenter;
            labelResetContactsButton.Click += LabelResetContactsButton_Click;
            labelResetContactsButton.MouseEnter += LabelResetContactsButton_MouseEnter;
            labelResetContactsButton.MouseLeave += LabelResetContactsButton_MouseLeave;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(labelLastMessageButton, 0, 0);
            tableLayoutPanel8.Controls.Add(labelOpenBrowser, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(425, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(399, 34);
            tableLayoutPanel8.TabIndex = 5;
            // 
            // labelLastMessageButton
            // 
            labelLastMessageButton.AutoSize = true;
            labelLastMessageButton.Cursor = Cursors.Hand;
            labelLastMessageButton.Dock = DockStyle.Fill;
            labelLastMessageButton.Font = new Font("JetBrains Mono", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLastMessageButton.ForeColor = Color.DarkRed;
            labelLastMessageButton.Location = new Point(3, 3);
            labelLastMessageButton.Margin = new Padding(3);
            labelLastMessageButton.Name = "labelLastMessageButton";
            labelLastMessageButton.Size = new Size(194, 28);
            labelLastMessageButton.TabIndex = 0;
            labelLastMessageButton.Text = "Сообщения ↓";
            labelLastMessageButton.TextAlign = ContentAlignment.MiddleCenter;
            labelLastMessageButton.Visible = false;
            labelLastMessageButton.Click += LabelLastMessageButton_Click;
            labelLastMessageButton.MouseEnter += LabelLastMessageButton_MouseEnter;
            labelLastMessageButton.MouseLeave += LabelLastMessageButton_MouseLeave;
            // 
            // labelOpenBrowser
            // 
            labelOpenBrowser.AutoSize = true;
            labelOpenBrowser.Cursor = Cursors.Hand;
            labelOpenBrowser.Dock = DockStyle.Fill;
            labelOpenBrowser.Font = new Font("JetBrains Mono", 13F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOpenBrowser.ForeColor = Color.DarkRed;
            labelOpenBrowser.Location = new Point(203, 3);
            labelOpenBrowser.Margin = new Padding(3);
            labelOpenBrowser.Name = "labelOpenBrowser";
            labelOpenBrowser.Size = new Size(194, 28);
            labelOpenBrowser.TabIndex = 1;
            labelOpenBrowser.Text = "Открыть ↪";
            labelOpenBrowser.TextAlign = ContentAlignment.MiddleCenter;
            labelOpenBrowser.Visible = false;
            labelOpenBrowser.Click += LabelOpenBrowser_Click;
            labelOpenBrowser.MouseEnter += LabelOpenBrowser_MouseEnter;
            labelOpenBrowser.MouseLeave += LabelOpenBrowser_MouseLeave;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 1, 1);
            tableLayoutPanel5.Controls.Add(MessageGridView, 1, 0);
            tableLayoutPanel5.Controls.Add(panel1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(425, 43);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 88.01653F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9834709F));
            tableLayoutPanel5.Size = new Size(399, 471);
            tableLayoutPanel5.TabIndex = 3;
            tableLayoutPanel5.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.78757F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.2124348F));
            tableLayoutPanel6.Controls.Add(richBoxTextSendMessageField, 0, 0);
            tableLayoutPanel6.Controls.Add(labelSendMessageButton, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(13, 417);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(383, 51);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // richBoxTextSendMessageField
            // 
            richBoxTextSendMessageField.BorderStyle = BorderStyle.None;
            richBoxTextSendMessageField.Dock = DockStyle.Fill;
            richBoxTextSendMessageField.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richBoxTextSendMessageField.Location = new Point(3, 3);
            richBoxTextSendMessageField.Name = "richBoxTextSendMessageField";
            richBoxTextSendMessageField.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richBoxTextSendMessageField.Size = new Size(326, 45);
            richBoxTextSendMessageField.TabIndex = 0;
            richBoxTextSendMessageField.TabStop = false;
            richBoxTextSendMessageField.Text = "";
            richBoxTextSendMessageField.WordWrap = false;
            richBoxTextSendMessageField.DoubleClick += RichBoxTextSendMessageField_DoubleClick;
            // 
            // labelSendMessageButton
            // 
            labelSendMessageButton.AutoSize = true;
            labelSendMessageButton.Cursor = Cursors.Hand;
            labelSendMessageButton.Dock = DockStyle.Fill;
            labelSendMessageButton.Font = new Font("Fira Sans SemiBold", 30F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelSendMessageButton.ForeColor = Color.FromArgb(247, 148, 29);
            labelSendMessageButton.Location = new Point(335, 0);
            labelSendMessageButton.Name = "labelSendMessageButton";
            labelSendMessageButton.Size = new Size(45, 51);
            labelSendMessageButton.TabIndex = 1;
            labelSendMessageButton.Text = "▷";
            labelSendMessageButton.TextAlign = ContentAlignment.TopCenter;
            labelSendMessageButton.Click += LabelSendMessageButton_Click;
            labelSendMessageButton.MouseDown += LabelSendMessageButton_MouseDown;
            labelSendMessageButton.MouseEnter += LabelSendMessageButton_MouseEnter;
            labelSendMessageButton.MouseLeave += LabelSendMessageButton_MouseLeave;
            labelSendMessageButton.MouseUp += LabelSendMessageButton_MouseUp;
            // 
            // MessageGridView
            // 
            MessageGridView.AllowUserToResizeColumns = false;
            MessageGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            MessageGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            MessageGridView.AutoGenerateColumns = false;
            MessageGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            MessageGridView.BackgroundColor = SystemColors.Control;
            MessageGridView.BorderStyle = BorderStyle.None;
            MessageGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            MessageGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            MessageGridView.ColumnHeadersVisible = false;
            MessageGridView.Columns.AddRange(new DataGridViewColumn[] { LBound, Time, Data, dataGridViewTextBoxColumn1, RBound, OuterFlag });
            MessageGridView.DataSource = messageUnwrapBindingSource;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            MessageGridView.DefaultCellStyle = dataGridViewCellStyle11;
            MessageGridView.Dock = DockStyle.Fill;
            MessageGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            MessageGridView.GridColor = SystemColors.Control;
            MessageGridView.Location = new Point(13, 3);
            MessageGridView.MultiSelect = false;
            MessageGridView.Name = "MessageGridView";
            MessageGridView.ReadOnly = true;
            MessageGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            MessageGridView.RowHeadersVisible = false;
            MessageGridView.RowTemplate.DividerHeight = 15;
            MessageGridView.RowTemplate.Height = 55;
            MessageGridView.ScrollBars = ScrollBars.Vertical;
            MessageGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MessageGridView.ShowCellErrors = false;
            MessageGridView.ShowCellToolTips = false;
            MessageGridView.ShowEditingIcon = false;
            MessageGridView.ShowRowErrors = false;
            MessageGridView.Size = new Size(383, 408);
            MessageGridView.TabIndex = 2;
            MessageGridView.TabStop = false;
            MessageGridView.CellFormatting += MessageGridView_CellFormatting;
            // 
            // messageUnwrapBindingSource
            // 
            messageUnwrapBindingSource.DataSource = typeof(MessageUnwrap);
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(4, 408);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 9;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 45F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 235F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel3.Controls.Add(labelCloseButton, 8, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 5, 0);
            tableLayoutPanel3.Controls.Add(labelMaximizeButton, 7, 0);
            tableLayoutPanel3.Controls.Add(labelMinimizeButton, 6, 0);
            tableLayoutPanel3.Controls.Add(labelSettingsButton, 2, 0);
            tableLayoutPanel3.Controls.Add(labelTitleHeader, 1, 0);
            tableLayoutPanel3.Controls.Add(labelInstructionButton, 3, 0);
            tableLayoutPanel3.Controls.Add(labelInfoButton, 4, 0);
            tableLayoutPanel3.Controls.Add(pictureBoxTitleHeader, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(857, 44);
            tableLayoutPanel3.TabIndex = 1;
            tableLayoutPanel3.MouseDown += TableLayoutPanel3_MouseDown;
            // 
            // labelCloseButton
            // 
            labelCloseButton.AutoSize = true;
            labelCloseButton.Cursor = Cursors.Hand;
            labelCloseButton.Dock = DockStyle.Fill;
            labelCloseButton.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCloseButton.Location = new Point(824, 0);
            labelCloseButton.Name = "labelCloseButton";
            labelCloseButton.Size = new Size(30, 44);
            labelCloseButton.TabIndex = 0;
            labelCloseButton.Text = "⤫";
            labelCloseButton.TextAlign = ContentAlignment.MiddleCenter;
            labelCloseButton.Click += LabelCloseButton_Click;
            labelCloseButton.MouseEnter += LabelCloseButton_MouseEnter;
            labelCloseButton.MouseLeave += LabelCloseButton_MouseLeave;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.8906288F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.21874F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.890625F));
            tableLayoutPanel7.Controls.Add(pictureBoxRightSideLogo, 1, 1);
            tableLayoutPanel7.Controls.Add(labelRightSightStats, 1, 2);
            tableLayoutPanel7.Location = new Point(391, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 3;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 11.48844F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 52.3843956F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 36.1271667F));
            tableLayoutPanel7.Size = new Size(89, 28);
            tableLayoutPanel7.TabIndex = 4;
            tableLayoutPanel7.Visible = false;
            // 
            // pictureBoxRightSideLogo
            // 
            pictureBoxRightSideLogo.Dock = DockStyle.Fill;
            pictureBoxRightSideLogo.Image = Properties.resource_pack_1.networkextra;
            pictureBoxRightSideLogo.Location = new Point(14, 6);
            pictureBoxRightSideLogo.Name = "pictureBoxRightSideLogo";
            pictureBoxRightSideLogo.Size = new Size(60, 8);
            pictureBoxRightSideLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRightSideLogo.TabIndex = 0;
            pictureBoxRightSideLogo.TabStop = false;
            // 
            // labelRightSightStats
            // 
            labelRightSightStats.AutoSize = true;
            labelRightSightStats.Dock = DockStyle.Top;
            labelRightSightStats.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRightSightStats.Location = new Point(14, 42);
            labelRightSightStats.Margin = new Padding(3, 25, 3, 0);
            labelRightSightStats.Name = "labelRightSightStats";
            labelRightSightStats.Size = new Size(60, 1);
            labelRightSightStats.TabIndex = 1;
            labelRightSightStats.Text = "Отправлено с помощью SNM: 5\r\nПрочитано с помощью SNM: 493\r\nВсего контактов: 159";
            labelRightSightStats.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelMaximizeButton
            // 
            labelMaximizeButton.AutoSize = true;
            labelMaximizeButton.Cursor = Cursors.Hand;
            labelMaximizeButton.Dock = DockStyle.Fill;
            labelMaximizeButton.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMaximizeButton.Location = new Point(788, 0);
            labelMaximizeButton.Name = "labelMaximizeButton";
            labelMaximizeButton.Size = new Size(30, 44);
            labelMaximizeButton.TabIndex = 1;
            labelMaximizeButton.Text = "⇗";
            labelMaximizeButton.TextAlign = ContentAlignment.MiddleCenter;
            labelMaximizeButton.Click += LabelMaximizeButton_Click;
            labelMaximizeButton.MouseEnter += LabelMaximizeButton_MouseEnter;
            labelMaximizeButton.MouseLeave += LabelMaximizeButton_MouseLeave;
            // 
            // labelMinimizeButton
            // 
            labelMinimizeButton.AutoSize = true;
            labelMinimizeButton.Cursor = Cursors.Hand;
            labelMinimizeButton.Dock = DockStyle.Fill;
            labelMinimizeButton.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMinimizeButton.Location = new Point(752, 0);
            labelMinimizeButton.Name = "labelMinimizeButton";
            labelMinimizeButton.Size = new Size(30, 44);
            labelMinimizeButton.TabIndex = 2;
            labelMinimizeButton.Text = "↙";
            labelMinimizeButton.TextAlign = ContentAlignment.MiddleCenter;
            labelMinimizeButton.Click += LabelMinimizeButton_Click;
            labelMinimizeButton.MouseEnter += LabelMinimizeButton_MouseEnter;
            labelMinimizeButton.MouseLeave += LabelMinimizeButton_MouseLeave;
            // 
            // labelSettingsButton
            // 
            labelSettingsButton.AutoSize = true;
            labelSettingsButton.Cursor = Cursors.Hand;
            labelSettingsButton.Dock = DockStyle.Fill;
            labelSettingsButton.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSettingsButton.Location = new Point(283, 0);
            labelSettingsButton.Name = "labelSettingsButton";
            labelSettingsButton.Size = new Size(30, 44);
            labelSettingsButton.TabIndex = 3;
            labelSettingsButton.Text = "☳";
            labelSettingsButton.TextAlign = ContentAlignment.MiddleCenter;
            labelSettingsButton.Click += LabelSettingsButton_Click;
            labelSettingsButton.MouseEnter += LabelSettingsButton_MouseEnter;
            labelSettingsButton.MouseLeave += LabelSettingsButton_MouseLeave;
            // 
            // labelTitleHeader
            // 
            labelTitleHeader.AutoSize = true;
            labelTitleHeader.Dock = DockStyle.Fill;
            labelTitleHeader.Font = new Font("Fira Sans SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitleHeader.ForeColor = Color.FromArgb(247, 148, 29);
            labelTitleHeader.Location = new Point(48, 0);
            labelTitleHeader.Name = "labelTitleHeader";
            labelTitleHeader.Size = new Size(229, 44);
            labelTitleHeader.TabIndex = 4;
            labelTitleHeader.Text = "Social Networks Manager";
            labelTitleHeader.TextAlign = ContentAlignment.MiddleLeft;
            labelTitleHeader.MouseDown += LabelTitleHeader_MouseDown;
            // 
            // labelInstructionButton
            // 
            labelInstructionButton.AutoSize = true;
            labelInstructionButton.Cursor = Cursors.Hand;
            labelInstructionButton.Dock = DockStyle.Fill;
            labelInstructionButton.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInstructionButton.Location = new Point(319, 0);
            labelInstructionButton.Name = "labelInstructionButton";
            labelInstructionButton.Size = new Size(30, 44);
            labelInstructionButton.TabIndex = 5;
            labelInstructionButton.Text = "?";
            labelInstructionButton.TextAlign = ContentAlignment.MiddleCenter;
            labelInstructionButton.Click += LabelInstructionButton_Click;
            labelInstructionButton.MouseEnter += LabelAboutButton_MouseEnter;
            labelInstructionButton.MouseLeave += LabelAboutButton_MouseLeave;
            // 
            // labelInfoButton
            // 
            labelInfoButton.AutoSize = true;
            labelInfoButton.Cursor = Cursors.Hand;
            labelInfoButton.Dock = DockStyle.Fill;
            labelInfoButton.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfoButton.Location = new Point(355, 0);
            labelInfoButton.Name = "labelInfoButton";
            labelInfoButton.Size = new Size(30, 44);
            labelInfoButton.TabIndex = 6;
            labelInfoButton.Text = "ⓘ";
            labelInfoButton.TextAlign = ContentAlignment.MiddleCenter;
            labelInfoButton.Click += LabelInfoButton_Click;
            labelInfoButton.MouseEnter += LabelInfoButton_MouseEnter;
            labelInfoButton.MouseLeave += LabelInfoButton_MouseLeave;
            // 
            // pictureBoxTitleHeader
            // 
            pictureBoxTitleHeader.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxTitleHeader.Dock = DockStyle.Fill;
            pictureBoxTitleHeader.Image = Properties.resource_pack_1.network1;
            pictureBoxTitleHeader.Location = new Point(3, 3);
            pictureBoxTitleHeader.Name = "pictureBoxTitleHeader";
            pictureBoxTitleHeader.Size = new Size(39, 38);
            pictureBoxTitleHeader.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTitleHeader.TabIndex = 7;
            pictureBoxTitleHeader.TabStop = false;
            pictureBoxTitleHeader.MouseDown += PictureBoxTitleHeader_MouseDown;
            // 
            // LblVersion
            // 
            LblVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            LblVersion.AutoSize = true;
            LblVersion.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LblVersion.Location = new Point(664, 596);
            LblVersion.Name = "LblVersion";
            LblVersion.Size = new Size(196, 32);
            LblVersion.TabIndex = 2;
            LblVersion.Text = "SNM 1.1.5 (build 11547)\r\nАртемий Вадимович Саганенко";
            LblVersion.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LBound
            // 
            LBound.HeaderText = "LBound";
            LBound.Name = "LBound";
            LBound.ReadOnly = true;
            LBound.Width = 5;
            // 
            // Time
            // 
            Time.DataPropertyName = "Time";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Time.DefaultCellStyle = dataGridViewCellStyle8;
            Time.HeaderText = "Time";
            Time.Name = "Time";
            Time.ReadOnly = true;
            // 
            // Data
            // 
            Data.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Data.DataPropertyName = "Data";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            Data.DefaultCellStyle = dataGridViewCellStyle9;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Time";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewTextBoxColumn1.HeaderText = "Time";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // RBound
            // 
            RBound.HeaderText = "RBound";
            RBound.Name = "RBound";
            RBound.ReadOnly = true;
            RBound.Width = 5;
            // 
            // OuterFlag
            // 
            OuterFlag.DataPropertyName = "OuterFlag";
            OuterFlag.HeaderText = "OuterFlag";
            OuterFlag.Name = "OuterFlag";
            OuterFlag.ReadOnly = true;
            OuterFlag.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 628);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(865, 630);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            PnlContactList.ResumeLayout(false);
            ((ISupportInitialize)ContactsGridView).EndInit();
            ((ISupportInitialize)anyContactTypeBindingSource).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((ISupportInitialize)MessageGridView).EndInit();
            ((ISupportInitialize)messageUnwrapBindingSource).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((ISupportInitialize)pictureBoxRightSideLogo).EndInit();
            ((ISupportInitialize)pictureBoxTitleHeader).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView MessageGridView;
        private BindingSource anyContactTypeBindingSource;
        private BindingSource messageUnwrapBindingSource;
        private PictureBox pictureBoxTitleHeader;
        private Panel panel1;
        private TextBox textBoxSearchContact;
        private TableLayoutPanel tableLayoutPanel7;
        private PictureBox pictureBoxRightSideLogo;
        private Label labelRightSightStats;
        private TableLayoutPanel tableLayoutPanel8;
        private Label labelLastMessageButton;
        private Label labelResetContactsButton;
        private Label labelSendMessageButton;
        private Label labelOpenBrowser;
        private DataGridViewTextBoxColumn SideColor;
        private DataGridViewTextBoxColumn ContactName;
        private DataGridViewTextBoxColumn agoMessageTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastMessageTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn APIId;
        private DataGridViewTextBoxColumn ContactType;
        private DataGridViewTextBoxColumn LBound;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn RBound;
        private DataGridViewTextBoxColumn OuterFlag;
    }
}
