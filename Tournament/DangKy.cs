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
    public partial class DangKy : Form
    {
        SqlConnection cnn = new SqlConnection((@"Data Source=Demon-PC;Initial Catalog=tournament;Integrated Security=True"));
        public DangKy()
        {
            InitializeComponent();
        }
        public string MaNgauNhien_SoChu(int codeCount)
        {
            string allChar = "0,1,2,3,4,5,6,7,8,9,  ";
            string[] allCharArray = allChar.Split(',');
            string randomCode = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 0; i < codeCount; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(36);
                if (temp != -1 && temp == t)
                {
                    return MaNgauNhien_SoChu(codeCount);
                }
                temp = t;
                randomCode += allCharArray[t];
            }
            return randomCode;
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            txtMaGiai.Text = MaNgauNhien_SoChu(10);
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (txtMaGiai.Text == "" || txtTenGiai.Text == "" || SoDoi.Text == "")
            {
                MessageBox.Show("Please input information !!! ");
                cnn.Close();
            }
            else
            {
                cnn.Open();
                string sql1 = "SELECT * FROM tournament where Keys Like '" + txtTenGiai.Text + "'";
                SqlCommand com1 = new SqlCommand(sql1, cnn);
                com1.CommandType = CommandType.Text;
                SqlDataAdapter da1 = new SqlDataAdapter(com1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count == 0)
                {
                    string sql = "Insert into tournament values(@Keys,@Type,@Name)";
                    SqlCommand com = new SqlCommand(sql, cnn);
                    com.Parameters.AddWithValue("Keys", txtMaGiai.Text);
                    com.Parameters.AddWithValue("Type", SoDoi.Text);
                    com.Parameters.AddWithValue("Name", txtTenGiai.Text);
                    SqlDataAdapter adap = new SqlDataAdapter(com);
                    DataTable dt2 = new DataTable();
                    adap.Fill(dt2);
                    cnn.Close();
                    MessageBox.Show("Complete!!!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The username is already exits !!! ");
                    cnn.Close();
                }
            }
        }
    }
}
