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




    public partial class Form2 : Form
    {

        private string Form2_value;
        public string Passvalue
        {
            get { return this.Form2_value;  }
            set { this.Form2_value = value; }
        }


        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void whghlbtn_Click(object sender, EventArgs e)
        {

            String acc = Passvalue;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=2019SEOJIN;Initial Catalog=project_M;Integrated Security=True");
            sqlcon.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            cmd.CommandText = "SELECT * FROM dbo.book where id = '" + acc + "'"; 

            //DataAdapter와 DataSet으로 DB table 불러오기
            SqlDataAdapter da = new SqlDataAdapter(cmd); //select 구문이 들어감
            DataSet ds = new DataSet();
            da.Fill(ds, "Student_table");

            //dataGridView에 DB에서 가져온 데이터 입력하기
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Student_table";

            





        }

        private void button2_Click(object sender, EventArgs e)
        {

            String acc = Passvalue;

            SqlConnection sqlcon = new SqlConnection(@"Data Source=2019SEOJIN;Initial Catalog=project_M;Integrated Security=True");
            sqlcon.Open();

            using (var cmd = new SqlCommand(@"INSERT INTO dbo.book 
           (book_id,book_name,author,date,id) VALUES
           (@value1, @value2, @value3,@value6, @value7) ", sqlcon))
            {
                cmd.Parameters.AddWithValue("@value1", bookidbox.Text);
                cmd.Parameters.AddWithValue("@value2", booknamebox.Text);
                cmd.Parameters.AddWithValue("@value3", authorbox.Text);
                cmd.Parameters.AddWithValue("@value6", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@value7", acc);

                cmd.ExecuteNonQuery();
            }

            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source=2019SEOJIN;Initial Catalog=project_M;Integrated Security=True");
            sqlcon.Open();

            string query = " DELETE from dbo.book where book_id = " + bookidbox.Text;
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            SqlCommand cmd = new SqlCommand(query, sqlcon);

            cmd.Connection = sqlcon;


            if (bookidbox.Text != "")
            {
                cmd.ExecuteNonQuery();
            }

        }
    }
}
