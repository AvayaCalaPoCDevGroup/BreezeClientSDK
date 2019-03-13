namespace BreezeClientSDK
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.login_btn = new MetroFramework.Controls.MetroButton();
            this.remember_chk = new MetroFramework.Controls.MetroCheckBox();
            this.pass_txt = new MetroFramework.Controls.MetroTextBox();
            this.user_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.save_btn = new MetroFramework.Controls.MetroButton();
            this.tls_chk = new MetroFramework.Controls.MetroCheckBox();
            this.puerto_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.domain_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.sip_txt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(248, 282);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.login_btn);
            this.metroTabPage1.Controls.Add(this.remember_chk);
            this.metroTabPage1.Controls.Add(this.pass_txt);
            this.metroTabPage1.Controls.Add(this.user_txt);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(240, 240);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Credenciales";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(0, 195);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(237, 42);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Iniciar Sesión";
            this.login_btn.UseSelectable = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // remember_chk
            // 
            this.remember_chk.AutoSize = true;
            this.remember_chk.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.remember_chk.Location = new System.Drawing.Point(4, 137);
            this.remember_chk.Name = "remember_chk";
            this.remember_chk.Size = new System.Drawing.Size(215, 19);
            this.remember_chk.TabIndex = 6;
            this.remember_chk.Text = "Recordar Usuario y Contraseña";
            this.remember_chk.UseSelectable = true;
            // 
            // pass_txt
            // 
            // 
            // 
            // 
            this.pass_txt.CustomButton.Image = null;
            this.pass_txt.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.pass_txt.CustomButton.Name = "";
            this.pass_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pass_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pass_txt.CustomButton.TabIndex = 1;
            this.pass_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pass_txt.CustomButton.UseSelectable = true;
            this.pass_txt.CustomButton.Visible = false;
            this.pass_txt.Lines = new string[0];
            this.pass_txt.Location = new System.Drawing.Point(4, 94);
            this.pass_txt.MaxLength = 32767;
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pass_txt.SelectedText = "";
            this.pass_txt.SelectionLength = 0;
            this.pass_txt.SelectionStart = 0;
            this.pass_txt.ShortcutsEnabled = true;
            this.pass_txt.Size = new System.Drawing.Size(233, 23);
            this.pass_txt.TabIndex = 5;
            this.pass_txt.UseSelectable = true;
            this.pass_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pass_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // user_txt
            // 
            // 
            // 
            // 
            this.user_txt.CustomButton.Image = null;
            this.user_txt.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.user_txt.CustomButton.Name = "";
            this.user_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.user_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.user_txt.CustomButton.TabIndex = 1;
            this.user_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.user_txt.CustomButton.UseSelectable = true;
            this.user_txt.CustomButton.Visible = false;
            this.user_txt.Lines = new string[0];
            this.user_txt.Location = new System.Drawing.Point(4, 38);
            this.user_txt.MaxLength = 32767;
            this.user_txt.Name = "user_txt";
            this.user_txt.PasswordChar = '\0';
            this.user_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.user_txt.SelectedText = "";
            this.user_txt.SelectionLength = 0;
            this.user_txt.SelectionStart = 0;
            this.user_txt.ShortcutsEnabled = true;
            this.user_txt.Size = new System.Drawing.Size(233, 23);
            this.user_txt.TabIndex = 4;
            this.user_txt.UseSelectable = true;
            this.user_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.user_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 72);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Contraseña:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Usuario / Extension";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.save_btn);
            this.metroTabPage2.Controls.Add(this.tls_chk);
            this.metroTabPage2.Controls.Add(this.puerto_txt);
            this.metroTabPage2.Controls.Add(this.metroLabel7);
            this.metroTabPage2.Controls.Add(this.domain_txt);
            this.metroTabPage2.Controls.Add(this.metroLabel6);
            this.metroTabPage2.Controls.Add(this.sip_txt);
            this.metroTabPage2.Controls.Add(this.metroLabel5);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(240, 240);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Ajustes";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(0, 196);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(237, 41);
            this.save_btn.TabIndex = 9;
            this.save_btn.Text = "Guardar ajustes";
            this.save_btn.UseSelectable = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // tls_chk
            // 
            this.tls_chk.AutoSize = true;
            this.tls_chk.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.tls_chk.Location = new System.Drawing.Point(175, 154);
            this.tls_chk.Name = "tls_chk";
            this.tls_chk.Size = new System.Drawing.Size(58, 19);
            this.tls_chk.TabIndex = 8;
            this.tls_chk.Text = "¿TLS?";
            this.tls_chk.UseSelectable = true;
            // 
            // puerto_txt
            // 
            // 
            // 
            // 
            this.puerto_txt.CustomButton.Image = null;
            this.puerto_txt.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.puerto_txt.CustomButton.Name = "";
            this.puerto_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.puerto_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.puerto_txt.CustomButton.TabIndex = 1;
            this.puerto_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.puerto_txt.CustomButton.UseSelectable = true;
            this.puerto_txt.CustomButton.Visible = false;
            this.puerto_txt.Lines = new string[0];
            this.puerto_txt.Location = new System.Drawing.Point(4, 154);
            this.puerto_txt.MaxLength = 32767;
            this.puerto_txt.Name = "puerto_txt";
            this.puerto_txt.PasswordChar = '\0';
            this.puerto_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.puerto_txt.SelectedText = "";
            this.puerto_txt.SelectionLength = 0;
            this.puerto_txt.SelectionStart = 0;
            this.puerto_txt.ShortcutsEnabled = true;
            this.puerto_txt.Size = new System.Drawing.Size(93, 23);
            this.puerto_txt.TabIndex = 7;
            this.puerto_txt.UseSelectable = true;
            this.puerto_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.puerto_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(0, 132);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(52, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Puerto:";
            // 
            // domain_txt
            // 
            // 
            // 
            // 
            this.domain_txt.CustomButton.Image = null;
            this.domain_txt.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.domain_txt.CustomButton.Name = "";
            this.domain_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.domain_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.domain_txt.CustomButton.TabIndex = 1;
            this.domain_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.domain_txt.CustomButton.UseSelectable = true;
            this.domain_txt.CustomButton.Visible = false;
            this.domain_txt.Lines = new string[0];
            this.domain_txt.Location = new System.Drawing.Point(4, 94);
            this.domain_txt.MaxLength = 32767;
            this.domain_txt.Name = "domain_txt";
            this.domain_txt.PasswordChar = '\0';
            this.domain_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.domain_txt.SelectedText = "";
            this.domain_txt.SelectionLength = 0;
            this.domain_txt.SelectionStart = 0;
            this.domain_txt.ShortcutsEnabled = true;
            this.domain_txt.Size = new System.Drawing.Size(233, 23);
            this.domain_txt.TabIndex = 5;
            this.domain_txt.UseSelectable = true;
            this.domain_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.domain_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(0, 72);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 19);
            this.metroLabel6.TabIndex = 4;
            this.metroLabel6.Text = "Dominio";
            // 
            // sip_txt
            // 
            // 
            // 
            // 
            this.sip_txt.CustomButton.Image = null;
            this.sip_txt.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.sip_txt.CustomButton.Name = "";
            this.sip_txt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.sip_txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sip_txt.CustomButton.TabIndex = 1;
            this.sip_txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sip_txt.CustomButton.UseSelectable = true;
            this.sip_txt.CustomButton.Visible = false;
            this.sip_txt.Lines = new string[0];
            this.sip_txt.Location = new System.Drawing.Point(4, 36);
            this.sip_txt.MaxLength = 32767;
            this.sip_txt.Name = "sip_txt";
            this.sip_txt.PasswordChar = '\0';
            this.sip_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sip_txt.SelectedText = "";
            this.sip_txt.SelectionLength = 0;
            this.sip_txt.SelectionStart = 0;
            this.sip_txt.ShortcutsEnabled = true;
            this.sip_txt.Size = new System.Drawing.Size(233, 23);
            this.sip_txt.TabIndex = 3;
            this.sip_txt.UseSelectable = true;
            this.sip_txt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sip_txt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 14);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(106, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Controlador SIP:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(126, 360);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(54, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Versión:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(186, 360);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Placeholder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 380);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton login_btn;
        private MetroFramework.Controls.MetroCheckBox remember_chk;
        private MetroFramework.Controls.MetroTextBox pass_txt;
        private MetroFramework.Controls.MetroTextBox user_txt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton save_btn;
        private MetroFramework.Controls.MetroCheckBox tls_chk;
        private MetroFramework.Controls.MetroTextBox puerto_txt;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox domain_txt;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox sip_txt;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}

