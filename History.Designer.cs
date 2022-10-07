namespace the_Project
{
  partial class History
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.historyData = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maidName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maidProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.receiptImage = new System.Windows.Forms.PictureBox();
            this.panelComment = new System.Windows.Forms.Panel();
            this.labelComment = new System.Windows.Forms.Label();
            this.panelAdress = new System.Windows.Forms.Panel();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelSlip = new System.Windows.Forms.Label();
            this.labelMaidName = new System.Windows.Forms.Label();
            this.maidImage = new System.Windows.Forms.PictureBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.TitleDelete = new System.Windows.Forms.TextBox();
            this.btnNoDel = new System.Windows.Forms.Button();
            this.btnYesDel = new System.Windows.Forms.Button();
            this.wallpaper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.historyData)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptImage)).BeginInit();
            this.panelComment.SuspendLayout();
            this.panelAdress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maidImage)).BeginInit();
            this.panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // historyData
            // 
            this.historyData.AllowUserToAddRows = false;
            this.historyData.AllowUserToDeleteRows = false;
            this.historyData.AllowUserToResizeColumns = false;
            this.historyData.AllowUserToResizeRows = false;
            this.historyData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(131)))), ((int)(((byte)(105)))));
            this.historyData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.historyData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("TH Sarabun New", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.historyData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.historyData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fname,
            this.lname,
            this.email,
            this.address,
            this.date,
            this.time,
            this.hour,
            this.price,
            this.comment,
            this.maidName,
            this.maidProfile,
            this.status,
            this.receiptPath,
            this.itemsID});
            this.historyData.EnableHeadersVisualStyles = false;
            this.historyData.Location = new System.Drawing.Point(225, 63);
            this.historyData.Name = "historyData";
            this.historyData.RowHeadersVisible = false;
            this.historyData.RowHeadersWidth = 62;
            this.historyData.RowTemplate.Height = 34;
            this.historyData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyData.Size = new System.Drawing.Size(1250, 352);
            this.historyData.TabIndex = 1;
            this.historyData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyData_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.fname.DefaultCellStyle = dataGridViewCellStyle2;
            this.fname.HeaderText = "ชื่อ";
            this.fname.MinimumWidth = 8;
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Width = 180;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "lname";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.lname.DefaultCellStyle = dataGridViewCellStyle3;
            this.lname.HeaderText = "นามสกุล";
            this.lname.MinimumWidth = 8;
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Width = 180;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.email.DefaultCellStyle = dataGridViewCellStyle4;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 198;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.address.DefaultCellStyle = dataGridViewCellStyle5;
            this.address.HeaderText = "ที่อยู่";
            this.address.MinimumWidth = 8;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.address.Visible = false;
            this.address.Width = 150;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.date.DefaultCellStyle = dataGridViewCellStyle6;
            this.date.HeaderText = "วันที่่ทำการ";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 150;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.time.DefaultCellStyle = dataGridViewCellStyle7;
            this.time.HeaderText = "เวลาทำการ";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 120;
            // 
            // hour
            // 
            this.hour.DataPropertyName = "hour";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.hour.DefaultCellStyle = dataGridViewCellStyle8;
            this.hour.HeaderText = "ชม.ที่จอง";
            this.hour.MinimumWidth = 8;
            this.hour.Name = "hour";
            this.hour.ReadOnly = true;
            this.hour.Width = 120;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.price.DefaultCellStyle = dataGridViewCellStyle9;
            this.price.HeaderText = "ราคา";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 120;
            // 
            // comment
            // 
            this.comment.DataPropertyName = "comment";
            this.comment.HeaderText = "หมายเหตุ";
            this.comment.MinimumWidth = 8;
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            this.comment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.comment.Visible = false;
            this.comment.Width = 150;
            // 
            // maidName
            // 
            this.maidName.DataPropertyName = "maidName";
            this.maidName.HeaderText = "Maid Name";
            this.maidName.MinimumWidth = 8;
            this.maidName.Name = "maidName";
            this.maidName.ReadOnly = true;
            this.maidName.Visible = false;
            this.maidName.Width = 150;
            // 
            // maidProfile
            // 
            this.maidProfile.DataPropertyName = "maidProfile";
            this.maidProfile.HeaderText = "Maid Image";
            this.maidProfile.MinimumWidth = 8;
            this.maidProfile.Name = "maidProfile";
            this.maidProfile.ReadOnly = true;
            this.maidProfile.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.maidProfile.Visible = false;
            this.maidProfile.Width = 150;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Chocolate;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.status.DefaultCellStyle = dataGridViewCellStyle10;
            this.status.HeaderText = "สถานะ";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // receiptPath
            // 
            this.receiptPath.DataPropertyName = "receiptPath";
            this.receiptPath.HeaderText = "Receipt Image";
            this.receiptPath.MinimumWidth = 8;
            this.receiptPath.Name = "receiptPath";
            this.receiptPath.ReadOnly = true;
            this.receiptPath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.receiptPath.Visible = false;
            this.receiptPath.Width = 150;
            // 
            // itemsID
            // 
            this.itemsID.DataPropertyName = "itemID";
            this.itemsID.HeaderText = "ITEMs ID";
            this.itemsID.MinimumWidth = 8;
            this.itemsID.Name = "itemsID";
            this.itemsID.ReadOnly = true;
            this.itemsID.Visible = false;
            this.itemsID.Width = 150;
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSearch.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tbxSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tbxSearch.Location = new System.Drawing.Point(1174, 15);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(301, 30);
            this.tbxSearch.TabIndex = 2;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(131)))), ((int)(((byte)(105)))));
            this.labelSearch.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelSearch.ForeColor = System.Drawing.Color.White;
            this.labelSearch.Location = new System.Drawing.Point(1100, 15);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(70, 30);
            this.labelSearch.TabIndex = 3;
            this.labelSearch.Text = "Search :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Chocolate;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(76, 33);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "กลับ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.receiptImage);
            this.panelDetail.Controls.Add(this.panelComment);
            this.panelDetail.Controls.Add(this.panelAdress);
            this.panelDetail.Controls.Add(this.labelSlip);
            this.panelDetail.Controls.Add(this.labelMaidName);
            this.panelDetail.Controls.Add(this.maidImage);
            this.panelDetail.Location = new System.Drawing.Point(225, 420);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(860, 277);
            this.panelDetail.TabIndex = 5;
            // 
            // receiptImage
            // 
            this.receiptImage.BackColor = System.Drawing.Color.Chocolate;
            this.receiptImage.Location = new System.Drawing.Point(648, 35);
            this.receiptImage.Name = "receiptImage";
            this.receiptImage.Size = new System.Drawing.Size(188, 230);
            this.receiptImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.receiptImage.TabIndex = 0;
            this.receiptImage.TabStop = false;
            this.receiptImage.Click += new System.EventHandler(this.receiptImage_Click);
            // 
            // panelComment
            // 
            this.panelComment.BackColor = System.Drawing.Color.DarkSalmon;
            this.panelComment.Controls.Add(this.labelComment);
            this.panelComment.Location = new System.Drawing.Point(197, 153);
            this.panelComment.Name = "panelComment";
            this.panelComment.Size = new System.Drawing.Size(428, 112);
            this.panelComment.TabIndex = 2;
            // 
            // labelComment
            // 
            this.labelComment.AutoEllipsis = true;
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelComment.ForeColor = System.Drawing.Color.White;
            this.labelComment.Location = new System.Drawing.Point(2, 0);
            this.labelComment.MaximumSize = new System.Drawing.Size(425, 122);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(94, 32);
            this.labelComment.TabIndex = 1;
            this.labelComment.Text = "หมายเหตุ :";
            // 
            // panelAdress
            // 
            this.panelAdress.BackColor = System.Drawing.Color.DarkSalmon;
            this.panelAdress.Controls.Add(this.labelAddress);
            this.panelAdress.Location = new System.Drawing.Point(197, 16);
            this.panelAdress.Name = "panelAdress";
            this.panelAdress.Size = new System.Drawing.Size(428, 126);
            this.panelAdress.TabIndex = 2;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoEllipsis = true;
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(2, 1);
            this.labelAddress.MaximumSize = new System.Drawing.Size(425, 126);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(55, 32);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "ที่อยู่ :";
            // 
            // labelSlip
            // 
            this.labelSlip.AutoSize = true;
            this.labelSlip.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelSlip.ForeColor = System.Drawing.Color.Chocolate;
            this.labelSlip.Location = new System.Drawing.Point(644, 11);
            this.labelSlip.Name = "labelSlip";
            this.labelSlip.Size = new System.Drawing.Size(135, 30);
            this.labelSlip.TabIndex = 1;
            this.labelSlip.Text = "Payment Receipt";
            // 
            // labelMaidName
            // 
            this.labelMaidName.AutoSize = true;
            this.labelMaidName.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelMaidName.ForeColor = System.Drawing.Color.Chocolate;
            this.labelMaidName.Location = new System.Drawing.Point(15, 157);
            this.labelMaidName.Name = "labelMaidName";
            this.labelMaidName.Size = new System.Drawing.Size(63, 30);
            this.labelMaidName.TabIndex = 1;
            this.labelMaidName.Text = "Name :";
            // 
            // maidImage
            // 
            this.maidImage.BackColor = System.Drawing.Color.Chocolate;
            this.maidImage.Location = new System.Drawing.Point(19, 16);
            this.maidImage.Name = "maidImage";
            this.maidImage.Size = new System.Drawing.Size(166, 138);
            this.maidImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maidImage.TabIndex = 0;
            this.maidImage.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Chocolate;
            this.btnDel.Enabled = false;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(1102, 418);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(177, 50);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "ลบ";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Enabled = false;
            this.btnDelAll.FlatAppearance.BorderSize = 0;
            this.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelAll.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDelAll.ForeColor = System.Drawing.Color.Chocolate;
            this.btnDelAll.Location = new System.Drawing.Point(1298, 418);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(177, 50);
            this.btnDelAll.TabIndex = 6;
            this.btnDelAll.Text = "ลบทั้งหมด";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.SystemColors.Control;
            this.panelDelete.Controls.Add(this.TitleDelete);
            this.panelDelete.Controls.Add(this.btnNoDel);
            this.panelDelete.Controls.Add(this.btnYesDel);
            this.panelDelete.Location = new System.Drawing.Point(1102, 494);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(373, 158);
            this.panelDelete.TabIndex = 7;
            this.panelDelete.Visible = false;
            // 
            // TitleDelete
            // 
            this.TitleDelete.BackColor = System.Drawing.SystemColors.Control;
            this.TitleDelete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleDelete.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold);
            this.TitleDelete.ForeColor = System.Drawing.Color.Chocolate;
            this.TitleDelete.Location = new System.Drawing.Point(3, 26);
            this.TitleDelete.Name = "TitleDelete";
            this.TitleDelete.Size = new System.Drawing.Size(367, 38);
            this.TitleDelete.TabIndex = 0;
            this.TitleDelete.Text = "คุณต้องการที่จะลบใช่หรือไม่ ?";
            this.TitleDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnNoDel
            // 
            this.btnNoDel.BackColor = System.Drawing.Color.Transparent;
            this.btnNoDel.FlatAppearance.BorderSize = 2;
            this.btnNoDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoDel.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnNoDel.ForeColor = System.Drawing.Color.Chocolate;
            this.btnNoDel.Location = new System.Drawing.Point(196, 72);
            this.btnNoDel.Name = "btnNoDel";
            this.btnNoDel.Size = new System.Drawing.Size(105, 38);
            this.btnNoDel.TabIndex = 6;
            this.btnNoDel.Text = "ไม่";
            this.btnNoDel.UseVisualStyleBackColor = false;
            this.btnNoDel.Click += new System.EventHandler(this.btnNoDel_Click);
            // 
            // btnYesDel
            // 
            this.btnYesDel.BackColor = System.Drawing.Color.Chocolate;
            this.btnYesDel.FlatAppearance.BorderSize = 0;
            this.btnYesDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYesDel.Font = new System.Drawing.Font("TH Sarabun New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnYesDel.ForeColor = System.Drawing.Color.White;
            this.btnYesDel.Location = new System.Drawing.Point(74, 72);
            this.btnYesDel.Name = "btnYesDel";
            this.btnYesDel.Size = new System.Drawing.Size(105, 38);
            this.btnYesDel.TabIndex = 6;
            this.btnYesDel.Text = "ใช่";
            this.btnYesDel.UseVisualStyleBackColor = false;
            this.btnYesDel.Click += new System.EventHandler(this.btnYesDel_Click);
            // 
            // wallpaper
            // 
            this.wallpaper.BackColor = System.Drawing.Color.Chocolate;
            this.wallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wallpaper.Image = global::the_Project.Properties.Resources.wallpaper_history;
            this.wallpaper.Location = new System.Drawing.Point(0, 0);
            this.wallpaper.Name = "wallpaper";
            this.wallpaper.Size = new System.Drawing.Size(1487, 708);
            this.wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wallpaper.TabIndex = 0;
            this.wallpaper.TabStop = false;
            this.wallpaper.Click += new System.EventHandler(this.wallpaper_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 708);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.historyData);
            this.Controls.Add(this.wallpaper);
            this.MaximumSize = new System.Drawing.Size(1509, 764);
            this.MinimumSize = new System.Drawing.Size(1509, 764);
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyData)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptImage)).EndInit();
            this.panelComment.ResumeLayout(false);
            this.panelComment.PerformLayout();
            this.panelAdress.ResumeLayout(false);
            this.panelAdress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maidImage)).EndInit();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox wallpaper;
    private System.Windows.Forms.DataGridView historyData;
    private System.Windows.Forms.TextBox tbxSearch;
    private System.Windows.Forms.Label labelSearch;
    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.Panel panelDetail;
    private System.Windows.Forms.PictureBox maidImage;
    private System.Windows.Forms.Label labelMaidName;
    private System.Windows.Forms.Panel panelComment;
    private System.Windows.Forms.Label labelComment;
    private System.Windows.Forms.PictureBox receiptImage;
    private System.Windows.Forms.Panel panelAdress;
    private System.Windows.Forms.Label labelAddress;
    private System.Windows.Forms.Button btnDel;
    private System.Windows.Forms.Button btnDelAll;
    private System.Windows.Forms.Panel panelDelete;
    private System.Windows.Forms.TextBox TitleDelete;
    private System.Windows.Forms.Button btnNoDel;
    private System.Windows.Forms.Button btnYesDel;
    private System.Windows.Forms.Label labelSlip;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn fname;
    private System.Windows.Forms.DataGridViewTextBoxColumn lname;
    private System.Windows.Forms.DataGridViewTextBoxColumn email;
    private System.Windows.Forms.DataGridViewTextBoxColumn address;
    private System.Windows.Forms.DataGridViewTextBoxColumn date;
    private System.Windows.Forms.DataGridViewTextBoxColumn time;
    private System.Windows.Forms.DataGridViewTextBoxColumn hour;
    private System.Windows.Forms.DataGridViewTextBoxColumn price;
    private System.Windows.Forms.DataGridViewTextBoxColumn comment;
    private System.Windows.Forms.DataGridViewTextBoxColumn maidName;
    private System.Windows.Forms.DataGridViewTextBoxColumn maidProfile;
    private System.Windows.Forms.DataGridViewTextBoxColumn status;
    private System.Windows.Forms.DataGridViewTextBoxColumn receiptPath;
    private System.Windows.Forms.DataGridViewTextBoxColumn itemsID;
  }
}