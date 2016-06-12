namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.tabPageDepartaments = new System.Windows.Forms.TabPage();
            this.dataGridViewDepartaments = new System.Windows.Forms.DataGridView();
            this.tabPageFaculties = new System.Windows.Forms.TabPage();
            this.dataGridViewFaculties = new System.Windows.Forms.DataGridView();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelRSREU = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.progressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.DeleteGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDepartamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditDepartamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteDepartamentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.факультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFacultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditFacultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFacultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.tabPageDepartaments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartaments)).BeginInit();
            this.tabPageFaculties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaculties)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStudents.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.Size = new System.Drawing.Size(724, 300);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStudents);
            this.tabControl.Controls.Add(this.tabPageGroups);
            this.tabControl.Controls.Add(this.tabPageDepartaments);
            this.tabControl.Controls.Add(this.tabPageFaculties);
            this.tabControl.ItemSize = new System.Drawing.Size(300, 20);
            this.tabControl.Location = new System.Drawing.Point(12, 99);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(738, 334);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 24);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(730, 306);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Студенты";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 24);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(730, 306);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Группы";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGroups.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.Size = new System.Drawing.Size(724, 300);
            this.dataGridViewGroups.TabIndex = 0;
            // 
            // tabPageDepartaments
            // 
            this.tabPageDepartaments.Controls.Add(this.dataGridViewDepartaments);
            this.tabPageDepartaments.Location = new System.Drawing.Point(4, 24);
            this.tabPageDepartaments.Name = "tabPageDepartaments";
            this.tabPageDepartaments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepartaments.Size = new System.Drawing.Size(730, 306);
            this.tabPageDepartaments.TabIndex = 2;
            this.tabPageDepartaments.Text = "Кафедры";
            this.tabPageDepartaments.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDepartaments
            // 
            this.dataGridViewDepartaments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDepartaments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDepartaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartaments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDepartaments.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDepartaments.Name = "dataGridViewDepartaments";
            this.dataGridViewDepartaments.Size = new System.Drawing.Size(724, 300);
            this.dataGridViewDepartaments.TabIndex = 1;
            // 
            // tabPageFaculties
            // 
            this.tabPageFaculties.Controls.Add(this.dataGridViewFaculties);
            this.tabPageFaculties.Location = new System.Drawing.Point(4, 24);
            this.tabPageFaculties.Name = "tabPageFaculties";
            this.tabPageFaculties.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFaculties.Size = new System.Drawing.Size(730, 306);
            this.tabPageFaculties.TabIndex = 3;
            this.tabPageFaculties.Text = "Факультеты";
            this.tabPageFaculties.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFaculties
            // 
            this.dataGridViewFaculties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFaculties.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFaculties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaculties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFaculties.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFaculties.Name = "dataGridViewFaculties";
            this.dataGridViewFaculties.Size = new System.Drawing.Size(724, 300);
            this.dataGridViewFaculties.TabIndex = 1;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.GroupToolStripMenuItem,
            this.DepartamentToolStripMenuItem,
            this.факультетToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(762, 24);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.progressToolStripMenuItem,
            this.attendanceToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.fileToolStripMenuItem.Text = "Студент";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // labelRSREU
            // 
            this.labelRSREU.BackColor = System.Drawing.Color.SteelBlue;
            this.labelRSREU.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelRSREU.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRSREU.ForeColor = System.Drawing.Color.White;
            this.labelRSREU.Location = new System.Drawing.Point(0, 24);
            this.labelRSREU.Name = "labelRSREU";
            this.labelRSREU.Size = new System.Drawing.Size(762, 51);
            this.labelRSREU.TabIndex = 3;
            this.labelRSREU.Text = "Рязанский государственный радиотехнический университет";
            this.labelRSREU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(225, 78);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(48, 18);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(279, 76);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(192, 20);
            this.textBoxSearch.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(477, 76);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Искать";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // progressToolStripMenuItem
            // 
            this.progressToolStripMenuItem.Name = "progressToolStripMenuItem";
            this.progressToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.progressToolStripMenuItem.Text = "Успеваемость";
            this.progressToolStripMenuItem.Click += new System.EventHandler(this.успеваемостьToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.attendanceToolStripMenuItem.Text = "Посещаемость";
            this.attendanceToolStripMenuItem.Click += new System.EventHandler(this.attendanceToolStripMenuItem_Click);
            // 
            // GroupToolStripMenuItem
            // 
            this.GroupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddGroupToolStripMenuItem,
            this.EditGroupToolStripMenuItem,
            this.DeleteGroupToolStripMenuItem});
            this.GroupToolStripMenuItem.Name = "GroupToolStripMenuItem";
            this.GroupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.GroupToolStripMenuItem.Text = "Группа";
            // 
            // AddGroupToolStripMenuItem
            // 
            this.AddGroupToolStripMenuItem.Name = "AddGroupToolStripMenuItem";
            this.AddGroupToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AddGroupToolStripMenuItem.Text = "Добавить";
            this.AddGroupToolStripMenuItem.Click += new System.EventHandler(this.AddGroupToolStripMenuItem_Click);
            // 
            // EditGroupToolStripMenuItem
            // 
            this.EditGroupToolStripMenuItem.Name = "EditGroupToolStripMenuItem";
            this.EditGroupToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.EditGroupToolStripMenuItem.Text = "Редактировать";
            this.EditGroupToolStripMenuItem.Click += new System.EventHandler(this.EditGroupToolStripMenuItem_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(489, 439);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(157, 32);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // DeleteGroupToolStripMenuItem
            // 
            this.DeleteGroupToolStripMenuItem.Name = "DeleteGroupToolStripMenuItem";
            this.DeleteGroupToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.DeleteGroupToolStripMenuItem.Text = "Удалить";
            this.DeleteGroupToolStripMenuItem.Click += new System.EventHandler(this.DeleteGroupToolStripMenuItem_Click);
            // 
            // DepartamentToolStripMenuItem
            // 
            this.DepartamentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDepartamentToolStripMenuItem,
            this.EditDepartamentToolStripMenuItem,
            this.DeleteDepartamentToolStripMenuItem});
            this.DepartamentToolStripMenuItem.Name = "DepartamentToolStripMenuItem";
            this.DepartamentToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.DepartamentToolStripMenuItem.Text = "Кафедра";
            // 
            // AddDepartamentToolStripMenuItem
            // 
            this.AddDepartamentToolStripMenuItem.Name = "AddDepartamentToolStripMenuItem";
            this.AddDepartamentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AddDepartamentToolStripMenuItem.Text = "Добавить";
            this.AddDepartamentToolStripMenuItem.Click += new System.EventHandler(this.AddDepartamentToolStripMenuItem_Click);
            // 
            // EditDepartamentToolStripMenuItem
            // 
            this.EditDepartamentToolStripMenuItem.Name = "EditDepartamentToolStripMenuItem";
            this.EditDepartamentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.EditDepartamentToolStripMenuItem.Text = "Редактировать";
            this.EditDepartamentToolStripMenuItem.Click += new System.EventHandler(this.EditDepartamentToolStripMenuItem_Click);
            // 
            // DeleteDepartamentToolStripMenuItem
            // 
            this.DeleteDepartamentToolStripMenuItem.Name = "DeleteDepartamentToolStripMenuItem";
            this.DeleteDepartamentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.DeleteDepartamentToolStripMenuItem.Text = "Удалить";
            this.DeleteDepartamentToolStripMenuItem.Click += new System.EventHandler(this.DeleteDepartamentToolStripMenuItem_Click);
            // 
            // факультетToolStripMenuItem
            // 
            this.факультетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFacultyToolStripMenuItem,
            this.EditFacultyToolStripMenuItem,
            this.DeleteFacultyToolStripMenuItem});
            this.факультетToolStripMenuItem.Name = "факультетToolStripMenuItem";
            this.факультетToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.факультетToolStripMenuItem.Text = "Факультет";
            // 
            // AddFacultyToolStripMenuItem
            // 
            this.AddFacultyToolStripMenuItem.Name = "AddFacultyToolStripMenuItem";
            this.AddFacultyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.AddFacultyToolStripMenuItem.Text = "Добавить";
            this.AddFacultyToolStripMenuItem.Click += new System.EventHandler(this.AddFacultyToolStripMenuItem_Click);
            // 
            // EditFacultyToolStripMenuItem
            // 
            this.EditFacultyToolStripMenuItem.Name = "EditFacultyToolStripMenuItem";
            this.EditFacultyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.EditFacultyToolStripMenuItem.Text = "Редактировать";
            this.EditFacultyToolStripMenuItem.Click += new System.EventHandler(this.EditFacultyToolStripMenuItem_Click);
            // 
            // DeleteFacultyToolStripMenuItem
            // 
            this.DeleteFacultyToolStripMenuItem.Name = "DeleteFacultyToolStripMenuItem";
            this.DeleteFacultyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.DeleteFacultyToolStripMenuItem.Text = "Удалить";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(89, 439);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(157, 32);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(287, 439);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(157, 32);
            this.buttonEdit.TabIndex = 10;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 507);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelRSREU);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "Университет";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.tabPageDepartaments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartaments)).EndInit();
            this.tabPageFaculties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaculties)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.Label labelRSREU;
        private System.Windows.Forms.TabPage tabPageDepartaments;
        private System.Windows.Forms.DataGridView dataGridViewDepartaments;
        private System.Windows.Forms.TabPage tabPageFaculties;
        private System.Windows.Forms.DataGridView dataGridViewFaculties;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ToolStripMenuItem progressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditGroupToolStripMenuItem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ToolStripMenuItem DeleteGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepartamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDepartamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditDepartamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteDepartamentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem факультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddFacultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditFacultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteFacultyToolStripMenuItem;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
    }
}

