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
    public partial class AddOrEditStudentForm : Form
    {
        /// <summary>
        /// Редактируемый студент
        /// </summary>
        private Student _editStudent;
        
        public AddOrEditStudentForm(Student editStudent = null)
        {
            InitializeComponent();
            InitGroupsCombobox();
            if (editStudent != null)
            {
                _editStudent = editStudent;
                buttonAddStud.Visible = false;
                buttonApplyChanges.Visible = true;
                labelAddOrRedact.Text = "Редактирование информации о студенте";
                InitEditedFormFields();
            }
            else
            {
                buttonAddStud.Visible = true;
                buttonApplyChanges.Visible = false;
            }
        }
        /// <summary>
        /// Инициализировать поля данными редактируемого студента
        /// </summary>
        private void InitEditedFormFields()
        {
            textBoxFullName.Text = _editStudent.FullName;
            textBoxStudentsRecord.Text = _editStudent.StudentRecordNumber;
            dateTimePicker.Value = (DateTime)_editStudent.BirthDate;
            int index = comboBoxGroups.Items.IndexOf(_editStudent.GroupNumber);
            comboBoxGroups.SelectedIndex = index;
        }
        /// <summary>
        /// Инициализировать элемент управления доступным списком групп
        /// </summary>
        private void InitGroupsCombobox()
        {
            using (GroupsBL groupsBL = new GroupsBL())
            {
                var list = groupsBL.GetList();
                foreach (var group in list)
                {
                    comboBoxGroups.Items.Add(group.GroupNumber);
                }
            }
            comboBoxGroups.SelectedIndex = 0;
        }
        /// <summary>
        /// Создать студента по заполненным полям формы
        /// </summary>
        /// <returns></returns>
        private Student CreateStudent()
        {
            Student student = new Student
            {
                BirthDate = this.dateTimePicker.Value,
                FullName = this.textBoxFullName.Text,
                GroupNumber = (int)comboBoxGroups.SelectedItem,
                StudentRecordNumber = textBoxStudentsRecord.Text
            };
            return student;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Добавить студента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddStud_Click(object sender, EventArgs e)
        {
            using(StudentsBL studentsBL = new StudentsBL())
            {
                var student = CreateStudent();
                studentsBL.Add(student);
            }
            MessageBox.Show("Студент добавлен");
            this.Close();
        }

        private void buttonApplyChanges_Click(object sender, EventArgs e)
        {
            var studentAfterEdit = CreateStudent();
            studentAfterEdit.StudentID = _editStudent.StudentID;
            using (StudentsBL studentsBL = new StudentsBL())
            {
                studentsBL.Edit(studentAfterEdit);
            }
            MessageBox.Show("Изменения приняты");
            this.Close();
        }

        private void AddOrEditStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
