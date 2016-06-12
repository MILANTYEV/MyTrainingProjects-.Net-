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
    static class FacultiesActions
    {
        /// <summary>
        /// Найти ячейки с совпадениями и выбрать их
        /// </summary>
        /// <param name="searchText">Искомый текст</param>
        /// <param name="dataGridViewFaculties">Ссылка на датаГрид, в котором ищем</param>
        public static void SelectFindedRow(string searchText, DataGridView dataGridViewFaculties)
        {
            dataGridViewFaculties.ClearSelection();
            for (int i = 1; i < dataGridViewFaculties.Columns.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridViewFaculties.Rows)
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
        /// Возрващает выбранный в таблице факультет
        /// </summary>
        /// <param name="dataGridViewFaculties"></param>
        /// <returns></returns>
        public static Faculty GetSelectedFacultyFromGrid(DataGridView dataGridViewFaculties)
        {
            int index = dataGridViewFaculties.SelectedCells[0].RowIndex;
            FacultiesBL facultiesBl = new FacultiesBL();
            Faculty faculty = facultiesBl.GetList()[index];
            facultiesBl.Dispose();
            return faculty;
        }

        public static void Add()
        {
            AddOrEditFacultyForm form = new AddOrEditFacultyForm();
            form.ShowDialog();
        }

        public static void Edit(DataGridView dataGridViewFaculties)
        {
            AddOrEditFacultyForm form = new AddOrEditFacultyForm(GetSelectedFacultyFromGrid(dataGridViewFaculties));
            form.ShowDialog();
        }

        public static void Delete(DataGridView dataGridViewFaculties)
        {
            Faculty faculty = GetSelectedFacultyFromGrid(dataGridViewFaculties);
            DialogResult dialog = MessageBox.Show("Удалить " + faculty.Title + "?", "Удаление",
              MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (FacultiesBL facultiesBL = new FacultiesBL())
                {
                    facultiesBL.Delete(faculty);
                }
            }
        }
    }
}
