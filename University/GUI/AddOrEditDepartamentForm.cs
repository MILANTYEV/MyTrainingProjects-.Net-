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
    public partial class AddOrEditDepartamentForm : Form
    {
        private Departament _editDepartament;

        public AddOrEditDepartamentForm(Departament departament = null)
        {
            InitializeComponent();
            InitComboboxFaculty();
            if (departament != null)
            {
                _editDepartament = departament;
                buttonAdd.Visible = false;
                buttonApplyChanges.Visible = true;
                InitEditedFormFields();
            }
        }

        /// <summary>
        /// Инициализировать поля данными редактируемой группы
        /// </summary>
        private void InitEditedFormFields()
        {
            using (DepartamentsBL departamentsBL = new DepartamentsBL())
            {
                Departament editDepartamentFromConnection = (from dep in departamentsBL.GetList()
                                                             where dep.DepartamentID == _editDepartament.DepartamentID
                                                             select dep).FirstOrDefault();
                textBoxHead.Text = editDepartamentFromConnection.DepartamentHead;
                textBoxTitle.Text = editDepartamentFromConnection.Title;
                textBoxPhoneNumber.Text = editDepartamentFromConnection.PhoneNumber;
                foreach (var item in comboBoxFaculty.Items)
                {
                    if (((Faculty)item).FacultyID == editDepartamentFromConnection.FacultyID)
                    {
                        comboBoxFaculty.SelectedIndex = comboBoxFaculty.Items.IndexOf(item);
                    }
                }
            }
        }

        private void InitComboboxFaculty()
        {
            using (FacultiesBL facultiesBL = new FacultiesBL())
            {
                foreach (Faculty faculty in facultiesBL.GetList())
                {
                    comboBoxFaculty.Items.Add(faculty);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Departament departament = new Departament
            {
                Title = textBoxTitle.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                DepartamentHead = textBoxHead.Text,
                FacultyID = ((Faculty)comboBoxFaculty.SelectedItem).FacultyID
            };
            using (DepartamentsBL departamentsBL = new DepartamentsBL())
            {
                departamentsBL.Add(departament);
            }
            MessageBox.Show("Кафедра добавлена");
            this.Close();
        }

        private void buttonApplyChanges_Click(object sender, EventArgs e)
        {
            Departament departamentAfterEdit = new Departament()
            {
                DepartamentID = _editDepartament.DepartamentID,
                Title = textBoxTitle.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                DepartamentHead = textBoxHead.Text,
                FacultyID = ((Faculty)comboBoxFaculty.SelectedItem).FacultyID
            };
            using (DepartamentsBL departamentsBL = new DepartamentsBL())
            {
                departamentsBL.Edit(departamentAfterEdit);
            }
            MessageBox.Show("Изменения приняты");
            this.Close();
        }

        private void buttonCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
