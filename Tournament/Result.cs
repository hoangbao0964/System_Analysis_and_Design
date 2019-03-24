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
    public partial class Result : Form
    {
        SqlConnection cnn = new SqlConnection((@"Data Source=Demon-PC;Initial Catalog=tournament;Integrated Security=True"));
       public Result(string str,string str2,string str3,string str4)
        {
            InitializeComponent();
            textBox1.Text = str3;
            textBox2.Text = str4;
        }
    }
}
