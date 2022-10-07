using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_Project
{
  public partial class Menu : Form
  {
    public Menu()
    {
      InitializeComponent();
    }

    private void btnBack2Main_Click(object sender, EventArgs e)
    {
      Main main = new Main();
      main.Show();
      this.Close();
    }

    //คลิกแล้วเด้งไปยังหน้า maid_Status หรือหน้าทำการจองแม่บ้าน
    private void btnMenu1_Click(object sender, EventArgs e)
    {
      Maid_status maid_Status = new Maid_status();
      maid_Status.Show();
      this.Close();
    }

    private void Menu_Load(object sender, EventArgs e)
    {
      if (Main.mainDataTable.Rows[0][2].ToString() == Main.adminEmail) // email ที่ login 
      {
        panelUser.Visible = false; 
        labelUser.Text = $"Admin : {Main.mainDataTable.Rows[0][1]}";
      }
      else //หากไม่ใช่อีเมลของแอดที่ล็อกอินเข้ามา ก็จะเข้าใช้งานเฉพาะของผู้ใช้บริการทั่วไป
      {
        panelUser.Visible = true;
        labelUser.Text = $"username : {Main.mainDataTable.Rows[0][1]}";
      }
    }
    // schedule หรือหน้าทำตาราง/แก้ไขการจอง
    private void pictureBox2_Click(object sender, EventArgs e)
    {
        Schedule schedule = new Schedule();
      schedule.Show();
      this.Close();
    }

    //ประวัติเฉพาะของ email คนนั้น
    private void btnHistory_Click(object sender, EventArgs e)
    {
      History history = new History();
      history.Show();
      this.Close();
    }

    // เฉพาะแอดมินเท่านั้น
    private void btnAdminMenu1_Click(object sender, EventArgs e)
    {
     Admin_Editor admin_Editor = new Admin_Editor();
      admin_Editor.Show();
      this.Close();
    }
    //เฉพาะแอดมินเท่านั้น
    private void btnAdminMenu2_Click(object sender, EventArgs e)
    {
        MaidForm maidForm = new MaidForm();
      maidForm.Show();
      this.Close();
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
