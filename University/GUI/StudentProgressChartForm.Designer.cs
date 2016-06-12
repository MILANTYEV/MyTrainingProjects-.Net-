namespace GUI
{
    partial class StudentProgressChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSumProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelStudent = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSumProgress = new System.Windows.Forms.TabPage();
            this.tabPageFirstSemesterProgress = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.tabPageSecondSemesterProgress = new System.Windows.Forms.TabPage();
            this.chartFirstSemesterProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSecondSemesterProgress = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelSecondSemesterAverageMark = new System.Windows.Forms.Label();
            this.labelFirstSemesterAverageMark = new System.Windows.Forms.Label();
            this.labelEntryAverageMark = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSumProgress)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageSumProgress.SuspendLayout();
            this.tabPageFirstSemesterProgress.SuspendLayout();
            this.tabPageSecondSemesterProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFirstSemesterProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSecondSemesterProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSumProgress
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSumProgress.ChartAreas.Add(chartArea1);
            this.chartSumProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSumProgress.Legends.Add(legend1);
            this.chartSumProgress.Location = new System.Drawing.Point(3, 3);
            this.chartSumProgress.Name = "chartSumProgress";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Оценка";
            this.chartSumProgress.Series.Add(series1);
            this.chartSumProgress.Size = new System.Drawing.Size(885, 378);
            this.chartSumProgress.TabIndex = 0;
            this.chartSumProgress.Text = "chart1";
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.labelStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudent.ForeColor = System.Drawing.Color.White;
            this.labelStudent.Location = new System.Drawing.Point(12, 18);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(45, 16);
            this.labelStudent.TabIndex = 1;
            this.labelStudent.Text = "label1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSumProgress);
            this.tabControl1.Controls.Add(this.tabPageFirstSemesterProgress);
            this.tabControl1.Controls.Add(this.tabPageSecondSemesterProgress);
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(899, 410);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageSumProgress
            // 
            this.tabPageSumProgress.Controls.Add(this.labelEntryAverageMark);
            this.tabPageSumProgress.Controls.Add(this.chartSumProgress);
            this.tabPageSumProgress.Location = new System.Drawing.Point(4, 22);
            this.tabPageSumProgress.Name = "tabPageSumProgress";
            this.tabPageSumProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSumProgress.Size = new System.Drawing.Size(891, 384);
            this.tabPageSumProgress.TabIndex = 0;
            this.tabPageSumProgress.Text = "Общая";
            this.tabPageSumProgress.UseVisualStyleBackColor = true;
            // 
            // tabPageFirstSemesterProgress
            // 
            this.tabPageFirstSemesterProgress.Controls.Add(this.labelFirstSemesterAverageMark);
            this.tabPageFirstSemesterProgress.Controls.Add(this.chartFirstSemesterProgress);
            this.tabPageFirstSemesterProgress.Location = new System.Drawing.Point(4, 22);
            this.tabPageFirstSemesterProgress.Name = "tabPageFirstSemesterProgress";
            this.tabPageFirstSemesterProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFirstSemesterProgress.Size = new System.Drawing.Size(891, 384);
            this.tabPageFirstSemesterProgress.TabIndex = 1;
            this.tabPageFirstSemesterProgress.Text = "Первый семестр";
            this.tabPageFirstSemesterProgress.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(898, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Успеваемость";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.BackColor = System.Drawing.Color.SteelBlue;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudentName.ForeColor = System.Drawing.Color.White;
            this.labelStudentName.Location = new System.Drawing.Point(16, 20);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(41, 15);
            this.labelStudentName.TabIndex = 4;
            this.labelStudentName.Text = "label2";
            // 
            // tabPageSecondSemesterProgress
            // 
            this.tabPageSecondSemesterProgress.Controls.Add(this.labelSecondSemesterAverageMark);
            this.tabPageSecondSemesterProgress.Controls.Add(this.chartSecondSemesterProgress);
            this.tabPageSecondSemesterProgress.Location = new System.Drawing.Point(4, 22);
            this.tabPageSecondSemesterProgress.Name = "tabPageSecondSemesterProgress";
            this.tabPageSecondSemesterProgress.Size = new System.Drawing.Size(891, 384);
            this.tabPageSecondSemesterProgress.TabIndex = 2;
            this.tabPageSecondSemesterProgress.Text = "Второй семестр";
            this.tabPageSecondSemesterProgress.UseVisualStyleBackColor = true;
            // 
            // chartFirstSemesterProgress
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFirstSemesterProgress.ChartAreas.Add(chartArea2);
            this.chartFirstSemesterProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartFirstSemesterProgress.Legends.Add(legend2);
            this.chartFirstSemesterProgress.Location = new System.Drawing.Point(3, 3);
            this.chartFirstSemesterProgress.Name = "chartFirstSemesterProgress";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Оценка";
            this.chartFirstSemesterProgress.Series.Add(series2);
            this.chartFirstSemesterProgress.Size = new System.Drawing.Size(885, 378);
            this.chartFirstSemesterProgress.TabIndex = 0;
            this.chartFirstSemesterProgress.Text = "chart1";
            // 
            // chartSecondSemesterProgress
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSecondSemesterProgress.ChartAreas.Add(chartArea3);
            this.chartSecondSemesterProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartSecondSemesterProgress.Legends.Add(legend3);
            this.chartSecondSemesterProgress.Location = new System.Drawing.Point(0, 0);
            this.chartSecondSemesterProgress.Name = "chartSecondSemesterProgress";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Оценка";
            this.chartSecondSemesterProgress.Series.Add(series3);
            this.chartSecondSemesterProgress.Size = new System.Drawing.Size(891, 384);
            this.chartSecondSemesterProgress.TabIndex = 0;
            this.chartSecondSemesterProgress.Text = "chart1";
            // 
            // labelSecondSemesterAverageMark
            // 
            this.labelSecondSemesterAverageMark.AutoSize = true;
            this.labelSecondSemesterAverageMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondSemesterAverageMark.Location = new System.Drawing.Point(748, 49);
            this.labelSecondSemesterAverageMark.Name = "labelSecondSemesterAverageMark";
            this.labelSecondSemesterAverageMark.Size = new System.Drawing.Size(87, 15);
            this.labelSecondSemesterAverageMark.TabIndex = 1;
            this.labelSecondSemesterAverageMark.Text = "Средний бал: ";
            // 
            // labelFirstSemesterAverageMark
            // 
            this.labelFirstSemesterAverageMark.AutoSize = true;
            this.labelFirstSemesterAverageMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstSemesterAverageMark.Location = new System.Drawing.Point(745, 52);
            this.labelFirstSemesterAverageMark.Name = "labelFirstSemesterAverageMark";
            this.labelFirstSemesterAverageMark.Size = new System.Drawing.Size(87, 15);
            this.labelFirstSemesterAverageMark.TabIndex = 2;
            this.labelFirstSemesterAverageMark.Text = "Средний бал: ";
            // 
            // labelEntryAverageMark
            // 
            this.labelEntryAverageMark.AutoSize = true;
            this.labelEntryAverageMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEntryAverageMark.Location = new System.Drawing.Point(745, 53);
            this.labelEntryAverageMark.Name = "labelEntryAverageMark";
            this.labelEntryAverageMark.Size = new System.Drawing.Size(87, 15);
            this.labelEntryAverageMark.TabIndex = 2;
            this.labelEntryAverageMark.Text = "Средний бал: ";
            // 
            // StudentProgressChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 456);
            this.Controls.Add(this.labelStudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentProgressChartForm";
            this.Text = "Успеваемость";
            ((System.ComponentModel.ISupportInitialize)(this.chartSumProgress)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSumProgress.ResumeLayout(false);
            this.tabPageSumProgress.PerformLayout();
            this.tabPageFirstSemesterProgress.ResumeLayout(false);
            this.tabPageFirstSemesterProgress.PerformLayout();
            this.tabPageSecondSemesterProgress.ResumeLayout(false);
            this.tabPageSecondSemesterProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFirstSemesterProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSecondSemesterProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSumProgress;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSumProgress;
        private System.Windows.Forms.TabPage tabPageFirstSemesterProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.TabPage tabPageSecondSemesterProgress;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFirstSemesterProgress;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSecondSemesterProgress;
        private System.Windows.Forms.Label labelEntryAverageMark;
        private System.Windows.Forms.Label labelFirstSemesterAverageMark;
        private System.Windows.Forms.Label labelSecondSemesterAverageMark;
    }
}