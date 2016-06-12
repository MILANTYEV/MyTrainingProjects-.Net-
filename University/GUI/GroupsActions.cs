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
    class GroupsActions
    {
        /// <summary>
        /// Найти ячейки с совпадениями и выбрать их
        /// </summary>
        /// <param name="searchText">Искомый текст</param>
        /// <param name="dataGridViewGroups">Ссылка на датаГрид, в котором ищем</param>
        public static void SelectFindedRow(string searchText, DataGridView dataGridViewGroups)
        {
            dataGridViewGroups.ClearSelection();
            foreach (DataGridViewRow row in dataGridViewGroups.Rows)
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
        public static Group GetSelectedGroupFromGrid(DataGridView dataGridViewGroups)
        {
            int groupNumber = (int)dataGridViewGroups.SelectedCells[0].Value;
            Group group;
            using (GroupsBL groupsBL = new GroupsBL())
            {
                group = (from gr in groupsBL.GetList()
                               where gr.GroupNumber == groupNumber
                               select gr).FirstOrDefault();
            }
            return group;
        }

        public static void Add(DataGridView dataGridViewGroups)
        {
            AddOrEditGroupForm form = new AddOrEditGroupForm();
            form.ShowDialog();
        }

        public static void Edit(DataGridView dataGridViewGroups)
        {
            AddOrEditGroupForm form = new AddOrEditGroupForm(GetSelectedGroupFromGrid(dataGridViewGroups));
            form.ShowDialog();
        }

        public static void Delete(DataGridView dataGridViewGroups)
        {
            Group group = GetSelectedGroupFromGrid(dataGridViewGroups);
            DialogResult dialog = MessageBox.Show("Удалить " + group.GroupNumber + " группу?", "Удаление",
              MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (GroupsBL GroupsBl = new GroupsBL())
                {
                    GroupsBl.Delete(group);
                }
            }
        }
    }
}
