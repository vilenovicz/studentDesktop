namespace StudentDesktopWF
{
    partial class FormCourses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCourses));
            this.studentDataSet = new StudentDesktopWF.studentDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new StudentDesktopWF.studentDataSetTableAdapters.CoursesTableAdapter();
            this.tableAdapterManager = new StudentDesktopWF.studentDataSetTableAdapters.TableAdapterManager();
            this.coursesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.coursesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.cmCourses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new StudentDesktopWF.studentDataSetTableAdapters.PersonsTableAdapter();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmPersons = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delPersonFromCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).BeginInit();
            this.coursesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.cmCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            this.cmPersons.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "studentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.studentDataSet;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompetencesTableAdapter = null;
            this.tableAdapterManager.course_personTableAdapter = null;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.person_competenceTableAdapter = null;
            this.tableAdapterManager.PersonsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StudentDesktopWF.studentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // coursesBindingNavigator
            // 
            this.coursesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coursesBindingNavigator.BindingSource = this.coursesBindingSource;
            this.coursesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coursesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coursesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.coursesBindingNavigatorSaveItem});
            this.coursesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coursesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coursesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coursesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coursesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coursesBindingNavigator.Name = "coursesBindingNavigator";
            this.coursesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coursesBindingNavigator.Size = new System.Drawing.Size(808, 25);
            this.coursesBindingNavigator.TabIndex = 0;
            this.coursesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // coursesBindingNavigatorSaveItem
            // 
            this.coursesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coursesBindingNavigatorSaveItem.Enabled = false;
            this.coursesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coursesBindingNavigatorSaveItem.Image")));
            this.coursesBindingNavigatorSaveItem.Name = "coursesBindingNavigatorSaveItem";
            this.coursesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.coursesBindingNavigatorSaveItem.Text = "Save Data";
            this.coursesBindingNavigatorSaveItem.Click += new System.EventHandler(this.coursesBindingNavigatorSaveItem_Click);
            // 
            // coursesDataGridView
            // 
            this.coursesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.coursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursesDataGridView.ContextMenuStrip = this.cmCourses;
            this.coursesDataGridView.Location = new System.Drawing.Point(12, 28);
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.coursesDataGridView.Size = new System.Drawing.Size(776, 196);
            this.coursesDataGridView.TabIndex = 1;
            // 
            // cmCourses
            // 
            this.cmCourses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.closeCourseToolStripMenuItem,
            this.delCourseToolStripMenuItem,
            this.toolStripSeparator1,
            this.ToCourseToolStripMenuItem});
            this.cmCourses.Name = "cmCourses";
            this.cmCourses.Size = new System.Drawing.Size(183, 120);
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addCourseToolStripMenuItem.Text = "Добавить курс";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.editCourseToolStripMenuItem.Text = "Редактировать курс";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // closeCourseToolStripMenuItem
            // 
            this.closeCourseToolStripMenuItem.Name = "closeCourseToolStripMenuItem";
            this.closeCourseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.closeCourseToolStripMenuItem.Text = "Закрыть курс";
            this.closeCourseToolStripMenuItem.Click += new System.EventHandler(this.closeCourseToolStripMenuItem_Click);
            // 
            // delCourseToolStripMenuItem
            // 
            this.delCourseToolStripMenuItem.Name = "delCourseToolStripMenuItem";
            this.delCourseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.delCourseToolStripMenuItem.Text = "Удалить курс";
            this.delCourseToolStripMenuItem.Click += new System.EventHandler(this.delCourseToolStripMenuItem_Click);
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataSource = this.coursesBindingSource;
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.ContextMenuStrip = this.cmPersons;
            this.personsDataGridView.Location = new System.Drawing.Point(12, 261);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personsDataGridView.Size = new System.Drawing.Size(776, 220);
            this.personsDataGridView.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // ToCourseToolStripMenuItem
            // 
            this.ToCourseToolStripMenuItem.Name = "ToCourseToolStripMenuItem";
            this.ToCourseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ToCourseToolStripMenuItem.Text = "Направить на курс";
            this.ToCourseToolStripMenuItem.Click += new System.EventHandler(this.направитьНаКурсToolStripMenuItem_Click);
            // 
            // cmPersons
            // 
            this.cmPersons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delPersonFromCourseToolStripMenuItem});
            this.cmPersons.Name = "cmPersons";
            this.cmPersons.Size = new System.Drawing.Size(242, 26);
            // 
            // delPersonFromCourseToolStripMenuItem
            // 
            this.delPersonFromCourseToolStripMenuItem.Name = "delPersonFromCourseToolStripMenuItem";
            this.delPersonFromCourseToolStripMenuItem.Size = new System.Drawing.Size(241, 22);
            this.delPersonFromCourseToolStripMenuItem.Text = "Отозвать Сотрудника из Курса";
            this.delPersonFromCourseToolStripMenuItem.Click += new System.EventHandler(this.delPersonFromCourseToolStripMenuItem_Click);
            // 
            // FormCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 538);
            this.Controls.Add(this.personsDataGridView);
            this.Controls.Add(this.coursesDataGridView);
            this.Controls.Add(this.coursesBindingNavigator);
            this.Name = "FormCourses";
            this.Text = "Курсы обучения";
            this.Load += new System.EventHandler(this.FormCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).EndInit();
            this.coursesBindingNavigator.ResumeLayout(false);
            this.coursesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            this.cmCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            this.cmPersons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private studentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private studentDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private studentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coursesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton coursesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView coursesDataGridView;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private studentDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private System.Windows.Forms.DataGridView personsDataGridView;
        private System.Windows.Forms.ContextMenuStrip cmCourses;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToCourseToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmPersons;
        private System.Windows.Forms.ToolStripMenuItem delPersonFromCourseToolStripMenuItem;
    }
}