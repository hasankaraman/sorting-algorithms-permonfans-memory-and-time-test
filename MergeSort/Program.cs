using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        public void MergeSort(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                MergeSort(A, p, q);
                MergeSort(A, q + 1, r);
                Merge(A, p, q, r);
            }
        }
        public void Merge(int[] A, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] L = new int[n1 + 1];
            int[] R = new int[n2 + 1];

            for (int i = 0; i < n1; i++)
                L[i] = A[p + i];

            for (int j = 0; j < n2; j++)
                R[j] = A[q + j + 1];

            L[n1] = Int32.MaxValue;
            R[n2] = Int32.MaxValue;

            int x = 0, y = 0;

            for (int k = p; k <= r; k++)
            {
                if (L[x] <= R[y])
                {
                    A[k] = L[x];
                    x++;
                }
                else
                {
                    A[k] = R[y];
                    y++;
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
                A[i] = (Convert.ToInt32(reader["degerler"].ToString()));
                i++;
            }
            Program s = new Program();
            s.MergeSort(A, 0, Arrayvalue - 1);
        }
    }
}
