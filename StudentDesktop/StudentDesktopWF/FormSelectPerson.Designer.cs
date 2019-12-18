namespace StudentDesktopWF
{
    partial class FormSelectPerson
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
            this.studentDataSet = new StudentDesktopWF.studentDataSet();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new StudentDesktopWF.studentDataSetTableAdapters.PersonsTableAdapter();
            this.tableAdapterManager = new StudentDesktopWF.studentDataSetTableAdapters.TableAdapterManager();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new StudentDesktopWF.studentDataSetTableAdapters.DepartmentsTableAdapter();
            this.btnToCourse = new System.Windows.Forms.Button();
            this.btnCancelToCourse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDataSet
            // 
            this.studentDataSet.DataSetName = "studentDataSet";
            this.studentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.studentDataSet;
            this.personsBindingSource.Filter = "";
            // 
            // personsTableAdapter
            // 
            this.personsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompetencesTableAdapter = null;
            this.tableAdapterManager.course_personTableAdapter = null;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.person_competenceTableAdapter = null;
            this.tableAdapterManager.PersonsTableAdapter = this.personsTableAdapter;
            this.tableAdapterManager.UpdateOrder = StudentDesktopWF.studentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.AutoGenerateColumns = false;
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.personsDataGridView.DataSource = this.personsBindingSource;
            this.personsDataGridView.Location = new System.Drawing.Point(20, 97);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personsDataGridView.Size = new System.Drawing.Size(768, 220);
            this.personsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Birthday";
            this.dataGridViewTextBoxColumn4.HeaderText = "Birthday";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DepartmentId";
            this.dataGridViewTextBoxColumn5.HeaderText = "DepartmentId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // cbDepartment
            // 
            this.cbDepartment.DataSource = this.departmentsBindingSource;
            this.cbDepartment.DisplayMember = "Code";
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(535, 70);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(253, 21);
            this.cbDepartment.TabIndex = 2;
            this.cbDepartment.ValueMember = "Id";
            this.cbDepartment.SelectedValueChanged += new System.EventHandler(this.cbDepartment_SelectedValueChanged);
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.studentDataSet;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // btnToCourse
            // 
            this.btnToCourse.Location = new System.Drawing.Point(524, 401);
            this.btnToCourse.Name = "btnToCourse";
            this.btnToCourse.Size = new System.Drawing.Size(120, 23);
            this.btnToCourse.TabIndex = 3;
            this.btnToCourse.Text = "Направить на курс";
            this.btnToCourse.UseVisualStyleBackColor = true;
            this.btnToCourse.Click += new System.EventHandler(this.btnToCourse_Click);
            // 
            // btnCancelToCourse
            // 
            this.btnCancelToCourse.Location = new System.Drawing.Point(650, 401);
            this.btnCancelToCourse.Name = "btnCancelToCourse";
            this.btnCancelToCourse.Size = new System.Drawing.Size(104, 23);
            this.btnCancelToCourse.TabIndex = 4;
            this.btnCancelToCourse.Text = "Отменить";
            this.btnCancelToCourse.UseVisualStyleBackColor = true;
            this.btnCancelToCourse.Click += new System.EventHandler(this.btnCancelToCourse_Click);
            // 
            // FormSelectPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelToCourse);
            this.Controls.Add(this.btnToCourse);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.personsDataGridView);
            this.Name = "FormSelectPerson";
            this.Text = "Выберите сотрудников";
            this.Load += new System.EventHandler(this.FormSelectPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private studentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private studentDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private studentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView personsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private studentDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.Button btnToCourse;
        private System.Windows.Forms.Button btnCancelToCourse;
    }
}