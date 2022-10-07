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
  public partial class MaidForm : Form
  {
    public MaidForm()
    {
      InitializeComponent();
    }

    MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=project_mild");
    DataTable maidData = new DataTable();

    private void database(string sql)
    {
      conn.Open();
      var cmd = new MySqlCommand(sql, conn);
      DataTable dt = new DataTable();
      new MySqlDataAdapter(cmd).Fill(dt);
      conn.Close();
      maidData = dt;
      maidTable.DataSource = dt;
    }
    private void btnBack_Click(object sender, EventArgs e)
    {
        Menu mainMenu = new Menu();
      mainMenu.Show();
      this.Close();
    }

    string itemKey;int rows;
        public static string fullMaidName;
    private void maidTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
            btnSummary.Enabled = true;
            btnOk.Enabled = true;


      itemKey = maidData.Rows[e.RowIndex][0].ToString();
      rows = e.RowIndex;
      newFnameMaid.Text = maidData.Rows[e.RowIndex][1].ToString();
      newLnameMaid.Text = maidData.Rows[e.RowIndex][2].ToString();
      cbxStatus.Text = maidData.Rows[e.RowIndex][3].ToString(); 
      newPhone.Text = maidData.Rows[e.RowIndex][4].ToString();
            fullMaidName = $"{newFnameMaid.Text} {newLnameMaid.Text}";

            newEmail.Text = maidData.Rows[e.RowIndex][5].ToString();

      maidPic.Image = new Bitmap(maidData.Rows[e.RowIndex][6].ToString());
      filepathMaid = maidData.Rows[e.RowIndex][6].ToString();
    }


    private void MaidForm_Load(object sender, EventArgs e)
    {
      btnEdit.PerformClick();
      database("SELECT * FROM maid_info");
    }

    string btnTxt;
    private void focusButton(Button clickButton,string txt)
    {
      newFnameMaid.Clear();newLnameMaid.Clear();
      newPhone.Clear();newEmail.Clear(); 

      maidPic.Image = new Bitmap("C:\\Users\\milds\\Desktop\\Project Mild\\Pic\\icon\\add-image.png");
      btnTxt = txt;

      btnEdit.BackColor = Color.Teal;btnEdit.ForeColor = Color.White;
      btnAdd.BackColor = Color.Teal;btnAdd.ForeColor = Color.White;
      btnDel.BackColor = Color.Teal;btnDel.ForeColor = Color.White;
      clickButton.BackColor = Color.PaleTurquoise;clickButton.ForeColor = Color.Teal;
      btnOk.Text = txt;
      if (clickButton.Text == "ลบ")
      {
        newFnameMaid.ReadOnly = true;newLnameMaid.ReadOnly = true;
        newPhone.ReadOnly = true;newEmail.ReadOnly = true;
      }
      else
      {
        newFnameMaid.ReadOnly = false;newLnameMaid.ReadOnly = false;
        newPhone.ReadOnly = false;newEmail.ReadOnly = false;
      }
    }
    private void btnEdit_Click(object sender, EventArgs e)
    {
      focusButton(((Button)sender),"ยืนยันการแก้ไข");
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      focusButton(((Button)sender),"ยืนยันการเพิ่ม");
    }

    private void btnDel_Click(object sender, EventArgs e)
    {
      focusButton(((Button)sender),"ยืนยันการลบ");
    }
    string pathMaid;
    private void btnOk_Click(object sender, EventArgs e)
    {
     if (newFnameMaid.Text.Trim() != "" && newLnameMaid.Text.Trim() != "" && newPhone.Text.Trim() != "" && newEmail.Text.Trim() != "" &&
        cbxStatus.Text != "")
      {
        string editDateTime = DateTime.Now.ToString("dd-MM-yy tt");
        pathMaid = $"C:\\Users\\milds\\Desktop\\Project Mild\\Pic\\maid_pic\\{newFnameMaid.Text.Trim()}.jpg";
        if (File.Exists(pathMaid))
        {
          File.Copy(filepathMaid, $"C:\\Users\\milds\\Desktop\\Project Mild\\Pic\\maid_pic\\({editDateTime}){newFnameMaid.Text.Trim()}.jpg");
          pathMaid = $"C:\\Users\\milds\\Desktop\\Project Mild\\Pic\\maid_pic\\({editDateTime}){newFnameMaid.Text.Trim()}.jpg";
        }
        else
        {
          File.Copy(filepathMaid, $"C:\\Users\\milds\\Desktop\\Project Mild\\Pic\\maid_pic\\{newFnameMaid.Text.Trim()}.jpg");
        }
        conn.Open();
        string sql;
        if (((Button)sender).Text == "ยืนยันการแก้ไข")
        {
          sql = $"UPDATE maid_info SET fname = '{newFnameMaid.Text.Trim()}', lname = '{newLnameMaid.Text.Trim()}'," +
            $" status = '{cbxStatus.Text.Trim()}', phone = '{newPhone.Text.Trim()}', email = '{newEmail.Text.Trim()}'," +
            $"image = '{pathMaid.Replace("\\", "\\\\")}' WHERE id = '{itemKey}';" +
            $"UPDATE booking SET maidName = '{newFnameMaid.Text.Trim()} {newLnameMaid.Text.Trim()}', maidProfile = '{pathMaid.Replace("\\","\\\\")}' WHERE maidName = '{newFnameMaid.Text.Trim()} {newLnameMaid.Text.Trim()}';" +
            $"UPDATE history SET maidName = '{newFnameMaid.Text.Trim()} {newLnameMaid.Text.Trim()}', maidProfile = '{pathMaid.Replace("\\", "\\\\")}' WHERE maidName = '{newFnameMaid.Text.Trim()} {newLnameMaid.Text.Trim()}'";
        }
       else if (((Button)sender).Text == "ยืนยันการเพิ่ม")
        {
          sql = $"INSERT INTO maid_info (fname,lname,status,phone,email,image) VALUES ('{newFnameMaid.Text.Trim()}','{newLnameMaid.Text.Trim()}'," +
            $"'{cbxStatus.Text}','{newPhone.Text.Trim()}','{newEmail.Text.Trim()}','{pathMaid.Replace("\\","\\\\")}')";
        }
        else
        {
          sql = $"DELETE FROM maid_info WHERE id = '{itemKey}';DELETE FROM booking WHERE maidName = '{newFnameMaid.Text.Trim()} {newLnameMaid.Text.Trim()}';" +
            $" DELETE FROM history WHERE maidName = '{newFnameMaid.Text.Trim()} {newLnameMaid.Text.Trim()}'";
          //File.Delete(filepathMaid);
        }
        var cmd = new MySqlCommand(sql, conn);
        if (cmd.ExecuteNonQuery() > 0)
        {
          conn.Close();
          MessageBox.Show($"{btnTxt} เรียบร้อย");
          MaidForm maidForm = new MaidForm();
          maidForm.Show();
          this.Close();
        }
      }
      else
      {
        MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการก่อน");
      }
    }
    string filepathMaid = "C:\\Users\\milds\\Desktop\\Project Mild\\Pic\\icon\\user.png", fileNameReceipt;

    private void tbxSearch_TextChanged(object sender, EventArgs e)
    {
      database($"SELECT * FROM maid_info WHERE fname LIKE '%{tbxSearch.Text}%' OR lname LIKE '%{tbxSearch.Text}%' OR email LIKE '%{tbxSearch.Text}%'");
    }

    private void checkEmpty(object sender,EventArgs e)
    {
      if (newFnameMaid.Text.Trim() != "" && newLnameMaid.Text.Trim() != "" && newPhone.Text.Trim() != "" && newEmail.Text.Trim() != "" && cbxStatus.Text != "")
      {
        btnOk.Enabled = true;
      }
      else
      {
        btnOk.Enabled = false;
      }
    }

        private void wallpeper_Click(object sender, EventArgs e)
        {

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            Maid_Sum ms = new Maid_Sum();
            ms.Show();
            this.Close();
        }

        private void maidPic_Click(object sender, EventArgs e)
    {
      OpenFileDialog open = new OpenFileDialog();
      // image filters  
      open.Filter = "Image Files(.png; *.jpg; *.jpeg; *.gif; *.bmp)|.png; *.jpg; *.jpeg; *.gif; *.bmp";
      if (open.ShowDialog() == DialogResult.OK)
      {
        filepathMaid = open.FileName;
        fileNameReceipt = open.SafeFileName;
        maidPic.Image = new Bitmap(filepathMaid);
      }
    }
  }
}
