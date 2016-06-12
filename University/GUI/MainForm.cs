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
using System.Data.Entity.Infrastructure;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitStudentsDataGrid();
            InitGroupsDataGrid();
            InitDepartamentsDataGrid();
            InitFacultiesDataGrid();
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDepartaments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFaculties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGroups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void InitGroupsDataGrid()
        {
            dataGridViewGroups.Columns.Clear();
            List<Group> groupList;
            GroupsBL groupsBL = new GroupsBL();
            groupList = groupsBL.GetList();
            dataGridViewGroups.Columns.Add("groupNumber", "Группа");
            dataGridViewGroups.Columns.Add("сourse", "Курс");
            dataGridViewGroups.Columns.Add("specialty", "Специальность");
            dataGridViewGroups.Columns.Add("studentsNumber", "Количество студентов");
            foreach (var group in groupList)
            {
                dataGridViewGroups.Rows.Add(group.GroupNumber, group.Course,
                    group.Specialty.Title, groupsBL.GetStudentsNumber(group));
            }
            //Подгоняем размеры колонок
            dataGridViewGroups.Columns[1].Width = (int)(dataGridViewGroups.Width * 0.1);
            dataGridViewGroups.Columns[2].Width = (int)(dataGridViewGroups.Width * 0.3);
            dataGridViewGroups.Columns[3].Width = (int)(dataGridViewGroups.Width * 0.2);
            groupsBL.Dispose();
        }

        private void InitDepartamentsDataGrid()
        {
            dataGridViewDepartaments.Columns.Clear();
            List<Departament> listDepartaments;
            DepartamentsBL departamentsBL = new DepartamentsBL();
            listDepartaments = departamentsBL.GetList();
            dataGridViewDepartaments.Columns.Add("Id", "Номер");
            dataGridViewDepartaments.Columns.Add("title", "Название");
            dataGridViewDepartaments.Columns.Add("Faculty", "Факультет");
            dataGridViewDepartaments.Columns.Add("Head", "Заведующий");
            dataGridViewDepartaments.Columns.Add("phoneNumber", "Телефон");
            foreach (var dept in listDepartaments)
            {
                dataGridViewDepartaments.Rows.Add(
                    dept.DepartamentID, dept.Title, dept.Faculty.Title, dept.DepartamentHead, dept.PhoneNumber);
            }
            dataGridViewDepartaments.Columns[0].Width = (int)(dataGridViewDepartaments.Width * 0.06);
            dataGridViewDepartaments.Columns[4].Width = (int)(dataGridViewDepartaments.Width * 0.1);
            departamentsBL.Dispose();
        }

        private void InitFacultiesDataGrid()
        {
            FacultiesBL facultiesBL = new FacultiesBL();
            dataGridViewFaculties.DataSource =
                new BindingList<Faculty>(facultiesBL.GetList());
            dataGridViewFaculties.Columns[0].HeaderText = "Номер";
            dataGridViewFaculties.Columns[1].HeaderText = "Название";
            dataGridViewFaculties.Columns[2].HeaderText = "Декан";
            dataGridViewFaculties.Columns[3].HeaderText = "Телефон";
            dataGridViewFaculties.Columns[4].Visible = false;
        }

        private void InitStudentsDataGrid()
        {
            StudentsBL studentsBL = new StudentsBL();
            List<Student> studList = studentsBL.GetList();
            BindingList<Student> bindList =
                new BindingList<Student>(studList);
            dataGridViewStudents.DataSource = bindList;
            dataGridViewStudents.Columns[0].HeaderText = "ID";
            dataGridViewStudents.Columns[1].HeaderText = "Группа";
            dataGridViewStudents.Columns[2].HeaderText = "Студент";
            dataGridViewStudents.Columns[3].HeaderText = "Дата рождения";
            dataGridViewStudents.Columns[4].HeaderText = "Номер зачётной книжки";
            dataGridViewStudents.Columns[5].Visible = false;
            dataGridViewStudents.Columns[6].Visible = false;
            dataGridViewStudents.Columns[7].Visible = false;
            studentsBL.Dispose();
        }
        
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentActions.Delete(this.dataGridViewStudents);
            InitStudentsDataGrid();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentActions.Add();
            InitStudentsDataGrid();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentActions.Edit(this.dataGridViewStudents);
            InitStudentsDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentActions.ShowStudentsProgressChart(this.dataGridViewStudents);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                StudentActions.SelectFindedRow(textBoxSearch.Text, this.dataGridViewStudents);
            }
            if (tabControl.SelectedIndex == 1)
            {
                GroupsActions.SelectFindedRow(textBoxSearch.Text, this.dataGridViewGroups);
            }
            if (tabControl.SelectedIndex == 2)
            {
                DepartamentsActions.SelectFindedRow(textBoxSearch.Text, this.dataGridViewDepartaments);
            }
            if (tabControl.SelectedIndex == 3)
            {
                FacultiesActions.SelectFindedRow(textBoxSearch.Text, this.dataGridViewFaculties);
            }
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            StudentAttendanceChartForm form = new StudentAttendanceChartForm
                (StudentActions.GetSelectedStudentFromGrid(this.dataGridViewStudents));
            form.ShowDialog();
        }

        private void успеваемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentActions.ShowStudentsProgressChart(this.dataGridViewStudents);
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAttendanceChartForm form = new StudentAttendanceChartForm
                (StudentActions.GetSelectedStudentFromGrid(this.dataGridViewStudents));
            form.ShowDialog();
        }

        private void AddGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupsActions.Add(this.dataGridViewGroups);
            InitGroupsDataGrid();
        }

        private void EditGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupsActions.Edit(this.dataGridViewGroups);
            InitGroupsDataGrid();
        }

        private void DeleteGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupsActions.Delete(this.dataGridViewGroups);
            InitGroupsDataGrid();
        }

        private void AddDepartamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartamentsActions.Add();
            InitDepartamentsDataGrid();
        }

        private void EditDepartamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartamentsActions.Edit(this.dataGridViewDepartaments);
            InitDepartamentsDataGrid();
        }

        private void DeleteDepartamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartamentsActions.Delete(this.dataGridViewDepartaments);
            InitDepartamentsDataGrid();
        }

        private void AddFacultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultiesActions.Add();
            InitFacultiesDataGrid();
        }

        private void EditFacultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacultiesActions.Edit(this.dataGridViewFaculties);
            InitFacultiesDataGrid();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                StudentActions.Add();
                InitStudentsDataGrid();
            }
            if (tabControl.SelectedIndex == 1)
            {
                GroupsActions.Add(this.dataGridViewGroups);
                InitGroupsDataGrid();
            }
            if (tabControl.SelectedIndex == 2)
            {
                DepartamentsActions.Add();
                InitDepartamentsDataGrid();
            }
            if (tabControl.SelectedIndex == 3)
            {
                FacultiesActions.Add();
                InitFacultiesDataGrid();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedIndex == 0)
                {
                    StudentActions.Edit(this.dataGridViewStudents);
                    InitStudentsDataGrid();
                }
                if (tabControl.SelectedIndex == 1)
                {
                    GroupsActions.Edit(this.dataGridViewGroups);
                    InitGroupsDataGrid();
                }
                if (tabControl.SelectedIndex == 2)
                {
                    DepartamentsActions.Edit(this.dataGridViewDepartaments);
                    InitDepartamentsDataGrid();
                }
                if (tabControl.SelectedIndex == 3)
                {
                    FacultiesActions.Edit(this.dataGridViewFaculties);
                    InitFacultiesDataGrid();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Строка не выбрана");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedIndex == 0)
                {
                    StudentActions.Delete(this.dataGridViewStudents);
                    InitStudentsDataGrid();
                }
                if (tabControl.SelectedIndex == 1)
                {
                    GroupsActions.Delete(this.dataGridViewGroups);
                    InitGroupsDataGrid();
                }
                if (tabControl.SelectedIndex == 2)
                {
                    DepartamentsActions.Delete(this.dataGridViewDepartaments);
                    InitDepartamentsDataGrid();
                }
                if (tabControl.SelectedIndex == 3)
                {
                    FacultiesActions.Delete(this.dataGridViewFaculties);
                    InitFacultiesDataGrid();
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Запрещается удалять действующую кафедру");
            }
            catch (Exception)
            {
                MessageBox.Show("Строка не выбрана");
            }
        }
    }
}
