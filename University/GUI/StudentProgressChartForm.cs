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
    public partial class StudentProgressChartForm : Form
    {
        StudentsBL _studBL;

        Student _studInList;

        public StudentProgressChartForm(Student student)
        {
            InitializeComponent();
            _studBL = new StudentsBL();
            _studInList = (from st in _studBL.GetList() //по входному параметру студенту сделать график не удастся
                            where st.StudentID == student.StudentID //т.к. нужно новое соединение, поэтому ищем его в списке
                            select st).FirstOrDefault();
            labelStudentName.Text = _studInList.FullName;
            ShowEntireProgress();
            ShowFirstSemesterProgressProgress();
            ShowSecondSemesterProgressProgress();
            _studBL.Dispose();
        }
        /// <summary>
        /// Отобразить на диаграмме общую успеваемость
        /// </summary>
        public void ShowEntireProgress()
        {
            foreach (var item in _studInList.Progress)
            {
                chartSumProgress.Series["Оценка"].Points.AddXY(item.Subject.Title, item.Mark);
            }
            labelEntryAverageMark.Text += _studBL.GetEntireAverageMark(_studInList).ToString("F1");
        }
        /// <summary>
        /// Отобразить на диаграмме успеваемость за первый семестр
        /// </summary>
        public void ShowFirstSemesterProgressProgress()
        {
            foreach (var item in _studInList.Progress)
            {
                if (item.Semester == "Первый")
                {
                    chartFirstSemesterProgress.Series["Оценка"].Points.AddXY(item.Subject.Title, item.Mark);
                }
            }
            labelFirstSemesterAverageMark.Text += _studBL.GetFirstSemesterAverageMark(_studInList).ToString("F1");
        }
        /// <summary>
        /// Отобразить на диаграмме успеваемость за второй семестр
        /// </summary>
        public void ShowSecondSemesterProgressProgress()
        {
            foreach (var item in _studInList.Progress)
            {
                if (item.Semester == "Второй")
                {
                    chartSecondSemesterProgress.Series["Оценка"].Points.AddXY(item.Subject.Title, item.Mark);
                }
            }
            labelSecondSemesterAverageMark.Text += _studBL.GetSecondSemesterAverageMark(_studInList).ToString("F1");
        }
    }
}
