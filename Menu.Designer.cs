namespace the_Project
{
  partial class Menu
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
            this.labelMenu1 = new System.Windows.Forms.Label();
            this.labelMenu2 = new System.Windows.Forms.Label();
            this.btnBack2Main = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.btnMenu1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAdminMenu2 = new System.Windows.Forms.PictureBox();
            this.btnAdminMenu1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAdminMenu1 = new System.Windows.Forms.Label();
            this.labelAdminMenu2 = new System.Windows.Forms.Label();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdminMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdminMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMenu1
            // 
            this.labelMenu1.AutoSize = true;
            this.labelMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.labelMenu1.Font = new System.Drawing.Font("TH Sarabun New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMenu1.ForeColor = System.Drawing.Color.Teal;
            this.labelMenu1.Location = new System.Drawing.Point(74, 130);
            this.labelMenu1.Name = "labelMenu1";
            this.labelMenu1.Size = new System.Drawing.Size(180, 48);
            this.labelMenu1.TabIndex = 2;
            this.labelMenu1.Text = " จองคิวแม่บ้าน ";
            // 
            // labelMenu2
            // 
            this.labelMenu2.AutoSize = true;
            this.labelMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.labelMenu2.Font = new System.Drawing.Font("TH Sarabun New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMenu2.ForeColor = System.Drawing.Color.Teal;
            this.labelMenu2.Location = new System.Drawing.Point(322, 130);
            this.labelMenu2.Name = "labelMenu2";
            this.labelMenu2.Size = new System.Drawing.Size(239, 48);
            this.labelMenu2.TabIndex = 2;
            this.labelMenu2.Text = " ตาราง/แก้ไขการจอง ";
            // 
            // btnBack2Main
            // 
            this.btnBack2Main.AutoSize = true;
            this.btnBack2Main.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnBack2Main.ForeColor = System.Drawing.Color.Teal;
            this.btnBack2Main.Location = new System.Drawing.Point(11, 409);
            this.btnBack2Main.Name = "btnBack2Main";
            this.btnBack2Main.Size = new System.Drawing.Size(50, 41);
            this.btnBack2Main.TabIndex = 3;
            this.btnBack2Main.Text = "t";
            this.btnBack2Main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack2Main.Click += new System.EventHandler(this.btnBack2Main_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelUser.ForeColor = System.Drawing.Color.Teal;
            this.labelUser.Location = new System.Drawing.Point(72, 410);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(122, 37);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "username : ";
            // 
            // btnHistory
            // 
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnHistory.ForeColor = System.Drawing.Color.Teal;
            this.btnHistory.Location = new System.Drawing.Point(798, 409);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(103, 34);
            this.btnHistory.TabIndex = 5;
            this.btnHistory.Text = "ประวัติ";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.panelUser.Controls.Add(this.btnMenu1);
            this.panelUser.Controls.Add(this.pictureBox2);
            this.panelUser.Controls.Add(this.labelMenu2);
            this.panelUser.Controls.Add(this.labelMenu1);
            this.panelUser.Location = new System.Drawing.Point(150, 113);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(595, 173);
            this.panelUser.TabIndex = 6;
            this.panelUser.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUser_Paint);
            // 
            // btnMenu1
            // 
            this.btnMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.btnMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu1.Image = global::the_Project.Properties.Resources.maid_icon;
            this.btnMenu1.Location = new System.Drawing.Point(96, 10);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Size = new System.Drawing.Size(138, 126);
            this.btnMenu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu1.TabIndex = 1;
            this.btnMenu1.TabStop = false;
            this.btnMenu1.Click += new System.EventHandler(this.btnMenu1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::the_Project.Properties.Resources.list;
            this.pictureBox2.Location = new System.Drawing.Point(371, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 126);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnAdminMenu2
            // 
            this.btnAdminMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.btnAdminMenu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminMenu2.Image = global::the_Project.Properties.Resources.maid;
            this.btnAdminMenu2.Location = new System.Drawing.Point(371, 10);
            this.btnAdminMenu2.Name = "btnAdminMenu2";
            this.btnAdminMenu2.Size = new System.Drawing.Size(138, 126);
            this.btnAdminMenu2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdminMenu2.TabIndex = 0;
            this.btnAdminMenu2.TabStop = false;
            this.btnAdminMenu2.Click += new System.EventHandler(this.btnAdminMenu2_Click);
            // 
            // btnAdminMenu1
            // 
            this.btnAdminMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.btnAdminMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminMenu1.Image = global::the_Project.Properties.Resources.Edit_User;
            this.btnAdminMenu1.Location = new System.Drawing.Point(96, 10);
            this.btnAdminMenu1.Name = "btnAdminMenu1";
            this.btnAdminMenu1.Size = new System.Drawing.Size(138, 126);
            this.btnAdminMenu1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdminMenu1.TabIndex = 0;
            this.btnAdminMenu1.TabStop = false;
            this.btnAdminMenu1.Click += new System.EventHandler(this.btnAdminMenu1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::the_Project.Properties.Resources.wallpaper_menu;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(924, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelAdminMenu1
            // 
            this.labelAdminMenu1.AutoSize = true;
            this.labelAdminMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.labelAdminMenu1.Font = new System.Drawing.Font("TH Sarabun New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelAdminMenu1.ForeColor = System.Drawing.Color.Teal;
            this.labelAdminMenu1.Location = new System.Drawing.Point(50, 134);
            this.labelAdminMenu1.Name = "labelAdminMenu1";
            this.labelAdminMenu1.Size = new System.Drawing.Size(233, 43);
            this.labelAdminMenu1.TabIndex = 2;
            this.labelAdminMenu1.Text = "จัดการข้อมูลผู้ใช้บริการ";
            // 
            // labelAdminMenu2
            // 
            this.labelAdminMenu2.AutoSize = true;
            this.labelAdminMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.labelAdminMenu2.Font = new System.Drawing.Font("TH Sarabun New", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelAdminMenu2.ForeColor = System.Drawing.Color.Teal;
            this.labelAdminMenu2.Location = new System.Drawing.Point(322, 134);
            this.labelAdminMenu2.Name = "labelAdminMenu2";
            this.labelAdminMenu2.Size = new System.Drawing.Size(235, 43);
            this.labelAdminMenu2.TabIndex = 2;
            this.labelAdminMenu2.Text = "เพิ่ม/แก้ไขข้อมูลแม่บ้าน";
            // 
            // panelAdmin
            // 
            this.panelAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(218)))), ((int)(((byte)(229)))));
            this.panelAdmin.Controls.Add(this.btnAdminMenu2);
            this.panelAdmin.Controls.Add(this.btnAdminMenu1);
            this.panelAdmin.Controls.Add(this.labelAdminMenu2);
            this.panelAdmin.Controls.Add(this.labelAdminMenu1);
            this.panelAdmin.Location = new System.Drawing.Point(150, 113);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(595, 173);
            this.panelAdmin.TabIndex = 3;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 454);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.panelAdmin);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.btnBack2Main);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(946, 510);
            this.MinimumSize = new System.Drawing.Size(946, 510);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdminMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdminMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox btnMenu1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.Label labelMenu1;
    private System.Windows.Forms.Label labelMenu2;
    private System.Windows.Forms.Label btnBack2Main;
    private System.Windows.Forms.Label labelUser;
    private System.Windows.Forms.Button btnHistory;
    private System.Windows.Forms.Panel panelUser;
    private System.Windows.Forms.PictureBox btnAdminMenu1;
    private System.Windows.Forms.PictureBox btnAdminMenu2;
    private System.Windows.Forms.Label labelAdminMenu1;
    private System.Windows.Forms.Label labelAdminMenu2;
    private System.Windows.Forms.Panel panelAdmin;
  }
}