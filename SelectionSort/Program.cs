using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class Program
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
            int[] A = new int[Arrayvalue];
            int k = 0;
            string query = "Select degerler from tbldeger";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                A[k] = (Convert.ToInt32(reader["degerler"].ToString()));
                k++;
            }

            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[(j)] < A[(i)])
                    {
                        int degistir = A[(j)];
                        A[(j)] = A[(i)];
                        A[(i)] = degistir;
                    }

                }
            }



        }
    }
}
