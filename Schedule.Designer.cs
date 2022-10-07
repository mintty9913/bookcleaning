namespace the_Project
{
  partial class Schedule
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.bookingData = new System.Windows.Forms.DataGridView();
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
            this.labelMaidName = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelPaymentStatus = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.maidPic = new System.Windows.Forms.PictureBox();
            this.panelComment = new System.Windows.Forms.Panel();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelNewDateTime = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.newHour = new System.Windows.Forms.NumericUpDown();
            this.newTime = new System.Windows.Forms.DateTimePicker();
            this.newDate = new System.Windows.Forms.DateTimePicker();
            this.tbxNewComment = new System.Windows.Forms.TextBox();
            this.tbxEdit = new System.Windows.Forms.TextBox();
            this.BtnCancelEdit = new System.Windows.Forms.Button();
            this.btnOkEdit = new System.Windows.Forms.Button();
            this.labelH = new System.Windows.Forms.Label();
            this.labelNewHour = new System.Windows.Forms.Label();
            this.panelPay = new System.Windows.Forms.Panel();
            this.picReceipt = new System.Windows.Forms.PictureBox();
            this.btnCancelSent = new System.Windows.Forms.Button();
            this.btnSentReceipt = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPathReceipt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelCancel = new System.Windows.Forms.Panel();
            this.btnNoCancel = new System.Windows.Forms.Button();
            this.btnYesCancel = new System.Windows.Forms.Button();
            this.labelTitleBtnCancel = new System.Windows.Forms.Label();
            this.wallpaper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookingData)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maidPic)).BeginInit();
            this.panelComment.SuspendLayout();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newHour)).BeginInit();
            this.panelPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(14, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 33);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "กลับ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // bookingData
            // 
            this.bookingData.AllowUserToAddRows = false;
            this.bookingData.AllowUserToDeleteRows = false;
            this.bookingData.AllowUserToResizeColumns = false;
            this.bookingData.AllowUserToResizeRows = false;
            this.bookingData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.bookingData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookingData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bookingData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("TH Sarabun New", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bookingData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.bookingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.bookingData.EnableHeadersVisualStyles = false;
            this.bookingData.Location = new System.Drawing.Point(414, 19);
            this.bookingData.Name = "bookingData";
            this.bookingData.RowHeadersVisible = false;
            this.bookingData.RowHeadersWidth = 62;
            this.bookingData.RowTemplate.Height = 40;
            this.bookingData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingData.Size = new System.Drawing.Size(1050, 376);
            this.bookingData.TabIndex = 2;
            this.bookingData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingData_CellContentClick);
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
            // labelMaidName
            // 
            this.labelMaidName.AutoSize = true;
            this.labelMaidName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMaidName.Font = new System.Drawing.Font("TH Sarabun New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMaidName.ForeColor = System.Drawing.Color.Teal;
            this.labelMaidName.Location = new System.Drawing.Point(185, 7);
            this.labelMaidName.Name = "labelMaidName";
            this.labelMaidName.Size = new System.Drawing.Size(85, 48);
            this.labelMaidName.TabIndex = 4;
            this.labelMaidName.Text = "name";
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.labelDateTime);
            this.panelDetail.Controls.Add(this.labelPaymentStatus);
            this.panelDetail.Controls.Add(this.labelPrice);
            this.panelDetail.Controls.Add(this.labelMaidName);
            this.panelDetail.Controls.Add(this.maidPic);
            this.panelDetail.Controls.Add(this.panelComment);
            this.panelDetail.Controls.Add(this.labelHour);
            this.panelDetail.Location = new System.Drawing.Point(411, 416);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(594, 267);
            this.panelDetail.TabIndex = 5;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDateTime.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelDateTime.ForeColor = System.Drawing.Color.Teal;
            this.labelDateTime.Location = new System.Drawing.Point(186, 50);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(151, 37);
            this.labelDateTime.TabIndex = 4;
            this.labelDateTime.Text = "วันและเวลางาน";
            // 
            // labelPaymentStatus
            // 
            this.labelPaymentStatus.AutoSize = true;
            this.labelPaymentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPaymentStatus.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelPaymentStatus.ForeColor = System.Drawing.Color.Teal;
            this.labelPaymentStatus.Location = new System.Drawing.Point(12, 207);
            this.labelPaymentStatus.Name = "labelPaymentStatus";
            this.labelPaymentStatus.Size = new System.Drawing.Size(63, 32);
            this.labelPaymentStatus.TabIndex = 4;
            this.labelPaymentStatus.Text = "สถานะ";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrice.Font = new System.Drawing.Font("TH Sarabun New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelPrice.ForeColor = System.Drawing.Color.Teal;
            this.labelPrice.Location = new System.Drawing.Point(11, 168);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(62, 40);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "ราคา";
            // 
            // maidPic
            // 
            this.maidPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.maidPic.Location = new System.Drawing.Point(18, 20);
            this.maidPic.Name = "maidPic";
            this.maidPic.Size = new System.Drawing.Size(160, 132);
            this.maidPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maidPic.TabIndex = 3;
            this.maidPic.TabStop = false;
            // 
            // panelComment
            // 
            this.panelComment.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelComment.Controls.Add(this.labelComment);
            this.panelComment.Location = new System.Drawing.Point(187, 125);
            this.panelComment.Name = "panelComment";
            this.panelComment.Size = new System.Drawing.Size(387, 126);
            this.panelComment.TabIndex = 5;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelComment.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelComment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelComment.Location = new System.Drawing.Point(-1, 0);
            this.labelComment.MaximumSize = new System.Drawing.Size(390, 0);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(89, 34);
            this.labelComment.TabIndex = 4;
            this.labelComment.Text = "หมายเหตุ";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHour.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelHour.ForeColor = System.Drawing.Color.Teal;
            this.labelHour.Location = new System.Drawing.Point(187, 83);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(121, 37);
            this.labelHour.TabIndex = 4;
            this.labelHour.Text = "จำนวน - ชม";
            // 
            // labelNewDateTime
            // 
            this.labelNewDateTime.AutoSize = true;
            this.labelNewDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNewDateTime.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelNewDateTime.ForeColor = System.Drawing.Color.Teal;
            this.labelNewDateTime.Location = new System.Drawing.Point(259, 64);
            this.labelNewDateTime.Name = "labelNewDateTime";
            this.labelNewDateTime.Size = new System.Drawing.Size(130, 32);
            this.labelNewDateTime.TabIndex = 4;
            this.labelNewDateTime.Text = "New Date Time";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Azure;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancel.ForeColor = System.Drawing.Color.Teal;
            this.btnCancel.Location = new System.Drawing.Point(1325, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 43);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "ยกเลิกจอง";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Teal;
            this.btnPay.Enabled = false;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(1178, 416);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(128, 46);
            this.btnPay.TabIndex = 6;
            this.btnPay.Text = "จ่ายเงิน";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(1029, 416);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 46);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "แก้ไขข้อมูล";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.Controls.Add(this.newHour);
            this.panelEdit.Controls.Add(this.newTime);
            this.panelEdit.Controls.Add(this.newDate);
            this.panelEdit.Controls.Add(this.tbxNewComment);
            this.panelEdit.Controls.Add(this.tbxEdit);
            this.panelEdit.Controls.Add(this.BtnCancelEdit);
            this.panelEdit.Controls.Add(this.btnOkEdit);
            this.panelEdit.Controls.Add(this.labelH);
            this.panelEdit.Controls.Add(this.labelNewHour);
            this.panelEdit.Controls.Add(this.labelNewDateTime);
            this.panelEdit.Location = new System.Drawing.Point(1029, 472);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(424, 212);
            this.panelEdit.TabIndex = 7;
            this.panelEdit.Visible = false;
            // 
            // newHour
            // 
            this.newHour.Location = new System.Drawing.Point(94, 68);
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
            this.newHour.Size = new System.Drawing.Size(60, 26);
            this.newHour.TabIndex = 9;
            this.newHour.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // newTime
            // 
            this.newTime.CustomFormat = "";
            this.newTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.newTime.Location = new System.Drawing.Point(296, 126);
            this.newTime.Name = "newTime";
            this.newTime.Size = new System.Drawing.Size(101, 26);
            this.newTime.TabIndex = 8;
            // 
            // newDate
            // 
            this.newDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.newDate.Location = new System.Drawing.Point(265, 89);
            this.newDate.Name = "newDate";
            this.newDate.Size = new System.Drawing.Size(132, 26);
            this.newDate.TabIndex = 8;
            // 
            // tbxNewComment
            // 
            this.tbxNewComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxNewComment.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxNewComment.ForeColor = System.Drawing.Color.Teal;
            this.tbxNewComment.Location = new System.Drawing.Point(30, 99);
            this.tbxNewComment.Multiline = true;
            this.tbxNewComment.Name = "tbxNewComment";
            this.tbxNewComment.Size = new System.Drawing.Size(207, 96);
            this.tbxNewComment.TabIndex = 7;
            // 
            // tbxEdit
            // 
            this.tbxEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEdit.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxEdit.ForeColor = System.Drawing.Color.Teal;
            this.tbxEdit.Location = new System.Drawing.Point(30, 20);
            this.tbxEdit.Multiline = true;
            this.tbxEdit.Name = "tbxEdit";
            this.tbxEdit.Size = new System.Drawing.Size(367, 33);
            this.tbxEdit.TabIndex = 7;
            // 
            // BtnCancelEdit
            // 
            this.BtnCancelEdit.BackColor = System.Drawing.Color.White;
            this.BtnCancelEdit.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BtnCancelEdit.FlatAppearance.BorderSize = 2;
            this.BtnCancelEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelEdit.Font = new System.Drawing.Font("TH Sarabun New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BtnCancelEdit.ForeColor = System.Drawing.Color.Teal;
            this.BtnCancelEdit.Location = new System.Drawing.Point(247, 166);
            this.BtnCancelEdit.Name = "BtnCancelEdit";
            this.BtnCancelEdit.Size = new System.Drawing.Size(71, 30);
            this.BtnCancelEdit.TabIndex = 6;
            this.BtnCancelEdit.Text = "ยกเลิก";
            this.BtnCancelEdit.UseVisualStyleBackColor = false;
            this.BtnCancelEdit.Click += new System.EventHandler(this.BtnCancelEdit_Click);
            // 
            // btnOkEdit
            // 
            this.btnOkEdit.BackColor = System.Drawing.Color.Teal;
            this.btnOkEdit.FlatAppearance.BorderSize = 0;
            this.btnOkEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkEdit.Font = new System.Drawing.Font("TH Sarabun New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnOkEdit.ForeColor = System.Drawing.Color.White;
            this.btnOkEdit.Location = new System.Drawing.Point(326, 166);
            this.btnOkEdit.Name = "btnOkEdit";
            this.btnOkEdit.Size = new System.Drawing.Size(71, 30);
            this.btnOkEdit.TabIndex = 6;
            this.btnOkEdit.Text = "ตกลง";
            this.btnOkEdit.UseVisualStyleBackColor = false;
            this.btnOkEdit.Click += new System.EventHandler(this.btnOkEdit_Click);
            // 
            // labelH
            // 
            this.labelH.AutoSize = true;
            this.labelH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelH.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelH.ForeColor = System.Drawing.Color.Teal;
            this.labelH.Location = new System.Drawing.Point(161, 65);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(39, 32);
            this.labelH.TabIndex = 4;
            this.labelH.Text = "ชม.";
            // 
            // labelNewHour
            // 
            this.labelNewHour.AutoSize = true;
            this.labelNewHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNewHour.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelNewHour.ForeColor = System.Drawing.Color.Teal;
            this.labelNewHour.Location = new System.Drawing.Point(24, 65);
            this.labelNewHour.Name = "labelNewHour";
            this.labelNewHour.Size = new System.Drawing.Size(64, 32);
            this.labelNewHour.TabIndex = 4;
            this.labelNewHour.Text = "จำนวน";
            // 
            // panelPay
            // 
            this.panelPay.BackColor = System.Drawing.Color.Teal;
            this.panelPay.Controls.Add(this.picReceipt);
            this.panelPay.Controls.Add(this.btnCancelSent);
            this.panelPay.Controls.Add(this.btnSentReceipt);
            this.panelPay.Controls.Add(this.btnUpload);
            this.panelPay.Controls.Add(this.pictureBox1);
            this.panelPay.Controls.Add(this.labelPathReceipt);
            this.panelPay.Location = new System.Drawing.Point(1029, 472);
            this.panelPay.Name = "panelPay";
            this.panelPay.Size = new System.Drawing.Size(424, 212);
            this.panelPay.TabIndex = 8;
            this.panelPay.Visible = false;
            // 
            // picReceipt
            // 
            this.picReceipt.BackColor = System.Drawing.Color.Turquoise;
            this.picReceipt.Location = new System.Drawing.Point(275, 40);
            this.picReceipt.Name = "picReceipt";
            this.picReceipt.Size = new System.Drawing.Size(100, 106);
            this.picReceipt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReceipt.TabIndex = 3;
            this.picReceipt.TabStop = false;
            // 
            // btnCancelSent
            // 
            this.btnCancelSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnCancelSent.Location = new System.Drawing.Point(247, 175);
            this.btnCancelSent.Name = "btnCancelSent";
            this.btnCancelSent.Size = new System.Drawing.Size(73, 22);
            this.btnCancelSent.TabIndex = 2;
            this.btnCancelSent.Text = "ยกเลิก";
            this.btnCancelSent.UseVisualStyleBackColor = true;
            this.btnCancelSent.Click += new System.EventHandler(this.btnCancelSent_Click);
            // 
            // btnSentReceipt
            // 
            this.btnSentReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSentReceipt.Location = new System.Drawing.Point(326, 175);
            this.btnSentReceipt.Name = "btnSentReceipt";
            this.btnSentReceipt.Size = new System.Drawing.Size(73, 22);
            this.btnSentReceipt.TabIndex = 2;
            this.btnSentReceipt.Text = "ตกลง";
            this.btnSentReceipt.UseVisualStyleBackColor = true;
            this.btnSentReceipt.Click += new System.EventHandler(this.btnSentReceipt_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnUpload.Location = new System.Drawing.Point(247, 11);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(152, 22);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload Receipt";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::the_Project.Properties.Resources.QrCode;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelPathReceipt
            // 
            this.labelPathReceipt.AutoEllipsis = true;
            this.labelPathReceipt.AutoSize = true;
            this.labelPathReceipt.Font = new System.Drawing.Font("TH Sarabun New", 9.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelPathReceipt.ForeColor = System.Drawing.Color.Wheat;
            this.labelPathReceipt.Location = new System.Drawing.Point(272, 150);
            this.labelPathReceipt.MaximumSize = new System.Drawing.Size(120, 27);
            this.labelPathReceipt.Name = "labelPathReceipt";
            this.labelPathReceipt.Size = new System.Drawing.Size(117, 27);
            this.labelPathReceipt.TabIndex = 1;
            this.labelPathReceipt.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.button1.Location = new System.Drawing.Point(1178, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "จ่ายเงิน";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(202)))));
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1029, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "แก้ไขข้อมูล";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panelCancel
            // 
            this.panelCancel.Controls.Add(this.btnNoCancel);
            this.panelCancel.Controls.Add(this.btnYesCancel);
            this.panelCancel.Controls.Add(this.labelTitleBtnCancel);
            this.panelCancel.Location = new System.Drawing.Point(1029, 472);
            this.panelCancel.Name = "panelCancel";
            this.panelCancel.Size = new System.Drawing.Size(424, 212);
            this.panelCancel.TabIndex = 9;
            this.panelCancel.Visible = false;
            // 
            // btnNoCancel
            // 
            this.btnNoCancel.BackColor = System.Drawing.Color.White;
            this.btnNoCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnNoCancel.FlatAppearance.BorderSize = 2;
            this.btnNoCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoCancel.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnNoCancel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnNoCancel.Location = new System.Drawing.Point(231, 106);
            this.btnNoCancel.Name = "btnNoCancel";
            this.btnNoCancel.Size = new System.Drawing.Size(122, 41);
            this.btnNoCancel.TabIndex = 6;
            this.btnNoCancel.Text = "ไม่";
            this.btnNoCancel.UseVisualStyleBackColor = false;
            this.btnNoCancel.Click += new System.EventHandler(this.btnNoCancel_Click);
            // 
            // btnYesCancel
            // 
            this.btnYesCancel.BackColor = System.Drawing.Color.Teal;
            this.btnYesCancel.FlatAppearance.BorderSize = 0;
            this.btnYesCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYesCancel.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnYesCancel.ForeColor = System.Drawing.Color.White;
            this.btnYesCancel.Location = new System.Drawing.Point(77, 105);
            this.btnYesCancel.Name = "btnYesCancel";
            this.btnYesCancel.Size = new System.Drawing.Size(122, 42);
            this.btnYesCancel.TabIndex = 6;
            this.btnYesCancel.Text = "ใช่";
            this.btnYesCancel.UseVisualStyleBackColor = false;
            this.btnYesCancel.Click += new System.EventHandler(this.btnYesCancel_Click);
            // 
            // labelTitleBtnCancel
            // 
            this.labelTitleBtnCancel.AutoSize = true;
            this.labelTitleBtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitleBtnCancel.Font = new System.Drawing.Font("TH Sarabun New", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelTitleBtnCancel.ForeColor = System.Drawing.Color.Teal;
            this.labelTitleBtnCancel.Location = new System.Drawing.Point(34, 40);
            this.labelTitleBtnCancel.Name = "labelTitleBtnCancel";
            this.labelTitleBtnCancel.Size = new System.Drawing.Size(373, 45);
            this.labelTitleBtnCancel.TabIndex = 4;
            this.labelTitleBtnCancel.Text = "คุณต้องการยกเลิกการจองใช่หรือไม่ ?";
            // 
            // wallpaper
            // 
            this.wallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wallpaper.Image = global::the_Project.Properties.Resources.wallpaper_schedule;
            this.wallpaper.Location = new System.Drawing.Point(0, 0);
            this.wallpaper.Name = "wallpaper";
            this.wallpaper.Size = new System.Drawing.Size(1487, 708);
            this.wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wallpaper.TabIndex = 0;
            this.wallpaper.TabStop = false;
            this.wallpaper.Click += new System.EventHandler(this.wallpaper_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 708);
            this.Controls.Add(this.panelPay);
            this.Controls.Add(this.panelCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.bookingData);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.wallpaper);
            this.MaximumSize = new System.Drawing.Size(1509, 764);
            this.MinimumSize = new System.Drawing.Size(1509, 764);
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingData)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maidPic)).EndInit();
            this.panelComment.ResumeLayout(false);
            this.panelComment.PerformLayout();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newHour)).EndInit();
            this.panelPay.ResumeLayout(false);
            this.panelPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCancel.ResumeLayout(false);
            this.panelCancel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wallpaper)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox wallpaper;
    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.DataGridView bookingData;
    private System.Windows.Forms.PictureBox maidPic;
    private System.Windows.Forms.Label labelMaidName;
    private System.Windows.Forms.Panel panelDetail;
    private System.Windows.Forms.Label labelDateTime;
    private System.Windows.Forms.Label labelNewDateTime;
    private System.Windows.Forms.Label labelComment;
    private System.Windows.Forms.Label labelPrice;
    private System.Windows.Forms.Panel panelComment;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnPay;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Panel panelEdit;
    private System.Windows.Forms.TextBox tbxEdit;
    private System.Windows.Forms.Button BtnCancelEdit;
    private System.Windows.Forms.Button btnOkEdit;
    private System.Windows.Forms.DateTimePicker newTime;
    private System.Windows.Forms.DateTimePicker newDate;
    private System.Windows.Forms.TextBox tbxNewComment;
    private System.Windows.Forms.Label labelHour;
    private System.Windows.Forms.NumericUpDown newHour;
    private System.Windows.Forms.Label labelH;
    private System.Windows.Forms.Label labelNewHour;
    private System.Windows.Forms.Panel panelPay;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label labelPathReceipt;
    private System.Windows.Forms.PictureBox picReceipt;
    private System.Windows.Forms.Button btnCancelSent;
    private System.Windows.Forms.Button btnSentReceipt;
    private System.Windows.Forms.Button btnUpload;
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
    private System.Windows.Forms.Label labelPaymentStatus;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Panel panelCancel;
    private System.Windows.Forms.Button btnNoCancel;
    private System.Windows.Forms.Button btnYesCancel;
    private System.Windows.Forms.Label labelTitleBtnCancel;
  }
}