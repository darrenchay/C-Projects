using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFlights
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

        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString;
            SqlConnection sqlcnn;
            SqlCommand sqlcmd;
            SqlDataReader dataReader;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            string Output, sql = "";

            connectionString = @"Server=(local);DataBase=Students;Integrated Security=SSPI";
            sqlcnn = new SqlConnection(connectionString);
            sqlcnn.Open();
            MessageBox.Show("Connection Opened.");
            sql = "Select * From flightPassengers where flightno = 'MK62/MK73'";
            sqlcmd = new SqlCommand(sql, sqlcnn);
            dataReader = sqlcmd.ExecuteReader();

            dataReader.Read();
            Output = dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + " - " + dataReader.GetValue(4) + "\n";

            MessageBox.Show(Output);
            dataReader.Close();
            sqlcmd.Dispose();


            sql = "Insert Into flightPassengers (CustomerName,FlightNo,FlightDate,Destination,Seat) values ('Brian Cheung', 'MK62/MK73', '2019-06-14', 'AMS', 'ECON')";
            sqlcmd = new SqlCommand(sql, sqlcnn);
            dataAdapter.InsertCommand = new SqlCommand(sql, sqlcnn);
            dataAdapter.InsertCommand.ExecuteNonQuery();

            MessageBox.Show("data inserted");
            sqlcmd.Dispose();
            sqlcnn.Close();
        }
    }
}
