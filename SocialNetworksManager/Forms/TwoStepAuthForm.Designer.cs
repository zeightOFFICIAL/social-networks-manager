namespace SocialNetworksManager.Forms
{
    partial class TwoStepAuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwoStepAuthForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            labelTextInfo = new Label();
            textBoxCodeInput = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonDeny = new Button();
            buttonTryApply = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(labelTextInfo, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxCodeInput, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.4004135F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.7997952F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.7997952F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(320, 200);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelTextInfo
            // 
            labelTextInfo.AutoSize = true;
            labelTextInfo.Dock = DockStyle.Fill;
            labelTextInfo.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelTextInfo.ForeColor = Color.DarkRed;
            labelTextInfo.Location = new Point(23, 20);
            labelTextInfo.Name = "labelTextInfo";
            labelTextInfo.Size = new Size(274, 77);
            labelTextInfo.TabIndex = 0;
            labelTextInfo.Text = "Двухфакторная авторизация запрашивает ввод кода. Введите код из приложения аутентификатора, смс код, последние 6 цифр номера телефона для потдверждения";
            labelTextInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxCodeInput
            // 
            textBoxCodeInput.BackColor = SystemColors.Control;
            textBoxCodeInput.BorderStyle = BorderStyle.None;
            textBoxCodeInput.Cursor = Cursors.IBeam;
            textBoxCodeInput.Dock = DockStyle.Fill;
            textBoxCodeInput.Font = new Font("JetBrains Mono", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCodeInput.Location = new Point(23, 100);
            textBoxCodeInput.MaxLength = 6;
            textBoxCodeInput.Name = "textBoxCodeInput";
            textBoxCodeInput.PlaceholderText = "___ ___";
            textBoxCodeInput.Size = new Size(274, 36);
            textBoxCodeInput.TabIndex = 1;
            textBoxCodeInput.TextAlign = HorizontalAlignment.Center;
            textBoxCodeInput.WordWrap = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(buttonDeny, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonTryApply, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(23, 141);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(274, 35);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // buttonDeny
            // 
            buttonDeny.Cursor = Cursors.Hand;
            buttonDeny.DialogResult = DialogResult.Cancel;
            buttonDeny.Dock = DockStyle.Fill;
            buttonDeny.FlatStyle = FlatStyle.Flat;
            buttonDeny.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDeny.ForeColor = Color.DarkRed;
            buttonDeny.Location = new Point(3, 3);
            buttonDeny.Name = "buttonDeny";
            buttonDeny.Size = new Size(131, 29);
            buttonDeny.TabIndex = 2;
            buttonDeny.TabStop = false;
            buttonDeny.Text = "Отменить ✕";
            buttonDeny.UseVisualStyleBackColor = true;
            buttonDeny.Click += ButtonDeny_Click;
            buttonDeny.MouseEnter += ButtonDeny_MouseEnter;
            buttonDeny.MouseLeave += ButtonDeny_MouseLeave;
            // 
            // buttonTryApply
            // 
            buttonTryApply.Cursor = Cursors.Hand;
            buttonTryApply.DialogResult = DialogResult.OK;
            buttonTryApply.Dock = DockStyle.Fill;
            buttonTryApply.FlatStyle = FlatStyle.Flat;
            buttonTryApply.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonTryApply.ForeColor = Color.DarkRed;
            buttonTryApply.Location = new Point(140, 3);
            buttonTryApply.Name = "buttonTryApply";
            buttonTryApply.Size = new Size(131, 29);
            buttonTryApply.TabIndex = 3;
            buttonTryApply.TabStop = false;
            buttonTryApply.Text = "Принять ✓ ";
            buttonTryApply.UseVisualStyleBackColor = true;
            buttonTryApply.Click += ButtonTryApply_Click;
            buttonTryApply.MouseEnter += ButtonTryApply_MouseEnter;
            buttonTryApply.MouseLeave += ButtonTryApply_MouseLeave;
            // 
            // TwoStepAuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 200);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TwoStepAuthForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "TwoStepAuthForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label labelTextInfo;
        private TextBox textBoxCodeInput;
        private Button buttonDeny;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonTryApply;
    }
}