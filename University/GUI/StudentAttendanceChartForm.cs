using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLogic;

namespace GUI
{
    public partial class StudentAttendanceChartForm : Form
    {
        /// <summary>
        /// Студент, данные по которому отображаются
        /// </summary>
        private Student _student;

        public StudentAttendanceChartForm(Student student)
        {
            InitializeComponent();
            labelStudent.Text = student.FullName;
            _student = student;
            ShowSumAttendance();
            ShowFirstSemesterAttendance();
            ShowSecondSemesterAttendance();
        }

        private void ShowSumAttendance()
        {
            StudentsBL studBL = new StudentsBL();
            Student studInList = (from st in studBL.GetList() //по входному параметру студенту сделать график не удастся
                                  where st.StudentID == _student.StudentID //т.к. нужно новое соединение, поэтому ищем его в списке
                                  select st).FirstOrDefault();
            foreach (var item in studInList.Attendance)
            {
                chartSumAttendance.Series["Пропущенные часы"].Points.AddXY(item.Subject.Title, item.MissedHoursNumber);
            }
            labelSumMissedHours.Text += studBL.GetSumMissedHoursNumber(_student) + " ч.";
            studBL.Dispose();
        }

        private void ShowFirstSemesterAttendance()
        {
            StudentsBL studBL = new StudentsBL();
            Student studInList = (from st in studBL.GetList() //по входному параметру студенту сделать график не удастся
                                  where st.StudentID == _student.StudentID //т.к. нужно новое соединение, поэтому ищем его в списке
                                  select st).FirstOrDefault();
            foreach (var item in studInList.Attendance)
            {
                if (item.Semester == "Первый")
                {
                    chartFirstAttendance.Series["Пропущенные часы"].Points.AddXY(item.Subject.Title, item.MissedHoursNumber);
                }
            }
            labelFirstSemesterHours.Text += studBL.GetFirstSemesterMissedHoursNumber(_student) + " ч.";
            studBL.Dispose();
        }

        private void ShowSecondSemesterAttendance()
        {
            StudentsBL studBL = new StudentsBL();
            Student studInList = (from st in studBL.GetList() //по входному параметру студенту сделать график не удастся
                                  where st.StudentID == _student.StudentID //т.к. нужно новое соединение, поэтому ищем его в списке
                                  select st).FirstOrDefault();
            foreach (var item in studInList.Attendance)
            {
                if (item.Semester == "Второй")
                {
                    chartSecondAttendance.Series["Пропущенные часы"].Points.AddXY(item.Subject.Title, item.MissedHoursNumber);
                }
            }
            labelSecondSemesterHours.Text += studBL.GetSecondSemesterMissedHoursNumber(_student) + " ч.";
            studBL.Dispose();
        }
    }
}
