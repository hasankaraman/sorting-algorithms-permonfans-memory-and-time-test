using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakerSortList
{
    class Program
    {
        public static void shakerSort(List<int> array)
        {

            for (int i = 0; i < array.Count / 2; i++)
            {

                bool swapped = false;

                for (int j = i; j < array.Count - i - 1; j++)
                {

                    if (array[j] < array[j + 1])
                    {

                        int tmp = array[j];

                        array[j] = array[j + 1];

                        array[j + 1] = tmp;

                        swapped = true;

                    }

                }

                for (int j = array.Count - 2 - i; j > i; j--)
                {

                    if (array[j] > array[j - 1])
                    {

                        int tmp = array[j];

                        array[j] = array[j - 1];

                        array[j - 1] = tmp;

                        swapped = true;

                    }

                }

                if (!swapped) break;

            }

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
            shakerSort(A);
        }
    }
}
