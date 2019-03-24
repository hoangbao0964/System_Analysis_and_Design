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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection((@"Data Source=Demon-PC;Initial Catalog=tournament;Integrated Security=True"));
    
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(400, 250);
            this.MinimumSize = new Size(400, 250);
        }
      
        private void DangNhap_Click(object sender, EventArgs e)
        {
            //Code Dang Nhap
            cnn.Open();
            string sql = "select * from tournament where Keys like '" + txtMaGiai.Text + "'";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("The Input Is Wrong!! ");
            }
            else
            {
                MessageBox.Show("Success!!");
                //Mo Form Quan Ly
                Hide();
                using (QuanLy form = new QuanLy(txtMaGiai.Text,dataGridView1.Rows[0].Cells[2].Value.ToString()))
                    form.ShowDialog();
                Show();
                //
            }
   
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            using (DangKy form3 = new DangKy())
                form3.ShowDialog();
            Show();
        }

       
    }
}
