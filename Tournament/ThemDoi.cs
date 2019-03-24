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
    public partial class ThemDoi : Form
    {
        //ket noi sql
        SqlConnection cnn = new SqlConnection((@"Data Source=Demon-PC;Initial Catalog=tournament;Integrated Security=True"));
        //
        int a;
        public void them()
        {
            cnn.Open();
            string sql1 = "SELECT * FROM team where Keys Like '"+txtMaGiai.Text+"' and TName Like '" + txtTName.Text + "'";
            SqlCommand com1 = new SqlCommand(sql1, cnn);
            com1.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(com1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            if (dt1.Rows.Count == 0)
            {
                string sql = "Insert into team values(@Keys,@TName)";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.Parameters.AddWithValue("Keys", txtMaGiai.Text);
                com.Parameters.AddWithValue("TName", txtTName.Text);
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable dt2 = new DataTable();
                adap.Fill(dt2);
                cnn.Close();
                MessageBox.Show("Complete!!!");
                this.Close();
            }
            else
            {
                MessageBox.Show("The Team name is already exits !!! ");
                cnn.Close();
            }
        }
        public void test()
        {
            string sql3 = "SELECT * FROM tournament where Keys Like '" + txtMaGiai.Text + "'";
            SqlCommand com3 = new SqlCommand(sql3, cnn);
            com3.CommandType = CommandType.Text;
            SqlDataAdapter da3 = new SqlDataAdapter(com3);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
            if (dataGridView1.Rows[0].Cells[1].Value.ToString()== "4 Teams")
            {
                a = 4;
            }
            if (dataGridView1.Rows[0].Cells[1].Value.ToString() == "8 Teams")
            {
                a = 8;
            }
            if (dataGridView1.Rows[0].Cells[1].Value.ToString() == "16 Teams")
            {
                a = 16;
            }


            ///////////////////////////////
            string sql = "Select * from team where keys like '"+txtMaGiai.Text+"'";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.Parameters.AddWithValue("Keys", txtMaGiai.Text);
            com.Parameters.AddWithValue("TName", txtTName.Text);
            SqlDataAdapter adap = new SqlDataAdapter(com);
            DataTable dt2 = new DataTable();
            adap.Fill(dt2);
            if (dt2.Rows.Count >= a)
            {
                MessageBox.Show("Đã đủ đội!!!");
            }
            else
            {
                them();
            }

        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public ThemDoi(string str, string str2,string str3)
        {
            InitializeComponent();
            txtTName.Text = str2;
            txtTenGiai.Text = str;
            txtMaGiai.Text = str3;
        }

        private void ThemDoi_Load(object sender, EventArgs e)
        {
            txtMaGiai.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtTName.Text == "" || txtTenGiai.Text == "" || txtPName.Text == "" || txtKitNum.Text == "")
            {
                MessageBox.Show("Please input information !!! ");
                cnn.Close();
            }
            else
            {
                cnn.Open();
                string sql1 = "SELECT * FROM player where Keys Like '" + txtMaGiai.Text +"' and TName like '" +txtTName.Text+
                            "' and  KitNum Like '" + txtKitNum.Text + "'";
                SqlCommand com1 = new SqlCommand(sql1, cnn);
                com1.CommandType = CommandType.Text;
                SqlDataAdapter da1 = new SqlDataAdapter(com1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count == 0)
                {
                    string sql = "Insert into player values(@Keys,@TName,@PName,@KitNum)";
                    SqlCommand com = new SqlCommand(sql, cnn);
                    com.Parameters.AddWithValue("Keys", txtMaGiai.Text);
                    com.Parameters.AddWithValue("TName", txtTName.Text);
                    com.Parameters.AddWithValue("PName", txtPName.Text);
                    com.Parameters.AddWithValue("KitNum", txtKitNum.Text);
                    SqlDataAdapter adap = new SqlDataAdapter(com);
                    DataTable dt2 = new DataTable();
                    adap.Fill(dt2);
                    cnn.Close();
                    MessageBox.Show("Complete!!!");
                    txtPName.Text = "";
                    txtKitNum.Text = "";
                }
                else
                {
                    MessageBox.Show("The Player is already exits !!! ");
                    cnn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
