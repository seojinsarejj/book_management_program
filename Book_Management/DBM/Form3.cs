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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source=2019SEOJIN;Initial Catalog=project_M;Integrated Security=True");
            sqlcon.Open();

            using (var cmd = new SqlCommand(@"INSERT INTO dbo.account 
           (id,password,email,name,phone) VALUES
           (@value1, @value2, @value3,@value6, @value7) ", sqlcon))
            {
                cmd.Parameters.AddWithValue("@value1", idmakingbox.Text);
                cmd.Parameters.AddWithValue("@value2", pwmakingbox.Text);
                cmd.Parameters.AddWithValue("@value3", emailmakingbox.Text);
                cmd.Parameters.AddWithValue("@value6",  namemakingbox.Text);
                cmd.Parameters.AddWithValue("@value7", phonemakingbox.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("가입이 완료되었습니다");

                Form1 form1 = new Form1();
                form1.Show();

            }


        }

        private void phonemakingbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
