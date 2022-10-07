namespace the_Project
{
  partial class Maid_Sum
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
            this.wallpaper = new System.Windows.Forms.PictureBox();
            this.maidSumData = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maidName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maidProfile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnSingle = new System.Windows.Forms.RadioButton();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.maidPic = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelMaidName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.labelAdminPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wallpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maidSumData)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maidPic)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // wallpaper
            // 
            this.wallpaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wallpaper.Image = global::the_Project.Properties.Resources.wallpaper_summary;
            this.wallpaper.Location = new System.Drawing.Point(0, 0);
            this.wallpaper.Name = "wallpaper";
            this.wallpaper.Size = new System.Drawing.Size(1487, 708);
            this.wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wallpaper.TabIndex = 0;
            this.wallpaper.TabStop = false;
            // 
            // maidSumData
            // 
            this.maidSumData.AllowUserToAddRows = false;
            this.maidSumData.AllowUserToDeleteRows = false;
            this.maidSumData.AllowUserToResizeColumns = false;
            this.maidSumData.AllowUserToResizeRows = false;
            this.maidSumData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(224)))), ((int)(((byte)(229)))));
            this.maidSumData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maidSumData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.maidSumData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.maidSumData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maidSumData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.maidName2,
            this.maidProfile,
            this.email,
            this.price,
            this.date,
            this.time});
            this.maidSumData.EnableHeadersVisualStyles = false;
            this.maidSumData.Location = new System.Drawing.Point(212, 65);
            this.maidSumData.Name = "maidSumData";
            this.maidSumData.RowHeadersVisible = false;
            this.maidSumData.RowHeadersWidth = 62;
            this.maidSumData.RowTemplate.Height = 32;
            this.maidSumData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.maidSumData.Size = new System.Drawing.Size(982, 357);
            this.maidSumData.TabIndex = 1;
            this.maidSumData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maidSumData_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // maidName2
            // 
            this.maidName2.DataPropertyName = "maidName";
            this.maidName2.HeaderText = "ชื่อ - นามสกุล";
            this.maidName2.MinimumWidth = 8;
            this.maidName2.Name = "maidName2";
            this.maidName2.ReadOnly = true;
            this.maidName2.Width = 210;
            // 
            // maidProfile
            // 
            this.maidProfile.DataPropertyName = "maidProfile";
            this.maidProfile.HeaderText = "IMAGE";
            this.maidProfile.MinimumWidth = 8;
            this.maidProfile.Name = "maidProfile";
            this.maidProfile.ReadOnly = true;
            this.maidProfile.Visible = false;
            this.maidProfile.Width = 150;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 190;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "ราคา";
            this.price.MinimumWidth = 8;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 180;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "วันที่";
            this.date.MinimumWidth = 8;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 180;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "เวลา";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnSingle);
            this.panel1.Controls.Add(this.rbtnAll);
            this.panel1.Controls.Add(this.tbxSearch);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(674, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 113);
            this.panel1.TabIndex = 2;
            // 
            // rbtnSingle
            // 
            this.rbtnSingle.AutoSize = true;
            this.rbtnSingle.BackColor = System.Drawing.Color.Teal;
            this.rbtnSingle.Font = new System.Drawing.Font("TH Sarabun New", 12.5F, System.Drawing.FontStyle.Bold);
            this.rbtnSingle.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnSingle.Location = new System.Drawing.Point(366, 67);
            this.rbtnSingle.Name = "rbtnSingle";
            this.rbtnSingle.Size = new System.Drawing.Size(137, 38);
            this.rbtnSingle.TabIndex = 1;
            this.rbtnSingle.TabStop = true;
            this.rbtnSingle.Text = "เฉพาะที่เลือก";
            this.rbtnSingle.UseVisualStyleBackColor = false;
            this.rbtnSingle.CheckedChanged += new System.EventHandler(this.rbtnSingle_CheckedChanged);
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.BackColor = System.Drawing.Color.Teal;
            this.rbtnAll.Font = new System.Drawing.Font("TH Sarabun New", 13F, System.Drawing.FontStyle.Bold);
            this.rbtnAll.ForeColor = System.Drawing.SystemColors.Control;
            this.rbtnAll.Location = new System.Drawing.Point(366, 22);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(135, 38);
            this.rbtnAll.TabIndex = 1;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "เลือกทั้งหมด";
            this.rbtnAll.UseVisualStyleBackColor = false;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSearch.Font = new System.Drawing.Font("TH Sarabun New", 11F, System.Drawing.FontStyle.Bold);
            this.tbxSearch.Location = new System.Drawing.Point(91, 42);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(245, 30);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("TH Sarabun New", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "ค้นหา";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maidPic);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelMaidName);
            this.panel2.Location = new System.Drawing.Point(1214, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 496);
            this.panel2.TabIndex = 2;
            // 
            // maidPic
            // 
            this.maidPic.BackColor = System.Drawing.Color.Teal;
            this.maidPic.Location = new System.Drawing.Point(17, 16);
            this.maidPic.Name = "maidPic";
            this.maidPic.Size = new System.Drawing.Size(215, 188);
            this.maidPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maidPic.TabIndex = 0;
            this.maidPic.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.labelTotal);
            this.panel3.Controls.Add(this.labelAdminPrice);
            this.panel3.Controls.Add(this.labelResult);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.labelSum);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 253);
            this.panel3.TabIndex = 2;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("TH Sarabun New", 15F, System.Drawing.FontStyle.Bold);
            this.labelTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotal.Location = new System.Drawing.Point(46, 54);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(69, 40);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "- บาท";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("TH Sarabun New", 15F, System.Drawing.FontStyle.Bold);
            this.labelResult.ForeColor = System.Drawing.SystemColors.Control;
            this.labelResult.Location = new System.Drawing.Point(46, 134);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(89, 40);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "จะเหลือ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("TH Sarabun New", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "หัก 20 % ";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("TH Sarabun New", 15F, System.Drawing.FontStyle.Bold);
            this.labelSum.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSum.Location = new System.Drawing.Point(46, 14);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(160, 40);
            this.labelSum.TabIndex = 0;
            this.labelSum.Text = "ยอดรวมทั้งหมด";
            // 
            // labelMaidName
            // 
            this.labelMaidName.AutoSize = true;
            this.labelMaidName.Font = new System.Drawing.Font("TH Sarabun New", 12F, System.Drawing.FontStyle.Bold);
            this.labelMaidName.ForeColor = System.Drawing.Color.Teal;
            this.labelMaidName.Location = new System.Drawing.Point(11, 212);
            this.labelMaidName.Name = "labelMaidName";
            this.labelMaidName.Size = new System.Drawing.Size(58, 32);
            this.labelMaidName.TabIndex = 1;
            this.labelMaidName.Text = "Name";
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
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "กลับ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // labelAdminPrice
            // 
            this.labelAdminPrice.AutoSize = true;
            this.labelAdminPrice.Font = new System.Drawing.Font("TH Sarabun New", 15F, System.Drawing.FontStyle.Bold);
            this.labelAdminPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAdminPrice.Location = new System.Drawing.Point(6, 181);
            this.labelAdminPrice.Name = "labelAdminPrice";
            this.labelAdminPrice.Size = new System.Drawing.Size(129, 40);
            this.labelAdminPrice.TabIndex = 0;
            this.labelAdminPrice.Text = "แอดมินจะได้";
            // 
            // Maid_Sum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 708);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maidSumData);
            this.Controls.Add(this.wallpaper);
            this.MaximumSize = new System.Drawing.Size(1509, 764);
            this.MinimumSize = new System.Drawing.Size(1509, 764);
            this.Name = "Maid_Sum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maid_Sum";
            this.Load += new System.EventHandler(this.Maid_Sum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wallpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maidSumData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maidPic)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox wallpaper;
    private System.Windows.Forms.DataGridView maidSumData;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn maidName2;
    private System.Windows.Forms.DataGridViewTextBoxColumn maidProfile;
    private System.Windows.Forms.DataGridViewTextBoxColumn email;
    private System.Windows.Forms.DataGridViewTextBoxColumn price;
    private System.Windows.Forms.DataGridViewTextBoxColumn date;
    private System.Windows.Forms.DataGridViewTextBoxColumn time;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label labelMaidName;
    private System.Windows.Forms.PictureBox maidPic;
    private System.Windows.Forms.Button btnBack;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label labelSum;
    private System.Windows.Forms.Label labelTotal;
    private System.Windows.Forms.TextBox tbxSearch;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label labelResult;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RadioButton rbtnAll;
    private System.Windows.Forms.RadioButton rbtnSingle;
        private System.Windows.Forms.Label labelAdminPrice;
    }
}