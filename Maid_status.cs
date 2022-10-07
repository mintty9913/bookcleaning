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
  public partial class Maid_status : Form
  {
    public Maid_status()
    {
      InitializeComponent();
    }
    MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=project_mild");
    public static DataTable maidDataTable;
    private void findBookingName (string sql)
    {
      conn.Open();
      var cmd = new MySqlCommand(sql, conn);
      DataTable dt = new DataTable();
      new MySqlDataAdapter(cmd).Fill(dt);
      conn.Close();
      if (dt.Rows.Count > 0) 
      {
        labelBookingName.Text = $"ชื่อผู้จอง : {dt.Rows[0][1]} {dt.Rows[0][2]}";
        labelBookingPhone.Text = $"เบอร์ผู้จอง : {dt.Rows[0][3]}";
        labelBookingEmail.Text = $"อีเมลผู้จอง : {dt.Rows[0][5]}";
        labelBookingHour.Text = $"จำนวน : {dt.Rows[0][11]} ชม.";
      }
      else 
      {
        labelBookingName.Text = $"ชื่อผู้จอง : -";
        labelBookingEmail.Text = $"อีเมลผู้จอง : -";
        labelBookingPhone.Text = $"เบอร์ผู้จอง : -";
        labelBookingHour.Text = $"จำนวน : - ชม.";
      }
    }

    private void database(string sql)
    {
      conn.Open();
      var cmd = new MySqlCommand(sql, conn);
      DataTable dt = new DataTable();
      new MySqlDataAdapter(cmd).Fill(dt);
      conn.Close();
      maidDataTable = dt;
      maid_info.DataSource = dt;
    }

    private void Maid_status_Load(object sender, EventArgs e)
    {
      database("SELECT * FROM maid_info");
    }

    public static string fullMaidName,fnameMaid,pathMaidPic;
    public static Bitmap maidPic;
    private void maid_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      maidProfile.Image = new Bitmap(maidDataTable.Rows[e.RowIndex][6].ToString());
      maidPic = new Bitmap(maidDataTable.Rows[e.RowIndex][6].ToString());
      pathMaidPic = maidDataTable.Rows[e.RowIndex][6].ToString();

      labelMaidName.Text = $"{maidDataTable.Rows[e.RowIndex][1]} {maidDataTable.Rows[e.RowIndex][2]}";
      fullMaidName = labelMaidName.Text;
      fnameMaid = maidDataTable.Rows[e.RowIndex][1].ToString();

      labelMaidStatus.Text = maidDataTable.Rows[e.RowIndex][3].ToString();
      findBookingName($"SELECT * FROM booking WHERE maidName = '{maidDataTable.Rows[e.RowIndex][1]} {maidDataTable.Rows[e.RowIndex][2]}'");
      if (maidDataTable.Rows[e.RowIndex][3].ToString() == "ว่าง")
      {
        btnBook.Visible = true;
      }
      else
      {
        btnBook.Visible = false;
      }
    }

    private void btnBack2Menu_Click(object sender, EventArgs e)
    {
     Menu mainMenu = new Menu();
      mainMenu.Show();
      this.Close();
    }

    private void tbxSearch_Enter(object sender, EventArgs e)
    {
     if (tbxSearch.Text == "  Search")
      {
        tbxSearch.Text = "";
      }
     tbxSearch.ForeColor = Color.Teal;
    }

    private void tbxSearch_Leave(object sender, EventArgs e)
    {
     if (tbxSearch.Text == "")
      {
        tbxSearch.Text = "  Search";
      }
      tbxSearch.ForeColor = Color.SkyBlue;
    }

    private void rbtn_available_CheckedChanged(object sender, EventArgs e)
    {
      database("SELECT * FROM maid_info WHERE status = 'ว่าง'");
    }

    private void rbtn_unavailable_CheckedChanged(object sender, EventArgs e)
    {
      database("SELECT * FROM maid_info WHERE status = 'ไม่ว่าง'");
    }

    private void rbtnAll_CheckedChanged(object sender, EventArgs e)
    {
      database("SELECT * FROM maid_info");
    }

    private void rbtn_booking_CheckedChanged(object sender, EventArgs e)
    {
      database("SELECT * FROM maid_info WHERE status = 'อยู่ในระหว่างการจอง'");
    }

        private void maidProfile_Click(object sender, EventArgs e)
        {

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
    {
      if (tbxSearch.Text != "  Search")
      {
        database($"SELECT * FROM maid_info WHERE fname LIKE '%{tbxSearch.Text.Trim()}%' OR lname LIKE '%{tbxSearch.Text.Trim()}%'");
      }
      else
      {
        database("SELECT * FROM maid_info");
      }
    }

    private void btnBook_Click(object sender, EventArgs e)
    {
        Booking booking = new Booking();
      booking.Show();
      this.Close();
    }
  }
}
