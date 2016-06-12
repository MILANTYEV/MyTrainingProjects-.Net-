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
    public partial class AddOrEditFacultyForm : Form
    {
        private Faculty _editedFaculty;

        public AddOrEditFacultyForm(Faculty faculty = null)
        {
            InitializeComponent();
            if (faculty != null)
            {
                _editedFaculty = faculty;
                buttonApplyChanges.Visible = true;
                buttonAdd.Visible = false;
                InitEditedFormFields();
            }
        }

        /// <summary>
        /// Инициализировать поля данными редактируемой группы
        /// </summary>
        private void InitEditedFormFields()
        {
            textBoxTitle.Text = _editedFaculty.Title;
            textBoxDean.Text = _editedFaculty.Dean;
            textBoxCellPhone.Text = _editedFaculty.PhoneNumber;
        }

        private void buttonCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Faculty faculty = new Faculty
            {
                Title = textBoxTitle.Text,
                Dean = textBoxDean.Text,
                PhoneNumber = textBoxCellPhone.Text
            };
            using (FacultiesBL facultiesBL = new FacultiesBL())
            {
                facultiesBL.Add(faculty);
            }
            MessageBox.Show("Информация добавлена");
            this.Close();
        }

        private void buttonApplyChanges_Click(object sender, EventArgs e)
        {
            Faculty facultyAfterEdit = new Faculty
            {
                Title = textBoxTitle.Text,
                Dean = textBoxDean.Text,
                PhoneNumber = textBoxCellPhone.Text,
                FacultyID = _editedFaculty.FacultyID
            };
            using (FacultiesBL facultiesBL = new FacultiesBL())
            {
                facultiesBL.Edit(facultyAfterEdit);
            }
            MessageBox.Show("Изменения приняты");
            this.Close();
        }
    }
}
