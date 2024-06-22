namespace SocialNetworksManager.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBoxLogo = new PictureBox();
            pictureBoxSPBSUTLogo = new PictureBox();
            labelTitleText = new Label();
            labelInfoText = new Label();
            buttonClose = new Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSPBSUTLogo).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Controls.Add(pictureBoxLogo, 1, 1);
            tableLayoutPanel1.Controls.Add(pictureBoxSPBSUTLogo, 1, 2);
            tableLayoutPanel1.Controls.Add(labelTitleText, 1, 3);
            tableLayoutPanel1.Controls.Add(labelInfoText, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonClose, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(298, 548);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Fill;
            pictureBoxLogo.Image = Properties.resource_pack_1.network1;
            pictureBoxLogo.Location = new Point(33, 33);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(232, 124);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxSPBSUTLogo
            // 
            pictureBoxSPBSUTLogo.Dock = DockStyle.Fill;
            pictureBoxSPBSUTLogo.Image = Properties.resource_pack_1.sut;
            pictureBoxSPBSUTLogo.Location = new Point(33, 163);
            pictureBoxSPBSUTLogo.Name = "pictureBoxSPBSUTLogo";
            pictureBoxSPBSUTLogo.Size = new Size(232, 64);
            pictureBoxSPBSUTLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSPBSUTLogo.TabIndex = 1;
            pictureBoxSPBSUTLogo.TabStop = false;
            // 
            // labelTitleText
            // 
            labelTitleText.AutoSize = true;
            labelTitleText.Dock = DockStyle.Fill;
            labelTitleText.Font = new Font("Fira Sans", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTitleText.ForeColor = Color.FromArgb(247, 148, 29);
            labelTitleText.Location = new Point(33, 230);
            labelTitleText.Name = "labelTitleText";
            labelTitleText.Size = new Size(232, 100);
            labelTitleText.TabIndex = 2;
            labelTitleText.Text = "Social\r\nNetworks\r\nManager";
            labelTitleText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInfoText
            // 
            labelInfoText.AutoSize = true;
            labelInfoText.Dock = DockStyle.Fill;
            labelInfoText.Font = new Font("Fira Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfoText.Location = new Point(33, 330);
            labelInfoText.Name = "labelInfoText";
            labelInfoText.Size = new Size(232, 130);
            labelInfoText.TabIndex = 3;
            labelInfoText.Text = "Разработка агрегатора социальных сетей для улучшения цифровой коммуникации между пользователями\r\n\r\nСтудент: \r\nСаганенко Артемий Вадимович\r\nРуководитель: \r\nБелая Татьяна Иоанновна";
            labelInfoText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.Dock = DockStyle.Fill;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Fira Sans", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonClose.ForeColor = Color.FromArgb(247, 148, 29);
            buttonClose.Location = new Point(33, 463);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(232, 44);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Закрыть ⛌";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += ButtonClose_Click;
            buttonClose.MouseEnter += ButtonClose_MouseEnter;
            buttonClose.MouseLeave += ButtonClose_MouseLeave;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 548);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(300, 550);
            MinimumSize = new Size(300, 550);
            Name = "AboutForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSPBSUTLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBoxLogo;
        private PictureBox pictureBoxSPBSUTLogo;
        private Label labelTitleText;
        private Label labelInfoText;
        private Button buttonClose;
    }
}