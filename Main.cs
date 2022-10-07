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
 public partial class Main : Form
 {
  public Main()
  {
   InitializeComponent();
  }
    public static string adminEmail = "mildsasikanya9913@gmail.com"; //สร้างอีเมลของแอดมินไว้สำหรับจัดการข้อมูลของแอดมิน
    MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project_mild");
    public static DataTable mainDataTable;//สร้าง dataTable ตัวนี้ไว้เพื่อที่ทุก function จะสามารถเรียกใช้ข้อมูลที่ดึงมาได้
    private void database(string sql) // ดึงข้อมูลมาจาก database ที่เราต้องการ
    {
      con.Open();
      var cmd = new MySqlCommand(sql, con);
      DataTable dt = new DataTable();
      new MySqlDataAdapter(cmd).Fill(dt); // โดยเราจะดึงข้อมูลทั้งหมดมาเก็บไว้ในตัวแปล DataTable ที่มีชื่อว่า dt
      mainDataTable = dt; //ให้ DataGridView มีค่าที่จะไปแสดงเท่ากับข้อมูลที่เราดึงมา
      con.Close();
    }
  private void btnLogin_Click(object sender, EventArgs e)
  {
      
      if (tbxEmail.Text.Trim() != "" && tbxPw.Text.Trim() != "")  //ทำการเช็กทุกช่องว่าต้องไม่เท่ากับช่องว่าง
      {
        database($"SELECT * FROM account WHERE email = '{tbxEmail.Text}'");
        if (mainDataTable.Rows.Count > 0) 
        {
          if (tbxPw.Text.Trim() == mainDataTable.Rows[0][3].ToString()) 
          {
            MessageBox.Show($"ยินดีต้อนรับคุณ {mainDataTable.Rows[0][1]}");
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.Show();
          }
          else 
          {
            MessageBox.Show("รหัสผ่านไม่ถูกต้อง");
          }
        }
        else
        {
          MessageBox.Show("ไม่พบบัญชีของคุณ");
        }

      }
      else
      {
        MessageBox.Show("กรุณากรอกให้ครบทุกช่อง");
      }

      
  }

  private void Main_Load(object sender, EventArgs e)
  {
     
  }

    private void btnCancelReg_Click(object sender, EventArgs e)
    {
     panelRegister.Visible = false; //เมื่อกดปุ่ม Cancel ในหน้าสมัครใช้งาน หน้าสมัครใช้งานจะถูกซ่อน
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
      panelRegister.Visible = true; //เมื่อกดปุ่มสมัครใช้งานในหน้า Login หน้าสมัครใช้งานจะถูกแสดงขึ้น
    }

    private void btnOkReg_Click(object sender, EventArgs e)
    {
     if (tbxUsernameReg.Text.Trim() != "" && tbxEmailReg.Text.Trim() != "" &&
        tbxPwReg.Text.Trim() != "" && tbxCfmPwReg.Text.Trim() != "") // เช็กว่ากรอกครบทุกช่องหรือยัง
      {
        if (tbxUsernameReg.Text.Trim().Length >= 5 && tbxUsernameReg.Text.Trim().Length <= 20) //เช็กว่าตัวอักษรของusernameมากกว่า 4 และน้อยกว่า 21 หรือไม่
        {
          if (tbxEmailReg.Text.Contains("@gmail.com") || tbxEmailReg.Text.Contains("@kkumail.com")) 
          {
            database($"SELECT * FROM account WHERE email = '{tbxEmailReg.Text.Trim()}'"); //เช็กว่าอีเมลนี้ถูกใช้งานหรือยัง
            if (mainDataTable.Rows.Count == 0) 
            { 
              if (tbxPwReg.Text.Trim().Length >= 8 && tbxPwReg.Text.Trim().Length <= 20) 
              {
                if (tbxCfmPwReg.Text.Trim() == tbxPwReg.Text.Trim()) 
                {
                  con.Open();
                  var cmd = new MySqlCommand($"INSERT INTO account (username,email,pw) VALUES ('{tbxUsernameReg.Text.Trim()}','{tbxEmailReg.Text.Trim()}','{tbxPwReg.Text.Trim()}')",con);
                  if (cmd.ExecuteNonQuery() > 0)
                  {
                    con.Close();
                    MessageBox.Show("สมัครใช้งานเรียบร้อย");
                    //หลังจากนั้นจะทำการเคลียร์ทุก textbox ในหน้าสมัครใช้งาน
                    tbxUsernameReg.Clear();
                    tbxEmailReg.Clear();
                    tbxPwReg.Clear();
                    tbxCfmPwReg.Clear();
                    panelRegister.Visible = false;
                  }
                  else
                  {
                    MessageBox.Show("ERROR line 102");
                  }
                }
                else
                {
                  MessageBox.Show("กรุณายืนยันรหัสผ่านให้ถูกต้อง");
                }
              }
              else
              {
                MessageBox.Show("รหัสผ่านต้องมี 8 - 20 ตัวเท่านั้น");
              }
            }
            else
            {
              MessageBox.Show("อีเมลนี้ได้ถูกใช้งานไปแล้ว");
            }
          }
          else
          {
            MessageBox.Show("กรุณากรอกอีเมลให้ถูกต้อง");
          }
        }
        else
        {
          MessageBox.Show("ชื่อผู้ใช้ต้องมี 5 - 20 ตัวเท่านั้น");
        }
      }
     else
      {
        MessageBox.Show("กรุณากรอกให้ครบทุกช่อง");
      }
    }

    
    private void button1_Click(object sender, EventArgs e) 
    {
      database("SELECT * FROM account"); //ตรงนี้จะทำการดึงข้อมูลทั้งหมดจาก Table account ไปเก็บไว้ที่ตัวแปร dt
      this.Hide();
      Menu mainMenu = new Menu();
      mainMenu.Show();
    }

    #region test Button
    private void button2_Click(object sender, EventArgs e)
    {
      database($"SELECT * FROM account WHERE username = 'Mild'"); //โดยจะทำการดึงบัญชีของ admin มาใช้เลย
      this.Hide();
      Menu mainMenu = new Menu();
      mainMenu.Show();
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
      //ในส่วนของปุ่ม เปิด/ปิด
        if (button1.Visible && button2.Visible) { button1.Visible = false; button2.Visible = false; }
        else { button1.Visible = true; button2.Visible = true; }
    }
        #endregion

        private void wallpaper_main_Click(object sender, EventArgs e)
        {

        }
    }
}
