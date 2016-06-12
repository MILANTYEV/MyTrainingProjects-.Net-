using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Entities;

namespace GUI
{
    public partial class AddOrEditGroupForm : Form
    {
        private Group _editGroup;

        public AddOrEditGroupForm(Group group = null)
        {
            InitializeComponent();
            InitComboboxCourse();
            InitComboboxSpecialty();
            if (group != null)
            {
                _editGroup = group;
                InitEditedFormFields();
                buttonAdd.Visible = false;
                buttonApplyChanges.Visible = true;
                textBoxGroupNumber.Enabled = false;
                labelAddOrEdit.Text = "Редактирование информации о группе";
            }
        }

        /// <summary>
        /// Инициализировать поля данными редактируемой группы
        /// </summary>
        private void InitEditedFormFields()
        {
            using (GroupsBL groupsBL = new GroupsBL())
            {
                Group editGroupFromConnection = (from gr in groupsBL.GetList()
                                                 where gr.GroupNumber == _editGroup.GroupNumber
                                                 select gr).FirstOrDefault();
                textBoxGroupNumber.Text = editGroupFromConnection.GroupNumber.ToString();
                int index = comboBoxCourse.Items.IndexOf(editGroupFromConnection.Course);
                comboBoxCourse.SelectedIndex = index;
                foreach (var item in comboBoxSpecialty.Items)
                {
                    if (((Specialty)item).Title == editGroupFromConnection.Specialty.Title)
                    {
                        index = comboBoxSpecialty.Items.IndexOf(item);
                    }
                }
                comboBoxSpecialty.SelectedIndex = index;
            }
        }

        private void InitComboboxSpecialty()
        {
            SpecialtiesBL specialtiesBL = new SpecialtiesBL();
            foreach (var spec in specialtiesBL.GetList())
            {
                comboBoxSpecialty.Items.Add(spec);
            }
        }

        private void InitComboboxCourse()
        {
            for (int i = 1; i<=5; i++)
            {
                comboBoxCourse.Items.Add(i);
            }
            comboBoxCourse.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            GroupsBL groupsBL = new GroupsBL();
            Group group = new Group
            {
                GroupNumber = int.Parse(textBoxGroupNumber.Text),
                Course = (int)comboBoxCourse.SelectedItem,
                SpecialtyID = ((Specialty)comboBoxSpecialty.SelectedItem).SpecialtyID
            };
            groupsBL.Add(group);
            MessageBox.Show("Группа добавлена");
            groupsBL.Dispose();
            this.Close();
        }

        private void buttonCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApplyChanges_Click(object sender, EventArgs e)
        {
            Group groupAfterEdit = new Group
            {
                GroupNumber = int.Parse(textBoxGroupNumber.Text),
                Course = (int)comboBoxCourse.SelectedItem,
                SpecialtyID = ((Specialty)comboBoxSpecialty.SelectedItem).SpecialtyID
            };
            using (GroupsBL groupsBL = new GroupsBL())
            {
                groupsBL.Edit(groupAfterEdit);
            }
            MessageBox.Show("Изменения приняты");
            this.Close();
        }
    }
}
