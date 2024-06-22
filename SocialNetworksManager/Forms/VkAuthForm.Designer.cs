namespace SocialNetworksManager.Forms
{
    partial class VkAuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VkAuthForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBoxTitle = new PictureBox();
            textBoxLogin = new TextBox();
            textBoxPass = new TextBox();
            textBoxUserId = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonCancel = new Button();
            buttonNext = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitle).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(pictureBoxTitle, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxLogin, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxPass, 1, 3);
            tableLayoutPanel1.Controls.Add(textBoxUserId, 1, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(298, 328);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBoxTitle
            // 
            pictureBoxTitle.Dock = DockStyle.Fill;
            pictureBoxTitle.Image = Properties.resource_pack_1.vklogo;
            pictureBoxTitle.Location = new Point(23, 23);
            pictureBoxTitle.Name = "pictureBoxTitle";
            pictureBoxTitle.Size = new Size(252, 69);
            pictureBoxTitle.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTitle.TabIndex = 0;
            pictureBoxTitle.TabStop = false;
            // 
            // textBoxLogin
            // 
            textBoxLogin.BorderStyle = BorderStyle.None;
            textBoxLogin.Cursor = Cursors.IBeam;
            textBoxLogin.Dock = DockStyle.Fill;
            textBoxLogin.Font = new Font("JetBrains Mono", 11.25F);
            textBoxLogin.Location = new Point(23, 98);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.PlaceholderText = "Login";
            textBoxLogin.Size = new Size(252, 20);
            textBoxLogin.TabIndex = 1;
            textBoxLogin.TextAlign = HorizontalAlignment.Center;
            textBoxLogin.WordWrap = false;
            // 
            // textBoxPass
            // 
            textBoxPass.BorderStyle = BorderStyle.None;
            textBoxPass.Cursor = Cursors.IBeam;
            textBoxPass.Dock = DockStyle.Fill;
            textBoxPass.Font = new Font("JetBrains Mono", 11.25F);
            textBoxPass.Location = new Point(23, 133);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PlaceholderText = "Password";
            textBoxPass.Size = new Size(252, 20);
            textBoxPass.TabIndex = 2;
            textBoxPass.TextAlign = HorizontalAlignment.Center;
            textBoxPass.WordWrap = false;
            // 
            // textBoxUserId
            // 
            textBoxUserId.BorderStyle = BorderStyle.None;
            textBoxUserId.Cursor = Cursors.IBeam;
            textBoxUserId.Dock = DockStyle.Fill;
            textBoxUserId.Font = new Font("JetBrains Mono", 11.25F);
            textBoxUserId.Location = new Point(23, 168);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.PlaceholderText = "User ID";
            textBoxUserId.Size = new Size(252, 20);
            textBoxUserId.TabIndex = 3;
            textBoxUserId.TextAlign = HorizontalAlignment.Center;
            textBoxUserId.WordWrap = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonCancel, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonNext, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(23, 263);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(252, 42);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // buttonCancel
            // 
            buttonCancel.Cursor = Cursors.Hand;
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("JetBrains Mono", 11.9999981F);
            buttonCancel.ForeColor = Color.DarkRed;
            buttonCancel.Location = new Point(3, 3);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 36);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Отменить ✕";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            buttonCancel.MouseEnter += ButtonCancel_MouseEnter;
            buttonCancel.MouseLeave += ButtonCancel_MouseLeave;
            // 
            // buttonNext
            // 
            buttonNext.Cursor = Cursors.Hand;
            buttonNext.Dock = DockStyle.Fill;
            buttonNext.FlatStyle = FlatStyle.Flat;
            buttonNext.Font = new Font("JetBrains Mono", 11.9999981F);
            buttonNext.ForeColor = Color.DarkRed;
            buttonNext.Location = new Point(129, 3);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(120, 36);
            buttonNext.TabIndex = 1;
            buttonNext.Text = "Далее ✓ ";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += ButtonNext_Click;
            buttonNext.MouseEnter += ButtonNext_MouseEnter;
            buttonNext.MouseLeave += ButtonNext_MouseLeave;
            // 
            // VkAuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 328);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(300, 330);
            MinimumSize = new Size(300, 330);
            Name = "VkAuthForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTitle).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBoxTitle;
        private TextBox textBoxLogin;
        private TextBox textBoxPass;
        private TextBox textBoxUserId;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonCancel;
        private Button buttonNext;
    }
}