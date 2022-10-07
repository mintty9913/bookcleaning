namespace the_Project
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
            this.wallpaper_main = new System.Windows.Forms.PictureBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.btnCancelReg = new System.Windows.Forms.Button();
            this.labelConfirmPwReg = new System.Windows.Forms.Label();
            this.labelPwReg = new System.Windows.Forms.Label();
            this.btnOkReg = new System.Windows.Forms.Button();
            this.labelUsernameReg = new System.Windows.Forms.Label();
            this.labelEmailReg = new System.Windows.Forms.Label();
            this.tbxCfmPwReg = new System.Windows.Forms.TextBox();
            this.tbxPwReg = new System.Windows.Forms.TextBox();
            this.tbxUsernameReg = new System.Windows.Forms.TextBox();
            this.tbxEmailReg = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.labelPw = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxPw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wallpaper_main)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // wallpaper_main
            // 
            this.wallpaper_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wallpaper_main.Image = global::the_Project.Properties.Resources.wallpaper_main;
            this.wallpaper_main.Location = new System.Drawing.Point(0, 0);
            this.wallpaper_main.Name = "wallpaper_main";
            this.wallpaper_main.Size = new System.Drawing.Size(924, 454);
            this.wallpaper_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wallpaper_main.TabIndex = 0;
            this.wallpaper_main.TabStop = false;
            this.wallpaper_main.Click += new System.EventHandler(this.wallpaper_main_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEmail.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbxEmail.Location = new System.Drawing.Point(126, 56);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(333, 35);
            this.tbxEmail.TabIndex = 0;
            this.tbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.White;
            this.labelEmail.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelEmail.ForeColor = System.Drawing.Color.Teal;
            this.labelEmail.Location = new System.Drawing.Point(237, 24);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(108, 32);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "อีเมลของคุณ";
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.Controls.Add(this.panelRegister);
            this.panelLogin.Controls.Add(this.btnRegister);
            this.panelLogin.Controls.Add(this.labelPw);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.labelEmail);
            this.panelLogin.Controls.Add(this.tbxPw);
            this.panelLogin.Controls.Add(this.tbxEmail);
            this.panelLogin.Location = new System.Drawing.Point(175, 91);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(581, 363);
            this.panelLogin.TabIndex = 0;
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelRegister.Controls.Add(this.btnCancelReg);
            this.panelRegister.Controls.Add(this.labelConfirmPwReg);
            this.panelRegister.Controls.Add(this.labelPwReg);
            this.panelRegister.Controls.Add(this.btnOkReg);
            this.panelRegister.Controls.Add(this.labelUsernameReg);
            this.panelRegister.Controls.Add(this.labelEmailReg);
            this.panelRegister.Controls.Add(this.tbxCfmPwReg);
            this.panelRegister.Controls.Add(this.tbxPwReg);
            this.panelRegister.Controls.Add(this.tbxUsernameReg);
            this.panelRegister.Controls.Add(this.tbxEmailReg);
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(581, 363);
            this.panelRegister.TabIndex = 4;
            this.panelRegister.Visible = false;
            // 
            // btnCancelReg
            // 
            this.btnCancelReg.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnCancelReg.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelReg.FlatAppearance.BorderSize = 3;
            this.btnCancelReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelReg.Font = new System.Drawing.Font("TH Sarabun New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReg.ForeColor = System.Drawing.Color.White;
            this.btnCancelReg.Location = new System.Drawing.Point(304, 248);
            this.btnCancelReg.Name = "btnCancelReg";
            this.btnCancelReg.Size = new System.Drawing.Size(211, 50);
            this.btnCancelReg.TabIndex = 5;
            this.btnCancelReg.Text = "ยกเลิก";
            this.btnCancelReg.UseVisualStyleBackColor = false;
            this.btnCancelReg.Click += new System.EventHandler(this.btnCancelReg_Click);
            // 
            // labelConfirmPwReg
            // 
            this.labelConfirmPwReg.AutoSize = true;
            this.labelConfirmPwReg.BackColor = System.Drawing.Color.MediumTurquoise;
            this.labelConfirmPwReg.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelConfirmPwReg.ForeColor = System.Drawing.Color.White;
            this.labelConfirmPwReg.Location = new System.Drawing.Point(205, 162);
            this.labelConfirmPwReg.Name = "labelConfirmPwReg";
            this.labelConfirmPwReg.Size = new System.Drawing.Size(172, 32);
            this.labelConfirmPwReg.TabIndex = 2;
            this.labelConfirmPwReg.Text = "ยืนยันรหัสผ่านของคุณ";
            // 
            // labelPwReg
            // 
            this.labelPwReg.AutoSize = true;
            this.labelPwReg.BackColor = System.Drawing.Color.MediumTurquoise;
            this.labelPwReg.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelPwReg.ForeColor = System.Drawing.Color.White;
            this.labelPwReg.Location = new System.Drawing.Point(198, 94);
            this.labelPwReg.Name = "labelPwReg";
            this.labelPwReg.Size = new System.Drawing.Size(203, 32);
            this.labelPwReg.TabIndex = 3;
            this.labelPwReg.Text = "รหัสผ่านของคุณ 8 - 20 ตัว";
            // 
            // btnOkReg
            // 
            this.btnOkReg.BackColor = System.Drawing.Color.Azure;
            this.btnOkReg.FlatAppearance.BorderSize = 0;
            this.btnOkReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkReg.Font = new System.Drawing.Font("TH Sarabun New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkReg.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnOkReg.Location = new System.Drawing.Point(73, 248);
            this.btnOkReg.Name = "btnOkReg";
            this.btnOkReg.Size = new System.Drawing.Size(211, 50);
            this.btnOkReg.TabIndex = 4;
            this.btnOkReg.Text = "สมัครใช้งาน";
            this.btnOkReg.UseVisualStyleBackColor = false;
            this.btnOkReg.Click += new System.EventHandler(this.btnOkReg_Click);
            // 
            // labelUsernameReg
            // 
            this.labelUsernameReg.AutoSize = true;
            this.labelUsernameReg.BackColor = System.Drawing.Color.MediumTurquoise;
            this.labelUsernameReg.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelUsernameReg.ForeColor = System.Drawing.Color.White;
            this.labelUsernameReg.Location = new System.Drawing.Point(100, 23);
            this.labelUsernameReg.Name = "labelUsernameReg";
            this.labelUsernameReg.Size = new System.Drawing.Size(136, 32);
            this.labelUsernameReg.TabIndex = 2;
            this.labelUsernameReg.Text = "ชื่อผู้ใช้ 5 - 20 ตัว";
            // 
            // labelEmailReg
            // 
            this.labelEmailReg.AutoSize = true;
            this.labelEmailReg.BackColor = System.Drawing.Color.MediumTurquoise;
            this.labelEmailReg.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelEmailReg.ForeColor = System.Drawing.Color.White;
            this.labelEmailReg.Location = new System.Drawing.Point(330, 24);
            this.labelEmailReg.Name = "labelEmailReg";
            this.labelEmailReg.Size = new System.Drawing.Size(205, 32);
            this.labelEmailReg.TabIndex = 2;
            this.labelEmailReg.Text = "อีเมลของคุณ @gmail.com";
            // 
            // tbxCfmPwReg
            // 
            this.tbxCfmPwReg.BackColor = System.Drawing.Color.Azure;
            this.tbxCfmPwReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCfmPwReg.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxCfmPwReg.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbxCfmPwReg.Location = new System.Drawing.Point(126, 191);
            this.tbxCfmPwReg.Name = "tbxCfmPwReg";
            this.tbxCfmPwReg.Size = new System.Drawing.Size(333, 35);
            this.tbxCfmPwReg.TabIndex = 3;
            this.tbxCfmPwReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPwReg
            // 
            this.tbxPwReg.BackColor = System.Drawing.Color.Azure;
            this.tbxPwReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPwReg.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxPwReg.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbxPwReg.Location = new System.Drawing.Point(126, 124);
            this.tbxPwReg.Name = "tbxPwReg";
            this.tbxPwReg.Size = new System.Drawing.Size(333, 35);
            this.tbxPwReg.TabIndex = 2;
            this.tbxPwReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUsernameReg
            // 
            this.tbxUsernameReg.BackColor = System.Drawing.Color.Azure;
            this.tbxUsernameReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUsernameReg.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxUsernameReg.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbxUsernameReg.Location = new System.Drawing.Point(36, 55);
            this.tbxUsernameReg.Name = "tbxUsernameReg";
            this.tbxUsernameReg.Size = new System.Drawing.Size(248, 35);
            this.tbxUsernameReg.TabIndex = 0;
            this.tbxUsernameReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxEmailReg
            // 
            this.tbxEmailReg.BackColor = System.Drawing.Color.Azure;
            this.tbxEmailReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEmailReg.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxEmailReg.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbxEmailReg.Location = new System.Drawing.Point(304, 55);
            this.tbxEmailReg.Name = "tbxEmailReg";
            this.tbxEmailReg.Size = new System.Drawing.Size(244, 35);
            this.tbxEmailReg.TabIndex = 1;
            this.tbxEmailReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Azure;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnRegister.FlatAppearance.BorderSize = 3;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("TH Sarabun New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnRegister.Location = new System.Drawing.Point(304, 248);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(211, 50);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "สมัครใช้งาน";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // labelPw
            // 
            this.labelPw.AutoSize = true;
            this.labelPw.BackColor = System.Drawing.Color.White;
            this.labelPw.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelPw.ForeColor = System.Drawing.Color.Teal;
            this.labelPw.Location = new System.Drawing.Point(225, 115);
            this.labelPw.Name = "labelPw";
            this.labelPw.Size = new System.Drawing.Size(130, 32);
            this.labelPw.TabIndex = 2;
            this.labelPw.Text = "รหัสผ่านของคุณ";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("TH Sarabun New", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Azure;
            this.btnLogin.Location = new System.Drawing.Point(73, 248);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(211, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "ล็อกอิน";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPw
            // 
            this.tbxPw.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tbxPw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPw.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxPw.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbxPw.Location = new System.Drawing.Point(126, 147);
            this.tbxPw.Name = "tbxPw";
            this.tbxPw.Size = new System.Drawing.Size(333, 35);
            this.tbxPw.TabIndex = 1;
            this.tbxPw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(12, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(12, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Admin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnTest.Location = new System.Drawing.Point(12, 415);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(57, 28);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 454);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.wallpaper_main);
            this.MaximumSize = new System.Drawing.Size(946, 510);
            this.MinimumSize = new System.Drawing.Size(946, 510);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wallpaper_main)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

  }

  #endregion

  private System.Windows.Forms.PictureBox wallpaper_main;
  private System.Windows.Forms.TextBox tbxEmail;
  private System.Windows.Forms.Label labelEmail;
  private System.Windows.Forms.Panel panelLogin;
  private System.Windows.Forms.Button btnRegister;
  private System.Windows.Forms.Label labelPw;
  private System.Windows.Forms.Button btnLogin;
  private System.Windows.Forms.TextBox tbxPw;
    private System.Windows.Forms.Panel panelRegister;
    private System.Windows.Forms.Button btnCancelReg;
    private System.Windows.Forms.Label labelConfirmPwReg;
    private System.Windows.Forms.Label labelPwReg;
    private System.Windows.Forms.Button btnOkReg;
    private System.Windows.Forms.Label labelEmailReg;
    private System.Windows.Forms.TextBox tbxCfmPwReg;
    private System.Windows.Forms.TextBox tbxPwReg;
    private System.Windows.Forms.TextBox tbxEmailReg;
    private System.Windows.Forms.Label labelUsernameReg;
    private System.Windows.Forms.TextBox tbxUsernameReg;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnTest;
  }
}

