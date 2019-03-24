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
    public partial class BangThiDau : Form
    {
        SqlConnection cnn = new SqlConnection((@"Data Source=Demon-PC;Initial Catalog=tournament;Integrated Security=True"));
        int intPoint1, intPoint2, intPoint3, intPoint4, intPointWin1, intPointWin2;
        public BangThiDau(string str,string str2)
        {
            InitializeComponent();
            label4.Text = str2;
            label3.Text = str;
        }

      
        private void capnhapdiem()
        {
        
            if (Point1.Text == "" || Point2.Text == "")
            {

            }
            else
            {
                intPoint1 = int.Parse(Point1.Text.ToString());
                intPoint2 = int.Parse(Point2.Text.ToString());
                if (intPoint1 < intPoint2)
                {
                    txtWin1.Text = txtTeam2.Text;
                }
                else
                {
                    if (intPoint1 > intPoint2)
                    {
                        txtWin1.Text = txtTeam1.Text;
                    }
                    else
                    {
                    }

                }
            }

            if (Point3.Text == "" || Point4.Text == "")
            {

            }
            else
            {
                intPoint3 = int.Parse(Point3.Text.ToString());
                intPoint4 = int.Parse(Point4.Text.ToString());
                if (intPoint3 < intPoint4)
                {
                    txtWin2.Text = txtTeam4.Text;
                }
                else
                {
                    if (intPoint3 > intPoint4)
                    {
                        txtWin2.Text = txtTeam3.Text;
                    }
                    else
                    {
                    }

                }
            }
        }
        private void Point1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void them_sua(TextBox a, TextBox b,string c)
        {
            if(a.Text == "")
            {
                cnn.Open();
                string sql = "select * from point where TName like '" + b.Text + "'";
                SqlCommand com = new SqlCommand(sql, cnn);
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                adap.Update(dt);
                if(dt.Rows.Count ==0)
                {
                    cnn.Close();
                }
                else
                {
                    cnn.Close();
                }
            }
            else
            {
                cnn.Open();
                string sql = "select * from point where Keys Like'"+label4.Text+"' and TName like '" + b.Text + "' and Round like '"+c+"'";
                SqlCommand com = new SqlCommand(sql, cnn);
                SqlDataAdapter adap = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                adap.Update(dt);
                if(dt.Rows.Count==0)
                {
                    string sql2 = "Insert into point values(@Keys,@TName,@Round,@Point)";
                    SqlCommand com2 = new SqlCommand(sql2, cnn);
                    com2.Parameters.AddWithValue("Keys",label4.Text);
                    com2.Parameters.AddWithValue("TName", b.Text);
                    com2.Parameters.AddWithValue("Round", c);
                    com2.Parameters.AddWithValue("Point", a.Text);
                    SqlDataAdapter adap2 = new SqlDataAdapter(com2);
                    DataTable dt2 = new DataTable();
                    adap2.Fill(dt2);
                    adap.Update(dt2);
                    cnn.Close();
                }
                else
                {
                    string sql3 = "Update Point set Point = @Point where Keys = @Keys and TName = @TName and Round = @Round";
                    SqlCommand com3 = new SqlCommand(sql3, cnn);
                    com3.Parameters.AddWithValue("Keys", label4.Text);
                    com3.Parameters.AddWithValue("TName", b.Text);
                    com3.Parameters.AddWithValue("Round", c);
                    com3.Parameters.AddWithValue("Point", a.Text);
                    SqlDataAdapter adap2 = new SqlDataAdapter(com3);
                    DataTable dt3 = new DataTable();
                    adap2.Fill(dt3);
                    dataGridView1.DataSource = dt3;
                    cnn.Close();
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            them_sua(Point1,txtTeam1,"1");
            them_sua(Point2, txtTeam2, "1");
            them_sua(Point3, txtTeam3, "1");
            them_sua(Point4, txtTeam4, "1");
            them_sua(PointWin1, txtWin1, "2");
            them_sua(PointWin2, txtWin2, "2");
            MessageBox.Show("Thành Công!");
            this.Hide();
            
            
        }
        private void test(TextBox b,TextBox a,string c)
        {
            cnn.Open();
            string sql2 = "Select * from point Where Keys like '" + label4.Text + "' and Round like '"+c+"' and TName like'" + b.Text + "'";
            SqlCommand com = new SqlCommand(sql2, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new SqlDataAdapter(com);
            DataTable dt10 = new DataTable();
            da1.Fill(dt10);
            da1.Update(dt10);
            if (dt10.Rows.Count == 0)
            {
                a.Text = "";
                cnn.Close();
            }
            else
            {
                dataGridView2.DataSource = dt10;
                a.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
            }
            cnn.Close();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        //Nhap vao textbox kết quả chỉ số
        //
        private void textBox(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void BangThiDau_Load(object sender, EventArgs e)
        {
            button2.Hide();
            label4.Hide();       
            cnn.Open();
            string sql2 = "Select * from team Where Keys like '" + label4.Text + "'";
            SqlCommand com2 = new SqlCommand(sql2, cnn);
            com2.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com2);
            DataTable dt3 = new DataTable();
            da.Fill(dt3);
            dataGridView1.DataSource = dt3;
            txtTeam1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            txtTeam2.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
            txtTeam3.Text = dataGridView1.Rows[2].Cells[1].Value.ToString();
            txtTeam4.Text = dataGridView1.Rows[3].Cells[1].Value.ToString();
            cnn.Close();
            capnhapdiem();
            test(txtTeam1, Point1,"1");
            test(txtTeam2, Point2,"1");
            test(txtTeam3, Point3,"1");
            test(txtTeam4, Point4,"1");
            capnhapdiem();
            test(txtWin1, PointWin1,"2");
            test(txtWin2,PointWin2,"2");


            if (PointWin1.Text == "" || PointWin2.Text == "")
            {

            }
            else
            {
                button2.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            capnhapdiem();
        }
   

     
        

        
    }
}
