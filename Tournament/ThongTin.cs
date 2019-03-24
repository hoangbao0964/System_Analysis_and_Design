using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tournament
{
    public partial class ThongTin : Form
    {
     
         public ThongTin(string str,string str2)
        {
            InitializeComponent();
            txtTenGiai.Text = str;
            txtMaGiai.Text = str2;
            label4.Text = str2;
        }
        //ket noi sql
         SqlConnection cnn = new SqlConnection((@"Data Source=Demon-PC;Initial Catalog=tournament;Integrated Security=True"));
        //
        private void test()
        {
            cnn.Open();
            string sql = "Select * from Player Where TName like '" + txtTName.Text + "'";
            SqlCommand com5 = new SqlCommand(sql, cnn);
            com5.CommandType = CommandType.Text;
            SqlDataAdapter da4 = new SqlDataAdapter(com5);
            DataTable dt1 = new DataTable();
            da4.Fill(dt1);
            da4.Update(dt1);
            dataGridView1.DataSource = dt1;
            textBox2.Text = textBox2.Text + dt1.Rows.Count;
            cnn.Close();
        }
         private void buttonSua_Click(object sender, EventArgs e)
         {
             {
                 cnn.Open();
                 string sql2 = "Select * from Tournament Where Keys like '" + txtMaGiai.Text + "'";
                 SqlCommand com2 = new SqlCommand(sql2, cnn);
                 com2.CommandType = CommandType.Text;
                 SqlDataAdapter da = new SqlDataAdapter(com2);
                 DataTable dt3 = new DataTable();
                 da.Fill(dt3);
                 if ((txtMaGiai.Text == "") ||(SoDoi.Text =="" )|| (txtTenGiai.Text == ""))
                 {
                     MessageBox.Show("Please Input Information !!!");
                     cnn.Close();
                 }
                 else
                 {
                    
                     string sql = "Update Tournament set Keys = @Keys,Type = @Type, Name = @Name where Keys = '"+label4.Text+"' ";
                     SqlCommand com = new SqlCommand(sql, cnn);
                     com.Parameters.AddWithValue("Keys", txtMaGiai.Text);
                     com.Parameters.AddWithValue("Type", SoDoi.Text);
                     com.Parameters.AddWithValue("Name", txtTenGiai.Text);
                     SqlDataAdapter adap = new SqlDataAdapter(com);
                     DataTable dt2 = new DataTable();
                     adap.Fill(dt2);
                     MessageBox.Show("Success!!");
                     cnn.Close();
 
                 }
             }
         }

       
        private void ThongTin_Load(object sender, EventArgs e)
         {
      
            label4.Hide();
            cnn.Open();
            string sql1 = "Select * from tournament Where Keys like '" + txtMaGiai.Text + "'";
            SqlCommand com = new SqlCommand(sql1, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            dataGridView1.DataSource = dt;
            SoDoi.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            cnn.Close();

            //
            //
            cnn.Open();
            string sql2 = "Select * from Team Where Keys like '" + txtMaGiai.Text + "'";
            SqlCommand com2 = new SqlCommand(sql2, cnn);
            com2.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com2);
            DataTable dt3 = new DataTable();
            da.Fill(dt3);
            dataGridView1.DataSource = dt3;
            cnn.Close();
            if (dt3.Rows.Count == 0)
            {
                txtTName.Text = "Chua co thong tin";
                textBox2.Text = "Chua co thong tin";
            }
            else
            {
               
                txtTName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                test();
            }
            //
            //
      
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int a = 10001;
        private void buttonnext_Click(object sender, EventArgs e)
        {
            string sql2 = "Select * from Team Where Keys like '" + txtMaGiai.Text + "'";
            SqlCommand com2 = new SqlCommand(sql2, cnn);
            com2.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com2);
            DataTable dt3 = new DataTable();
            da.Fill(dt3);
            dataGridView1.DataSource = dt3;
            txtTName.Text = dataGridView1.Rows[a % (dataGridView1.Rows.Count - 1)].Cells[1].Value.ToString();           
            a = a + 1;
            textBox2.Text = "";
            test();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            txtTName.Text = dataGridView1.Rows[a % (dataGridView1.Rows.Count - 1)].Cells[1].Value.ToString();
            a = a - 1;
            textBox2.Text = "";
            test();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ThemDoi form3 = new ThemDoi(txtTenGiai.Text, txtTName.Text, txtMaGiai.Text);
              form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemDoi form3 = new ThemDoi(txtTenGiai.Text, "", txtMaGiai.Text);
                form3.Show();
          
        }
    }
}
