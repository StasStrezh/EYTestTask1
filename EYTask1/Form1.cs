using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYTask1
{
    public partial class Form1 : Form
    {
        public setText SetT;
        public setProgressValue SetP;
        private static DatabaseController dBins; 
        internal static DatabaseController DBins { get => dBins; set => dBins = value; } 

        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            SetT = new setText(SetText);
            SetP = new setProgressValue(SetProg);
            DatabaseController.SetTextEvent += SetText;
            DatabaseController.SetProgressValueEvent += SetProg;
        }


        /// <summary>
        /// Set Value for progress bar
        /// </summary>
        public void SetProg(int am)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(SetP, am);
                return;
            }
            progressBar1.Minimum = 0;
            progressBar1.Maximum = am;
        }
        /// <summary>
        /// Set text to progress label
        /// </summary>
        public void SetText(string str)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(SetT, str);
                return;
            }
            countLabel.Text = str;
            progressBar1.Increment(1);
        }


        /// <summary>
        /// Generating files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generate_Click(object sender, EventArgs e)
        {
            Generating.Generator();

            labelProc.Text = "Done";
            mergeFiles.Enabled = true;
        }


        /// <summary>
        /// Merging files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mergeFiles_Click(object sender, EventArgs e)
        {
            string comb = combTextBox.Text;
            Merging.MergeFiles(comb);
            labelMerg.Text = "Merged, deleted strings:" + Merging.counter;
            ImportDB.Enabled = true;
        }


        /// <summary>
        /// Importing to Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportDB_Click(object sender, EventArgs e)
        {
            dBins = new DatabaseController();
            dBins.Run();
            getMedian.Enabled = true;
            getSum.Enabled = true;
        }


        /// <summary>
        /// Summing all int numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getSum_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(dBins.connectionString))
            using (var command = new SqlCommand("dbo.CountSum", conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                conn.Open();
                using (SqlDataReader rdr = command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        textBoxSum.Text = String.Format(" {0} ", rdr["SumOfInt"]);
                    }
                }
                conn.Close();
            }
        }


        /// <summary>
        /// Get median of double
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getMedian_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(dBins.connectionString))
            using (var command = new SqlCommand("dbo.CountMedian", conn)
            {
                CommandType = CommandType.StoredProcedure
            })
            {

                conn.Open();
                using (SqlDataReader rdr = command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        textBoxMedian.Text = String.Format(" {0} ", rdr["DoubleMedian"]);
                    }
                }
                conn.Close();
            }
        }
    }
}
