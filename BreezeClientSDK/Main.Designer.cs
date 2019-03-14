namespace BreezeClientSDK
{
    partial class Main
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.actioncombobox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.subject_in_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.subject_out_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.hang_btn = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.call_btn = new MetroFramework.Controls.MetroButton();
            this.number_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton10 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton11 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton12 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton7 = new MetroFramework.Controls.MetroButton();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroButton8 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage7 = new MetroFramework.Controls.MetroTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabPage7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.Controls.Add(this.metroTabPage5);
            this.metroTabControl1.Controls.Add(this.metroTabPage6);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage7);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1211, 634);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.groupBox5);
            this.metroTabPage1.Controls.Add(this.groupBox2);
            this.metroTabPage1.Controls.Add(this.groupBox1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1203, 592);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Llamadas";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.actioncombobox);
            this.groupBox5.Controls.Add(this.metroLabel2);
            this.groupBox5.Controls.Add(this.subject_in_txt);
            this.groupBox5.Controls.Add(this.metroLabel1);
            this.groupBox5.Location = new System.Drawing.Point(580, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(166, 161);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Estado Actual";
            // 
            // actioncombobox
            // 
            this.actioncombobox.FormattingEnabled = true;
            this.actioncombobox.ItemHeight = 23;
            this.actioncombobox.Items.AddRange(new object[] {
            "Google Maps",
            "Notepad",
            "Navegador",
            ""});
            this.actioncombobox.Location = new System.Drawing.Point(7, 119);
            this.actioncombobox.Name = "actioncombobox";
            this.actioncombobox.Size = new System.Drawing.Size(150, 29);
            this.actioncombobox.TabIndex = 3;
            this.actioncombobox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 94);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Acción:";
            // 
            // subject_in_txt
            // 
            // 
            // 
            // 
            this.subject_in_txt.CustomButton.Image = null;
            this.subject_in_txt.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.subject_in_txt.CustomButton.Name = "";
            this.subject_in_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.subject_in_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subject_in_txt.CustomButton.TabIndex = 1;
            this.subject_in_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subject_in_txt.CustomButton.UseSelectable = true;
            this.subject_in_txt.CustomButton.Visible = false;
            this.subject_in_txt.Enabled = false;
            this.subject_in_txt.Lines = new string[0];
            this.subject_in_txt.Location = new System.Drawing.Point(6, 42);
            this.subject_in_txt.MaxLength = 32767;
            this.subject_in_txt.Name = "subject_in_txt";
            this.subject_in_txt.PasswordChar = '\0';
            this.subject_in_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subject_in_txt.SelectedText = "";
            this.subject_in_txt.SelectionLength = 0;
            this.subject_in_txt.SelectionStart = 0;
            this.subject_in_txt.ShortcutsEnabled = true;
            this.subject_in_txt.Size = new System.Drawing.Size(151, 23);
            this.subject_in_txt.TabIndex = 1;
            this.subject_in_txt.UseSelectable = true;
            this.subject_in_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subject_in_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 16);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Asunto:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(196, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 232);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.subject_out_txt);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.hang_btn);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.call_btn);
            this.groupBox1.Controls.Add(this.number_txt);
            this.groupBox1.Controls.Add(this.metroButton3);
            this.groupBox1.Controls.Add(this.metroButton10);
            this.groupBox1.Controls.Add(this.metroButton6);
            this.groupBox1.Controls.Add(this.metroButton11);
            this.groupBox1.Controls.Add(this.metroButton5);
            this.groupBox1.Controls.Add(this.metroButton12);
            this.groupBox1.Controls.Add(this.metroButton4);
            this.groupBox1.Controls.Add(this.metroButton7);
            this.groupBox1.Controls.Add(this.metroButton9);
            this.groupBox1.Controls.Add(this.metroButton8);
            this.groupBox1.Location = new System.Drawing.Point(3, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 379);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pad";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 68);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(52, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Digitos:";
            // 
            // subject_out_txt
            // 
            // 
            // 
            // 
            this.subject_out_txt.CustomButton.Image = null;
            this.subject_out_txt.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.subject_out_txt.CustomButton.Name = "";
            this.subject_out_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.subject_out_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subject_out_txt.CustomButton.TabIndex = 1;
            this.subject_out_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subject_out_txt.CustomButton.UseSelectable = true;
            this.subject_out_txt.CustomButton.Visible = false;
            this.subject_out_txt.Lines = new string[0];
            this.subject_out_txt.Location = new System.Drawing.Point(10, 42);
            this.subject_out_txt.MaxLength = 32767;
            this.subject_out_txt.Name = "subject_out_txt";
            this.subject_out_txt.PasswordChar = '\0';
            this.subject_out_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subject_out_txt.SelectedText = "";
            this.subject_out_txt.SelectionLength = 0;
            this.subject_out_txt.SelectionStart = 0;
            this.subject_out_txt.ShortcutsEnabled = true;
            this.subject_out_txt.Size = new System.Drawing.Size(171, 23);
            this.subject_out_txt.TabIndex = 19;
            this.subject_out_txt.UseSelectable = true;
            this.subject_out_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subject_out_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 16);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Asunto:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(10, 127);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(53, 42);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "1";
            this.metroButton1.UseSelectable = true;
            // 
            // hang_btn
            // 
            this.hang_btn.Enabled = false;
            this.hang_btn.Location = new System.Drawing.Point(102, 317);
            this.hang_btn.Name = "hang_btn";
            this.hang_btn.Size = new System.Drawing.Size(79, 56);
            this.hang_btn.TabIndex = 17;
            this.hang_btn.Text = "Colgar";
            this.hang_btn.UseSelectable = true;
            this.hang_btn.Click += new System.EventHandler(this.hang_btn_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(69, 127);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(53, 42);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "2";
            this.metroButton2.UseSelectable = true;
            // 
            // call_btn
            // 
            this.call_btn.Enabled = false;
            this.call_btn.Location = new System.Drawing.Point(10, 317);
            this.call_btn.Name = "call_btn";
            this.call_btn.Size = new System.Drawing.Size(79, 56);
            this.call_btn.TabIndex = 16;
            this.call_btn.Text = "Llamar";
            this.call_btn.UseSelectable = true;
            this.call_btn.Click += new System.EventHandler(this.call_btn_Click);
            // 
            // number_txt
            // 
            // 
            // 
            // 
            this.number_txt.CustomButton.Image = null;
            this.number_txt.CustomButton.Location = new System.Drawing.Point(143, 2);
            this.number_txt.CustomButton.Name = "";
            this.number_txt.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.number_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.number_txt.CustomButton.TabIndex = 1;
            this.number_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.number_txt.CustomButton.UseSelectable = true;
            this.number_txt.CustomButton.Visible = false;
            this.number_txt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.number_txt.Lines = new string[0];
            this.number_txt.Location = new System.Drawing.Point(10, 91);
            this.number_txt.MaxLength = 32767;
            this.number_txt.Name = "number_txt";
            this.number_txt.PasswordChar = '\0';
            this.number_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.number_txt.SelectedText = "";
            this.number_txt.SelectionLength = 0;
            this.number_txt.SelectionStart = 0;
            this.number_txt.ShortcutsEnabled = true;
            this.number_txt.Size = new System.Drawing.Size(171, 30);
            this.number_txt.TabIndex = 2;
            this.number_txt.UseSelectable = true;
            this.number_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.number_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(128, 127);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(53, 42);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "3";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton10
            // 
            this.metroButton10.Location = new System.Drawing.Point(128, 271);
            this.metroButton10.Name = "metroButton10";
            this.metroButton10.Size = new System.Drawing.Size(53, 42);
            this.metroButton10.TabIndex = 15;
            this.metroButton10.Text = "#";
            this.metroButton10.UseSelectable = true;
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(10, 175);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(53, 42);
            this.metroButton6.TabIndex = 7;
            this.metroButton6.Text = "4";
            this.metroButton6.UseSelectable = true;
            // 
            // metroButton11
            // 
            this.metroButton11.Location = new System.Drawing.Point(69, 271);
            this.metroButton11.Name = "metroButton11";
            this.metroButton11.Size = new System.Drawing.Size(53, 42);
            this.metroButton11.TabIndex = 14;
            this.metroButton11.Text = "0";
            this.metroButton11.UseSelectable = true;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(69, 175);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(53, 42);
            this.metroButton5.TabIndex = 8;
            this.metroButton5.Text = "5";
            this.metroButton5.UseSelectable = true;
            // 
            // metroButton12
            // 
            this.metroButton12.Location = new System.Drawing.Point(10, 271);
            this.metroButton12.Name = "metroButton12";
            this.metroButton12.Size = new System.Drawing.Size(53, 42);
            this.metroButton12.TabIndex = 13;
            this.metroButton12.Text = "*";
            this.metroButton12.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(128, 175);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(53, 42);
            this.metroButton4.TabIndex = 9;
            this.metroButton4.Text = "6";
            this.metroButton4.UseSelectable = true;
            // 
            // metroButton7
            // 
            this.metroButton7.Location = new System.Drawing.Point(128, 223);
            this.metroButton7.Name = "metroButton7";
            this.metroButton7.Size = new System.Drawing.Size(53, 42);
            this.metroButton7.TabIndex = 12;
            this.metroButton7.Text = "9";
            this.metroButton7.UseSelectable = true;
            // 
            // metroButton9
            // 
            this.metroButton9.Location = new System.Drawing.Point(10, 223);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(53, 42);
            this.metroButton9.TabIndex = 10;
            this.metroButton9.Text = "7";
            this.metroButton9.UseSelectable = true;
            // 
            // metroButton8
            // 
            this.metroButton8.Location = new System.Drawing.Point(69, 223);
            this.metroButton8.Name = "metroButton8";
            this.metroButton8.Size = new System.Drawing.Size(53, 42);
            this.metroButton8.TabIndex = 11;
            this.metroButton8.Text = "8";
            this.metroButton8.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(746, 392);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Contactos";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(746, 392);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Mensajeria";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.HorizontalScrollbarSize = 10;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(746, 392);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "Presencia";
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage5.VerticalScrollbarSize = 10;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 10;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(746, 392);
            this.metroTabPage6.TabIndex = 5;
            this.metroTabPage6.Text = "metroTabPage6";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(746, 392);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Historial";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage7
            // 
            this.metroTabPage7.Controls.Add(this.groupBox3);
            this.metroTabPage7.HorizontalScrollbarBarColor = true;
            this.metroTabPage7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.HorizontalScrollbarSize = 10;
            this.metroTabPage7.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage7.Name = "metroTabPage7";
            this.metroTabPage7.Size = new System.Drawing.Size(746, 392);
            this.metroTabPage7.TabIndex = 6;
            this.metroTabPage7.Text = "metroTabPage7";
            this.metroTabPage7.VerticalScrollbarBarColor = true;
            this.metroTabPage7.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage7.VerticalScrollbarSize = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(3, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 334);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(618, 309);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.metroTabPage7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroTabPage metroTabPage7;
        private MetroFramework.Controls.MetroTextBox number_txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton hang_btn;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton call_btn;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton10;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroButton metroButton11;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton12;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton7;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroButton metroButton8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroComboBox actioncombobox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox subject_in_txt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox subject_out_txt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}