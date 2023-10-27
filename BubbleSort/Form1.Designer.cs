
namespace BubbleSort
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Randomize = new System.Windows.Forms.Button();
            this.bubbleSortButton = new System.Windows.Forms.Button();
            this.selectionSortButton = new System.Windows.Forms.Button();
            this.mergeSortButton = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.quickSortButton = new System.Windows.Forms.Button();
            this.insertionSortButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(776, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Randomize
            // 
            this.Randomize.Location = new System.Drawing.Point(794, 13);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(115, 23);
            this.Randomize.TabIndex = 1;
            this.Randomize.Text = "Randomize";
            this.Randomize.UseVisualStyleBackColor = true;
            this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // bubbleSortButton
            // 
            this.bubbleSortButton.Location = new System.Drawing.Point(795, 42);
            this.bubbleSortButton.Name = "bubbleSortButton";
            this.bubbleSortButton.Size = new System.Drawing.Size(115, 23);
            this.bubbleSortButton.TabIndex = 2;
            this.bubbleSortButton.Text = "Bubble Sort";
            this.bubbleSortButton.UseVisualStyleBackColor = true;
            this.bubbleSortButton.Click += new System.EventHandler(this.bubbleSortButton_Click);
            // 
            // selectionSortButton
            // 
            this.selectionSortButton.Location = new System.Drawing.Point(795, 71);
            this.selectionSortButton.Name = "selectionSortButton";
            this.selectionSortButton.Size = new System.Drawing.Size(115, 23);
            this.selectionSortButton.TabIndex = 3;
            this.selectionSortButton.Text = "Selection Sort";
            this.selectionSortButton.UseVisualStyleBackColor = true;
            this.selectionSortButton.Click += new System.EventHandler(this.selectionSortButton_Click);
            // 
            // mergeSortButton
            // 
            this.mergeSortButton.Location = new System.Drawing.Point(795, 100);
            this.mergeSortButton.Name = "mergeSortButton";
            this.mergeSortButton.Size = new System.Drawing.Size(114, 23);
            this.mergeSortButton.TabIndex = 4;
            this.mergeSortButton.Text = "Merge Sort";
            this.mergeSortButton.UseVisualStyleBackColor = true;
            this.mergeSortButton.Click += new System.EventHandler(this.mergeSortButton_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(795, 288);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(114, 150);
            this.Output.TabIndex = 5;
            this.Output.Text = "";
            // 
            // quickSortButton
            // 
            this.quickSortButton.Location = new System.Drawing.Point(794, 129);
            this.quickSortButton.Name = "quickSortButton";
            this.quickSortButton.Size = new System.Drawing.Size(114, 23);
            this.quickSortButton.TabIndex = 6;
            this.quickSortButton.Text = "Quick Sort";
            this.quickSortButton.UseVisualStyleBackColor = true;
            this.quickSortButton.Click += new System.EventHandler(this.quickSortButton_Click);
            // 
            // insertionSortButton
            // 
            this.insertionSortButton.Location = new System.Drawing.Point(794, 158);
            this.insertionSortButton.Name = "insertionSortButton";
            this.insertionSortButton.Size = new System.Drawing.Size(114, 23);
            this.insertionSortButton.TabIndex = 7;
            this.insertionSortButton.Text = "Insertion Sort";
            this.insertionSortButton.UseVisualStyleBackColor = true;
            this.insertionSortButton.Click += new System.EventHandler(this.insertionSortButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 450);
            this.Controls.Add(this.insertionSortButton);
            this.Controls.Add(this.quickSortButton);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.mergeSortButton);
            this.Controls.Add(this.selectionSortButton);
            this.Controls.Add(this.bubbleSortButton);
            this.Controls.Add(this.Randomize);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Randomize;
        private System.Windows.Forms.Button bubbleSortButton;
        private System.Windows.Forms.Button selectionSortButton;
        private System.Windows.Forms.Button mergeSortButton;
        private System.Windows.Forms.RichTextBox Output;
        private System.Windows.Forms.Button quickSortButton;
        private System.Windows.Forms.Button insertionSortButton;
    }
}

