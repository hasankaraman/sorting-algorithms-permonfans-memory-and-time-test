using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSortList
{
    class Program
    {
        static void Main(string[] args)
        {

            string connStr = "Data Source=DESKTOP-AEHI9NI\\SQLEXPRESS;Initial Catalog=SortingAlgorithms;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connStr;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            int Arrayvalue = Convert.ToInt32(args[0]);
            List<int> selection = new List<int>();
            string query = "Select degerler from tbldeger";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               selection.Add(Convert.ToInt32(reader["degerler"].ToString()));

            }



            for (int i = 0; i < Arrayvalue - 1; i++)
            {
                for (int j = i + 1; j < Arrayvalue; j++)
                {
                    if (selection[(j)] < selection[(i)])
                    {
                        int degistir = selection[(j)];
                        selection[(j)] = selection[(i)];
                        selection[(i)] = degistir;
                    }

                }
            }
        }
    }
}
