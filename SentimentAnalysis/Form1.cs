using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentimentAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            EFContext efContext = new EFContext();
            efContext.Database.CommandTimeout = 180;

            // Filter Articles
            var articles = efContext.Articles.Where(x => x.Content.Contains(textBoxQuery.Text) || x.Title.Contains(textBoxQuery.Text)).ToList();

            File.WriteAllText(@"C:\Users\Kenan\Desktop\master\relatedArticles.csv",  string.Join(",\n", articles.Select(x => x.Content)));

            //Call CRAN algorithm
            var resultCran = RunFromCmd(@"C:\Users\Kenan\Desktop\master\master.r", @"C:\Program Files\R\R-3.6.3\bin\Rscript.exe");
            var listOfResultsCran = resultCran.Replace("\"", "").Replace("\r\n", "").Split(' ').Where(x => x.Contains("positive") || x.Contains("negative"));
            listOfResultsCran = listOfResultsCran.Take(listOfResultsCran.Count() - 2);
            // Call Naive Bayes algorithm
            var resultNaiveBayes = RunFromCmd(@"C:\Users\Kenan\Desktop\master\naivebayes.r", @"C:\Program Files\R\R-3.6.3\bin\Rscript.exe").Replace("\"", "").Replace("\r\n", "");
            var listOfResultsBayes = resultNaiveBayes.Split(' ').Where(x => x.Contains("positive") || x.Contains("negative"));

            // Calculate results
            double cranPositive = Math.Round(((double)listOfResultsCran.Count(x => x.Contains("positive")) / listOfResultsCran.Count()),2);
            double cranNegative = Math.Round(((double)listOfResultsCran.Count(x => x.Contains("negative")) / listOfResultsCran.Count()),2);
            double bayesPositive = Math.Round(((double)listOfResultsBayes.Count(x => x.Contains("positive")) / listOfResultsBayes.Count()),2);
            double bayesNegative = Math.Round(((double)listOfResultsBayes.Count(x => x.Contains("negative")) / listOfResultsBayes.Count()),2);
            double totalPositive = Math.Round((cranPositive + bayesPositive) / 2,2);
            double totalNegative = Math.Round((cranNegative + bayesNegative) / 2,2);

            // Present results
            labelCRANPositive.Text = $"{listOfResultsCran.Count(x => x.Contains("positive")).ToString()} ( {cranPositive * 100}% )";
            labelCRANNegative.Text = $"{listOfResultsCran.Count(x => x.Contains("negative")).ToString()} ( {cranNegative * 100}% )";
            labelBayesNegative.Text = $"{listOfResultsBayes.Count(x => x.Contains("negative")).ToString()} ( {bayesNegative * 100}% )";
            labelBayesPositive.Text = $"{listOfResultsBayes.Count(x => x.Contains("positive")).ToString()} ( {bayesPositive * 100}% )";
            labelTotalNegative.Text = $"{totalNegative * 100}%";
            labelTotalPositive.Text = $"{totalPositive * 100}%";
            labelTotalTotal.Text = articles.Count().ToString();

            dataGridView1.DataSource = articles;
            //chart1.Series["Business"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series[0].Points.DataBindY(new[] { totalNegative, totalPositive }, "value");

            File.WriteAllLines(@"C:\Users\Kenan\Desktop\master\naivebayesResults.txt", listOfResultsBayes);
            File.WriteAllLines(@"C:\Users\Kenan\Desktop\master\cranResults.txt", listOfResultsCran);
        }

        

        /// <summary>
        /// Runs an R script from a file using Rscript.exe.
        /// </summary>
        /// <param name="rCodeFilePath">File where your R code is located.</param>
        /// <param name="rScriptExecutablePath">Usually only requires "rscript.exe"</param>
        /// <param name="args">Multiple R args can be seperated by spaces.</param>
        /// <returns>Returns a string with the R responses.</returns>
        private static string RunFromCmd(string rCodeFilePath, string rScriptExecutablePath)
        {
            try
            {
                string result = "";
                var info = new ProcessStartInfo();
                info.FileName = rScriptExecutablePath;
                info.Arguments = rCodeFilePath;
                info.RedirectStandardInput = false;
                info.RedirectStandardOutput = true;
                info.UseShellExecute = false;
                info.CreateNoWindow = true;

                using (var proc = new Process())
                {

                    proc.StartInfo = info;
                    proc.Start();
                    result = proc.StandardOutput.ReadToEnd();
                }


                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("R Script failed: ", ex);
            }
        }
    }
}
