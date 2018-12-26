namespace sortingalgorithms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtdeger = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKarsilastir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbquick = new System.Windows.Forms.CheckBox();
            this.cbmerge = new System.Windows.Forms.CheckBox();
            this.cbshaker = new System.Windows.Forms.CheckBox();
            this.cbheap = new System.Windows.Forms.CheckBox();
            this.cbshell = new System.Windows.Forms.CheckBox();
            this.cbcounting = new System.Windows.Forms.CheckBox();
            this.cbradix = new System.Windows.Forms.CheckBox();
            this.cbbubble = new System.Windows.Forms.CheckBox();
            this.cbinsertion = new System.Windows.Forms.CheckBox();
            this.cbselection = new System.Windows.Forms.CheckBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdeger
            // 
            this.txtdeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtdeger.Location = new System.Drawing.Point(669, 30);
            this.txtdeger.Name = "txtdeger";
            this.txtdeger.Size = new System.Drawing.Size(161, 31);
            this.txtdeger.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(663, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "number of elements";
            // 
            // BtnKarsilastir
            // 
            this.BtnKarsilastir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKarsilastir.Location = new System.Drawing.Point(862, 30);
            this.BtnKarsilastir.Name = "BtnKarsilastir";
            this.BtnKarsilastir.Size = new System.Drawing.Size(91, 30);
            this.BtnKarsilastir.TabIndex = 2;
            this.BtnKarsilastir.Text = "TEST";
            this.BtnKarsilastir.UseVisualStyleBackColor = true;
            this.BtnKarsilastir.Click += new System.EventHandler(this.BtnKarsilastir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbquick);
            this.panel1.Controls.Add(this.cbmerge);
            this.panel1.Controls.Add(this.cbshaker);
            this.panel1.Controls.Add(this.cbheap);
            this.panel1.Controls.Add(this.cbshell);
            this.panel1.Controls.Add(this.cbcounting);
            this.panel1.Controls.Add(this.cbradix);
            this.panel1.Controls.Add(this.cbbubble);
            this.panel1.Controls.Add(this.cbinsertion);
            this.panel1.Controls.Add(this.cbselection);
            this.panel1.Controls.Add(this.txtdeger);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnKarsilastir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1343, 76);
            this.panel1.TabIndex = 7;
            // 
            // cbquick
            // 
            this.cbquick.AutoSize = true;
            this.cbquick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbquick.Location = new System.Drawing.Point(528, 30);
            this.cbquick.Name = "cbquick";
            this.cbquick.Size = new System.Drawing.Size(102, 24);
            this.cbquick.TabIndex = 12;
            this.cbquick.Text = "Quick Sort";
            this.cbquick.UseVisualStyleBackColor = true;
            // 
            // cbmerge
            // 
            this.cbmerge.AutoSize = true;
            this.cbmerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbmerge.Location = new System.Drawing.Point(528, 6);
            this.cbmerge.Name = "cbmerge";
            this.cbmerge.Size = new System.Drawing.Size(107, 24);
            this.cbmerge.TabIndex = 11;
            this.cbmerge.Text = "Merge Sort";
            this.cbmerge.UseVisualStyleBackColor = true;
            // 
            // cbshaker
            // 
            this.cbshaker.AutoSize = true;
            this.cbshaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbshaker.Location = new System.Drawing.Point(417, 33);
            this.cbshaker.Name = "cbshaker";
            this.cbshaker.Size = new System.Drawing.Size(113, 24);
            this.cbshaker.TabIndex = 10;
            this.cbshaker.Text = "Shaker Sort";
            this.cbshaker.UseVisualStyleBackColor = true;
            // 
            // cbheap
            // 
            this.cbheap.AutoSize = true;
            this.cbheap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbheap.Location = new System.Drawing.Point(417, 3);
            this.cbheap.Name = "cbheap";
            this.cbheap.Size = new System.Drawing.Size(101, 24);
            this.cbheap.TabIndex = 9;
            this.cbheap.Text = "Heap Sort";
            this.cbheap.UseVisualStyleBackColor = true;
            // 
            // cbshell
            // 
            this.cbshell.AutoSize = true;
            this.cbshell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbshell.Location = new System.Drawing.Point(278, 33);
            this.cbshell.Name = "cbshell";
            this.cbshell.Size = new System.Drawing.Size(97, 24);
            this.cbshell.TabIndex = 8;
            this.cbshell.Text = "Shell Sort";
            this.cbshell.UseVisualStyleBackColor = true;
            // 
            // cbcounting
            // 
            this.cbcounting.AutoSize = true;
            this.cbcounting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbcounting.Location = new System.Drawing.Point(278, 3);
            this.cbcounting.Name = "cbcounting";
            this.cbcounting.Size = new System.Drawing.Size(126, 24);
            this.cbcounting.TabIndex = 7;
            this.cbcounting.Text = "Counting Sort";
            this.cbcounting.UseVisualStyleBackColor = true;
            // 
            // cbradix
            // 
            this.cbradix.AutoSize = true;
            this.cbradix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbradix.Location = new System.Drawing.Point(153, 33);
            this.cbradix.Name = "cbradix";
            this.cbradix.Size = new System.Drawing.Size(98, 24);
            this.cbradix.TabIndex = 6;
            this.cbradix.Text = "RadixSort";
            this.cbradix.UseVisualStyleBackColor = true;
            // 
            // cbbubble
            // 
            this.cbbubble.AutoSize = true;
            this.cbbubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbbubble.Location = new System.Drawing.Point(153, 3);
            this.cbbubble.Name = "cbbubble";
            this.cbbubble.Size = new System.Drawing.Size(112, 24);
            this.cbbubble.TabIndex = 5;
            this.cbbubble.Text = "Bubble Sort";
            this.cbbubble.UseVisualStyleBackColor = true;
            this.cbbubble.CheckedChanged += new System.EventHandler(this.cbbubblearray_CheckedChanged);
            // 
            // cbinsertion
            // 
            this.cbinsertion.AutoSize = true;
            this.cbinsertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbinsertion.Location = new System.Drawing.Point(12, 33);
            this.cbinsertion.Name = "cbinsertion";
            this.cbinsertion.Size = new System.Drawing.Size(124, 24);
            this.cbinsertion.TabIndex = 4;
            this.cbinsertion.Text = "İnsertion Sort";
            this.cbinsertion.UseVisualStyleBackColor = true;
            // 
            // cbselection
            // 
            this.cbselection.AutoSize = true;
            this.cbselection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbselection.Location = new System.Drawing.Point(12, 3);
            this.cbselection.Name = "cbselection";
            this.cbselection.Size = new System.Drawing.Size(128, 24);
            this.cbselection.TabIndex = 3;
            this.cbselection.Text = "Selection Sort";
            this.cbselection.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 76);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1222, 289);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Algorithms Type";
            this.columnHeader1.Width = 196;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Elements";
            this.columnHeader2.Width = 163;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Array Test Time";
            this.columnHeader3.Width = 169;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Array Memory Usage";
            this.columnHeader4.Width = 215;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "List Test Time";
            this.columnHeader5.Width = 149;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "List Memory Usage";
            this.columnHeader6.Width = 203;
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(0, 33);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Memory Array";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Memory List";
            this.chart1.Series.Add(series17);
            this.chart1.Series.Add(series18);
            this.chart1.Size = new System.Drawing.Size(569, 302);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart3
            // 
            chartArea10.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart3.Legends.Add(legend10);
            this.chart3.Location = new System.Drawing.Point(622, 33);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "Time Array";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "Time List";
            this.chart3.Series.Add(series19);
            this.chart3.Series.Add(series20);
            this.chart3.Size = new System.Drawing.Size(594, 302);
            this.chart3.TabIndex = 11;
            this.chart3.Text = "chart3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.chart3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 358);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1343, 359);
            this.panel2.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1223, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 282);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(1223, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 359);
            this.listBox2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1343, 717);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtdeger;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKarsilastir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.CheckBox cbradix;
        private System.Windows.Forms.CheckBox cbbubble;
        private System.Windows.Forms.CheckBox cbinsertion;
        private System.Windows.Forms.CheckBox cbselection;
        private System.Windows.Forms.CheckBox cbquick;
        private System.Windows.Forms.CheckBox cbmerge;
        private System.Windows.Forms.CheckBox cbshaker;
        private System.Windows.Forms.CheckBox cbheap;
        private System.Windows.Forms.CheckBox cbshell;
        private System.Windows.Forms.CheckBox cbcounting;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

