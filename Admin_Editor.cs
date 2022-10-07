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

namespace the_Project
{
  public partial class Admin_Editor : Form
  {
    public Admin_Editor()
    {
      InitializeComponent();
    }

    MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=project_mild");
    DataTable bookingDataTable;

    private void database(string sql)
    {
      conn.Open();
      var cmd = new MySqlCommand(sql,conn);
      DataTable dt = new DataTable();
      new MySqlDataAdapter(cmd).Fill(dt); 
      bookingDataTable = dt;
      conn.Close();
      userTable.DataSource = dt;
    }
    string columnName,itemID;
    int rows;
    private void userTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      itemID = bookingDataTable.Rows[e.RowIndex][0].ToString();
      rows = e.RowIndex;

      maidPic.Image = new Bitmap(bookingDataTable.Rows[e.RowIndex][15].ToString());
      labelMaidName.Text = bookingDataTable.Rows[e.RowIndex][14].ToString();

      labelDateTime.Text = $"วันเริ่มงาน : {bookingDataTable.Rows[rows][9]} เวลา {bookingDataTable.Rows[rows][10]} น.";
      labelHour.Text = $"จำนวน : {bookingDataTable.Rows[rows][11]} ชม.";
      labelComment.Text = $"หมายเหตุ : {bookingDataTable.Rows[rows][13]}";
      labelPrice.Text = $"ราคา : {bookingDataTable.Rows[rows][12]} บาท";
      labelStatus.Text = $"สถานะ : {bookingDataTable.Rows[rows][16]}";

      cbxStatus.Text = bookingDataTable.Rows[e.RowIndex][16].ToString();

      tbxNewEdit.Text = bookingDataTable.Rows[e.RowIndex][e.ColumnIndex].ToString();
      newDate.Text = bookingDataTable.Rows[e.RowIndex][9].ToString();
      newTime.Text = bookingDataTable.Rows[e.RowIndex][10].ToString();
      NewComment.Text = bookingDataTable.Rows[e.RowIndex][13].ToString();
      newHour.Text = bookingDataTable.Rows[e.RowIndex][11].ToString();

      columnName = userTable.Columns[e.ColumnIndex].DataPropertyName;
    }
    private void reloadDetail()
    {
      labelDateTime.Text = $"วันเริ่มงาน : {bookingDataTable.Rows[rows][9]} เวลา {bookingDataTable.Rows[rows][10]} น.";
      labelHour.Text = $"จำนวน : {bookingDataTable.Rows[rows][11]} ชม.";
      labelComment.Text = $"หมายเหตุ : {bookingDataTable.Rows[rows][13]}";
      labelPrice.Text = $"ราคา : {bookingDataTable.Rows[rows][12]} บาท";
      labelStatus.Text = $"สถานะ : {bookingDataTable.Rows[rows][16]}";
    }
    private void Admin_Editor_Load(object sender, EventArgs e)
    {
      database("SELECT * FROM booking");
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
      Menu mainMenu = new Menu();
      mainMenu.Show();
      this.Close();
    }

    private void tbxSearch_TextChanged(object sender, EventArgs e)
    {
      database($"SELECT * FROM booking WHERE fname LIKE '%{tbxSearch.Text.Trim()}%' OR lname LIKE '%{tbxSearch.Text.Trim()}%' OR" +
        $" email LIKE '%{tbxSearch.Text.Trim()}%' OR email2 LIKE '%{tbxSearch.Text.Trim()}%' OR maidName LIKE '%{tbxSearch.Text.Trim()}%'");
    }

    private void btnOkEdit_Click(object sender, EventArgs e)
    {
      conn.Open();
      string sql = $"UPDATE booking SET {columnName} = '{tbxNewEdit.Text}' ,payment_status = '{cbxStatus.Text}', date = '{newDate.Value.ToString("dd/MM/yy")}', " +
        $"time = '{newTime.Value.ToString("t")}', hour = '{newHour.Value}', price = '{120 * Convert.ToInt32(newHour.Value)}', " +
        $"comment = '{NewComment.Text}' WHERE id = '{itemID}'";
      var cmd = new MySqlCommand(sql, conn);
      cmd.ExecuteNonQuery();
      conn.Close();
      database("SELECT * FROM booking");
      reloadDetail();
      MessageBox.Show("แก้ไขเรียบร้อย");
    }
  }
}
