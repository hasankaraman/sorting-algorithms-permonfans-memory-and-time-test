using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSortList
{
    class Program
    {
        public static LinkedList<int> RadixSort(LinkedList<int> linkedList)
        {
            bool isFinished = false;
            int digitPosition = 0;

            var buckets = new List<Queue<int>>();
            InitializeBuckets(buckets);

            while (!isFinished)
            {
                isFinished = true;

                foreach (int value in linkedList)
                {
                    int bucketNumber = GetBucketNumber(value, digitPosition);
                    if (bucketNumber > 0)
                    {
                        isFinished = false;
                    }

                    buckets[bucketNumber].Enqueue(value);
                }

                var walk = linkedList.First;
                foreach (var bucket in buckets)
                {
                    while (bucket.Count > 0 && walk != null)
                    {
                        walk.Value = bucket.Dequeue();
                        walk = walk.Next;
                    }
                }

                digitPosition++;
            }

            return linkedList;
        }

        public static int GetBucketNumber(int value, int digitPosition)
        {
            int bucketNumber = (value / (int)Math.Pow(10, digitPosition)) % 10;
            return bucketNumber;
        }

        public static void InitializeBuckets(List<Queue<int>> buckets)
        {
            for (int i = 0; i < 10; i++)
            {
                var q = new Queue<int>();
                buckets.Add(q);
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
            LinkedList<int> A = new LinkedList<int>();
            string query = "Select degerler from tbldeger";
            cmd.CommandText = query;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                A.AddLast(Convert.ToInt32(reader["degerler"].ToString()));

            }

            Program s = new Program();
            RadixSort(A);
        }
    }
}
