using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShakerSortArray
{
    class Program
    {
        public static void shakerSort(int[] array)
        {

            for (int i = 0; i < array.Length / 2; i++)
            {

                bool swapped = false;

                for (int j = i; j < array.Length - i - 1; j++)
                {

                    if (array[j] < array[j + 1])
                    {

                        int tmp = array[j];

                        array[j] = array[j + 1];

                        array[j + 1] = tmp;

                        swapped = true;

                    }

                }

                for (int j = array.Length - 2 - i; j > i; j--)
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
            int[] A = new int[Arrayvalue];
            int i = 0;
            string query = "Select degerler from tbldeger";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                A[i] = (Convert.ToInt32(reader["degerler"].ToString()));
                i++;
            }
            Program s = new Program();
            shakerSort(A);
        }
    }
}
