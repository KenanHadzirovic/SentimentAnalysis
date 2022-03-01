namespace SentimentAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCRANPositive = new System.Windows.Forms.Label();
            this.labelCRANNegative = new System.Windows.Forms.Label();
            this.labelBayesPositive = new System.Windows.Forms.Label();
            this.labelBayesNegative = new System.Windows.Forms.Label();
            this.labelTotalPositive = new System.Windows.Forms.Label();
            this.labelTotalNegative = new System.Windows.Forms.Label();
            this.labelTotalTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Location = new System.Drawing.Point(12, 38);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(353, 20);
            this.textBoxQuery.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesite pojam za pretragu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotalTotal);
            this.groupBox1.Controls.Add(this.labelTotalNegative);
            this.groupBox1.Controls.Add(this.labelTotalPositive);
            this.groupBox1.Controls.Add(this.labelBayesNegative);
            this.groupBox1.Controls.Add(this.labelBayesPositive);
            this.groupBox1.Controls.Add(this.labelCRANNegative);
            this.groupBox1.Controls.Add(this.labelCRANPositive);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rezultati analize";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(12, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 114);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grafički prikaz";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 145);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Članci";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(451, 126);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Location = new System.Drawing.Point(371, 12);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(95, 46);
            this.buttonAnalyze.TabIndex = 5;
            this.buttonAnalyze.Text = "Analiziraj";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 19);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(198, 89);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CRAN Algoritam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Naive Bayes Algoritam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ukupno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pozitivno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Negativno";
            // 
            // labelCRANPositive
            // 
            this.labelCRANPositive.AutoSize = true;
            this.labelCRANPositive.Location = new System.Drawing.Point(103, 41);
            this.labelCRANPositive.Name = "labelCRANPositive";
            this.labelCRANPositive.Size = new System.Drawing.Size(0, 13);
            this.labelCRANPositive.TabIndex = 5;
            // 
            // labelCRANNegative
            // 
            this.labelCRANNegative.AutoSize = true;
            this.labelCRANNegative.Location = new System.Drawing.Point(103, 70);
            this.labelCRANNegative.Name = "labelCRANNegative";
            this.labelCRANNegative.Size = new System.Drawing.Size(0, 13);
            this.labelCRANNegative.TabIndex = 6;
            // 
            // labelBayesPositive
            // 
            this.labelBayesPositive.AutoSize = true;
            this.labelBayesPositive.Location = new System.Drawing.Point(238, 41);
            this.labelBayesPositive.Name = "labelBayesPositive";
            this.labelBayesPositive.Size = new System.Drawing.Size(0, 13);
            this.labelBayesPositive.TabIndex = 7;
            // 
            // labelBayesNegative
            // 
            this.labelBayesNegative.AutoSize = true;
            this.labelBayesNegative.Location = new System.Drawing.Point(238, 70);
            this.labelBayesNegative.Name = "labelBayesNegative";
            this.labelBayesNegative.Size = new System.Drawing.Size(0, 13);
            this.labelBayesNegative.TabIndex = 8;
            // 
            // labelTotalPositive
            // 
            this.labelTotalPositive.AutoSize = true;
            this.labelTotalPositive.Location = new System.Drawing.Point(377, 41);
            this.labelTotalPositive.Name = "labelTotalPositive";
            this.labelTotalPositive.Size = new System.Drawing.Size(0, 13);
            this.labelTotalPositive.TabIndex = 9;
            // 
            // labelTotalNegative
            // 
            this.labelTotalNegative.AutoSize = true;
            this.labelTotalNegative.Location = new System.Drawing.Point(377, 70);
            this.labelTotalNegative.Name = "labelTotalNegative";
            this.labelTotalNegative.Size = new System.Drawing.Size(0, 13);
            this.labelTotalNegative.TabIndex = 10;
            // 
            // labelTotalTotal
            // 
            this.labelTotalTotal.AutoSize = true;
            this.labelTotalTotal.Location = new System.Drawing.Point(377, 98);
            this.labelTotalTotal.Name = "labelTotalTotal";
            this.labelTotalTotal.Size = new System.Drawing.Size(0, 13);
            this.labelTotalTotal.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 473);
            this.Controls.Add(this.buttonAnalyze);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQuery);
            this.Name = "Form1";
            this.Text = "Analiza mišljenja";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label labelTotalTotal;
        private System.Windows.Forms.Label labelTotalNegative;
        private System.Windows.Forms.Label labelTotalPositive;
        private System.Windows.Forms.Label labelBayesNegative;
        private System.Windows.Forms.Label labelBayesPositive;
        private System.Windows.Forms.Label labelCRANNegative;
        private System.Windows.Forms.Label labelCRANPositive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

