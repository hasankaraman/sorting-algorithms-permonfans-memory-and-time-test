using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortList
{
    class Program
    {
        public List<int> InsertionSort(List<int> inputArray)
        {
            for (int i = 0; i < inputArray.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }
        static void Main(string[] args)
        {
            string connStr = "Data Source=DESKTOP-AEHI9NI\\SQLEXPRESS;Initial Catalog=SortingAlgorithms;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connStr;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            int Arrayvalue = Convert.ToInt32(args[0]);
            List<int> A = new List<int>();
            string query = "Select degerler from tbldeger";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                A.Add(Convert.ToInt32(reader["degerler"].ToString()));

            }

            Program s = new Program();
            s.InsertionSort(A);
        }
    }
}
