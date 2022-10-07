using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace the_Project
{
  public partial class Schedule : Form
  {
    public Schedule()
    {
      InitializeComponent();
    }

    MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=project_mild");
    DataTable bookingDataTable = new DataTable();
    private void database(string sql)
    {
      conn.Open();
      var cmd = new MySqlCommand(sql, conn);
      DataTable dt = new DataTable();
      new MySqlDataAdapter(cmd).Fill(dt);
      bookingDataTable = dt;
      conn.Close();

      bookingData.DataSource = dt;
    }
    private void btnBack_Click(object sender, EventArgs e)
    {
        Menu mainMenu = new Menu();
      mainMenu.Show();
      this.Close();
    }

    private void Schedule_Load(object sender, EventArgs e)
    {
        database($"SELECT * FROM booking WHERE email = '{Main.mainDataTable.Rows[0][2]}'");
    }

    string columnHeaderName,fullPathMaid, itemKey;
    int rows;
    private void bookingData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      itemKey = bookingDataTable.Rows[e.RowIndex][0].ToString();
      btnEdit.Enabled = true;
      btnPay.Enabled = true;
      btnCancel.Enabled = true;

      rows = e.RowIndex;

      maidPic.Image = new Bitmap(bookingDataTable.Rows[e.RowIndex][15].ToString());
      fullPathMaid = bookingDataTable.Rows[e.RowIndex][15].ToString();
      labelMaidName.Text = bookingDataTable.Rows[e.RowIndex][14].ToString();

      labelDateTime.Text = $"วันเริ่มงาน : {bookingDataTable.Rows[e.RowIndex][9]} เวลา {bookingDataTable.Rows[e.RowIndex][10]} น.";
      labelHour.Text = $"จำนวน : {bookingDataTable.Rows[e.RowIndex][11]} ชม.";
      labelComment.Text = $"หมายเหตุ : {bookingDataTable.Rows[e.RowIndex][13]}";
      labelPrice.Text = $"ราคา : {bookingDataTable.Rows[e.RowIndex][12]} บาท";
      labelPaymentStatus.Text = $"สถานะ : {bookingDataTable.Rows[e.RowIndex][16]}";

      newDate.Text = bookingDataTable.Rows[e.RowIndex][9].ToString();
      newTime.Text = bookingDataTable.Rows[e.RowIndex][10].ToString();
      newHour.Text = bookingDataTable.Rows[e.RowIndex][11].ToString();

      tbxEdit.Text = bookingDataTable.Rows[e.RowIndex][e.ColumnIndex].ToString();
      tbxNewComment.Text = bookingDataTable.Rows[e.RowIndex][13].ToString();
      columnHeaderName = bookingData.Columns[e.ColumnIndex].DataPropertyName;

      if (bookingDataTable.Rows[rows][16].ToString() == "จ่ายแล้ว") { btnPay.Visible = false; btnEdit.Visible = false; }
      else { btnPay.Visible = true;btnEdit.Visible = true; }
    }
    private void reloadDetail()
    {
      labelDateTime.Text = $"วันเริ่มงาน : {bookingDataTable.Rows[rows][9]} เวลา {bookingDataTable.Rows[rows][10]} น.";
      labelHour.Text = $"จำนวน : {bookingDataTable.Rows[rows][11]} ชม.";
      labelComment.Text = $"หมายเหตุ : {bookingDataTable.Rows[rows][13]}";
      labelPrice.Text = $"ราคา : {bookingDataTable.Rows[rows][12]} บาท";
      labelPaymentStatus.Text = $"สถานะ : {bookingDataTable.Rows[rows][16]}";

      if (bookingDataTable.Rows[rows][16].ToString() == "จ่ายแล้ว") { btnPay.Visible = false; btnEdit.Visible = false; }
      else { btnPay.Visible = true; btnEdit.Visible = true; }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      if (panelEdit.Visible == true) { panelEdit.Visible = false; }
      else { panelEdit.Visible = true;panelPay.Visible = false; panelCancel.Visible = false; }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      if (panelCancel.Visible == true) { panelCancel.Visible = false; }
      else { panelCancel.Visible = true; panelPay.Visible = false; panelEdit.Visible = false; }
  
    }

    private void btnPay_Click(object sender, EventArgs e)
    {
      if (panelPay.Visible == true){ panelPay.Visible = false; }
      else { panelPay.Visible = true;panelEdit.Visible = false;panelCancel.Visible = false; }
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
     QrCode qrCode = new QrCode();
      qrCode.ShowDialog();
    }

    string fileNameReceipt, filePathReceipt;

    private void btnCancelSent_Click(object sender, EventArgs e)
    {
      panelPay.Visible = false;
    }

    string pathReceipt;
    private void btnSentReceipt_Click(object sender, EventArgs e)
    {
      int count = new Random().Next(100,9999);
      pathReceipt = $"C:\\Users\\milds\\Desktop\\Project Mild\\Pic\\receipt\\{fileNameReceipt}";
      if (File.Exists(pathReceipt))
      {
        File.Copy(filePathReceipt, $"C:\\Users\\milds\\Desktop\\Project Mild\\Pic\\receipt\\({count}){fileNameReceipt}");
        pathReceipt = $"C:\\Users\\milds\\Desktop\\Project Mild\\Pic\\receipt\\({count}){fileNameReceipt}";
      }
      else
      {
        File.Copy(filePathReceipt, $"C:\\Users\\milds\\Desktop\\Project Mild\\Pic\\receipt\\{fileNameReceipt}");
      }
      conn.Open();
      string sql = $"INSERT INTO payment_status (username,email,date,time,receiptPath) VALUES " +
        $"('{Main.mainDataTable.Rows[0][1]}','{Main.mainDataTable.Rows[0][2]}','{DateTime.Now.ToString("dd-MM-yy")}'," +
        $"'{DateTime.Now.ToString("t")}','{pathReceipt.Replace("\\","\\\\")}');" +
        $"UPDATE booking SET payment_status = 'จ่ายแล้ว' WHERE id = '{itemKey}';" +
        $"UPDATE maid_info SET status = 'ไม่ว่าง' WHERE image = '{fullPathMaid.Replace("\\", "\\\\")}';" +
        $"UPDATE history SET status = 'จ่ายแล้ว', receiptPath = '{pathReceipt.Replace("\\", "\\\\")}', " +
        $"date = '{DateTime.Now.ToString("dd-MM-yy")}', time = '{DateTime.Now.ToString("t")}' WHERE email = '{Main.mainDataTable.Rows[0][2]}' AND maidName = '{labelMaidName.Text}'";
      var cmd = new MySqlCommand(sql, conn);
      cmd.ExecuteNonQuery();

            //ทำการบันทึกลงในๅ Database summary เพื่อนำช้อไปทำสรุปผลสรุปยอดรวม
            sql = $"INSERT INTO maid_summary (maidName,maidProfile,email,price,date,time) VALUES ('{labelMaidName.Text}','{fullPathMaid.Replace("\\", "\\\\")}'," +
              $"'{Main.mainDataTable.Rows[0][2]}','{120 * Convert.ToInt32(newHour.Text)}','{DateTime.Now.ToString("dd-MM-yy")}','{DateTime.Now.ToString("t")}')";
            cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
      MessageBox.Show("ทำการจ่ายเรียบร้อย");
      database($"SELECT * FROM booking WHERE email = '{Main.mainDataTable.Rows[0][2]}'");
      panelPay.Visible = false;
      reloadDetail();
    }

    private void btnYesCancel_Click(object sender, EventArgs e)
    {
      conn.Open();
      string sql = $"UPDATE maid_info SET status = 'ว่าง' WHERE image = '{fullPathMaid.Replace("\\", "\\\\")}'";
      var cmd = new MySqlCommand(sql, conn);
      if (cmd.ExecuteNonQuery() > 0)
      {
        sql = $"DELETE FROM booking WHERE id = {itemKey}";
        cmd = new MySqlCommand(sql, conn);
        cmd.ExecuteNonQuery();
        conn.Close();
        MessageBox.Show("ยกเลิกการจองเรียบร้อย");
        Schedule schedule = new Schedule();
        schedule.Show();
        this.Close();
      }
    }

    private void btnNoCancel_Click(object sender, EventArgs e)
    {
     panelCancel.Visible = false;
    }

        private void wallpaper_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
    {
      //และในส่วนของตรงนี้จะเป็นการอัพโหลดรูปภาพสลิป
      OpenFileDialog open = new OpenFileDialog();
      // image filters  
      open.Filter = "Image Files(.png; *.jpg; *.jpeg; *.gif; *.bmp)|.png; *.jpg; *.jpeg; *.gif; *.bmp";
      if (open.ShowDialog() == DialogResult.OK)
      {
        filePathReceipt = open.FileName;
        fileNameReceipt = open.SafeFileName;
        labelPathReceipt.Text = fileNameReceipt;

        picReceipt.Image = new Bitmap(filePathReceipt);
      }
    }

    private void BtnCancelEdit_Click(object sender, EventArgs e)
    {
     panelEdit.Visible = false;
    }

    private void btnOkEdit_Click(object sender, EventArgs e)
    {
      conn.Open();
      string sql = $"UPDATE booking SET {columnHeaderName} = '{tbxEdit.Text}' , date = '{newDate.Value.ToString("dd/MM/yy")}', " +
        $"time = '{newTime.Value.ToString("t")}', hour = '{newHour.Value}', price = '{120 * Convert.ToInt32(newHour.Value)}', " +
        $"comment = '{tbxNewComment.Text}' WHERE maidProfile = '{fullPathMaid.Replace("\\","\\\\")}'";
      var cmd = new MySqlCommand(sql, conn);
      if (cmd.ExecuteNonQuery() > 0)
      {
        conn.Close();
        MessageBox.Show("แก้ไขเรียบร้อย");
        database($"SELECT * FROM booking WHERE email = '{Main.mainDataTable.Rows[0][2]}'");
        panelEdit.Visible = false;
        reloadDetail();
      }
      else
      {
        MessageBox.Show("ERROR Line 94");
      }
    }
  }
}
