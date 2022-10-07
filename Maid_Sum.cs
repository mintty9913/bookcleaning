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
  public partial class Maid_Sum : Form
  {
    public Maid_Sum()
    {
      InitializeComponent();
    }
    MySqlConnection conn = new MySqlConnection("host=localhost;user=root;password=;database=project_mild");
    DataTable maidSumDataTable;

    private void database(string sql)
    {
      conn.Open();
      var cmd = new MySqlCommand(sql, conn); 
      DataTable dt = new DataTable();
      new MySqlDataAdapter(cmd).Fill(dt);
      conn.Close();
      maidSumDataTable = dt;
      maidSumData.DataSource = dt;
    }
    private void Maid_Sum_Load(object sender, EventArgs e)
    {
      //ทำการดึงข้อมูลมาจาก Table maid_summary ของแม่บ้านคนนั้น
      database($"SELECT * FROM maid_summary WHERE maidName = '{MaidForm.fullMaidName}'");

      if (maidSumDataTable.Rows.Count > 0) //ทำการเช็กว่าแม่บ้านคนนั้นมีข้อมูลหรือไม่หากมีก็จะทำงานดึงข้อมูลมาใส่ในแต่ละ label ที่กำหนด
      {
        itemkey = maidSumDataTable.Rows[0][0].ToString(); 
        labelMaidName.Text = maidSumDataTable.Rows[0][1].ToString(); // label ชื่อ นามสกุล
        maidPic.Image = new Bitmap(maidSumDataTable.Rows[0][2].ToString());// label รูปภาพ
        sum(); // ยังติดส่วนของการหัก 20% จากรายได้แม่บ้าน
      }
      else //หากไม่มีข้อมูลแม่บ้านก็จะให้ค่าเป็นค่าว่างเปล่า
      {
        itemkey = "0";
        labelMaidName.Text = "-";
        maidPic.Image = null;
      }
 
    }

    string itemkey;
    int rows;

    private void btnBack_Click(object sender, EventArgs e) //ปุ่มย้อนกลับ
    {
     MaidForm  maidForm = new MaidForm();
      maidForm.Show();
      this.Close();
    }

    
    double result;
    private void sum() //ส่วนของการคำนวน
    {
      int totalprice = 0;
      for (int i = 0; i < maidSumDataTable.Rows.Count; i++) //ทำการวนหลูบใน Data แล้วรวมราคาเงินทั้งหมด
      {
        totalprice += Convert.ToInt32(maidSumDataTable.Rows[i][4]); //ทำการบวกทีละค่า
      }
      result = 20.0 / 100.0 * Convert.ToDouble(totalprice); // นุ้งหารไม่ด้ายยยยยยตรงนี้ที่มีปัญหา
      labelTotal.Text = $"{totalprice} บาท"; //แสดงผลเงินรวม
            labelAdminPrice.Text = $"แอดมินจะได้ {result} บาท";
      labelResult.Text = $"จะเหลือ {Convert.ToDouble(totalprice - result):f2} บาท"; // ส่วนของแสดงผลจำนวนเหลือหลังจากหลัก 20%
    }
    private void maidSumData_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      rows = e.RowIndex;
      itemkey = maidSumDataTable.Rows[e.RowIndex][0].ToString();

      labelMaidName.Text = maidSumDataTable.Rows [e.RowIndex][1].ToString(); //เมื่อคลิก label Name ข้อมูลจะเป็นข้อมูลชื่อแสดงตามที่เราเลือก
      maidPic.Image = new Bitmap(maidSumDataTable.Rows[e.RowIndex][2].ToString()); // รูปของแม่บ้านที่เราเลือก
    }
       //เมื่อทำการกดปุ่ม เลือกทั้งหมด จะทำในส่วนนี้ 
    private void rbtnAll_CheckedChanged(object sender, EventArgs e)
    {
      database("SELECT * FROM maid_summary"); // RadioButton สำหรับเลือกทั้งหมดจะดึงข้อมูลทั้งหมดโดยไม่ต้องใส่ WHERE
      sum(); //ฟังชั่นสำหรับคำนวน20%
    }

        //เมื่อทำการกดปุ่ม เฉพาะที่เลือก จะทำในส่วนนี้ 
        private void rbtnSingle_CheckedChanged(object sender, EventArgs e)
    {
      database($"SELECT * FROM maid_summary WHERE maidName = '{MaidForm.fullMaidName}'"); // RadioButton สำหรับเลือกเฉพาะข้อมูลของแม่บ้านนั้น
      sum();
    }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            //ในส่วนของการค้นหาจะทำการดึงข้อมูลทั้งหมดที่คล้ายกันโดยอ้างอิงคอลัมน์ maidName หรือ Email มาแสดงผล
            database($"SELECT * FROM maid_summary WHERE maidName LIKE '%{tbxSearch.Text.Trim()}%' OR email LIKE '%{tbxSearch.Text.Trim()}%'");
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
