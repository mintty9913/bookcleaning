namespace the_Project
{
  partial class Maid_status
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.maid_info = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maidProfile = new System.Windows.Forms.PictureBox();
            this.btnBack2Menu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.btnBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMaidStatus = new System.Windows.Forms.Label();
            this.labelBookingHour = new System.Windows.Forms.Label();
            this.labelBookingPhone = new System.Windows.Forms.Label();
            this.labelBookingEmail = new System.Windows.Forms.Label();
            this.labelBookingName = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMaidName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.rbtn_unavailable = new System.Windows.Forms.RadioButton();
            this.rbtn_booking = new System.Windows.Forms.RadioButton();
            this.rbtn_available = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.maid_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maidProfile)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // maid_info
            // 
            this.maid_info.AllowUserToAddRows = false;
            this.maid_info.AllowUserToDeleteRows = false;
            this.maid_info.AllowUserToResizeColumns = false;
            this.maid_info.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            this.maid_info.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.maid_info.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.maid_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maid_info.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.maid_info.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maid_info.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.maid_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maid_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fname,
            this.lname,
            this.status,
            this.phone,
            this.email,
            this.image});
            this.maid_info.EnableHeadersVisualStyles = false;
            this.maid_info.Location = new System.Drawing.Point(19, 26);
            this.maid_info.Name = "maid_info";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maid_info.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.maid_info.RowHeadersVisible = false;
            this.maid_info.RowHeadersWidth = 62;
            this.maid_info.RowTemplate.Height = 40;
            this.maid_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.maid_info.Size = new System.Drawing.Size(761, 290);
            this.maid_info.TabIndex = 0;
            this.maid_info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maid_info_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 40;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Teal;
            this.fname.DefaultCellStyle = dataGridViewCellStyle4;
            this.fname.HeaderText = "First Name";
            this.fname.MinimumWidth = 8;
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.fname.Width = 150;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "lname";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Teal;
            this.lname.DefaultCellStyle = dataGridViewCellStyle5;
            this.lname.HeaderText = "Last Name";
            this.lname.MinimumWidth = 8;
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lname.Width = 150;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Teal;
            this.status.DefaultCellStyle = dataGridViewCellStyle6;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.status.Width = 80;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Teal;
            this.phone.DefaultCellStyle = dataGridViewCellStyle7;
            this.phone.HeaderText = "Phone Number";
            this.phone.MinimumWidth = 8;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phone.Width = 130;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Teal;
            this.email.DefaultCellStyle = dataGridViewCellStyle8;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "IMAGE";
            this.image.MinimumWidth = 8;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.image.Visible = false;
            this.image.Width = 150;
            // 
            // maidProfile
            // 
            this.maidProfile.BackColor = System.Drawing.Color.White;
            this.maidProfile.Image = global::the_Project.Properties.Resources.maid_icon;
            this.maidProfile.Location = new System.Drawing.Point(807, 132);
            this.maidProfile.Name = "maidProfile";
            this.maidProfile.Size = new System.Drawing.Size(201, 171);
            this.maidProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maidProfile.TabIndex = 1;
            this.maidProfile.TabStop = false;
            this.maidProfile.Click += new System.EventHandler(this.maidProfile_Click);
            // 
            // btnBack2Menu
            // 
            this.btnBack2Menu.BackColor = System.Drawing.Color.Teal;
            this.btnBack2Menu.FlatAppearance.BorderSize = 0;
            this.btnBack2Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack2Menu.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBack2Menu.ForeColor = System.Drawing.Color.White;
            this.btnBack2Menu.Location = new System.Drawing.Point(19, 449);
            this.btnBack2Menu.Name = "btnBack2Menu";
            this.btnBack2Menu.Size = new System.Drawing.Size(111, 38);
            this.btnBack2Menu.TabIndex = 2;
            this.btnBack2Menu.Text = "BACK";
            this.btnBack2Menu.UseVisualStyleBackColor = false;
            this.btnBack2Menu.Click += new System.EventHandler(this.btnBack2Menu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(750, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 302);
            this.panel1.TabIndex = 3;
            // 
            // panelDetail
            // 
            this.panelDetail.BackColor = System.Drawing.Color.Teal;
            this.panelDetail.Controls.Add(this.btnBook);
            this.panelDetail.Controls.Add(this.label1);
            this.panelDetail.Controls.Add(this.labelMaidStatus);
            this.panelDetail.Controls.Add(this.labelBookingHour);
            this.panelDetail.Controls.Add(this.labelBookingPhone);
            this.panelDetail.Controls.Add(this.labelBookingEmail);
            this.panelDetail.Controls.Add(this.labelBookingName);
            this.panelDetail.Controls.Add(this.labelStatus);
            this.panelDetail.Controls.Add(this.labelName);
            this.panelDetail.Controls.Add(this.labelMaidName);
            this.panelDetail.Controls.Add(this.pictureBox1);
            this.panelDetail.Location = new System.Drawing.Point(198, 321);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(552, 184);
            this.panelDetail.TabIndex = 4;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.White;
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBook.ForeColor = System.Drawing.Color.Teal;
            this.btnBook.Location = new System.Drawing.Point(407, 134);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(133, 38);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "ทำการจอง";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Visible = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(419, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "ทำการจอง";
            // 
            // labelMaidStatus
            // 
            this.labelMaidStatus.AutoSize = true;
            this.labelMaidStatus.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMaidStatus.ForeColor = System.Drawing.Color.White;
            this.labelMaidStatus.Location = new System.Drawing.Point(96, 40);
            this.labelMaidStatus.Name = "labelMaidStatus";
            this.labelMaidStatus.Size = new System.Drawing.Size(21, 34);
            this.labelMaidStatus.TabIndex = 0;
            this.labelMaidStatus.Text = "-";
            // 
            // labelBookingHour
            // 
            this.labelBookingHour.AutoSize = true;
            this.labelBookingHour.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelBookingHour.ForeColor = System.Drawing.Color.White;
            this.labelBookingHour.Location = new System.Drawing.Point(17, 152);
            this.labelBookingHour.Name = "labelBookingHour";
            this.labelBookingHour.Size = new System.Drawing.Size(108, 30);
            this.labelBookingHour.TabIndex = 0;
            this.labelBookingHour.Text = "จำนวน : - ชม.";
            // 
            // labelBookingPhone
            // 
            this.labelBookingPhone.AutoSize = true;
            this.labelBookingPhone.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelBookingPhone.ForeColor = System.Drawing.Color.White;
            this.labelBookingPhone.Location = new System.Drawing.Point(16, 126);
            this.labelBookingPhone.Name = "labelBookingPhone";
            this.labelBookingPhone.Size = new System.Drawing.Size(104, 30);
            this.labelBookingPhone.TabIndex = 0;
            this.labelBookingPhone.Text = "เบอร์ผู้จอง : -";
            // 
            // labelBookingEmail
            // 
            this.labelBookingEmail.AutoSize = true;
            this.labelBookingEmail.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelBookingEmail.ForeColor = System.Drawing.Color.White;
            this.labelBookingEmail.Location = new System.Drawing.Point(18, 99);
            this.labelBookingEmail.Name = "labelBookingEmail";
            this.labelBookingEmail.Size = new System.Drawing.Size(105, 30);
            this.labelBookingEmail.TabIndex = 0;
            this.labelBookingEmail.Text = "อีเมลผู้จอง : -";
            // 
            // labelBookingName
            // 
            this.labelBookingName.AutoSize = true;
            this.labelBookingName.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelBookingName.ForeColor = System.Drawing.Color.White;
            this.labelBookingName.Location = new System.Drawing.Point(18, 71);
            this.labelBookingName.Name = "labelBookingName";
            this.labelBookingName.Size = new System.Drawing.Size(91, 30);
            this.labelBookingName.TabIndex = 0;
            this.labelBookingName.Text = "ชื่อผู้จอง : -";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(17, 39);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(84, 37);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(20, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(80, 37);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name :";
            // 
            // labelMaidName
            // 
            this.labelMaidName.AutoSize = true;
            this.labelMaidName.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMaidName.ForeColor = System.Drawing.Color.White;
            this.labelMaidName.Location = new System.Drawing.Point(95, 12);
            this.labelMaidName.Name = "labelMaidName";
            this.labelMaidName.Size = new System.Drawing.Size(23, 37);
            this.labelMaidName.TabIndex = 0;
            this.labelMaidName.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::the_Project.Properties.Resources.verified;
            this.pictureBox1.Location = new System.Drawing.Point(353, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Location = new System.Drawing.Point(766, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(14, 459);
            this.panel2.TabIndex = 5;
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSearch.Font = new System.Drawing.Font("TH Sarabun New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxSearch.ForeColor = System.Drawing.Color.SkyBlue;
            this.tbxSearch.Location = new System.Drawing.Point(807, 26);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(201, 27);
            this.tbxSearch.TabIndex = 6;
            this.tbxSearch.Text = "  Search";
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.Enter += new System.EventHandler(this.tbxSearch_Enter);
            this.tbxSearch.Leave += new System.EventHandler(this.tbxSearch_Leave);
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panelFilter.Controls.Add(this.rbtn_unavailable);
            this.panelFilter.Controls.Add(this.rbtn_booking);
            this.panelFilter.Controls.Add(this.rbtn_available);
            this.panelFilter.Controls.Add(this.rbtnAll);
            this.panelFilter.Location = new System.Drawing.Point(789, 56);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(239, 67);
            this.panelFilter.TabIndex = 7;
            // 
            // rbtn_unavailable
            // 
            this.rbtn_unavailable.AutoSize = true;
            this.rbtn_unavailable.Font = new System.Drawing.Font("TH Sarabun New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rbtn_unavailable.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbtn_unavailable.Location = new System.Drawing.Point(164, 6);
            this.rbtn_unavailable.Name = "rbtn_unavailable";
            this.rbtn_unavailable.Size = new System.Drawing.Size(75, 31);
            this.rbtn_unavailable.TabIndex = 0;
            this.rbtn_unavailable.Text = "ไม่ว่าง";
            this.rbtn_unavailable.UseVisualStyleBackColor = true;
            this.rbtn_unavailable.CheckedChanged += new System.EventHandler(this.rbtn_unavailable_CheckedChanged);
            // 
            // rbtn_booking
            // 
            this.rbtn_booking.AutoSize = true;
            this.rbtn_booking.Font = new System.Drawing.Font("TH Sarabun New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rbtn_booking.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbtn_booking.Location = new System.Drawing.Point(15, 36);
            this.rbtn_booking.Name = "rbtn_booking";
            this.rbtn_booking.Size = new System.Drawing.Size(169, 31);
            this.rbtn_booking.TabIndex = 0;
            this.rbtn_booking.Text = "อยู่ในระหว่างการจอง";
            this.rbtn_booking.UseVisualStyleBackColor = true;
            this.rbtn_booking.CheckedChanged += new System.EventHandler(this.rbtn_booking_CheckedChanged);
            // 
            // rbtn_available
            // 
            this.rbtn_available.AutoSize = true;
            this.rbtn_available.Font = new System.Drawing.Font("TH Sarabun New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rbtn_available.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbtn_available.Location = new System.Drawing.Point(95, 6);
            this.rbtn_available.Name = "rbtn_available";
            this.rbtn_available.Size = new System.Drawing.Size(59, 31);
            this.rbtn_available.TabIndex = 0;
            this.rbtn_available.Text = "ว่าง";
            this.rbtn_available.UseVisualStyleBackColor = true;
            this.rbtn_available.CheckedChanged += new System.EventHandler(this.rbtn_available_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Font = new System.Drawing.Font("TH Sarabun New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rbtnAll.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.rbtnAll.Location = new System.Drawing.Point(15, 6);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(82, 31);
            this.rbtnAll.TabIndex = 0;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "ทั้งหมด";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Location = new System.Drawing.Point(807, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 16);
            this.panel3.TabIndex = 5;
            // 
            // Maid_status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::the_Project.Properties.Resources.wallpaper_maid_info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 516);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack2Menu);
            this.Controls.Add(this.maidProfile);
            this.Controls.Add(this.maid_info);
            this.MaximumSize = new System.Drawing.Size(1062, 572);
            this.MinimumSize = new System.Drawing.Size(1062, 572);
            this.Name = "Maid_status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maid_status";
            this.Load += new System.EventHandler(this.Maid_status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maid_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maidProfile)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView maid_info;
    private System.Windows.Forms.PictureBox maidProfile;
    private System.Windows.Forms.Button btnBack2Menu;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panelDetail;
    private System.Windows.Forms.Label labelMaidStatus;
    private System.Windows.Forms.Label labelStatus;
    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.Label labelMaidName;
    private System.Windows.Forms.Button btnBook;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox tbxSearch;
    private System.Windows.Forms.Panel panelFilter;
    private System.Windows.Forms.RadioButton rbtn_unavailable;
    private System.Windows.Forms.RadioButton rbtn_available;
    private System.Windows.Forms.RadioButton rbtnAll;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn fname;
    private System.Windows.Forms.DataGridViewTextBoxColumn lname;
    private System.Windows.Forms.DataGridViewTextBoxColumn status;
    private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    private System.Windows.Forms.DataGridViewTextBoxColumn email;
    private System.Windows.Forms.DataGridViewTextBoxColumn image;
    private System.Windows.Forms.RadioButton rbtn_booking;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label labelBookingName;
    private System.Windows.Forms.Label labelBookingEmail;
    private System.Windows.Forms.Label labelBookingPhone;
    private System.Windows.Forms.Label labelBookingHour;
  }
}