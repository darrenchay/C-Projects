using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace FlightTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            string date;
            Console.WriteLine("Get Arrival or Departure Date?(press 1 for arrival and 2 for departure)");
            choice = Console.Read();
            var test = new Program();
            date = test.getTime(choice);
            Console.WriteLine(date);
        }

        private string getTime(int choice)
        {
            string datestr ="";
            DateTime date;
            String connectionstr;
            SqlConnection sqlconn;
            SqlCommand sqlCommand;
            SqlDataReader dataReader;
            string flight = "1";

            connectionstr = @"Server=(local);DataBase=Flights;Integrated Security=SSPI";
            sqlconn = new SqlConnection(connectionstr);
            sqlconn.Open();
            sqlCommand = new SqlCommand("Select TimeDepart from flight where flightNo = 1", sqlconn);
/*            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@flightNo", flight));*/

            dataReader = sqlCommand.ExecuteReader();

            dataReader.Read();
            
            if (choice == 1)
            {
                datestr = dataReader.GetValue(0).ToString();
            }
            else if (choice == 2)
            {
                datestr = dataReader.GetValue(1).ToString();
            }
            Console.WriteLine(datestr);
            Console.WriteLine("test");
            //date = Convert.ToDateTime(datestr);
            sqlconn.Close();
            return datestr;
        }
    }
}
