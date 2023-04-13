using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AdoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void sqlCon_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source=localhost;Initial Catalog=Cliente01;User ID=sa;Password=zaqmko21@;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            sqlCon.Open();

            MessageBox.Show("Open SQL Connection");

            sqlCon.Close();
        }

        private void mySqlCon_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlCon = new MySqlConnection();
            mySqlCon.ConnectionString = "Server=127.0.0.1;Port=3306;Database=Cliente01;Uid=root;Pwd=zaqmko21@;";
            mySqlCon.Open();

            MessageBox.Show("Open Mysql Connection");

            mySqlCon.Close();
        }



        private void sqlList_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection();

            string connection = "Data Source=localhost;Initial Catalog=Cliente01;User ID=sa;Password=zaqmko21@;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            sqlCon.ConnectionString = connection;

            sqlCon.Open();

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from Produtos";
            sqlCommand.Connection = sqlCon;




            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string nome = reader.GetString(0);
                string cor = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);

                listBox1.Items.Add($"{reader.GetInt32(2)}, {nome}, {cor}");
            }

            sqlCon.Close();
        }

        private void mySqlList_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlCon = new MySqlConnection();
            mySqlCon.ConnectionString = "Server=127.0.0.1;Port=3306;Database=Cliente01;Uid=root;Pwd=zaqmko21@;";
            mySqlCon.Open();

            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.CommandText = "select * from Produtos";
            mySqlCommand.Connection = mySqlCon;

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            while (mySqlDataReader.Read())
            {
                string nome = mySqlDataReader.GetString(1);
                string cor = mySqlDataReader.IsDBNull(2) ? String.Empty : mySqlDataReader.GetString(2);

                listBox2.Items.Add($"{mySqlDataReader.GetInt32(0)}, {nome}, {cor}");
            }

            mySqlCon.Close();
        }
    }
}