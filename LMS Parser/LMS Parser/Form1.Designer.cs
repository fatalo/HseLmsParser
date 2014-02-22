namespace LMS_Parser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.fromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.startParseButton = new System.Windows.Forms.Button();
            this.toNumberComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logTextbox = new System.Windows.Forms.TextBox();
            this.numberOfCompletedLabel = new System.Windows.Forms.Label();
            this.threadsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.saveAstxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAscsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsCountNumericUpDown)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.linkColumn,
            this.headerColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(671, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Width = 40;
            // 
            // linkColumn
            // 
            this.linkColumn.FillWeight = 193.6306F;
            this.linkColumn.HeaderText = "Link";
            this.linkColumn.Name = "linkColumn";
            this.linkColumn.ReadOnly = true;
            this.linkColumn.Width = 150;
            // 
            // headerColumn
            // 
            this.headerColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.headerColumn.FillWeight = 6.369431F;
            this.headerColumn.HeaderText = "Header";
            this.headerColumn.Name = "headerColumn";
            this.headerColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начальный id";
            // 
            // fromNumericUpDown
            // 
            this.fromNumericUpDown.Location = new System.Drawing.Point(142, 24);
            this.fromNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.fromNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fromNumericUpDown.Name = "fromNumericUpDown";
            this.fromNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.fromNumericUpDown.TabIndex = 2;
            this.fromNumericUpDown.Value = new decimal(new int[] {
            341076,
            0,
            0,
            0});
            this.fromNumericUpDown.ValueChanged += new System.EventHandler(this.fromNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество";
            // 
            // startParseButton
            // 
            this.startParseButton.Location = new System.Drawing.Point(142, 115);
            this.startParseButton.Name = "startParseButton";
            this.startParseButton.Size = new System.Drawing.Size(71, 23);
            this.startParseButton.TabIndex = 4;
            this.startParseButton.Text = "Парсить";
            this.startParseButton.UseVisualStyleBackColor = true;
            this.startParseButton.Click += new System.EventHandler(this.startParseButton_Click);
            // 
            // toNumberComboBox
            // 
            this.toNumberComboBox.FormattingEnabled = true;
            this.toNumberComboBox.Items.AddRange(new object[] {
            "1",
            "10",
            "50",
            "100",
            "500",
            "1000",
            "2500",
            "5000"});
            this.toNumberComboBox.Location = new System.Drawing.Point(142, 53);
            this.toNumberComboBox.Name = "toNumberComboBox";
            this.toNumberComboBox.Size = new System.Drawing.Size(71, 21);
            this.toNumberComboBox.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAstxtToolStripMenuItem,
            this.saveAscsvToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearListToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearListToolStripMenuItem.Text = "Clear list";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // logTextbox
            // 
            this.logTextbox.Location = new System.Drawing.Point(12, 248);
            this.logTextbox.Multiline = true;
            this.logTextbox.Name = "logTextbox";
            this.logTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTextbox.Size = new System.Drawing.Size(428, 367);
            this.logTextbox.TabIndex = 9;
            // 
            // numberOfCompletedLabel
            // 
            this.numberOfCompletedLabel.AutoSize = true;
            this.numberOfCompletedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberOfCompletedLabel.Location = new System.Drawing.Point(36, 115);
            this.numberOfCompletedLabel.Name = "numberOfCompletedLabel";
            this.numberOfCompletedLabel.Size = new System.Drawing.Size(0, 20);
            this.numberOfCompletedLabel.TabIndex = 10;
            // 
            // threadsCountNumericUpDown
            // 
            this.threadsCountNumericUpDown.Location = new System.Drawing.Point(142, 80);
            this.threadsCountNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.threadsCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.threadsCountNumericUpDown.Name = "threadsCountNumericUpDown";
            this.threadsCountNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.threadsCountNumericUpDown.TabIndex = 11;
            this.threadsCountNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(71, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Потоки";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.startParseButton);
            this.settingsGroupBox.Controls.Add(this.label3);
            this.settingsGroupBox.Controls.Add(this.label1);
            this.settingsGroupBox.Controls.Add(this.threadsCountNumericUpDown);
            this.settingsGroupBox.Controls.Add(this.fromNumericUpDown);
            this.settingsGroupBox.Controls.Add(this.numberOfCompletedLabel);
            this.settingsGroupBox.Controls.Add(this.label2);
            this.settingsGroupBox.Controls.Add(this.toNumberComboBox);
            this.settingsGroupBox.Location = new System.Drawing.Point(446, 354);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(237, 160);
            this.settingsGroupBox.TabIndex = 13;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Настройки";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordTextbox);
            this.groupBox1.Controls.Add(this.loginTextbox);
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.loginLabel);
            this.groupBox1.Location = new System.Drawing.Point(446, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизация";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(7, 29);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(38, 13);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(7, 60);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(45, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginTextbox
            // 
            this.loginTextbox.Location = new System.Drawing.Point(51, 26);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(180, 20);
            this.loginTextbox.TabIndex = 2;
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(51, 57);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(180, 20);
            this.passwordTextbox.TabIndex = 3;
            // 
            // saveAstxtToolStripMenuItem
            // 
            this.saveAstxtToolStripMenuItem.Name = "saveAstxtToolStripMenuItem";
            this.saveAstxtToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAstxtToolStripMenuItem.Text = "Save as .txt";
            this.saveAstxtToolStripMenuItem.Click += new System.EventHandler(this.saveAstxtToolStripMenuItem_Click);
            // 
            // saveAscsvToolStripMenuItem
            // 
            this.saveAscsvToolStripMenuItem.Name = "saveAscsvToolStripMenuItem";
            this.saveAscsvToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAscsvToolStripMenuItem.Text = "Save as .csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.logTextbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HSE LMS Parser";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromNumericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threadsCountNumericUpDown)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown fromNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startParseButton;
        private System.Windows.Forms.ComboBox toNumberComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox logTextbox;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn headerColumn;
        private System.Windows.Forms.Label numberOfCompletedLabel;
        private System.Windows.Forms.NumericUpDown threadsCountNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.ToolStripMenuItem saveAstxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAscsvToolStripMenuItem;
    }
}

