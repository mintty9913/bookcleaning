namespace the_Project
{
  partial class MaidForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.maidTable = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.newLnameMaid = new System.Windows.Forms.TextBox();
            this.newEmail = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.newPhone = new System.Windows.Forms.TextBox();
            this.newFnameMaid = new System.Windows.Forms.TextBox();
            this.labelLname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.maidPic = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.wallpeper = new System.Windows.Forms.PictureBox();
            this.btnSummary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maidTable)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maidPic)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wallpeper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 11);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 36);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "กลับ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // maidTable
            // 
            this.maidTable.AllowUserToAddRows = false;
            this.maidTable.AllowUserToDeleteRows = false;
            this.maidTable.AllowUserToResizeColumns = false;
            this.maidTable.AllowUserToResizeRows = false;
            this.maidTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            this.maidTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maidTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maidTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.maidTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maidTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fname,
            this.lname,
            this.status,
            this.phone,
            this.email,
            this.image});
            this.maidTable.EnableHeadersVisualStyles = false;
            this.maidTable.Location = new System.Drawing.Point(229, 47);
            this.maidTable.Name = "maidTable";
            this.maidTable.RowHeadersVisible = false;
            this.maidTable.RowHeadersWidth = 62;
            this.maidTable.RowTemplate.Height = 28;
            this.maidTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.maidTable.Size = new System.Drawing.Size(1135, 373);
            this.maidTable.TabIndex = 7;
            this.maidTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maidTable_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Teal;
            this.id.DefaultCellStyle = dataGridViewCellStyle16;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 80;
            // 
            // fname
            // 
            this.fname.DataPropertyName = "fname";
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Teal;
            this.fname.DefaultCellStyle = dataGridViewCellStyle17;
            this.fname.HeaderText = "ชื่อ";
            this.fname.MinimumWidth = 8;
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            this.fname.Width = 230;
            // 
            // lname
            // 
            this.lname.DataPropertyName = "lname";
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Teal;
            this.lname.DefaultCellStyle = dataGridViewCellStyle18;
            this.lname.HeaderText = "นามสกุล";
            this.lname.MinimumWidth = 8;
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            this.lname.Width = 230;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Teal;
            this.status.DefaultCellStyle = dataGridViewCellStyle19;
            this.status.HeaderText = "สถานะ";
            this.status.MinimumWidth = 8;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 190;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Teal;
            this.phone.DefaultCellStyle = dataGridViewCellStyle20;
            this.phone.HeaderText = "เบอร์";
            this.phone.MinimumWidth = 8;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 180;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Teal;
            this.email.DefaultCellStyle = dataGridViewCellStyle21;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // image
            // 
            this.image.DataPropertyName = "image";
            this.image.HeaderText = "IMAGE";
            this.image.MinimumWidth = 8;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Visible = false;
            this.image.Width = 150;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.btnSummary);
            this.panelDetail.Controls.Add(this.cbxStatus);
            this.panelDetail.Controls.Add(this.newLnameMaid);
            this.panelDetail.Controls.Add(this.newEmail);
            this.panelDetail.Controls.Add(this.btnOk);
            this.panelDetail.Controls.Add(this.newPhone);
            this.panelDetail.Controls.Add(this.newFnameMaid);
            this.panelDetail.Controls.Add(this.labelLname);
            this.panelDetail.Controls.Add(this.label2);
            this.panelDetail.Controls.Add(this.label1);
            this.panelDetail.Controls.Add(this.labelPhone);
            this.panelDetail.Controls.Add(this.labelFname);
            this.panelDetail.Controls.Add(this.maidPic);
            this.panelDetail.Location = new System.Drawing.Point(777, 434);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(587, 230);
            this.panelDetail.TabIndex = 8;
            // 
            // cbxStatus
            // 
            this.cbxStatus.Font = new System.Drawing.Font("TH Sarabun New", 10F, System.Drawing.FontStyle.Bold);
            this.cbxStatus.ForeColor = System.Drawing.Color.Teal;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "ว่าง",
            "ไม่ว่าง",
            "อยู่ในระหว่างการจอง"});
            this.cbxStatus.Location = new System.Drawing.Point(97, 184);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 35);
            this.cbxStatus.TabIndex = 4;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.checkEmpty);
            this.cbxStatus.TextChanged += new System.EventHandler(this.checkEmpty);
            // 
            // newLnameMaid
            // 
            this.newLnameMaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newLnameMaid.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold);
            this.newLnameMaid.ForeColor = System.Drawing.Color.Teal;
            this.newLnameMaid.Location = new System.Drawing.Point(217, 36);
            this.newLnameMaid.Name = "newLnameMaid";
            this.newLnameMaid.Size = new System.Drawing.Size(176, 35);
            this.newLnameMaid.TabIndex = 1;
            this.newLnameMaid.TextChanged += new System.EventHandler(this.checkEmpty);
            // 
            // newEmail
            // 
            this.newEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newEmail.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold);
            this.newEmail.ForeColor = System.Drawing.Color.Teal;
            this.newEmail.Location = new System.Drawing.Point(143, 128);
            this.newEmail.Name = "newEmail";
            this.newEmail.Size = new System.Drawing.Size(250, 35);
            this.newEmail.TabIndex = 3;
            this.newEmail.TextChanged += new System.EventHandler(this.checkEmpty);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Teal;
            this.btnOk.Enabled = false;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(409, 181);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(163, 36);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "ตกลง";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // newPhone
            // 
            this.newPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newPhone.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold);
            this.newPhone.ForeColor = System.Drawing.Color.Teal;
            this.newPhone.Location = new System.Drawing.Point(143, 82);
            this.newPhone.Name = "newPhone";
            this.newPhone.Size = new System.Drawing.Size(250, 35);
            this.newPhone.TabIndex = 2;
            this.newPhone.TextChanged += new System.EventHandler(this.checkEmpty);
            // 
            // newFnameMaid
            // 
            this.newFnameMaid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newFnameMaid.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold);
            this.newFnameMaid.ForeColor = System.Drawing.Color.Teal;
            this.newFnameMaid.Location = new System.Drawing.Point(25, 36);
            this.newFnameMaid.Name = "newFnameMaid";
            this.newFnameMaid.Size = new System.Drawing.Size(176, 35);
            this.newFnameMaid.TabIndex = 0;
            this.newFnameMaid.TextChanged += new System.EventHandler(this.checkEmpty);
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
            this.labelLname.ForeColor = System.Drawing.Color.Teal;
            this.labelLname.Location = new System.Drawing.Point(212, 13);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(69, 30);
            this.labelLname.TabIndex = 2;
            this.labelLname.Text = "นามสกุล";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(37, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "สถานะ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(88, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "อีเมล";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
            this.labelPhone.ForeColor = System.Drawing.Color.Teal;
            this.labelPhone.Location = new System.Drawing.Point(88, 86);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(47, 30);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "เบอร์";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
            this.labelFname.ForeColor = System.Drawing.Color.Teal;
            this.labelFname.Location = new System.Drawing.Point(20, 13);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(34, 30);
            this.labelFname.TabIndex = 2;
            this.labelFname.Text = "ชื่อ";
            // 
            // maidPic
            // 
            this.maidPic.BackColor = System.Drawing.SystemColors.Control;
            this.maidPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maidPic.Image = global::the_Project.Properties.Resources.add_image;
            this.maidPic.Location = new System.Drawing.Point(409, 13);
            this.maidPic.Name = "maidPic";
            this.maidPic.Size = new System.Drawing.Size(163, 147);
            this.maidPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maidPic.TabIndex = 0;
            this.maidPic.TabStop = false;
            this.maidPic.Click += new System.EventHandler(this.maidPic_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnDel);
            this.panelMenu.Controls.Add(this.btnAdd);
            this.panelMenu.Controls.Add(this.btnEdit);
            this.panelMenu.Location = new System.Drawing.Point(612, 434);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(159, 230);
            this.panelMenu.TabIndex = 9;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Teal;
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(34, 164);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(96, 36);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "ลบ";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(34, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "เพิ่ม";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(34, 29);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 36);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "แก้ไข";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSearch.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold);
            this.tbxSearch.ForeColor = System.Drawing.Color.Teal;
            this.tbxSearch.Location = new System.Drawing.Point(293, 434);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(250, 35);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(226)))), ((int)(((byte)(231)))));
            this.labelSearch.Font = new System.Drawing.Font("TH Sarabun New", 10F, System.Drawing.FontStyle.Bold);
            this.labelSearch.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelSearch.Location = new System.Drawing.Point(224, 437);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(63, 27);
            this.labelSearch.TabIndex = 10;
            this.labelSearch.Text = "Search :";
            // 
            // wallpeper
            // 
            this.wallpeper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wallpeper.Image = global::the_Project.Properties.Resources.wallpaper_MaidForm;
            this.wallpeper.Location = new System.Drawing.Point(0, 0);
            this.wallpeper.Name = "wallpeper";
            this.wallpeper.Size = new System.Drawing.Size(1487, 708);
            this.wallpeper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wallpeper.TabIndex = 0;
            this.wallpeper.TabStop = false;
            this.wallpeper.Click += new System.EventHandler(this.wallpeper_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.Chocolate;
            this.btnSummary.Enabled = false;
            this.btnSummary.FlatAppearance.BorderSize = 0;
            this.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummary.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            this.btnSummary.ForeColor = System.Drawing.Color.White;
            this.btnSummary.Location = new System.Drawing.Point(230, 181);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(163, 36);
            this.btnSummary.TabIndex = 6;
            this.btnSummary.Text = "ดูข้อมูล";
            this.btnSummary.UseVisualStyleBackColor = false;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // MaidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 708);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.maidTable);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.wallpeper);
            this.MaximumSize = new System.Drawing.Size(1509, 764);
            this.MinimumSize = new System.Drawing.Size(1509, 764);
            this.Name = "MaidForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaidForm";
            this.Load += new System.EventHandler(this.MaidForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maidTable)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maidPic)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wallpeper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox wallpeper;
    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.DataGridView maidTable;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn fname;
    private System.Windows.Forms.DataGridViewTextBoxColumn lname;
    private System.Windows.Forms.DataGridViewTextBoxColumn status;
    private System.Windows.Forms.DataGridViewTextBoxColumn phone;
    private System.Windows.Forms.DataGridViewTextBoxColumn email;
    private System.Windows.Forms.DataGridViewTextBoxColumn image;
    private System.Windows.Forms.Panel panelDetail;
    private System.Windows.Forms.TextBox newFnameMaid;
    private System.Windows.Forms.PictureBox maidPic;
    private System.Windows.Forms.Label labelLname;
    private System.Windows.Forms.Label labelFname;
    private System.Windows.Forms.TextBox newLnameMaid;
    private System.Windows.Forms.TextBox newEmail;
    private System.Windows.Forms.Button btnOk;
    private System.Windows.Forms.TextBox newPhone;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label labelPhone;
    private System.Windows.Forms.Panel panelMenu;
    private System.Windows.Forms.Button btnDel;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.ComboBox cbxStatus;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox tbxSearch;
    private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button btnSummary;
    }
}