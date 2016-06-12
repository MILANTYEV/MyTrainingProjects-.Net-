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
    class DepartamentsActions
    {
        /// <summary>
        /// Найти ячейки с совпадениями и выбрать их
        /// </summary>
        /// <param name="searchText">Искомый текст</param>
        /// <param name="dataGridViewDepartaments">Ссылка на датаГрид, в котором ищем</param>
        public static void SelectFindedRow(string searchText, DataGridView dataGridViewDepartaments)
        {
            dataGridViewDepartaments.ClearSelection();
            foreach (DataGridViewRow row in dataGridViewDepartaments.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null &&
                        System.Text.RegularExpressions.Regex.IsMatch(cell.Value.ToString(), searchText))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }


        /// <summary>
        /// Возрващает выбранную в таблице группу
        /// </summary>
        /// <param name="dataGridViewGroups"></param>
        /// <returns></returns>
        public static Departament GetSelectedDepartamentFromGrid(DataGridView dataGridViewDepartaments)
        {
            int departamentID = (int)dataGridViewDepartaments.SelectedCells[0].Value;
            Departament departament;
            using (DepartamentsBL departamentsBL = new DepartamentsBL())
            {
                departament = (from dep in departamentsBL.GetList()
                         where dep.DepartamentID == departamentID
                         select dep).FirstOrDefault();
            }
            return departament;
        }

        public static void Add()
        {
            AddOrEditDepartamentForm form = new AddOrEditDepartamentForm();
            form.ShowDialog();
        }

        public static void Edit(DataGridView dataGridViewDepartaments)
        {
            AddOrEditDepartamentForm form = new AddOrEditDepartamentForm(GetSelectedDepartamentFromGrid(dataGridViewDepartaments));
            form.ShowDialog();
        }

        public static void Delete(DataGridView dataGridViewDepartaments)
        {
            Departament departament = GetSelectedDepartamentFromGrid(dataGridViewDepartaments);
            DialogResult dialog = MessageBox.Show("Удалить кафедру " + departament.Title + "?", "Удаление",
              MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (DepartamentsBL departamentsBL = new DepartamentsBL())
                {
                    departamentsBL.Delete(departament);
                }
            }
        }
    }
}
