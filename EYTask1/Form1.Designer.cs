namespace EYTask1
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
            this.generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ImportDB = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.labelProc = new System.Windows.Forms.Label();
            this.combTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMerg = new System.Windows.Forms.Label();
            this.mergeFiles = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Label();
            this.median = new System.Windows.Forms.Label();
            this.textBoxMedian = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.getMedian = new System.Windows.Forms.Button();
            this.getSum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate.Location = new System.Drawing.Point(221, 48);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(128, 36);
            this.generate.TabIndex = 0;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "First, push \"Generate\" button to generate 100 files with 100000 lines";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(160, 212);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(384, 31);
            this.progressBar1.TabIndex = 2;
            // 
            // ImportDB
            // 
            this.ImportDB.Enabled = false;
            this.ImportDB.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportDB.Location = new System.Drawing.Point(16, 207);
            this.ImportDB.Name = "ImportDB";
            this.ImportDB.Size = new System.Drawing.Size(128, 36);
            this.ImportDB.TabIndex = 0;
            this.ImportDB.Text = "Import to DB";
            this.ImportDB.UseVisualStyleBackColor = true;
            this.ImportDB.Click += new System.EventHandler(this.ImportDB_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(166, 192);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(0, 17);
            this.countLabel.TabIndex = 3;
            // 
            // labelProc
            // 
            this.labelProc.AutoSize = true;
            this.labelProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProc.Location = new System.Drawing.Point(355, 58);
            this.labelProc.Name = "labelProc";
            this.labelProc.Size = new System.Drawing.Size(0, 18);
            this.labelProc.TabIndex = 4;
            // 
            // combTextBox
            // 
            this.combTextBox.Location = new System.Drawing.Point(160, 129);
            this.combTextBox.Name = "combTextBox";
            this.combTextBox.Size = new System.Drawing.Size(195, 22);
            this.combTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter symbol combination";
            // 
            // labelMerg
            // 
            this.labelMerg.AutoSize = true;
            this.labelMerg.Location = new System.Drawing.Point(378, 132);
            this.labelMerg.Name = "labelMerg";
            this.labelMerg.Size = new System.Drawing.Size(0, 17);
            this.labelMerg.TabIndex = 7;
            // 
            // mergeFiles
            // 
            this.mergeFiles.Enabled = false;
            this.mergeFiles.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeFiles.Location = new System.Drawing.Point(16, 121);
            this.mergeFiles.Name = "mergeFiles";
            this.mergeFiles.Size = new System.Drawing.Size(128, 39);
            this.mergeFiles.TabIndex = 6;
            this.mergeFiles.Text = "Merge";
            this.mergeFiles.UseVisualStyleBackColor = true;
            this.mergeFiles.Click += new System.EventHandler(this.mergeFiles_Click);
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(157, 291);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(135, 20);
            this.sum.TabIndex = 20;
            this.sum.Text = "Sum of Numbers";
            // 
            // median
            // 
            this.median.AutoSize = true;
            this.median.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.median.Location = new System.Drawing.Point(158, 366);
            this.median.Name = "median";
            this.median.Size = new System.Drawing.Size(63, 20);
            this.median.TabIndex = 19;
            this.median.Text = "Median";
            // 
            // textBoxMedian
            // 
            this.textBoxMedian.Location = new System.Drawing.Point(160, 397);
            this.textBoxMedian.Name = "textBoxMedian";
            this.textBoxMedian.ReadOnly = true;
            this.textBoxMedian.Size = new System.Drawing.Size(195, 22);
            this.textBoxMedian.TabIndex = 18;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(160, 321);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(195, 22);
            this.textBoxSum.TabIndex = 17;
            // 
            // getMedian
            // 
            this.getMedian.Enabled = false;
            this.getMedian.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMedian.Location = new System.Drawing.Point(16, 389);
            this.getMedian.Name = "getMedian";
            this.getMedian.Size = new System.Drawing.Size(128, 39);
            this.getMedian.TabIndex = 16;
            this.getMedian.Text = "Get Median";
            this.getMedian.UseVisualStyleBackColor = true;
            this.getMedian.Click += new System.EventHandler(this.getMedian_Click);
            // 
            // getSum
            // 
            this.getSum.Enabled = false;
            this.getSum.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSum.Location = new System.Drawing.Point(16, 311);
            this.getSum.Name = "getSum";
            this.getSum.Size = new System.Drawing.Size(128, 39);
            this.getSum.TabIndex = 15;
            this.getSum.Text = "Get Sum";
            this.getSum.UseVisualStyleBackColor = true;
            this.getSum.Click += new System.EventHandler(this.getSum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.median);
            this.Controls.Add(this.textBoxMedian);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.getMedian);
            this.Controls.Add(this.getSum);
            this.Controls.Add(this.combTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelMerg);
            this.Controls.Add(this.mergeFiles);
            this.Controls.Add(this.labelProc);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ImportDB);
            this.Controls.Add(this.generate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ImportDB;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label labelProc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMerg;
        private System.Windows.Forms.Button mergeFiles;
        internal System.Windows.Forms.TextBox combTextBox;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label median;
        private System.Windows.Forms.TextBox textBoxMedian;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button getMedian;
        private System.Windows.Forms.Button getSum;
    }
}

