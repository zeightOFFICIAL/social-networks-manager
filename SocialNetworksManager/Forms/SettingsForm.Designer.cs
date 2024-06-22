namespace SocialNetworksManager.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonCancelSettings = new Button();
            buttonApplySettings = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            LabelSettingsTitle = new Label();
            LabelSettingsLeft = new Label();
            LabelSettingsRight = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBoxTg = new PictureBox();
            pictureBoxVk = new PictureBox();
            pictureBoxOk = new PictureBox();
            pictureBoxVi = new PictureBox();
            buttonTgAgg = new Button();
            buttonVkAgg = new Button();
            buttonOkAgg = new Button();
            buttonViAgg = new Button();
            buttonOpenSettings = new Button();
            labelOpenAgg = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            buttonOpenGeneral = new Button();
            buttonOpenFilters = new Button();
            buttonStats = new Button();
            labelOpenGeneral = new Label();
            labelOpenFilter = new Label();
            labelOpenStats = new Label();
            tableLayoutPanel6 = new TableLayoutPanel();
            buttonLightTheme = new Button();
            buttonNightTheme = new Button();
            buttonRoyalTheme = new Button();
            buttonAddRule = new Button();
            buttonRemoveRule = new Button();
            labelRulesTotal = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVi).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(698, 508);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(buttonCancelSettings, 0, 0);
            tableLayoutPanel2.Controls.Add(buttonApplySettings, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(38, 451);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(622, 39);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonCancelSettings
            // 
            buttonCancelSettings.Cursor = Cursors.Hand;
            buttonCancelSettings.Dock = DockStyle.Fill;
            buttonCancelSettings.FlatStyle = FlatStyle.Flat;
            buttonCancelSettings.Font = new Font("Fira Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonCancelSettings.ForeColor = Color.FromArgb(247, 148, 29);
            buttonCancelSettings.Location = new Point(110, 3);
            buttonCancelSettings.Margin = new Padding(110, 3, 15, 3);
            buttonCancelSettings.Name = "buttonCancelSettings";
            buttonCancelSettings.Size = new Size(186, 33);
            buttonCancelSettings.TabIndex = 0;
            buttonCancelSettings.Text = "Отменить ✕";
            buttonCancelSettings.UseVisualStyleBackColor = true;
            buttonCancelSettings.Click += ButtonCancelSettings_Click;
            buttonCancelSettings.MouseEnter += ButtonCancelSettings_MouseEnter;
            buttonCancelSettings.MouseLeave += ButtonCancelSettings_MouseLeave;
            // 
            // buttonApplySettings
            // 
            buttonApplySettings.Cursor = Cursors.Hand;
            buttonApplySettings.Dock = DockStyle.Fill;
            buttonApplySettings.FlatStyle = FlatStyle.Flat;
            buttonApplySettings.Font = new Font("Fira Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonApplySettings.ForeColor = Color.FromArgb(247, 148, 29);
            buttonApplySettings.Location = new Point(326, 3);
            buttonApplySettings.Margin = new Padding(15, 3, 110, 3);
            buttonApplySettings.Name = "buttonApplySettings";
            buttonApplySettings.Size = new Size(186, 33);
            buttonApplySettings.TabIndex = 1;
            buttonApplySettings.Text = "Принять ✓";
            buttonApplySettings.UseVisualStyleBackColor = true;
            buttonApplySettings.Click += ButtonApplySettings_Click;
            buttonApplySettings.MouseEnter += ButtonApplySettings_MouseEnter;
            buttonApplySettings.MouseLeave += ButtonApplySettings_MouseLeave;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(LabelSettingsTitle, 0, 0);
            tableLayoutPanel3.Controls.Add(LabelSettingsLeft, 0, 1);
            tableLayoutPanel3.Controls.Add(LabelSettingsRight, 1, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(38, 18);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(622, 427);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // LabelSettingsTitle
            // 
            LabelSettingsTitle.AutoSize = true;
            LabelSettingsTitle.Dock = DockStyle.Fill;
            LabelSettingsTitle.Font = new Font("Fira Sans SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelSettingsTitle.ForeColor = Color.FromArgb(247, 148, 29);
            LabelSettingsTitle.Location = new Point(3, 0);
            LabelSettingsTitle.Name = "LabelSettingsTitle";
            LabelSettingsTitle.Size = new Size(305, 35);
            LabelSettingsTitle.TabIndex = 0;
            LabelSettingsTitle.Text = "Настройки";
            LabelSettingsTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelSettingsLeft
            // 
            LabelSettingsLeft.AutoSize = true;
            LabelSettingsLeft.Dock = DockStyle.Fill;
            LabelSettingsLeft.Font = new Font("Fira Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelSettingsLeft.ForeColor = Color.FromArgb(247, 148, 29);
            LabelSettingsLeft.Location = new Point(35, 35);
            LabelSettingsLeft.Margin = new Padding(35, 0, 3, 0);
            LabelSettingsLeft.Name = "LabelSettingsLeft";
            LabelSettingsLeft.Size = new Size(273, 35);
            LabelSettingsLeft.TabIndex = 1;
            LabelSettingsLeft.Text = "Общие";
            LabelSettingsLeft.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelSettingsRight
            // 
            LabelSettingsRight.AutoSize = true;
            LabelSettingsRight.Dock = DockStyle.Fill;
            LabelSettingsRight.Font = new Font("Fira Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelSettingsRight.ForeColor = Color.FromArgb(247, 148, 29);
            LabelSettingsRight.Location = new Point(346, 35);
            LabelSettingsRight.Margin = new Padding(35, 0, 3, 0);
            LabelSettingsRight.Name = "LabelSettingsRight";
            LabelSettingsRight.Size = new Size(273, 35);
            LabelSettingsRight.TabIndex = 2;
            LabelSettingsRight.Text = "Агрегации";
            LabelSettingsRight.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel4.Controls.Add(pictureBoxTg, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBoxVk, 0, 1);
            tableLayoutPanel4.Controls.Add(pictureBoxOk, 0, 2);
            tableLayoutPanel4.Controls.Add(pictureBoxVi, 0, 3);
            tableLayoutPanel4.Controls.Add(buttonTgAgg, 1, 0);
            tableLayoutPanel4.Controls.Add(buttonVkAgg, 1, 1);
            tableLayoutPanel4.Controls.Add(buttonOkAgg, 1, 2);
            tableLayoutPanel4.Controls.Add(buttonViAgg, 1, 3);
            tableLayoutPanel4.Controls.Add(buttonOpenSettings, 1, 5);
            tableLayoutPanel4.Controls.Add(labelOpenAgg, 0, 5);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(314, 73);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.Size = new Size(305, 351);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // pictureBoxTg
            // 
            pictureBoxTg.Dock = DockStyle.Fill;
            pictureBoxTg.Image = Properties.resource_pack_1.tglogo;
            pictureBoxTg.Location = new Point(3, 7);
            pictureBoxTg.Margin = new Padding(3, 7, 3, 7);
            pictureBoxTg.Name = "pictureBoxTg";
            pictureBoxTg.Size = new Size(174, 36);
            pictureBoxTg.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTg.TabIndex = 0;
            pictureBoxTg.TabStop = false;
            // 
            // pictureBoxVk
            // 
            pictureBoxVk.Dock = DockStyle.Fill;
            pictureBoxVk.Image = Properties.resource_pack_1.vklogo;
            pictureBoxVk.Location = new Point(3, 53);
            pictureBoxVk.Name = "pictureBoxVk";
            pictureBoxVk.Size = new Size(174, 44);
            pictureBoxVk.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxVk.TabIndex = 1;
            pictureBoxVk.TabStop = false;
            // 
            // pictureBoxOk
            // 
            pictureBoxOk.Dock = DockStyle.Fill;
            pictureBoxOk.Image = Properties.resource_pack_1.oklogo;
            pictureBoxOk.Location = new Point(3, 103);
            pictureBoxOk.Name = "pictureBoxOk";
            pictureBoxOk.Size = new Size(174, 44);
            pictureBoxOk.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxOk.TabIndex = 2;
            pictureBoxOk.TabStop = false;
            // 
            // pictureBoxVi
            // 
            pictureBoxVi.Dock = DockStyle.Fill;
            pictureBoxVi.Image = Properties.resource_pack_1.vilogo;
            pictureBoxVi.Location = new Point(3, 157);
            pictureBoxVi.Margin = new Padding(3, 7, 3, 7);
            pictureBoxVi.Name = "pictureBoxVi";
            pictureBoxVi.Size = new Size(174, 36);
            pictureBoxVi.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxVi.TabIndex = 3;
            pictureBoxVi.TabStop = false;
            // 
            // buttonTgAgg
            // 
            buttonTgAgg.Cursor = Cursors.Hand;
            buttonTgAgg.Dock = DockStyle.Fill;
            buttonTgAgg.FlatStyle = FlatStyle.Flat;
            buttonTgAgg.Font = new Font("JetBrains Mono", 8.999999F);
            buttonTgAgg.ForeColor = SystemColors.MenuHighlight;
            buttonTgAgg.Location = new Point(183, 10);
            buttonTgAgg.Margin = new Padding(3, 10, 3, 10);
            buttonTgAgg.Name = "buttonTgAgg";
            buttonTgAgg.Size = new Size(119, 30);
            buttonTgAgg.TabIndex = 4;
            buttonTgAgg.Text = "Подключить";
            buttonTgAgg.UseVisualStyleBackColor = true;
            buttonTgAgg.Click += ButtonTgAgg_Click;
            buttonTgAgg.MouseEnter += ButtonTgAgg_MouseEnter;
            buttonTgAgg.MouseLeave += ButtonTgAgg_MouseLeave;
            // 
            // buttonVkAgg
            // 
            buttonVkAgg.Cursor = Cursors.Hand;
            buttonVkAgg.Dock = DockStyle.Fill;
            buttonVkAgg.FlatStyle = FlatStyle.Flat;
            buttonVkAgg.Font = new Font("JetBrains Mono", 8.999999F);
            buttonVkAgg.ForeColor = SystemColors.HotTrack;
            buttonVkAgg.Location = new Point(183, 60);
            buttonVkAgg.Margin = new Padding(3, 10, 3, 10);
            buttonVkAgg.Name = "buttonVkAgg";
            buttonVkAgg.Size = new Size(119, 30);
            buttonVkAgg.TabIndex = 5;
            buttonVkAgg.Text = "Подключить";
            buttonVkAgg.UseVisualStyleBackColor = true;
            buttonVkAgg.Click += ButtonVkAgg_Click;
            buttonVkAgg.MouseEnter += ButtonVkAgg_MouseEnter;
            buttonVkAgg.MouseLeave += ButtonVkAgg_MouseLeave;
            // 
            // buttonOkAgg
            // 
            buttonOkAgg.Cursor = Cursors.No;
            buttonOkAgg.Dock = DockStyle.Fill;
            buttonOkAgg.FlatStyle = FlatStyle.Flat;
            buttonOkAgg.Font = new Font("JetBrains Mono", 8.999999F);
            buttonOkAgg.ForeColor = Color.Orange;
            buttonOkAgg.Location = new Point(183, 110);
            buttonOkAgg.Margin = new Padding(3, 10, 3, 10);
            buttonOkAgg.Name = "buttonOkAgg";
            buttonOkAgg.Size = new Size(119, 30);
            buttonOkAgg.TabIndex = 6;
            buttonOkAgg.Text = "Подключить";
            buttonOkAgg.UseVisualStyleBackColor = true;
            buttonOkAgg.MouseEnter += ButtonOkAgg_MouseEnter;
            buttonOkAgg.MouseLeave += ButtonOkAgg_MouseLeave;
            // 
            // buttonViAgg
            // 
            buttonViAgg.Cursor = Cursors.No;
            buttonViAgg.Dock = DockStyle.Fill;
            buttonViAgg.FlatStyle = FlatStyle.Flat;
            buttonViAgg.Font = new Font("JetBrains Mono", 8.999999F);
            buttonViAgg.ForeColor = Color.MediumPurple;
            buttonViAgg.Location = new Point(183, 160);
            buttonViAgg.Margin = new Padding(3, 10, 3, 10);
            buttonViAgg.Name = "buttonViAgg";
            buttonViAgg.Size = new Size(119, 30);
            buttonViAgg.TabIndex = 7;
            buttonViAgg.Text = "Подключить";
            buttonViAgg.UseVisualStyleBackColor = true;
            buttonViAgg.MouseEnter += ButtonViAgg_MouseEnter;
            buttonViAgg.MouseLeave += ButtonViAgg_MouseLeave;
            // 
            // buttonOpenSettings
            // 
            buttonOpenSettings.Cursor = Cursors.Hand;
            buttonOpenSettings.Dock = DockStyle.Fill;
            buttonOpenSettings.FlatStyle = FlatStyle.Flat;
            buttonOpenSettings.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOpenSettings.ForeColor = Color.DarkRed;
            buttonOpenSettings.Location = new Point(183, 311);
            buttonOpenSettings.Margin = new Padding(3, 10, 3, 10);
            buttonOpenSettings.Name = "buttonOpenSettings";
            buttonOpenSettings.Size = new Size(119, 30);
            buttonOpenSettings.TabIndex = 8;
            buttonOpenSettings.Text = "Открыть";
            buttonOpenSettings.UseVisualStyleBackColor = true;
            buttonOpenSettings.Click += ButtonOpenSettings_Click;
            buttonOpenSettings.MouseEnter += ButtonOpenSettings_MouseEnter;
            buttonOpenSettings.MouseLeave += ButtonOpenSettings_MouseLeave;
            // 
            // labelOpenAgg
            // 
            labelOpenAgg.AutoSize = true;
            labelOpenAgg.Dock = DockStyle.Fill;
            labelOpenAgg.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelOpenAgg.ForeColor = Color.DarkRed;
            labelOpenAgg.Location = new Point(3, 301);
            labelOpenAgg.Name = "labelOpenAgg";
            labelOpenAgg.Size = new Size(174, 50);
            labelOpenAgg.TabIndex = 9;
            labelOpenAgg.Text = "Открыть JSON \r\nфайл для просмотра \r\nконфигурации агрегации";
            labelOpenAgg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            tableLayoutPanel5.Controls.Add(buttonOpenGeneral, 1, 4);
            tableLayoutPanel5.Controls.Add(buttonOpenFilters, 1, 5);
            tableLayoutPanel5.Controls.Add(buttonStats, 1, 6);
            tableLayoutPanel5.Controls.Add(labelOpenGeneral, 0, 4);
            tableLayoutPanel5.Controls.Add(labelOpenFilter, 0, 5);
            tableLayoutPanel5.Controls.Add(labelOpenStats, 0, 6);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Controls.Add(buttonAddRule, 0, 1);
            tableLayoutPanel5.Controls.Add(buttonRemoveRule, 0, 2);
            tableLayoutPanel5.Controls.Add(labelRulesTotal, 1, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 73);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 7;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.Size = new Size(305, 351);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // buttonOpenGeneral
            // 
            buttonOpenGeneral.Cursor = Cursors.Hand;
            buttonOpenGeneral.Dock = DockStyle.Fill;
            buttonOpenGeneral.FlatStyle = FlatStyle.Flat;
            buttonOpenGeneral.Font = new Font("JetBrains Mono", 11.25F);
            buttonOpenGeneral.ForeColor = Color.DarkRed;
            buttonOpenGeneral.Location = new Point(183, 211);
            buttonOpenGeneral.Margin = new Padding(3, 10, 3, 10);
            buttonOpenGeneral.Name = "buttonOpenGeneral";
            buttonOpenGeneral.Size = new Size(119, 30);
            buttonOpenGeneral.TabIndex = 0;
            buttonOpenGeneral.Text = "Открыть";
            buttonOpenGeneral.UseVisualStyleBackColor = true;
            buttonOpenGeneral.MouseEnter += ButtonOpenGeneral_MouseEnter;
            buttonOpenGeneral.MouseLeave += ButtonOpenGeneral_MouseLeave;
            // 
            // buttonOpenFilters
            // 
            buttonOpenFilters.Cursor = Cursors.Hand;
            buttonOpenFilters.Dock = DockStyle.Fill;
            buttonOpenFilters.FlatStyle = FlatStyle.Flat;
            buttonOpenFilters.Font = new Font("JetBrains Mono", 11.25F);
            buttonOpenFilters.ForeColor = Color.DarkRed;
            buttonOpenFilters.Location = new Point(183, 261);
            buttonOpenFilters.Margin = new Padding(3, 10, 3, 10);
            buttonOpenFilters.Name = "buttonOpenFilters";
            buttonOpenFilters.Size = new Size(119, 30);
            buttonOpenFilters.TabIndex = 1;
            buttonOpenFilters.Text = "Открыть";
            buttonOpenFilters.UseVisualStyleBackColor = true;
            buttonOpenFilters.MouseEnter += ButtonOpenFilters_MouseEnter;
            buttonOpenFilters.MouseLeave += ButtonOpenFilters_MouseLeave;
            // 
            // buttonStats
            // 
            buttonStats.Cursor = Cursors.Hand;
            buttonStats.Dock = DockStyle.Fill;
            buttonStats.FlatStyle = FlatStyle.Flat;
            buttonStats.Font = new Font("JetBrains Mono", 11.25F);
            buttonStats.ForeColor = Color.DarkRed;
            buttonStats.Location = new Point(183, 311);
            buttonStats.Margin = new Padding(3, 10, 3, 10);
            buttonStats.Name = "buttonStats";
            buttonStats.Size = new Size(119, 30);
            buttonStats.TabIndex = 2;
            buttonStats.Text = "Открыть";
            buttonStats.UseVisualStyleBackColor = true;
            buttonStats.MouseEnter += ButtonStats_MouseEnter;
            buttonStats.MouseLeave += ButtonStats_MouseLeave;
            // 
            // labelOpenGeneral
            // 
            labelOpenGeneral.AutoSize = true;
            labelOpenGeneral.Dock = DockStyle.Fill;
            labelOpenGeneral.Font = new Font("JetBrains Mono", 8.999999F);
            labelOpenGeneral.ForeColor = Color.DarkRed;
            labelOpenGeneral.Location = new Point(3, 201);
            labelOpenGeneral.Name = "labelOpenGeneral";
            labelOpenGeneral.Size = new Size(174, 50);
            labelOpenGeneral.TabIndex = 3;
            labelOpenGeneral.Text = "Открыть JSON\r\nфайл для просмотра\r\nобщей конфигурации\r\n";
            labelOpenGeneral.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOpenFilter
            // 
            labelOpenFilter.AutoSize = true;
            labelOpenFilter.Dock = DockStyle.Fill;
            labelOpenFilter.Font = new Font("JetBrains Mono", 8.999999F);
            labelOpenFilter.ForeColor = Color.DarkRed;
            labelOpenFilter.Location = new Point(3, 251);
            labelOpenFilter.Name = "labelOpenFilter";
            labelOpenFilter.Size = new Size(174, 50);
            labelOpenFilter.TabIndex = 4;
            labelOpenFilter.Text = "Открыть JSON\r\nфайл для просмотра\r\nконфигурации фильтров";
            labelOpenFilter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOpenStats
            // 
            labelOpenStats.AutoSize = true;
            labelOpenStats.Dock = DockStyle.Fill;
            labelOpenStats.Font = new Font("JetBrains Mono", 8.999999F);
            labelOpenStats.ForeColor = Color.DarkRed;
            labelOpenStats.Location = new Point(3, 301);
            labelOpenStats.Name = "labelOpenStats";
            labelOpenStats.Size = new Size(174, 50);
            labelOpenStats.TabIndex = 5;
            labelOpenStats.Text = "Открыть JSON\r\nфайл для просмотра\r\nсобранной статистики";
            labelOpenStats.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.Controls.Add(buttonLightTheme, 0, 0);
            tableLayoutPanel6.Controls.Add(buttonNightTheme, 1, 0);
            tableLayoutPanel6.Controls.Add(buttonRoyalTheme, 2, 0);
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(172, 44);
            tableLayoutPanel6.TabIndex = 6;
            // 
            // buttonLightTheme
            // 
            buttonLightTheme.BackColor = Color.Wheat;
            buttonLightTheme.Cursor = Cursors.Hand;
            buttonLightTheme.Dock = DockStyle.Fill;
            buttonLightTheme.FlatStyle = FlatStyle.Flat;
            buttonLightTheme.Font = new Font("Fira Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLightTheme.Location = new Point(3, 3);
            buttonLightTheme.Name = "buttonLightTheme";
            buttonLightTheme.Size = new Size(51, 38);
            buttonLightTheme.TabIndex = 0;
            buttonLightTheme.TabStop = false;
            buttonLightTheme.Text = "☼";
            buttonLightTheme.UseVisualStyleBackColor = false;
            buttonLightTheme.Click += ButtonLightTheme_Click;
            buttonLightTheme.MouseEnter += ButtonLightTheme_MouseEnter;
            buttonLightTheme.MouseLeave += ButtonLightTheme_MouseLeave;
            // 
            // buttonNightTheme
            // 
            buttonNightTheme.BackColor = Color.MidnightBlue;
            buttonNightTheme.Cursor = Cursors.Hand;
            buttonNightTheme.Dock = DockStyle.Fill;
            buttonNightTheme.FlatStyle = FlatStyle.Flat;
            buttonNightTheme.Font = new Font("Fira Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonNightTheme.ForeColor = Color.White;
            buttonNightTheme.Location = new Point(60, 3);
            buttonNightTheme.Name = "buttonNightTheme";
            buttonNightTheme.Size = new Size(51, 38);
            buttonNightTheme.TabIndex = 1;
            buttonNightTheme.TabStop = false;
            buttonNightTheme.Text = "☾";
            buttonNightTheme.UseVisualStyleBackColor = false;
            buttonNightTheme.Click += ButtonNightTheme_Click;
            buttonNightTheme.MouseEnter += ButtonNightTheme_MouseEnter;
            buttonNightTheme.MouseLeave += ButtonNightTheme_MouseLeave;
            // 
            // buttonRoyalTheme
            // 
            buttonRoyalTheme.BackColor = Color.Indigo;
            buttonRoyalTheme.Cursor = Cursors.Hand;
            buttonRoyalTheme.Dock = DockStyle.Fill;
            buttonRoyalTheme.FlatStyle = FlatStyle.Flat;
            buttonRoyalTheme.Font = new Font("Fira Sans", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRoyalTheme.ForeColor = Color.White;
            buttonRoyalTheme.Location = new Point(117, 3);
            buttonRoyalTheme.Name = "buttonRoyalTheme";
            buttonRoyalTheme.Size = new Size(52, 38);
            buttonRoyalTheme.TabIndex = 2;
            buttonRoyalTheme.TabStop = false;
            buttonRoyalTheme.Text = "♜";
            buttonRoyalTheme.UseVisualStyleBackColor = false;
            buttonRoyalTheme.Click += ButtonRoyalTheme_Click;
            buttonRoyalTheme.MouseEnter += ButtonRoyalTheme_MouseEnter;
            buttonRoyalTheme.MouseLeave += ButtonRoyalTheme_MouseLeave;
            // 
            // buttonAddRule
            // 
            buttonAddRule.Cursor = Cursors.Hand;
            buttonAddRule.Dock = DockStyle.Fill;
            buttonAddRule.FlatStyle = FlatStyle.Flat;
            buttonAddRule.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddRule.ForeColor = Color.DarkGreen;
            buttonAddRule.Location = new Point(7, 57);
            buttonAddRule.Margin = new Padding(7, 7, 3, 7);
            buttonAddRule.Name = "buttonAddRule";
            buttonAddRule.Size = new Size(170, 36);
            buttonAddRule.TabIndex = 7;
            buttonAddRule.TabStop = false;
            buttonAddRule.Text = "Правило ➕ ";
            buttonAddRule.UseVisualStyleBackColor = true;
            buttonAddRule.MouseEnter += ButtonAddRule_MouseEnter;
            buttonAddRule.MouseLeave += ButtonAddRule_MouseLeave;
            // 
            // buttonRemoveRule
            // 
            buttonRemoveRule.Cursor = Cursors.Hand;
            buttonRemoveRule.Dock = DockStyle.Fill;
            buttonRemoveRule.FlatStyle = FlatStyle.Flat;
            buttonRemoveRule.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRemoveRule.ForeColor = Color.DarkRed;
            buttonRemoveRule.Location = new Point(7, 107);
            buttonRemoveRule.Margin = new Padding(7);
            buttonRemoveRule.Name = "buttonRemoveRule";
            buttonRemoveRule.Size = new Size(166, 36);
            buttonRemoveRule.TabIndex = 8;
            buttonRemoveRule.TabStop = false;
            buttonRemoveRule.Text = "Правило ➖";
            buttonRemoveRule.UseVisualStyleBackColor = true;
            buttonRemoveRule.Click += ButtonRemoveRule_Click;
            buttonRemoveRule.MouseEnter += ButtonRemoveRule_MouseEnter;
            buttonRemoveRule.MouseLeave += ButtonRemoveRule_MouseLeave;
            // 
            // labelRulesTotal
            // 
            labelRulesTotal.AutoSize = true;
            labelRulesTotal.Dock = DockStyle.Fill;
            labelRulesTotal.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelRulesTotal.Location = new Point(183, 50);
            labelRulesTotal.Name = "labelRulesTotal";
            labelRulesTotal.Size = new Size(119, 50);
            labelRulesTotal.TabIndex = 9;
            labelRulesTotal.Text = "Всего правил: 0";
            labelRulesTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 504);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(700, 510);
            MinimumSize = new Size(700, 510);
            Name = "SettingsForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOk).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVi).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonCancelSettings;
        private TableLayoutPanel tableLayoutPanel2;
        private Button buttonApplySettings;
        private TableLayoutPanel tableLayoutPanel3;
        private Label LabelSettingsTitle;
        private Label LabelSettingsLeft;
        private Label LabelSettingsRight;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBoxTg;
        private PictureBox pictureBoxVk;
        private PictureBox pictureBoxOk;
        private PictureBox pictureBoxVi;
        private Button buttonTgAgg;
        private Button buttonVkAgg;
        private Button buttonOkAgg;
        private Button buttonViAgg;
        private Button buttonOpenSettings;
        private Label labelOpenAgg;
        private TableLayoutPanel tableLayoutPanel5;
        private Button buttonOpenGeneral;
        private Button buttonOpenFilters;
        private Button buttonStats;
        private Label labelOpenGeneral;
        private Label labelOpenFilter;
        private Label labelOpenStats;
        private TableLayoutPanel tableLayoutPanel6;
        private Button buttonLightTheme;
        private Button buttonNightTheme;
        private Button buttonRoyalTheme;
        private Button buttonAddRule;
        private Button buttonRemoveRule;
        private Label labelRulesTotal;
    }
}