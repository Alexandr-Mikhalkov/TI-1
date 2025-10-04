namespace Laba1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFilems = new ToolStripMenuItem();
            saveAsms = new ToolStripMenuItem();
            PltextBox = new TextBox();
            KeytextBox = new TextBox();
            plainTextLbl = new Label();
            keyLbl = new Label();
            RFradioButton = new RadioButton();
            VradioButton = new RadioButton();
            EncoderadioButton = new RadioButton();
            DecoderadioButton = new RadioButton();
            RestextBox = new TextBox();
            ResLbl = new Label();
            Execbtn = new Button();
            Methodpanel = new Panel();
            Typepanel = new Panel();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            clearPLbtn = new Button();
            clearKbtn = new Button();
            menuStrip1.SuspendLayout();
            Methodpanel.SuspendLayout();
            Typepanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(818, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFilems, saveAsms });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(69, 29);
            fileToolStripMenuItem.Text = "Файл";
            // 
            // openFilems
            // 
            openFilems.Name = "openFilems";
            openFilems.Size = new Size(244, 34);
            openFilems.Text = "Открыть...";
            openFilems.Click += openFilems_Click;
            // 
            // saveAsms
            // 
            saveAsms.Name = "saveAsms";
            saveAsms.Size = new Size(244, 34);
            saveAsms.Text = "Сохранить как...";
            saveAsms.Click += saveAsms_Click;
            // 
            // PltextBox
            // 
            PltextBox.BorderStyle = BorderStyle.FixedSingle;
            PltextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PltextBox.Location = new Point(40, 205);
            PltextBox.Multiline = true;
            PltextBox.Name = "PltextBox";
            PltextBox.Size = new Size(306, 157);
            PltextBox.TabIndex = 1;
            PltextBox.TextChanged += PltextBox_TextChanged;
            // 
            // KeytextBox
            // 
            KeytextBox.BorderStyle = BorderStyle.FixedSingle;
            KeytextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KeytextBox.Location = new Point(443, 205);
            KeytextBox.Multiline = true;
            KeytextBox.Name = "KeytextBox";
            KeytextBox.Size = new Size(306, 157);
            KeytextBox.TabIndex = 2;
            // 
            // plainTextLbl
            // 
            plainTextLbl.AutoSize = true;
            plainTextLbl.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            plainTextLbl.Location = new Point(40, 175);
            plainTextLbl.Name = "plainTextLbl";
            plainTextLbl.Size = new Size(181, 27);
            plainTextLbl.TabIndex = 3;
            plainTextLbl.Text = "Исходный текст:";
            // 
            // keyLbl
            // 
            keyLbl.AutoSize = true;
            keyLbl.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            keyLbl.Location = new Point(443, 175);
            keyLbl.Name = "keyLbl";
            keyLbl.Size = new Size(75, 27);
            keyLbl.TabIndex = 4;
            keyLbl.Text = "Ключ:";
            // 
            // RFradioButton
            // 
            RFradioButton.AutoSize = true;
            RFradioButton.Checked = true;
            RFradioButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RFradioButton.Location = new Point(0, 17);
            RFradioButton.Name = "RFradioButton";
            RFradioButton.Size = new Size(319, 31);
            RFradioButton.TabIndex = 5;
            RFradioButton.TabStop = true;
            RFradioButton.Text = "Железнодорожная изгородь";
            RFradioButton.UseVisualStyleBackColor = true;
            // 
            // VradioButton
            // 
            VradioButton.AutoSize = true;
            VradioButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            VradioButton.Location = new Point(403, 17);
            VradioButton.Name = "VradioButton";
            VradioButton.Size = new Size(370, 31);
            VradioButton.TabIndex = 6;
            VradioButton.Text = "Виженер (прогрессивный ключ)";
            VradioButton.UseVisualStyleBackColor = true;
            // 
            // EncoderadioButton
            // 
            EncoderadioButton.AutoSize = true;
            EncoderadioButton.Checked = true;
            EncoderadioButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            EncoderadioButton.Location = new Point(0, 10);
            EncoderadioButton.Name = "EncoderadioButton";
            EncoderadioButton.Size = new Size(173, 31);
            EncoderadioButton.TabIndex = 7;
            EncoderadioButton.TabStop = true;
            EncoderadioButton.Text = "Шифрование";
            EncoderadioButton.UseVisualStyleBackColor = true;
            // 
            // DecoderadioButton
            // 
            DecoderadioButton.AutoSize = true;
            DecoderadioButton.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DecoderadioButton.Location = new Point(403, 10);
            DecoderadioButton.Name = "DecoderadioButton";
            DecoderadioButton.Size = new Size(194, 31);
            DecoderadioButton.TabIndex = 8;
            DecoderadioButton.Text = "Дешифрование";
            DecoderadioButton.UseVisualStyleBackColor = true;
            DecoderadioButton.Click += DecoderadioButton_Click;
            // 
            // RestextBox
            // 
            RestextBox.BackColor = SystemColors.Menu;
            RestextBox.BorderStyle = BorderStyle.FixedSingle;
            RestextBox.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RestextBox.Location = new Point(188, 440);
            RestextBox.Multiline = true;
            RestextBox.Name = "RestextBox";
            RestextBox.ReadOnly = true;
            RestextBox.Size = new Size(425, 227);
            RestextBox.TabIndex = 9;
            // 
            // ResLbl
            // 
            ResLbl.AutoSize = true;
            ResLbl.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ResLbl.Location = new Point(189, 410);
            ResLbl.Name = "ResLbl";
            ResLbl.Size = new Size(114, 27);
            ResLbl.TabIndex = 10;
            ResLbl.Text = "Результат:";
            // 
            // Execbtn
            // 
            Execbtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Execbtn.Location = new Point(222, 709);
            Execbtn.Name = "Execbtn";
            Execbtn.Size = new Size(356, 63);
            Execbtn.TabIndex = 11;
            Execbtn.Text = "Выполнить";
            Execbtn.UseVisualStyleBackColor = true;
            Execbtn.Click += Execbtn_Click;
            // 
            // Methodpanel
            // 
            Methodpanel.Controls.Add(RFradioButton);
            Methodpanel.Controls.Add(VradioButton);
            Methodpanel.Location = new Point(40, 45);
            Methodpanel.Name = "Methodpanel";
            Methodpanel.Size = new Size(766, 60);
            Methodpanel.TabIndex = 12;
            // 
            // Typepanel
            // 
            Typepanel.Controls.Add(DecoderadioButton);
            Typepanel.Controls.Add(EncoderadioButton);
            Typepanel.Location = new Point(40, 111);
            Typepanel.Name = "Typepanel";
            Typepanel.Size = new Size(766, 51);
            Typepanel.TabIndex = 13;
            // 
            // clearPLbtn
            // 
            clearPLbtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearPLbtn.Location = new Point(40, 368);
            clearPLbtn.Name = "clearPLbtn";
            clearPLbtn.Size = new Size(129, 34);
            clearPLbtn.TabIndex = 14;
            clearPLbtn.Text = "Очистить";
            clearPLbtn.UseVisualStyleBackColor = true;
            clearPLbtn.Click += clearPLbtn_Click;
            // 
            // clearKbtn
            // 
            clearKbtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearKbtn.Location = new Point(443, 368);
            clearKbtn.Name = "clearKbtn";
            clearKbtn.Size = new Size(129, 34);
            clearKbtn.TabIndex = 15;
            clearKbtn.Text = "Очистить";
            clearKbtn.UseVisualStyleBackColor = true;
            clearKbtn.Click += clearKbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 804);
            Controls.Add(clearKbtn);
            Controls.Add(clearPLbtn);
            Controls.Add(Typepanel);
            Controls.Add(Methodpanel);
            Controls.Add(Execbtn);
            Controls.Add(ResLbl);
            Controls.Add(RestextBox);
            Controls.Add(keyLbl);
            Controls.Add(plainTextLbl);
            Controls.Add(KeytextBox);
            Controls.Add(PltextBox);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лаба 1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            Methodpanel.ResumeLayout(false);
            Methodpanel.PerformLayout();
            Typepanel.ResumeLayout(false);
            Typepanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private TextBox PltextBox;
        private TextBox KeytextBox;
        private Label plainTextLbl;
        private Label keyLbl;
        private RadioButton RFradioButton;
        private RadioButton VradioButton;
        private RadioButton EncoderadioButton;
        private RadioButton DecoderadioButton;
        private TextBox RestextBox;
        private Label ResLbl;
        private Button Execbtn;
        private Panel Methodpanel;
        private Panel Typepanel;
        private ToolStripMenuItem openFilems;
        private ToolStripMenuItem saveAsms;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private Button clearPLbtn;
        private Button clearKbtn;
    }
}
