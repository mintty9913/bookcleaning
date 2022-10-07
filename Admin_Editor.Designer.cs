namespace the_Project
{
  partial class Admin_Editor
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
      this.wallpaper = new System.Windows.Forms.PictureBox();
      this.userTable = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.email2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dormName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.zone = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.maidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.maidProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.paymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.labelMaidName = new System.Windows.Forms.Label();
      this.labelComment = new System.Windows.Forms.Label();
      this.labelHour = new System.Windows.Forms.Label();
      this.labelStatus = new System.Windows.Forms.Label();
      this.labelPrice = new System.Windows.Forms.Label();
      this.labelDateTime = new System.Windows.Forms.Label();
      this.maidPic = new System.Windows.Forms.PictureBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.newHour = new System.Windows.Forms.NumericUpDown();
      this.NewComment = new System.Windows.Forms.TextBox();
      this.tbxNewEdit = new System.Windows.Forms.TextBox();
      this.newTime = new System.Windows.Forms.DateTimePicker();
      this.newDate = new System.Windows.Forms.DateTimePicker();
      this.btnNoEdit = new System.Windows.Forms.Button();
      this.btnOkEdit = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnBack = new System.Windows.Forms.Button();
      this.panelFilter = new System.Windows.Forms.Panel();
      this.tbxSearch = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.cbxStatus = new System.Windows.Forms.ComboBox();
      this.label7 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.wallpaper)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.maidPic)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.newHour)).BeginInit();
      this.panelFilter.SuspendLayout();
      this.SuspendLayout();
      // 
      // wallpaper
      // 
      this.wallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
      this.wallpaper.Image = global::the_Project.Properties.Resources.wallpaper_Admin_Editor;
      this.wallpaper.Location = new System.Drawing.Point(0, 0);
      this.wallpaper.Name = "wallpaper";
      this.wallpaper.Size = new System.Drawing.Size(1487, 787);
      this.wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.wallpaper.TabIndex = 0;
      this.wallpaper.TabStop = false;
      // 
      // userTable
      // 
      this.userTable.AllowUserToAddRows = false;
      this.userTable.AllowUserToDeleteRows = false;
      this.userTable.AllowUserToResizeColumns = false;
      this.userTable.AllowUserToResizeRows = false;
      this.userTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
      this.userTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.userTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.userTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle41.BackColor = System.Drawing.Color.Teal;
      dataGridViewCellStyle41.Font = new System.Drawing.Font("TH Sarabun New", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      dataGridViewCellStyle41.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.Teal;
      dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.userTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
      this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fname,
            this.lname,
            this.phone,
            this.email2,
            this.email,
            this.address,
            this.dormName,
            this.zone,
            this.date,
            this.time,
            this.hour,
            this.price,
            this.comment,
            this.maidName,
            this.maidProfile,
            this.paymentStatus});
      this.userTable.EnableHeadersVisualStyles = false;
      this.userTable.Location = new System.Drawing.Point(213, 30);
      this.userTable.Name = "userTable";
      this.userTable.RowHeadersVisible = false;
      this.userTable.RowHeadersWidth = 62;
      this.userTable.RowTemplate.Height = 40;
      this.userTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.userTable.Size = new System.Drawing.Size(1050, 418);
      this.userTable.TabIndex = 3;
      this.userTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userTable_CellContentClick);
      // 
      // id
      // 
      this.id.DataPropertyName = "id";
      this.id.HeaderText = "id";
      this.id.MinimumWidth = 8;
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.id.Visible = false;
      this.id.Width = 150;
      // 
      // fname
      // 
      this.fname.DataPropertyName = "fname";
      dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle42.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Teal;
      dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
      dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.Teal;
      this.fname.DefaultCellStyle = dataGridViewCellStyle42;
      this.fname.HeaderText = "ชื่อ";
      this.fname.MinimumWidth = 8;
      this.fname.Name = "fname";
      this.fname.ReadOnly = true;
      this.fname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.fname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.fname.Width = 150;
      // 
      // lname
      // 
      this.lname.DataPropertyName = "lname";
      dataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle43.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle43.ForeColor = System.Drawing.Color.Teal;
      dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
      dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.Teal;
      this.lname.DefaultCellStyle = dataGridViewCellStyle43;
      this.lname.HeaderText = "นามสกุล";
      this.lname.MinimumWidth = 8;
      this.lname.Name = "lname";
      this.lname.ReadOnly = true;
      this.lname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.lname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.lname.Width = 150;
      // 
      // phone
      // 
      this.phone.DataPropertyName = "phone";
      dataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle44.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle44.ForeColor = System.Drawing.Color.Teal;
      dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
      dataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.Teal;
      this.phone.DefaultCellStyle = dataGridViewCellStyle44;
      this.phone.HeaderText = "เบอร์";
      this.phone.MinimumWidth = 8;
      this.phone.Name = "phone";
      this.phone.ReadOnly = true;
      this.phone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.phone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.phone.Width = 150;
      // 
      // email2
      // 
      this.email2.DataPropertyName = "email2";
      dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle45.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle45.ForeColor = System.Drawing.Color.Teal;
      dataGridViewCellStyle45.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
      dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.Teal;
      this.email2.DefaultCellStyle = dataGridViewCellStyle45;
      this.email2.HeaderText = "Email";
      this.email2.MinimumWidth = 8;
      this.email2.Name = "email2";
      this.email2.ReadOnly = true;
      this.email2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.email2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.email2.Width = 150;
      // 
      // email
      // 
      this.email.DataPropertyName = "email";
      this.email.HeaderText = "RealEmail";
      this.email.MinimumWidth = 8;
      this.email.Name = "email";
      this.email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.email.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.email.Visible = false;
      this.email.Width = 150;
      // 
      // address
      // 
      this.address.DataPropertyName = "address";
      dataGridViewCellStyle46.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle46.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle46.ForeColor = System.Drawing.Color.Teal;
      dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
      dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.Teal;
      this.address.DefaultCellStyle = dataGridViewCellStyle46;
      this.address.HeaderText = "ที่อยู่";
      this.address.MinimumWidth = 8;
      this.address.Name = "address";
      this.address.ReadOnly = true;
      this.address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.address.Width = 150;
      // 
      // dormName
      // 
      this.dormName.DataPropertyName = "dormName";
      dataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle47.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle47.ForeColor = System.Drawing.Color.Teal;
      dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
      dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.Teal;
      this.dormName.DefaultCellStyle = dataGridViewCellStyle47;
      this.dormName.HeaderText = "ชื่อหอพัก";
      this.dormName.MinimumWidth = 8;
      this.dormName.Name = "dormName";
      this.dormName.ReadOnly = true;
      this.dormName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.dormName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.dormName.Width = 150;
      // 
      // zone
      // 
      this.zone.DataPropertyName = "zone";
      dataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle48.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
      dataGridViewCellStyle48.ForeColor = System.Drawing.Color.Teal;
      dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
      dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.Teal;
      this.zone.DefaultCellStyle = dataGridViewCellStyle48;
      this.zone.HeaderText = "โซน";
      this.zone.MinimumWidth = 8;
      this.zone.Name = "zone";
      this.zone.ReadOnly = true;
      this.zone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.zone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.zone.Width = 150;
      // 
      // date
      // 
      this.date.DataPropertyName = "date";
      this.date.HeaderText = "วันเริ่มงาน";
      this.date.MinimumWidth = 8;
      this.date.Name = "date";
      this.date.ReadOnly = true;
      this.date.Visible = false;
      this.date.Width = 150;
      // 
      // time
      // 
      this.time.DataPropertyName = "time";
      this.time.HeaderText = "เวลางาน";
      this.time.MinimumWidth = 8;
      this.time.Name = "time";
      this.time.ReadOnly = true;
      this.time.Visible = false;
      this.time.Width = 150;
      // 
      // hour
      // 
      this.hour.DataPropertyName = "hour";
      this.hour.HeaderText = "จำนวนชม.";
      this.hour.MinimumWidth = 8;
      this.hour.Name = "hour";
      this.hour.ReadOnly = true;
      this.hour.Visible = false;
      this.hour.Width = 150;
      // 
      // price
      // 
      this.price.DataPropertyName = "price";
      this.price.HeaderText = "ราคา";
      this.price.MinimumWidth = 8;
      this.price.Name = "price";
      this.price.ReadOnly = true;
      this.price.Visible = false;
      this.price.Width = 150;
      // 
      // comment
      // 
      this.comment.DataPropertyName = "comment";
      this.comment.HeaderText = "หมายเหตุ";
      this.comment.MinimumWidth = 8;
      this.comment.Name = "comment";
      this.comment.ReadOnly = true;
      this.comment.Visible = false;
      this.comment.Width = 150;
      // 
      // maidName
      // 
      this.maidName.DataPropertyName = "maidName";
      this.maidName.HeaderText = "ชื่อแม่บ้าน";
      this.maidName.MinimumWidth = 8;
      this.maidName.Name = "maidName";
      this.maidName.ReadOnly = true;
      this.maidName.Visible = false;
      this.maidName.Width = 150;
      // 
      // maidProfile
      // 
      this.maidProfile.DataPropertyName = "maidProfile";
      this.maidProfile.HeaderText = "Image";
      this.maidProfile.MinimumWidth = 8;
      this.maidProfile.Name = "maidProfile";
      this.maidProfile.ReadOnly = true;
      this.maidProfile.Visible = false;
      this.maidProfile.Width = 150;
      // 
      // paymentStatus
      // 
      this.paymentStatus.DataPropertyName = "payment_status";
      this.paymentStatus.HeaderText = "สถานะการจ่าย";
      this.paymentStatus.MinimumWidth = 8;
      this.paymentStatus.Name = "paymentStatus";
      this.paymentStatus.ReadOnly = true;
      this.paymentStatus.Visible = false;
      this.paymentStatus.Width = 150;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.labelMaidName);
      this.panel1.Controls.Add(this.labelComment);
      this.panel1.Controls.Add(this.labelHour);
      this.panel1.Controls.Add(this.labelStatus);
      this.panel1.Controls.Add(this.labelPrice);
      this.panel1.Controls.Add(this.labelDateTime);
      this.panel1.Controls.Add(this.maidPic);
      this.panel1.Location = new System.Drawing.Point(213, 464);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(648, 311);
      this.panel1.TabIndex = 4;
      // 
      // labelMaidName
      // 
      this.labelMaidName.AutoSize = true;
      this.labelMaidName.Font = new System.Drawing.Font("TH Sarabun New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.labelMaidName.ForeColor = System.Drawing.Color.Teal;
      this.labelMaidName.Location = new System.Drawing.Point(217, 14);
      this.labelMaidName.Name = "labelMaidName";
      this.labelMaidName.Size = new System.Drawing.Size(73, 40);
      this.labelMaidName.TabIndex = 1;
      this.labelMaidName.Text = "Name";
      // 
      // labelComment
      // 
      this.labelComment.AutoEllipsis = true;
      this.labelComment.AutoSize = true;
      this.labelComment.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.labelComment.ForeColor = System.Drawing.Color.Teal;
      this.labelComment.Location = new System.Drawing.Point(217, 144);
      this.labelComment.MaximumSize = new System.Drawing.Size(430, 150);
      this.labelComment.Name = "labelComment";
      this.labelComment.Size = new System.Drawing.Size(99, 37);
      this.labelComment.TabIndex = 1;
      this.labelComment.Text = "หมายเหตุ";
      // 
      // labelHour
      // 
      this.labelHour.AutoSize = true;
      this.labelHour.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.labelHour.ForeColor = System.Drawing.Color.Teal;
      this.labelHour.Location = new System.Drawing.Point(217, 104);
      this.labelHour.Name = "labelHour";
      this.labelHour.Size = new System.Drawing.Size(114, 37);
      this.labelHour.TabIndex = 1;
      this.labelHour.Text = "จำนวน ชม.";
      // 
      // labelStatus
      // 
      this.labelStatus.AutoSize = true;
      this.labelStatus.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.labelStatus.ForeColor = System.Drawing.Color.Teal;
      this.labelStatus.Location = new System.Drawing.Point(19, 256);
      this.labelStatus.Name = "labelStatus";
      this.labelStatus.Size = new System.Drawing.Size(58, 30);
      this.labelStatus.TabIndex = 1;
      this.labelStatus.Text = "สถานะ";
      // 
      // labelPrice
      // 
      this.labelPrice.AutoSize = true;
      this.labelPrice.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.labelPrice.ForeColor = System.Drawing.Color.Teal;
      this.labelPrice.Location = new System.Drawing.Point(16, 213);
      this.labelPrice.Name = "labelPrice";
      this.labelPrice.Size = new System.Drawing.Size(60, 37);
      this.labelPrice.TabIndex = 1;
      this.labelPrice.Text = "ราคา";
      // 
      // labelDateTime
      // 
      this.labelDateTime.AutoSize = true;
      this.labelDateTime.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.labelDateTime.ForeColor = System.Drawing.Color.Teal;
      this.labelDateTime.Location = new System.Drawing.Point(217, 59);
      this.labelDateTime.Name = "labelDateTime";
      this.labelDateTime.Size = new System.Drawing.Size(151, 37);
      this.labelDateTime.TabIndex = 1;
      this.labelDateTime.Text = "วันและเวลางาน";
      // 
      // maidPic
      // 
      this.maidPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(223)))), ((int)(((byte)(229)))));
      this.maidPic.Location = new System.Drawing.Point(23, 21);
      this.maidPic.Name = "maidPic";
      this.maidPic.Size = new System.Drawing.Size(189, 185);
      this.maidPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.maidPic.TabIndex = 0;
      this.maidPic.TabStop = false;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.cbxStatus);
      this.panel2.Controls.Add(this.newHour);
      this.panel2.Controls.Add(this.NewComment);
      this.panel2.Controls.Add(this.tbxNewEdit);
      this.panel2.Controls.Add(this.newTime);
      this.panel2.Controls.Add(this.newDate);
      this.panel2.Controls.Add(this.btnNoEdit);
      this.panel2.Controls.Add(this.btnOkEdit);
      this.panel2.Controls.Add(this.label5);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Location = new System.Drawing.Point(880, 464);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(383, 311);
      this.panel2.TabIndex = 4;
      // 
      // newHour
      // 
      this.newHour.Location = new System.Drawing.Point(97, 264);
      this.newHour.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
      this.newHour.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.newHour.Name = "newHour";
      this.newHour.Size = new System.Drawing.Size(51, 26);
      this.newHour.TabIndex = 10;
      this.newHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // NewComment
      // 
      this.NewComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.NewComment.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
      this.NewComment.ForeColor = System.Drawing.Color.Teal;
      this.NewComment.Location = new System.Drawing.Point(41, 156);
      this.NewComment.Multiline = true;
      this.NewComment.Name = "NewComment";
      this.NewComment.Size = new System.Drawing.Size(307, 89);
      this.NewComment.TabIndex = 0;
      // 
      // tbxNewEdit
      // 
      this.tbxNewEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbxNewEdit.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
      this.tbxNewEdit.ForeColor = System.Drawing.Color.Teal;
      this.tbxNewEdit.Location = new System.Drawing.Point(41, 34);
      this.tbxNewEdit.Name = "tbxNewEdit";
      this.tbxNewEdit.Size = new System.Drawing.Size(209, 30);
      this.tbxNewEdit.TabIndex = 0;
      // 
      // newTime
      // 
      this.newTime.CalendarForeColor = System.Drawing.Color.Teal;
      this.newTime.CalendarTitleBackColor = System.Drawing.Color.MediumTurquoise;
      this.newTime.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
      this.newTime.CalendarTrailingForeColor = System.Drawing.Color.White;
      this.newTime.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.newTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.newTime.Location = new System.Drawing.Point(239, 91);
      this.newTime.Name = "newTime";
      this.newTime.Size = new System.Drawing.Size(109, 42);
      this.newTime.TabIndex = 9;
      this.newTime.Value = new System.DateTime(2022, 9, 27, 9, 0, 0, 0);
      // 
      // newDate
      // 
      this.newDate.CalendarForeColor = System.Drawing.Color.Teal;
      this.newDate.CalendarTitleBackColor = System.Drawing.Color.MediumTurquoise;
      this.newDate.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray;
      this.newDate.CalendarTrailingForeColor = System.Drawing.Color.White;
      this.newDate.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.newDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.newDate.Location = new System.Drawing.Point(41, 91);
      this.newDate.Name = "newDate";
      this.newDate.Size = new System.Drawing.Size(175, 42);
      this.newDate.TabIndex = 8;
      this.newDate.Value = new System.DateTime(2022, 9, 28, 21, 59, 0, 0);
      // 
      // btnNoEdit
      // 
      this.btnNoEdit.BackColor = System.Drawing.SystemColors.Control;
      this.btnNoEdit.FlatAppearance.BorderSize = 2;
      this.btnNoEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNoEdit.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
      this.btnNoEdit.ForeColor = System.Drawing.Color.Teal;
      this.btnNoEdit.Location = new System.Drawing.Point(193, 259);
      this.btnNoEdit.Name = "btnNoEdit";
      this.btnNoEdit.Size = new System.Drawing.Size(76, 33);
      this.btnNoEdit.TabIndex = 5;
      this.btnNoEdit.Text = "ยกเลิก";
      this.btnNoEdit.UseVisualStyleBackColor = false;
      // 
      // btnOkEdit
      // 
      this.btnOkEdit.BackColor = System.Drawing.Color.Teal;
      this.btnOkEdit.FlatAppearance.BorderSize = 0;
      this.btnOkEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnOkEdit.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
      this.btnOkEdit.ForeColor = System.Drawing.Color.White;
      this.btnOkEdit.Location = new System.Drawing.Point(272, 259);
      this.btnOkEdit.Name = "btnOkEdit";
      this.btnOkEdit.Size = new System.Drawing.Size(76, 33);
      this.btnOkEdit.TabIndex = 5;
      this.btnOkEdit.Text = "ตกลง";
      this.btnOkEdit.UseVisualStyleBackColor = false;
      this.btnOkEdit.Click += new System.EventHandler(this.btnOkEdit_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.label5.ForeColor = System.Drawing.Color.Teal;
      this.label5.Location = new System.Drawing.Point(150, 264);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(38, 30);
      this.label5.TabIndex = 1;
      this.label5.Text = "ชม.";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.label4.ForeColor = System.Drawing.Color.Teal;
      this.label4.Location = new System.Drawing.Point(36, 262);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(59, 30);
      this.label4.TabIndex = 1;
      this.label4.Text = "จำนวน";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.label3.ForeColor = System.Drawing.Color.Teal;
      this.label3.Location = new System.Drawing.Point(37, 131);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(74, 30);
      this.label3.TabIndex = 1;
      this.label3.Text = "หมายเหตุ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.label2.ForeColor = System.Drawing.Color.Teal;
      this.label2.Location = new System.Drawing.Point(36, 67);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(178, 30);
      this.label2.TabIndex = 1;
      this.label2.Text = "เลือกวันและเวลางานใหม่";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.label1.ForeColor = System.Drawing.Color.Teal;
      this.label1.Location = new System.Drawing.Point(37, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(80, 30);
      this.label1.TabIndex = 1;
      this.label1.Text = "ข้อมูลใหม่";
      // 
      // btnBack
      // 
      this.btnBack.BackColor = System.Drawing.Color.Teal;
      this.btnBack.FlatAppearance.BorderSize = 0;
      this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBack.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
      this.btnBack.ForeColor = System.Drawing.Color.White;
      this.btnBack.Location = new System.Drawing.Point(12, 12);
      this.btnBack.Name = "btnBack";
      this.btnBack.Size = new System.Drawing.Size(96, 40);
      this.btnBack.TabIndex = 5;
      this.btnBack.Text = "กลับ";
      this.btnBack.UseVisualStyleBackColor = false;
      this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
      // 
      // panelFilter
      // 
      this.panelFilter.Controls.Add(this.tbxSearch);
      this.panelFilter.Controls.Add(this.label6);
      this.panelFilter.Location = new System.Drawing.Point(1269, 29);
      this.panelFilter.Name = "panelFilter";
      this.panelFilter.Size = new System.Drawing.Size(206, 97);
      this.panelFilter.TabIndex = 6;
      // 
      // tbxSearch
      // 
      this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tbxSearch.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
      this.tbxSearch.ForeColor = System.Drawing.Color.Teal;
      this.tbxSearch.Location = new System.Drawing.Point(13, 46);
      this.tbxSearch.Name = "tbxSearch";
      this.tbxSearch.Size = new System.Drawing.Size(179, 30);
      this.tbxSearch.TabIndex = 0;
      this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.label6.ForeColor = System.Drawing.Color.Teal;
      this.label6.Location = new System.Drawing.Point(62, 9);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(91, 30);
      this.label6.TabIndex = 1;
      this.label6.Text = "ค้นหาข้อมูล";
      // 
      // cbxStatus
      // 
      this.cbxStatus.Font = new System.Drawing.Font("TH Sarabun New", 10F, System.Drawing.FontStyle.Bold);
      this.cbxStatus.ForeColor = System.Drawing.Color.Teal;
      this.cbxStatus.FormattingEnabled = true;
      this.cbxStatus.Items.AddRange(new object[] {
            "จ่ายแล้ว",
            "ยังไม่จ่าย"});
      this.cbxStatus.Location = new System.Drawing.Point(256, 34);
      this.cbxStatus.Name = "cbxStatus";
      this.cbxStatus.Size = new System.Drawing.Size(92, 35);
      this.cbxStatus.TabIndex = 11;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
      this.label7.ForeColor = System.Drawing.Color.Teal;
      this.label7.Location = new System.Drawing.Point(251, 8);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(58, 30);
      this.label7.TabIndex = 1;
      this.label7.Text = "สถานะ";
      // 
      // Admin_Editor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1487, 787);
      this.Controls.Add(this.panelFilter);
      this.Controls.Add(this.btnBack);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.userTable);
      this.Controls.Add(this.wallpaper);
      this.MaximumSize = new System.Drawing.Size(1509, 843);
      this.MinimumSize = new System.Drawing.Size(1509, 843);
      this.Name = "Admin_Editor";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Admin_Editor";
      this.Load += new System.EventHandler(this.Admin_Editor_Load);
      ((System.ComponentModel.ISupportInitialize)(this.wallpaper)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.maidPic)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.newHour)).EndInit();
      this.panelFilter.ResumeLayout(false);
      this.panelFilter.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox wallpaper;
    private System.Windows.Forms.DataGridView userTable;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn fname;
    private System.Windows.Forms.DataGridViewTextBoxColumn lname;
    private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    private System.Windows.Forms.DataGridViewTextBoxColumn email2;
    private System.Windows.Forms.DataGridViewTextBoxColumn email;
    private System.Windows.Forms.DataGridViewTextBoxColumn address;
    private System.Windows.Forms.DataGridViewTextBoxColumn dormName;
    private System.Windows.Forms.DataGridViewTextBoxColumn zone;
    private System.Windows.Forms.DataGridViewTextBoxColumn date;
    private System.Windows.Forms.DataGridViewTextBoxColumn time;
    private System.Windows.Forms.DataGridViewTextBoxColumn hour;
    private System.Windows.Forms.DataGridViewTextBoxColumn price;
    private System.Windows.Forms.DataGridViewTextBoxColumn comment;
    private System.Windows.Forms.DataGridViewTextBoxColumn maidName;
    private System.Windows.Forms.DataGridViewTextBoxColumn maidProfile;
    private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatus;
    private System.Windows.Forms.PictureBox maidPic;
    private System.Windows.Forms.Label labelMaidName;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label labelDateTime;
    private System.Windows.Forms.Label labelHour;
    private System.Windows.Forms.Label labelComment;
    private System.Windows.Forms.Label labelStatus;
    private System.Windows.Forms.Label labelPrice;
    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.Button btnOkEdit;
    private System.Windows.Forms.TextBox tbxNewEdit;
    private System.Windows.Forms.DateTimePicker newDate;
    private System.Windows.Forms.TextBox NewComment;
    private System.Windows.Forms.DateTimePicker newTime;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown newHour;
    private System.Windows.Forms.Button btnNoEdit;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panelFilter;
    private System.Windows.Forms.TextBox tbxSearch;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ComboBox cbxStatus;
    private System.Windows.Forms.Label label7;
  }
}