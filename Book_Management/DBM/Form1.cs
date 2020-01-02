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

namespace DBM
{



    public partial class Form1 : Form
    {
        String acc;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source=2019SEOJIN;Initial Catalog=project_M;Integrated Security=True");
     

            
            

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {



            SqlConnection sqlcon = new SqlConnection(@"Data Source=2019SEOJIN;Initial Catalog=project_M;Integrated Security=True");
            sqlcon.Open();
            string query = " Select password from dbo.account where id =" + idbox.Text ;
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            SqlCommand cmd = new SqlCommand(query, sqlcon);

            cmd.Connection = sqlcon;

            if (idbox.Text == "")
            {
                MessageBox.Show("아이디를 다시 확인해주세요");
            }
            else
            {

                cmd.CommandText = "Select password from dbo.account where id =  '" + idbox.Text+ "'" ;


                object scalarValue = cmd.ExecuteScalar();

                if (scalarValue == null)
                {
                    MessageBox.Show("아이디를 다시 확인해주세요");
                }
                else
                {
                    String Pwd = scalarValue.ToString();

                    if (Pwd == pwbox.Text)
                    {
                        
                        Form2 form2 = new Form2();
                        form2.Show();
                        form2.Passvalue = idbox.Text;
                        
                    }
                    else
                    {
                        MessageBox.Show("잘못된 계정입니다.");
                    }

                }

            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
