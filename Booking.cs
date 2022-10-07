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
  public partial class Booking : Form
  {
    public Booking()
    {
      InitializeComponent();
    }

    MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=project_mild");


    private void Booking_Load(object sender, EventArgs e)
    {
      tbxEmail.Text = Main.mainDataTable.Rows[0][2].ToString();
      maidProfile.Image = Maid_status.maidPic;
      labelMaidName.Text = Maid_status.fullMaidName;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
      Maid_status maid_Status = new Maid_status();
      maid_Status.Show();
      this.Close();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      bool checkEmpty = false;
      foreach (Control c in this.Controls)
      {
        if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)) ||
          this.Controls.OfType<ComboBox>().Any(t => string.IsNullOrEmpty(t.Text))) 
        { checkEmpty = false;}
        else{ checkEmpty = true;}
      }
      if (checkEmpty)
      {
        conn.Open();
        string sql = $"INSERT INTO booking (fname,lname,phone,email,email2,address,dormName,zone,date,time,hour,price,comment,maidName,maidProfile,payment_status) VALUES " +
          $"('{tbxFname.Text}','{tbxLname.Text}','{tbxPhone.Text}','{tbxEmail.Text}','{tbxEmail.Text}','{tbxAddress.Text}','{tbxDorm.Text}'," +
          $"'{cbxZone.Text}','{dateTimePicker.Value.ToString("dd/MM/yy")}','{timePicker.Value.ToString("t")}','{cbxHour.Text}','{120*Convert.ToInt32(cbxHour.Text)}'," +
          $"'{tbxComment.Text}','{labelMaidName.Text}','{Maid_status.pathMaidPic.ToString().Replace("\\", "\\\\")}','ยังไม่จ่าย')";
        var cmd = new MySqlCommand(sql, conn);
        cmd.ExecuteNonQuery();

        sql = $"UPDATE maid_info SET status = 'อยู่ในระหว่างการจอง' WHERE fname = '{Maid_status.fnameMaid}'";
        cmd = new MySqlCommand(sql, conn);
        cmd.ExecuteNonQuery();

        sql = $"INSERT INTO history (fname,lname,email,address,date,time,hour,price,comment,maidName,maidProfile,status,receiptPath) VALUES " +
          $"('{tbxFname.Text}','{tbxLname.Text}','{Main.mainDataTable.Rows[0][2]}','{tbxDorm.Text} {tbxAddress.Text} {cbxZone.Text} {tbxEmail.Text} {tbxPhone.Text}'," +
          $"'{DateTime.Now.ToString("dd-MM-yy")}','{DateTime.Now.ToString("t")}','{cbxHour.Text}','{120 * Convert.ToInt32(cbxHour.Text)}','{tbxComment.Text}','{labelMaidName.Text}','{Maid_status.pathMaidPic.ToString().Replace("\\", "\\\\")}'," +
          $"'อยู่ในระหว่างการจอง','-')";
        cmd = new MySqlCommand(sql,conn);
        int CheckRows = cmd.ExecuteNonQuery();
        if (CheckRows > 0)
        {
          conn.Close();
          MessageBox.Show("ทำการจองเรียบร้อย");
          Menu mainMenu = new Menu();
          mainMenu.Show();
          this.Close();
        }
      }
      else{ MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง"); }
    }

    private void tbxPhone_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
      {
        e.Handled = true;
      }
    }

        private void maidProfile_Click(object sender, EventArgs e)
        {

        }

        private void tbxFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxHour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
