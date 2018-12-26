using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortArray
{
    class Program
    {
        public void BubbleSort(int[] dizi)
        {
            int gecici;

            for (int i = 0; i <= dizi.Length - 1; i++)
            {
                for (int j = 1; j <= dizi.Length - 1; j++)
                {
                    if (dizi[j - 1] > dizi[j])
                    {
                        gecici = dizi[j - 1];
                        dizi[j - 1] = dizi[j];
                        dizi[j] = gecici;
                    }
                }
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
                A[i]=(Convert.ToInt32(reader["degerler"].ToString()));
                i++;
            }
           
            Program s = new Program();
            s.BubbleSort(A);
        }
    }
}
