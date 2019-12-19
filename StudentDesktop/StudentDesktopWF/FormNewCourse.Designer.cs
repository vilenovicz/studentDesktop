namespace StudentDesktopWF
{
    partial class FormNewCourse
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label competenceIdLabel;
            System.Windows.Forms.Label statusIdLabel;
            System.Windows.Forms.Label dateFromLabel;
            System.Windows.Forms.Label dateToLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewCourse));
            this.studentDataSet = new StudentDesktopWF.studentDataSet();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new StudentDesktopWF.studentDataSetTableAdapters.CoursesTableAdapter();
            this.tableAdapterManager = new StudentDesktopWF.studentDataSetTableAdapters.TableAdapterManager();
            this.competencesTableAdapter = new StudentDesktopWF.studentDataSetTableAdapters.CompetencesTableAdapter();
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.competenceIdComboBox = new System.Windows.Forms.ComboBox();
            this.competencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusIdTextBox = new System.Windows.Forms.TextBox();
            this.dateFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSaveCourse = new System.Windows.Forms.Button();
            this.btnCancelCourse = new System.Windows.Forms.Button();
            this.gbNewCourse = new System.Windows.Forms.GroupBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            competenceIdLabel = new System.Windows.Forms.Label();
            statusIdLabel = new System.Windows.Forms.Label();
            dateFromLabel = new System.Windows.Forms.Label();
            dateToLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).BeginInit();
            this.coursesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competencesBindingSource)).BeginInit();
            this.gbNewCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(18, 36);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(18, 62);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(118, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Наименование курса:";
            // 
            // competenceIdLabel
            // 
            competenceIdLabel.AutoSize = true;
            competenceIdLabel.Location = new System.Drawing.Point(18, 88);
            competenceIdLabel.Name = "competenceIdLabel";
            competenceIdLabel.Size = new System.Drawing.Size(110, 13);
            competenceIdLabel.TabIndex = 5;
            competenceIdLabel.Text = "Компетенция курса:";
            // 
            // statusIdLabel
            // 
            statusIdLabel.AutoSize = true;
            statusIdLabel.Location = new System.Drawing.Point(18, 115);
            statusIdLabel.Name = "statusIdLabel";
            statusIdLabel.Size = new System.Drawing.Size(76, 13);
            statusIdLabel.TabIndex = 7;
            statusIdLabel.Text = "Статус курса:";
            // 
            // dateFromLabel
            // 
            dateFromLabel.AutoSize = true;
            dateFromLabel.Location = new System.Drawing.Point(18, 142);
            dateFromLabel.Name = "dateFromLabel";
            dateFromLabel.Size = new System.Drawing.Size(74, 13);
            dateFromLabel.TabIndex = 9;
            dateFromLabel.Text = "Дата начала:";
            // 
            // dateToLabel
            // 
            dateToLabel.AutoSize = true;
            dateToLabel.Location = new System.Drawing.Point(18, 168);
            dateToLabel.Name = "dateToLabel";
            dateToLabel.Size = new System.Drawing.Size(92, 13);
            dateToLabel.TabIndex = 11;
            dateToLabel.Text = "Дата окончания:";
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
            this.tableAdapterManager.CompetencesTableAdapter = this.competencesTableAdapter;
            this.tableAdapterManager.course_personTableAdapter = null;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.person_competenceTableAdapter = null;
            this.tableAdapterManager.PersonsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StudentDesktopWF.studentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // competencesTableAdapter
            // 
            this.competencesTableAdapter.ClearBeforeFill = true;
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
            this.coursesBindingNavigator.Size = new System.Drawing.Size(671, 25);
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
            this.coursesBindingNavigatorSaveItem.Click += new System.EventHandler(this.coursesBindingNavigatorSaveItem_Click_1);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(106, 33);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(503, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(152, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(457, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // competenceIdComboBox
            // 
            this.competenceIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource, "CompetenceId", true));
            this.competenceIdComboBox.DataSource = this.competencesBindingSource;
            this.competenceIdComboBox.DisplayMember = "Code";
            this.competenceIdComboBox.FormattingEnabled = true;
            this.competenceIdComboBox.Location = new System.Drawing.Point(152, 85);
            this.competenceIdComboBox.Name = "competenceIdComboBox";
            this.competenceIdComboBox.Size = new System.Drawing.Size(457, 21);
            this.competenceIdComboBox.TabIndex = 6;
            this.competenceIdComboBox.ValueMember = "Id";
            // 
            // competencesBindingSource
            // 
            this.competencesBindingSource.DataMember = "Competences";
            this.competencesBindingSource.DataSource = this.studentDataSet;
            // 
            // statusIdTextBox
            // 
            this.statusIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coursesBindingSource, "StatusId", true));
            this.statusIdTextBox.Location = new System.Drawing.Point(152, 112);
            this.statusIdTextBox.Name = "statusIdTextBox";
            this.statusIdTextBox.ReadOnly = true;
            this.statusIdTextBox.Size = new System.Drawing.Size(457, 20);
            this.statusIdTextBox.TabIndex = 8;
            // 
            // dateFromDateTimePicker
            // 
            this.dateFromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.coursesBindingSource, "DateFrom", true));
            this.dateFromDateTimePicker.Location = new System.Drawing.Point(152, 138);
            this.dateFromDateTimePicker.Name = "dateFromDateTimePicker";
            this.dateFromDateTimePicker.Size = new System.Drawing.Size(457, 20);
            this.dateFromDateTimePicker.TabIndex = 10;
            // 
            // dateToDateTimePicker
            // 
            this.dateToDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.coursesBindingSource, "DateTo", true));
            this.dateToDateTimePicker.Location = new System.Drawing.Point(152, 164);
            this.dateToDateTimePicker.Name = "dateToDateTimePicker";
            this.dateToDateTimePicker.Size = new System.Drawing.Size(457, 20);
            this.dateToDateTimePicker.TabIndex = 12;
            // 
            // btnSaveCourse
            // 
            this.btnSaveCourse.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveCourse.Location = new System.Drawing.Point(414, 306);
            this.btnSaveCourse.Name = "btnSaveCourse";
            this.btnSaveCourse.Size = new System.Drawing.Size(90, 23);
            this.btnSaveCourse.TabIndex = 15;
            this.btnSaveCourse.Text = "Сохранить";
            this.btnSaveCourse.UseVisualStyleBackColor = true;
            this.btnSaveCourse.Click += new System.EventHandler(this.btnSaveCourse_Click);
            // 
            // btnCancelCourse
            // 
            this.btnCancelCourse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelCourse.Location = new System.Drawing.Point(556, 306);
            this.btnCancelCourse.Name = "btnCancelCourse";
            this.btnCancelCourse.Size = new System.Drawing.Size(75, 23);
            this.btnCancelCourse.TabIndex = 14;
            this.btnCancelCourse.Text = "Отменить";
            this.btnCancelCourse.UseVisualStyleBackColor = true;
            // 
            // gbNewCourse
            // 
            this.gbNewCourse.Controls.Add(idLabel);
            this.gbNewCourse.Controls.Add(this.dateToDateTimePicker);
            this.gbNewCourse.Controls.Add(dateToLabel);
            this.gbNewCourse.Controls.Add(this.dateFromDateTimePicker);
            this.gbNewCourse.Controls.Add(this.idTextBox);
            this.gbNewCourse.Controls.Add(dateFromLabel);
            this.gbNewCourse.Controls.Add(nameLabel);
            this.gbNewCourse.Controls.Add(this.statusIdTextBox);
            this.gbNewCourse.Controls.Add(this.nameTextBox);
            this.gbNewCourse.Controls.Add(statusIdLabel);
            this.gbNewCourse.Controls.Add(competenceIdLabel);
            this.gbNewCourse.Controls.Add(this.competenceIdComboBox);
            this.gbNewCourse.Location = new System.Drawing.Point(22, 40);
            this.gbNewCourse.Name = "gbNewCourse";
            this.gbNewCourse.Size = new System.Drawing.Size(627, 227);
            this.gbNewCourse.TabIndex = 16;
            this.gbNewCourse.TabStop = false;
            this.gbNewCourse.Text = "Курс обучения";
            // 
            // FormNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 352);
            this.Controls.Add(this.gbNewCourse);
            this.Controls.Add(this.btnSaveCourse);
            this.Controls.Add(this.btnCancelCourse);
            this.Controls.Add(this.coursesBindingNavigator);
            this.Name = "FormNewCourse";
            this.Text = "Добавление курса";
            this.Load += new System.EventHandler(this.NewCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingNavigator)).EndInit();
            this.coursesBindingNavigator.ResumeLayout(false);
            this.coursesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competencesBindingSource)).EndInit();
            this.gbNewCourse.ResumeLayout(false);
            this.gbNewCourse.PerformLayout();
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
        private studentDataSetTableAdapters.CompetencesTableAdapter competencesTableAdapter;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox competenceIdComboBox;
        private System.Windows.Forms.TextBox statusIdTextBox;
        private System.Windows.Forms.DateTimePicker dateFromDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateToDateTimePicker;
        private System.Windows.Forms.BindingSource competencesBindingSource;
        private System.Windows.Forms.Button btnSaveCourse;
        private System.Windows.Forms.Button btnCancelCourse;
        private System.Windows.Forms.GroupBox gbNewCourse;
    }
}