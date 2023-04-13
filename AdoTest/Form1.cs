using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

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


        private void sqlCon_Click(object sender, EventArgs e)//SQL Connection
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = "Data Source=localhost;Initial Catalog=Cliente01;User ID=sa;Password=zaqmko21@;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            sqlCon.Open();

            MessageBox.Show("Open SQL Connection");

            sqlCon.Close();
        }//SQL Click Connection Test Botton

        private void mySqlCon_Click(object sender, EventArgs e)//MySql Connection
        {
            MySqlConnection mySqlCon = new MySqlConnection();
            mySqlCon.ConnectionString = "Server=127.0.0.1;Port=3306;Database=Cliente01;Uid=root;Pwd=zaqmko21@;";
            mySqlCon.Open();

            MessageBox.Show("Open Mysql Connection");

            mySqlCon.Close();
        }//Mysql Click Connection Test Botton



        private void sqlList_Click(object sender, EventArgs e)//SQL List Data Reader
        {
            SqlConnection sqlCon = new SqlConnection();

            string connection = "Data Source=localhost;Initial Catalog=Cliente01;User ID=sa;Password=zaqmko21@;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            sqlCon.ConnectionString = connection;

            sqlCon.Open();

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
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


        private void mySqlList_Click(object sender, EventArgs e)//Mysql List Data Reader
        {
            MySqlConnection mySqlCon = new MySqlConnection();
            string myConnection = "Server=127.0.0.1;Port=3306;Database=Cliente01;Uid=root;Pwd=zaqmko21@;";
            mySqlCon.ConnectionString = myConnection;

            mySqlCon.Open();

            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.CommandType = CommandType.Text;
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



        private void btnListSQLDataSet_Click(object sender, EventArgs e)//SQL List Data Set
        {
            string sqlConnection = "Data Source=localhost;Initial Catalog=Cliente01;User ID=sa;Password=zaqmko21@;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from Produtos", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void btnListMySqlDataSet_Click(object sender, EventArgs e)//Mysql List Data Set
        {
            string mysqlConnection = "Server=127.0.0.1;Port=3306;Database=Cliente01;Uid=root;Pwd=zaqmko21@;";
            MySqlDataAdapter mySqlData = new MySqlDataAdapter("select * from Produtos", mysqlConnection);
            DataSet dataSet = new DataSet();
            mySqlData.Fill(dataSet);
            dataGridView2.DataSource = dataSet.Tables[0];
        }
    }
}