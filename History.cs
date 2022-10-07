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
  public partial class History : Form
  {
    public History()
    {
      InitializeComponent();
    }
    MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=project_mild");
    private DataTable historyTable;
    private void database(string sql)
    {
      conn.Open();
      var cmd = new MySqlCommand(sql, conn); 
      DataTable dt = new DataTable();
      new MySqlDataAdapter(cmd).Fill(dt);
      conn.Close();
      historyTable = dt;
      historyData.DataSource = dt;
    }
    private void History_Load(object sender, EventArgs e)
    {
      if (Main.mainDataTable.Rows[0][2].ToString() == Main.adminEmail)
      {
        database("SELECT * FROM history");
      }
      else
      {
        database($"SELECT * FROM history WHERE email = '{Main.mainDataTable.Rows[0][2]}'");
      }

    }

    private void tbxSearch_TextChanged(object sender, EventArgs e)
    {
      //database($"SELECT * FROM history WHERE fname LIKE '%{tbxSearch.Text.Trim()}%' OR lname LIKE '%{tbxSearch.Text.Trim()}%' OR " +
      //  $"maidName LIKE '%{tbxSearch.Text.Trim()}%' AND email = '{Main.mainDataTable.Rows[0][2]}'");
      var dv = new DataView(historyTable);
      dv.RowFilter = $"fname LIKE '%{tbxSearch.Text.Trim()}%' OR lname LIKE '%{tbxSearch.Text.Trim()}%' OR maidName LIKE '%{tbxSearch.Text.Trim()}%'";
      historyData.DataSource = dv;
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
     Menu mainMenu = new Menu();
      mainMenu.Show();
      this.Close();
    }
    string itemID;

    private void historyData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      btnDel.Enabled = true;btnDelAll.Enabled = true;
      itemID = historyTable.Rows[e.RowIndex][0].ToString();
      labelAddress.Text = historyTable.Rows[e.RowIndex][4].ToString();
      labelComment.Text = historyTable.Rows[e.RowIndex][9].ToString();
      labelMaidName.Text = historyTable.Rows[e.RowIndex][10].ToString();
      maidImage.Image = new Bitmap(historyTable.Rows[e.RowIndex][11].ToString());
      if (historyTable.Rows[e.RowIndex][13].ToString() != "-")
      {
        receiptImage.Image = new Bitmap(historyTable.Rows[e.RowIndex][13].ToString());
      }
      else
      {
        receiptImage.Image = null;
      }
    }

    private void receiptImage_Click(object sender, EventArgs e)
    {

    }

    string checkBtnDelName = null;
    private void btnDel_Click(object sender, EventArgs e)
    {
      if (((Button)sender).Text == "ลบทั้งหมด")
      {
        TitleDelete.Text = "คุณต้องการที่จะลบทั้งหมดใช่หรือไม่";
      }
      else
      {
        TitleDelete.Text = "คุณต้องการที่จะลบใช่หรือไม่";
      }
      if (panelDelete.Visible == true && (((Button)sender).Text) == checkBtnDelName) { panelDelete.Visible = false; }
      else { panelDelete.Visible = true; }
      checkBtnDelName = ((Button)sender).Text;
    }

    private void btnNoDel_Click(object sender, EventArgs e)
    {
     panelDelete.Visible = false;
    }

    private void btnYesDel_Click(object sender, EventArgs e)
    {
      conn.Open();
      string sql;
      if (checkBtnDelName == "ลบ")
      {
        sql = $"DELETE FROM history WHERE id = '{itemID}'";
        MessageBox.Show("ลบเรียบร้อย");
      }
      else
      {
        sql = $"DELETE FROM history WHERE email = '{Main.mainDataTable.Rows[0][2]}'";
        MessageBox.Show("ลบทั้งหมดเรียบร้อย");
      }
      var cmd = new MySqlCommand(sql, conn);
      cmd.ExecuteNonQuery();
      conn.Close();
      History history = new History();
      history.Show();
      this.Close();
    }

        private void wallpaper_Click(object sender, EventArgs e)
        {

        }
    }
}
