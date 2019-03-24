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
    public partial class QuanLy : Form
    {
        SqlConnection cnn = new SqlConnection((@"Data Source=Demon-PC;Initial Catalog=tournament;Integrated Security=True"));

        public QuanLy(string str,string str2)
        {
            InitializeComponent();
            label2.Text = str2;//tengiai
            label3.Text = str;//magiai
        }
        
        private void QuanLy_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //Mo Form Thong Tin
            Hide();
            using (ThongTin form = new ThongTin(label2.Text, label3.Text))
                form.ShowDialog();
            Show();
            //
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
           
            string sql2 = "Select * from team Where Keys like '" + label3.Text + "'";
            SqlCommand com2 = new SqlCommand(sql2, cnn);
            com2.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com2);
            DataTable dt3 = new DataTable();
            da.Fill(dt3);
            //Mo Form BangThiDau(1,2)

            if (dt3.Rows.Count == 4)
            {
                Hide();
                using (BangThiDau form = new BangThiDau(label2.Text, label3.Text))
                    form.ShowDialog();
                Show();
                cnn.Close();
            }
            else if (dt3.Rows.Count == 8)
            {
                Hide();
                using (BangThiDau2 form = new BangThiDau2(label2.Text, label3.Text))
                    form.ShowDialog();
                Show();
                cnn.Close();

            }
            else if (dt3.Rows.Count == 16)
            {
                Hide();
                using (BangThiDau3 form = new BangThiDau3(label2.Text, label3.Text))
                    form.ShowDialog();
                Show();
                cnn.Close();
            }
            else
            {
                MessageBox.Show("Chưa đủ số đội !!");
            }

        }
        int a = 0;
        string temp = "";
        string temp2 = "";
        private void buttonResult_Click(object sender, EventArgs e)
        {

            string sql2 = "Select * from point Where Keys like '" + label3.Text + "'";
            SqlCommand com2 = new SqlCommand(sql2, cnn);
            com2.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com2);
            DataTable dt3 = new DataTable();
            da.Fill(dt3);
            //Mo Form BangThiDau(1,2)

            if (dt3.Rows.Count == 6)
            {
                dataGridView1.DataSource = dt3;
                a = int.Parse(dataGridView1.Rows[4].Cells[3].Value.ToString());
                temp = dataGridView1.Rows[4].Cells[1].Value.ToString();
                temp2 = dataGridView1.Rows[5].Cells[1].Value.ToString();
                if (a < int.Parse(dataGridView1.Rows[5].Cells[3].Value.ToString()))
                {
                    a = int.Parse(dataGridView1.Rows[5].Cells[3].Value.ToString());
                    temp = dataGridView1.Rows[5].Cells[1].Value.ToString();
                    temp2 = dataGridView1.Rows[4].Cells[1].Value.ToString();
                }
                Hide();
                using (Result form = new Result(label2.Text, label3.Text,temp,temp2))
                    form.ShowDialog();
                Show();
                cnn.Close();
            }
            else if (dt3.Rows.Count == 14)
            {
                dataGridView1.DataSource = dt3;
                a = int.Parse(dataGridView1.Rows[12].Cells[3].Value.ToString());
                temp = dataGridView1.Rows[12].Cells[1].Value.ToString();
                temp2 = dataGridView1.Rows[13].Cells[1].Value.ToString();
                if (a < int.Parse(dataGridView1.Rows[13].Cells[3].Value.ToString()))
                {
                    a = int.Parse(dataGridView1.Rows[13].Cells[3].Value.ToString());
                    temp = dataGridView1.Rows[13].Cells[1].Value.ToString();
                    temp2 = dataGridView1.Rows[12].Cells[1].Value.ToString();
                }
                Hide();
                using (Result form = new Result(label2.Text, label3.Text, temp, temp2))
                    form.ShowDialog();
                Show();
                cnn.Close();

            }
            else if (dt3.Rows.Count == 30)
            {
                dataGridView1.DataSource = dt3;
                a = int.Parse(dataGridView1.Rows[4].Cells[3].Value.ToString());
                temp = dataGridView1.Rows[4].Cells[1].Value.ToString();
                temp2 = dataGridView1.Rows[5].Cells[1].Value.ToString();
                if (a < int.Parse(dataGridView1.Rows[5].Cells[3].Value.ToString()))
                {
                    a = int.Parse(dataGridView1.Rows[5].Cells[3].Value.ToString());
                    temp = dataGridView1.Rows[5].Cells[1].Value.ToString();
                    temp2 = dataGridView1.Rows[4].Cells[1].Value.ToString();
                }
                Hide();
                using (Result form = new Result(label2.Text, label3.Text, temp, temp2))
                    form.ShowDialog();
                Show();
                cnn.Close();
            }
            else
            {
                MessageBox.Show("Giải Đấu Chưa Hoàn Tất !!");
            }
        }
    }
}
