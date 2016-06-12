namespace GUI
{
    partial class StudentAttendanceChartForm
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
            this.chartSumAttendance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelAttendance = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Sum = new System.Windows.Forms.TabPage();
            this.labelSumMissedHours = new System.Windows.Forms.Label();
            this.FirstSemester = new System.Windows.Forms.TabPage();
            this.labelFirstSemesterHours = new System.Windows.Forms.Label();
            this.chartFirstAttendance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SecondSemester = new System.Windows.Forms.TabPage();
            this.labelSecondSemesterHours = new System.Windows.Forms.Label();
            this.chartSecondAttendance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSumAttendance)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Sum.SuspendLayout();
            this.FirstSemester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFirstAttendance)).BeginInit();
            this.SecondSemester.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSecondAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSumAttendance
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSumAttendance.ChartAreas.Add(chartArea1);
            this.chartSumAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartSumAttendance.Legends.Add(legend1);
            this.chartSumAttendance.Location = new System.Drawing.Point(3, 3);
            this.chartSumAttendance.Name = "chartSumAttendance";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Пропущенные часы";
            this.chartSumAttendance.Series.Add(series1);
            this.chartSumAttendance.Size = new System.Drawing.Size(949, 421);
            this.chartSumAttendance.TabIndex = 0;
            this.chartSumAttendance.Text = "Посещаемость";
            // 
            // labelAttendance
            // 
            this.labelAttendance.BackColor = System.Drawing.Color.SteelBlue;
            this.labelAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAttendance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttendance.ForeColor = System.Drawing.Color.White;
            this.labelAttendance.Location = new System.Drawing.Point(0, 0);
            this.labelAttendance.Name = "labelAttendance";
            this.labelAttendance.Size = new System.Drawing.Size(966, 38);
            this.labelAttendance.TabIndex = 1;
            this.labelAttendance.Text = "Посещаемость";
            this.labelAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Sum);
            this.tabControl1.Controls.Add(this.FirstSemester);
            this.tabControl1.Controls.Add(this.SecondSemester);
            this.tabControl1.Location = new System.Drawing.Point(3, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(963, 453);
            this.tabControl1.TabIndex = 2;
            // 
            // Sum
            // 
            this.Sum.Controls.Add(this.labelSumMissedHours);
            this.Sum.Controls.Add(this.chartSumAttendance);
            this.Sum.Location = new System.Drawing.Point(4, 22);
            this.Sum.Name = "Sum";
            this.Sum.Padding = new System.Windows.Forms.Padding(3);
            this.Sum.Size = new System.Drawing.Size(955, 427);
            this.Sum.TabIndex = 0;
            this.Sum.Text = "Общая";
            this.Sum.UseVisualStyleBackColor = true;
            // 
            // labelSumMissedHours
            // 
            this.labelSumMissedHours.AutoSize = true;
            this.labelSumMissedHours.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumMissedHours.Location = new System.Drawing.Point(749, 61);
            this.labelSumMissedHours.Name = "labelSumMissedHours";
            this.labelSumMissedHours.Size = new System.Drawing.Size(119, 16);
            this.labelSumMissedHours.TabIndex = 3;
            this.labelSumMissedHours.Text = "Всего пропущено: ";
            // 
            // FirstSemester
            // 
            this.FirstSemester.Controls.Add(this.labelFirstSemesterHours);
            this.FirstSemester.Controls.Add(this.chartFirstAttendance);
            this.FirstSemester.Location = new System.Drawing.Point(4, 22);
            this.FirstSemester.Name = "FirstSemester";
            this.FirstSemester.Padding = new System.Windows.Forms.Padding(3);
            this.FirstSemester.Size = new System.Drawing.Size(955, 427);
            this.FirstSemester.TabIndex = 1;
            this.FirstSemester.Text = "Первый семестр";
            this.FirstSemester.UseVisualStyleBackColor = true;
            // 
            // labelFirstSemesterHours
            // 
            this.labelFirstSemesterHours.AutoSize = true;
            this.labelFirstSemesterHours.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstSemesterHours.Location = new System.Drawing.Point(750, 63);
            this.labelFirstSemesterHours.Name = "labelFirstSemesterHours";
            this.labelFirstSemesterHours.Size = new System.Drawing.Size(119, 16);
            this.labelFirstSemesterHours.TabIndex = 2;
            this.labelFirstSemesterHours.Text = "Всего пропущено: ";
            // 
            // chartFirstAttendance
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFirstAttendance.ChartAreas.Add(chartArea2);
            this.chartFirstAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartFirstAttendance.Legends.Add(legend2);
            this.chartFirstAttendance.Location = new System.Drawing.Point(3, 3);
            this.chartFirstAttendance.Name = "chartFirstAttendance";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Пропущенные часы";
            this.chartFirstAttendance.Series.Add(series2);
            this.chartFirstAttendance.Size = new System.Drawing.Size(949, 421);
            this.chartFirstAttendance.TabIndex = 0;
            this.chartFirstAttendance.Text = "chart1";
            // 
            // SecondSemester
            // 
            this.SecondSemester.Controls.Add(this.labelSecondSemesterHours);
            this.SecondSemester.Controls.Add(this.chartSecondAttendance);
            this.SecondSemester.Location = new System.Drawing.Point(4, 22);
            this.SecondSemester.Name = "SecondSemester";
            this.SecondSemester.Size = new System.Drawing.Size(955, 427);
            this.SecondSemester.TabIndex = 2;
            this.SecondSemester.Text = "Второй семестр";
            this.SecondSemester.UseVisualStyleBackColor = true;
            // 
            // labelSecondSemesterHours
            // 
            this.labelSecondSemesterHours.AutoSize = true;
            this.labelSecondSemesterHours.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondSemesterHours.Location = new System.Drawing.Point(751, 63);
            this.labelSecondSemesterHours.Name = "labelSecondSemesterHours";
            this.labelSecondSemesterHours.Size = new System.Drawing.Size(119, 16);
            this.labelSecondSemesterHours.TabIndex = 1;
            this.labelSecondSemesterHours.Text = "Всего пропущено: ";
            // 
            // chartSecondAttendance
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSecondAttendance.ChartAreas.Add(chartArea3);
            this.chartSecondAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartSecondAttendance.Legends.Add(legend3);
            this.chartSecondAttendance.Location = new System.Drawing.Point(0, 0);
            this.chartSecondAttendance.Name = "chartSecondAttendance";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Пропущенные часы";
            this.chartSecondAttendance.Series.Add(series3);
            this.chartSecondAttendance.Size = new System.Drawing.Size(955, 427);
            this.chartSecondAttendance.TabIndex = 0;
            this.chartSecondAttendance.Text = "chart1";
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.labelStudent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudent.ForeColor = System.Drawing.Color.White;
            this.labelStudent.Location = new System.Drawing.Point(12, 13);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(38, 14);
            this.labelStudent.TabIndex = 3;
            this.labelStudent.Text = "label1";
            // 
            // StudentAttendanceChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 496);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelAttendance);
            this.Name = "StudentAttendanceChartForm";
            this.Text = "StudentAttendanceChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartSumAttendance)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Sum.ResumeLayout(false);
            this.Sum.PerformLayout();
            this.FirstSemester.ResumeLayout(false);
            this.FirstSemester.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFirstAttendance)).EndInit();
            this.SecondSemester.ResumeLayout(false);
            this.SecondSemester.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSecondAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSumAttendance;
        private System.Windows.Forms.Label labelAttendance;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Sum;
        private System.Windows.Forms.TabPage FirstSemester;
        private System.Windows.Forms.TabPage SecondSemester;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFirstAttendance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSecondAttendance;
        private System.Windows.Forms.Label labelSumMissedHours;
        private System.Windows.Forms.Label labelFirstSemesterHours;
        private System.Windows.Forms.Label labelSecondSemesterHours;
    }
}