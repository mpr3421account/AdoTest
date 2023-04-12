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
    }
}