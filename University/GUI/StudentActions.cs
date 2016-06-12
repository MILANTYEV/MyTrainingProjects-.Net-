using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLogic;

namespace GUI
{
    static class StudentActions
    {
        /// <summary>
        /// Найти ячейки с совпадениями и выбрать их
        /// </summary>
        /// <param name="searchText">Искомый текст</param>
        /// <param name="dataGridViewStudents">Ссылка на датаГрид, в котором ищем</param>
        public static void SelectFindedRow(string searchText, DataGridView dataGridViewStudents)
        {
            dataGridViewStudents.ClearSelection();
            for (int i = 1; i <= 4; i++)
            {
                foreach (DataGridViewRow row in dataGridViewStudents.Rows)
                {
                    if (row.Cells[i].Value != null && 
                        System.Text.RegularExpressions.Regex.IsMatch(row.Cells[i].Value.ToString(), searchText))
                    {
                        row.Selected = true;
                    }
                }
            }
        }

        /// <summary>
        /// Возрващает выбранного в таблице студента
        /// </summary>
        /// <param name="dataGridViewStudents"></param>
        /// <returns></returns>
        public static Student GetSelectedStudentFromGrid(DataGridView dataGridViewStudents)
        {
            int index = dataGridViewStudents.SelectedCells[0].RowIndex;
            StudentsBL studentsBL = new StudentsBL();
            Student student = studentsBL.GetList()[index];
            return student;
        }
        /// <summary>
        /// Вывести для студента график успеваемости
        /// </summary>
        /// <param name="dataGridViewStudents"></param>
        public static void ShowStudentsProgressChart(DataGridView dataGridViewStudents)
        {
            Student student = GetSelectedStudentFromGrid(dataGridViewStudents);
            StudentProgressChartForm form = new StudentProgressChartForm(student);
            form.ShowDialog();
        }

        public static void Edit(DataGridView dataGridViewStudents)
        {
            AddOrEditStudentForm form = new AddOrEditStudentForm(GetSelectedStudentFromGrid(dataGridViewStudents));
            form.ShowDialog();
        }

        public static void Add()
        {
            AddOrEditStudentForm form = new AddOrEditStudentForm();
            form.ShowDialog();
        }

        public static void Delete(DataGridView dataGridViewStudents)
        {
            Student student = GetSelectedStudentFromGrid(dataGridViewStudents);
            DialogResult dialog = MessageBox.Show("Удалить " + student.FullName + "?", "Удаление",
              MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (StudentsBL bl = new StudentsBL())
                {
                    bl.Delete(student);
                }
            }
        }
    }
}
