using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sortingalgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public static int[] CountingSort(List<int> array)
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
        private void BtnKarsilastir_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Stopwatch stopwatch = new Stopwatch();
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart3.Series)
            {
                series.Points.Clear();
            }

            List<string> sortname = new List<string>();
            List<string> sortmbarray = new List<string>();
            List<string> sortmblist = new List<string>();
            List<string> sorttimearray = new List<string>();
            List<string> sorttimelist = new List<string>();

            List<double> mbarray = new List<double>();
            List<double> mblist = new List<double>();
            List<double> timearray = new List<double>();
            List<double> timelist = new List<double>();

            mbarray.Clear();
            mblist.Clear();
            timearray.Clear();
            timelist.Clear();
            sortmbarray.Clear();
            sortname.Clear();
            sortmblist.Clear();
            sorttimearray.Clear();
            sorttimelist.Clear();
            int valuename = 0;
            int sayi = Convert.ToInt32(txtdeger.Text);
            Random ran = new Random();
            stopwatch.Start();

            string connStr = "Data Source=DESKTOP-AEHI9NI\\SQLEXPRESS;Initial Catalog=SortingAlgorithms;Integrated Security=True";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connStr;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            stopwatch.Stop();
            TimeSpan tsconn = stopwatch.Elapsed;
            stopwatch.Reset();

            string query = "Delete From tbldeger";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            query = "Insert Into tbldeger(degerler) Values('0'),";
            for (int i = 1; i < sayi; i++)
            {
                query += "('" + ran.Next(0, sayi) + "'),";
                if ((i + 1) % 1000 == 0)
                {
                    query = query.Remove(query.Length - 1);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    query = "Insert Into tbldeger(degerler) Values";
                }
            }
            if (query != "Insert Into tbldeger(degerler) Values")
            {
                query = query.Remove(query.Length - 1);
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }


            query = "Select degerler from tbldeger";
            cmd.CommandText = query;

            SqlDataReader reader = cmd.ExecuteReader();
            List<int> b = new List<int>();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["degerler"].ToString());


            }
            reader.Close();

            stopwatch.Start();
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                b.Add((Convert.ToInt32(reader["degerler"].ToString())));

            }


            stopwatch.Stop();
            TimeSpan Tsdatabase = stopwatch.Elapsed + tsconn;
            stopwatch.Reset();
            int[] A = CountingSort(b);
            for (int i = 0; i < A.Length; i++)
            {
                listBox2.Items.Add(A[i]);
            }

            string listBytes = "";
            string listBytes2 = "";
            string[] items = new string[6];
            ListViewItem listViewItem = new ListViewItem(items);






            #region -selectionalgorithms-
            if (cbselection.Checked)
            {
                stopwatch.Start();
                Process ProcessSelectionArray = Process.Start("SelectionSort.exe", txtdeger.Text);

                while (!ProcessSelectionArray.HasExited)
                {
                    ProcessSelectionArray.Refresh();
                    listBytes = getAvailableRAM(ProcessSelectionArray.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsSelectionarray = stopwatch.Elapsed - Tsdatabase;


                stopwatch.Start();
                Process ProcessSelectionList = Process.Start("SelectionSortList.exe", txtdeger.Text);

                while (!ProcessSelectionList.HasExited)
                {
                    ProcessSelectionList.Refresh();
                    listBytes2 = getAvailableRAM(ProcessSelectionList.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsSelectionList = stopwatch.Elapsed - Tsdatabase;
                items = new string[6] { "SelectionSortArray", txtdeger.Text, TsSelectionarray.TotalMilliseconds + " ms", listBytes.ToString(), TsSelectionList.TotalMilliseconds + " ms", listBytes2.ToString() };
                listViewItem = new ListViewItem(items);
                listView1.Items.Add(listViewItem);
                Application.DoEvents();
                sortname.Add(listView1.Items[valuename].SubItems[0].Text);
                sorttimearray.Add(listView1.Items[valuename].SubItems[2].Text);
                sortmbarray.Add(listView1.Items[valuename].SubItems[3].Text);
                sorttimelist.Add(listView1.Items[valuename].SubItems[4].Text);
                sortmblist.Add(listView1.Items[valuename].SubItems[5].Text);
                valuename++;
            }


            #endregion

            stopwatch.Reset();

            #region -quicksort-
            if (cbquick.Checked)
            {


                stopwatch.Start();
                Process ProcessQuickSortArray = Process.Start("QuickSortArray.exe", txtdeger.Text);
                listBytes = "";
                while (!ProcessQuickSortArray.HasExited)
                {
                    ProcessQuickSortArray.Refresh();
                    listBytes = getAvailableRAM(ProcessQuickSortArray.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsQuickSortArray = stopwatch.Elapsed - Tsdatabase;
                stopwatch.Reset();
                stopwatch.Start();
                Process ProcessQuickSortList = Process.Start("QuickSortList.exe", txtdeger.Text);
                listBytes2 = "";
                while (!ProcessQuickSortList.HasExited)
                {
                    ProcessQuickSortList.Refresh();
                    listBytes2 = getAvailableRAM(ProcessQuickSortList.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsQuickSortList = stopwatch.Elapsed - Tsdatabase;
                items = new string[6] { "QuickSortArray", txtdeger.Text, TsQuickSortArray.TotalMilliseconds + " ms", listBytes.ToString(), TsQuickSortList.TotalMilliseconds + " ms", listBytes2.ToString() };
                listViewItem = new ListViewItem(items);
                listView1.Items.Add(listViewItem);
                Application.DoEvents();
                sortname.Add(listView1.Items[valuename].SubItems[0].Text);
                sorttimearray.Add(listView1.Items[valuename].SubItems[2].Text);
                sortmbarray.Add(listView1.Items[valuename].SubItems[3].Text);
                sorttimelist.Add(listView1.Items[valuename].SubItems[4].Text);
                sortmblist.Add(listView1.Items[valuename].SubItems[5].Text);
                valuename++;
            }
            #endregion

            stopwatch.Reset();

            #region -mergesort-
            if (cbmerge.Checked)
            {
                stopwatch.Start();
                Process ProcessMergeSortArray = Process.Start("MergeSort.exe", txtdeger.Text);
                listBytes = "";
                while (!ProcessMergeSortArray.HasExited)
                {
                    ProcessMergeSortArray.Refresh();
                    listBytes = getAvailableRAM(ProcessMergeSortArray.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsMergeSortArray = stopwatch.Elapsed - Tsdatabase;
                stopwatch.Reset();
                stopwatch.Start();
                Process ProcesMergeSortList = Process.Start("MergeSortList.exe", txtdeger.Text);
                listBytes2 = "";
                while (!ProcesMergeSortList.HasExited)
                {
                    ProcesMergeSortList.Refresh();
                    listBytes2 = getAvailableRAM(ProcesMergeSortList.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsMergeSortList = stopwatch.Elapsed - Tsdatabase;
                items = new string[6] { "MergeSortArray", txtdeger.Text, TsMergeSortArray.TotalMilliseconds + " ms", listBytes.ToString(), TsMergeSortList.TotalMilliseconds + " ms", listBytes2.ToString() };
                listViewItem = new ListViewItem(items);
                listView1.Items.Add(listViewItem);
                Application.DoEvents();
                sortname.Add(listView1.Items[valuename].SubItems[0].Text);
                sorttimearray.Add(listView1.Items[valuename].SubItems[2].Text);
                sortmbarray.Add(listView1.Items[valuename].SubItems[3].Text);
                sorttimelist.Add(listView1.Items[valuename].SubItems[4].Text);
                sortmblist.Add(listView1.Items[valuename].SubItems[5].Text);
                valuename++;
            }
            #endregion

            stopwatch.Reset();

            #region -insertionsort-
            if (cbinsertion.Checked)
            {


                stopwatch.Start();
                Process ProcessInsertionSortArray = Process.Start("İnsertionSortArray.exe", txtdeger.Text);
                listBytes = "";
                while (!ProcessInsertionSortArray.HasExited)
                {
                    ProcessInsertionSortArray.Refresh();
                    listBytes = getAvailableRAM(ProcessInsertionSortArray.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan InsertionSortArray = stopwatch.Elapsed - Tsdatabase;
                stopwatch.Reset();
                stopwatch.Start();
                Process ProcessInsertionSortList = Process.Start("InsertionSortList.exe", txtdeger.Text);
                listBytes2 = "";
                while (!ProcessInsertionSortList.HasExited)
                {
                    ProcessInsertionSortList.Refresh();
                    listBytes2 = getAvailableRAM(ProcessInsertionSortList.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsInsertionSortList = stopwatch.Elapsed - Tsdatabase;
                items = new string[6] { "InsertionSort", txtdeger.Text, InsertionSortArray.TotalMilliseconds + " ms", listBytes.ToString(), TsInsertionSortList.TotalMilliseconds + " ms", listBytes2.ToString() };
                listViewItem = new ListViewItem(items);
                listView1.Items.Add(listViewItem);
                Application.DoEvents();
                sortname.Add(listView1.Items[valuename].SubItems[0].Text);
                sorttimearray.Add(listView1.Items[valuename].SubItems[2].Text);
                sortmbarray.Add(listView1.Items[valuename].SubItems[3].Text);
                sorttimelist.Add(listView1.Items[valuename].SubItems[4].Text);
                sortmblist.Add(listView1.Items[valuename].SubItems[5].Text);
                valuename++;
            }
            #endregion

            stopwatch.Reset();

            #region -Heapsort-
            if (cbheap.Checked)
            {


                stopwatch.Start();
                Process ProcessHeapSortArray = Process.Start("HeapSortArray.exe", txtdeger.Text);
                listBytes = "";
                while (!ProcessHeapSortArray.HasExited)
                {
                    ProcessHeapSortArray.Refresh();
                    listBytes = getAvailableRAM(ProcessHeapSortArray.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsHeapSortArray = stopwatch.Elapsed - Tsdatabase;
                stopwatch.Reset();
                stopwatch.Start();
                Process ProcessHeapSortList = Process.Start("HeapSortList.exe", txtdeger.Text);
                listBytes2 = "";
                while (!ProcessHeapSortList.HasExited)
                {
                    ProcessHeapSortList.Refresh();
                    listBytes2 = getAvailableRAM(ProcessHeapSortList.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsHeapSortList = stopwatch.Elapsed - Tsdatabase;
                items = new string[6] { "HeapSort", txtdeger.Text, TsHeapSortArray.TotalMilliseconds + " ms", listBytes.ToString(), TsHeapSortList.TotalMilliseconds + " ms", listBytes2.ToString() };
                listViewItem = new ListViewItem(items);
                listView1.Items.Add(listViewItem);
                Application.DoEvents();
                sortname.Add(listView1.Items[valuename].SubItems[0].Text);
                sorttimearray.Add(listView1.Items[valuename].SubItems[2].Text);
                sortmbarray.Add(listView1.Items[valuename].SubItems[3].Text);
                sorttimelist.Add(listView1.Items[valuename].SubItems[4].Text);
                sortmblist.Add(listView1.Items[valuename].SubItems[5].Text);
                valuename++;
            }
            #endregion

            stopwatch.Reset();

            #region -Countingsort-
            if (cbcounting.Checked)
            {


                stopwatch.Start();
                Process ProcessCountingsortArray = Process.Start("CountingSortArray.exe", txtdeger.Text);
                listBytes = "";
                while (!ProcessCountingsortArray.HasExited)
                {
                    ProcessCountingsortArray.Refresh();
                    listBytes = getAvailableRAM(ProcessCountingsortArray.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsCoutingSortArray = stopwatch.Elapsed - Tsdatabase;
                stopwatch.Reset();
                stopwatch.Start();
                Process ProcessCoutingSortList = Process.Start("CountingSortList.exe", txtdeger.Text);
                listBytes2 = "";
                while (!ProcessCoutingSortList.HasExited)
                {
                    ProcessCoutingSortList.Refresh();
                    listBytes2 = getAvailableRAM(ProcessCoutingSortList.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsCoutingSortList = stopwatch.Elapsed - Tsdatabase;
                items = new string[6] { "CountingSort", txtdeger.Text, TsCoutingSortArray.TotalMilliseconds + " ms", listBytes.ToString(), TsCoutingSortList.TotalMilliseconds + " ms", listBytes2.ToString() };
                listViewItem = new ListViewItem(items);
                listView1.Items.Add(listViewItem);
                Application.DoEvents();
                sortname.Add(listView1.Items[valuename].SubItems[0].Text);
                sorttimearray.Add(listView1.Items[valuename].SubItems[2].Text);
                sortmbarray.Add(listView1.Items[valuename].SubItems[3].Text);
                sorttimelist.Add(listView1.Items[valuename].SubItems[4].Text);
                sortmblist.Add(listView1.Items[valuename].SubItems[5].Text);
                valuename++;
            }
            #endregion

            stopwatch.Reset();

            #region -bubblesort-
            if (cbbubble.Checked)
            {


                stopwatch.Start();
                Process ProcessBubblesortArray = Process.Start("BubbleSortArray.exe", txtdeger.Text);
                listBytes = "";
                while (!ProcessBubblesortArray.HasExited)
                {
                    ProcessBubblesortArray.Refresh();
                    listBytes = getAvailableRAM(ProcessBubblesortArray.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsbubbleSortArray = stopwatch.Elapsed - Tsdatabase;
                stopwatch.Reset();
                stopwatch.Start();
                Process ProcessbubbleSortList = Process.Start("BubbleSortList.exe", txtdeger.Text);
                listBytes2 = "";
                while (!ProcessbubbleSortList.HasExited)
                {
                    ProcessbubbleSortList.Refresh();
                    listBytes2 = getAvailableRAM(ProcessbubbleSortList.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsbubbleSortList = stopwatch.Elapsed - Tsdatabase;
                items = new string[6] { "BubbleSort", txtdeger.Text, TsbubbleSortArray.TotalMilliseconds + " ms", listBytes.ToString(), TsbubbleSortList.TotalMilliseconds + " ms", listBytes2.ToString() };
                listViewItem = new ListViewItem(items);
                listView1.Items.Add(listViewItem);
                Application.DoEvents();
                sortname.Add(listView1.Items[valuename].SubItems[0].Text);
                sorttimearray.Add(listView1.Items[valuename].SubItems[2].Text);
                sortmbarray.Add(listView1.Items[valuename].SubItems[3].Text);
                sorttimelist.Add(listView1.Items[valuename].SubItems[4].Text);
                sortmblist.Add(listView1.Items[valuename].SubItems[5].Text);
                valuename++;
            }
            #endregion

            stopwatch.Reset();

            #region -radix-
            if (cbradix.Checked)
            {


                stopwatch.Start();
                Process ProcessRadixsortArray = Process.Start("RadixSortArray.exe", txtdeger.Text);
                listBytes = "";
                while (!ProcessRadixsortArray.HasExited)
                {
                    ProcessRadixsortArray.Refresh();
                    listBytes = getAvailableRAM(ProcessRadixsortArray.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsRadixSortArray = stopwatch.Elapsed - Tsdatabase;
                stopwatch.Reset();
                stopwatch.Start();
                Process ProcessRadixSortList = Process.Start("RadixSortList.exe", txtdeger.Text);
                listBytes2 = "";
                while (!ProcessRadixSortList.HasExited)
                {
                    ProcessRadixSortList.Refresh();
                    listBytes2 = getAvailableRAM(ProcessRadixSortList.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsRadixSortList = stopwatch.Elapsed - Tsdatabase;
                items = new string[6] { "RadixSort", txtdeger.Text, TsRadixSortArray.TotalMilliseconds + " ms", listBytes.ToString(), TsRadixSortList.TotalMilliseconds + " ms", listBytes2.ToString() };
                listViewItem = new ListViewItem(items);
                listView1.Items.Add(listViewItem);
                Application.DoEvents();
                sortname.Add(listView1.Items[valuename].SubItems[0].Text);
                sorttimearray.Add(listView1.Items[valuename].SubItems[2].Text);
                sortmbarray.Add(listView1.Items[valuename].SubItems[3].Text);
                sorttimelist.Add(listView1.Items[valuename].SubItems[4].Text);
                sortmblist.Add(listView1.Items[valuename].SubItems[5].Text);
                valuename++;
            }
            #endregion

            stopwatch.Reset();

            #region -shakersort-
            if (cbshaker.Checked)
            {

                stopwatch.Start();
                Process ProcessShakersortArray = Process.Start("ShakerSortArray.exe", txtdeger.Text);
                listBytes = "";
                while (!ProcessShakersortArray.HasExited)
                {
                    ProcessShakersortArray.Refresh();
                    listBytes = getAvailableRAM(ProcessShakersortArray.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsShakerSortArray = stopwatch.Elapsed - Tsdatabase;
                stopwatch.Reset();
                stopwatch.Start();
                Process ProcessShakerSortList = Process.Start("ShakerSortList.exe", txtdeger.Text);
                listBytes2 = "";
                while (!ProcessShakerSortList.HasExited)
                {
                    ProcessShakerSortList.Refresh();
                    listBytes2 = getAvailableRAM(ProcessShakerSortList.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsShakerSortList = stopwatch.Elapsed - Tsdatabase;
                items = new string[6] { "ShakerSort", txtdeger.Text, TsShakerSortArray.TotalMilliseconds + " ms", listBytes.ToString(), TsShakerSortList.TotalMilliseconds + " ms", listBytes2.ToString() };
                listViewItem = new ListViewItem(items);
                listView1.Items.Add(listViewItem);
                Application.DoEvents();
                sortname.Add(listView1.Items[valuename].SubItems[0].Text);
                sorttimearray.Add(listView1.Items[valuename].SubItems[2].Text);
                sortmbarray.Add(listView1.Items[valuename].SubItems[3].Text);
                sorttimelist.Add(listView1.Items[valuename].SubItems[4].Text);
                sortmblist.Add(listView1.Items[valuename].SubItems[5].Text);
                valuename++;
            }
            #endregion

            stopwatch.Reset();

            #region -shellsort
            if (cbshell.Checked)
            {


                stopwatch.Start();
                Process ProcessShellsortArray = Process.Start("ShellSortArray.exe", txtdeger.Text);
                listBytes = "";
                while (!ProcessShellsortArray.HasExited)
                {
                    ProcessShellsortArray.Refresh();

                    listBytes = getAvailableRAM(ProcessShellsortArray.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsShellSortArray = stopwatch.Elapsed - Tsdatabase;
                stopwatch.Reset();
                stopwatch.Start();
                Process ProcessShellSortList = Process.Start("ShellSortList.exe", txtdeger.Text);
                listBytes2 = "";
                while (!ProcessShellSortList.HasExited)
                {
                    ProcessShellSortList.Refresh();
                    listBytes2 = getAvailableRAM(ProcessShellSortList.PrivateMemorySize64);
                }
                stopwatch.Stop();
                TimeSpan TsShellSortList = stopwatch.Elapsed - Tsdatabase;
                items = new string[6] { "ShellSort", txtdeger.Text, TsShellSortArray.TotalMilliseconds + " ms", listBytes.ToString(), TsShellSortList.TotalMilliseconds + " ms", listBytes2.ToString() };
                listViewItem = new ListViewItem(items);
                listView1.Items.Add(listViewItem);
                Application.DoEvents();
                sortname.Add(listView1.Items[valuename].SubItems[0].Text);
                sorttimearray.Add(listView1.Items[valuename].SubItems[2].Text);
                sortmbarray.Add(listView1.Items[valuename].SubItems[3].Text);
                sorttimelist.Add(listView1.Items[valuename].SubItems[4].Text);
                sortmblist.Add(listView1.Items[valuename].SubItems[5].Text);
                valuename++;
            }
            #endregion


            foreach (string item in sortmbarray)
            {
                mbarray.Add(Convert.ToDouble(item.Substring(0, item.IndexOf(' '))));
            }
            foreach (string item in sortmblist)
            {
                mblist.Add(Convert.ToDouble(item.Substring(0, item.IndexOf(' '))));
            }
            foreach (string item in sorttimearray)
            {
                timearray.Add(Convert.ToDouble(item.Substring(0, item.IndexOf(' '))));
            }
            foreach (string item in sorttimelist)
            {
                timelist.Add(Convert.ToDouble(item.Substring(0, item.IndexOf(' '))));
            }
            for (int i = 0; i < sortname.Count; i++)
            {
                chart1.Series["Memory Array"].Points.AddXY(sortname[i], mbarray[i]);
                chart1.Series["Memory List"].Points.AddXY(sortname[i], mblist[i]);
                chart3.Series["Time Array"].Points.AddXY(sortname[i], timearray[i]);
                chart3.Series["Time List"].Points.AddXY(sortname[i], timelist[i]);

            }
        }

        private string getAvailableRAM(long privateMemorySize64)
        {
            double mb = privateMemorySize64 / 1024d / 1024d;
            return Math.Round(mb, 1) + " MB";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbubblearray_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}


