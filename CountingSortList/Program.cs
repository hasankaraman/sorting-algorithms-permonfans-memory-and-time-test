using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSortList
{
    class Program
    {
        public int[] CountingSort(List<int> array)
        {
            int[] sortedArray = new int[array.Count];

            // find smallest and largest value
            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Count; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            // init array of frequencies
           
            int[] counts = new int[maxVal - minVal + 1];


            // init the frequencies
            for (int i = 0; i < array.Count; i++)
            {
                counts[array[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = array.Count - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }

            return sortedArray;
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
            s.CountingSort(A);
        }
    }
}
