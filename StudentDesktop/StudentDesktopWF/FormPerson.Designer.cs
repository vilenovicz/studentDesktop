namespace StudentDesktopWF
{
    partial class FormPerson
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
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label departmentIdLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelPerson = new System.Windows.Forms.Button();
            this.btnSavePerson = new System.Windows.Forms.Button();
            this.studentDataSet = new StudentDesktopWF.studentDataSet();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personsTableAdapter = new StudentDesktopWF.studentDataSetTableAdapters.PersonsTableAdapter();
            this.tableAdapterManager = new StudentDesktopWF.studentDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departmentIdComboBox = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new StudentDesktopWF.studentDataSetTableAdapters.DepartmentsTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            departmentIdLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(lastNameLabel);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(firstNameLabel);
            this.groupBox1.Controls.Add(this.firstNameTextBox);
            this.groupBox1.Controls.Add(birthdayLabel);
            this.groupBox1.Controls.Add(this.birthdayDateTimePicker);
            this.groupBox1.Controls.Add(departmentIdLabel);
            this.groupBox1.Controls.Add(this.departmentIdComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 203);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудник";
            // 
            // btnCancelPerson
            // 
            this.btnCancelPerson.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelPerson.Location = new System.Drawing.Point(281, 254);
            this.btnCancelPerson.Name = "btnCancelPerson";
            this.btnCancelPerson.Size = new System.Drawing.Size(75, 23);
            this.btnCancelPerson.TabIndex = 12;
            this.btnCancelPerson.Text = "Отменить";
            this.btnCancelPerson.UseVisualStyleBackColor = true;
            // 
            // btnSavePerson
            // 
            this.btnSavePerson.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSavePerson.Location = new System.Drawing.Point(60, 254);
            this.btnSavePerson.Name = "btnSavePerson";
            this.btnSavePerson.Size = new System.Drawing.Size(75, 23);
            this.btnSavePerson.TabIndex = 13;
            this.btnSavePerson.Text = "Сохранить";
            this.btnSavePerson.UseVisualStyleBackColor = true;
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
            this.tableAdapterManager.DepartmentsTableAdapter = this.departmentsTableAdapter;
            this.tableAdapterManager.person_competenceTableAdapter = null;
            this.tableAdapterManager.PersonsTableAdapter = this.personsTableAdapter;
            this.tableAdapterManager.UpdateOrder = StudentDesktopWF.studentDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(16, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(99, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(16, 67);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(99, 64);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(16, 93);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 4;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(99, 90);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(16, 120);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 6;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personsBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(99, 116);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateTimePicker.TabIndex = 7;
            // 
            // departmentIdLabel
            // 
            departmentIdLabel.AutoSize = true;
            departmentIdLabel.Location = new System.Drawing.Point(16, 145);
            departmentIdLabel.Name = "departmentIdLabel";
            departmentIdLabel.Size = new System.Drawing.Size(77, 13);
            departmentIdLabel.TabIndex = 8;
            departmentIdLabel.Text = "Department Id:";
            // 
            // departmentIdComboBox
            // 
            this.departmentIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personsBindingSource, "DepartmentId", true));
            this.departmentIdComboBox.DataSource = this.departmentsBindingSource;
            this.departmentIdComboBox.DisplayMember = "Code";
            this.departmentIdComboBox.FormattingEnabled = true;
            this.departmentIdComboBox.Location = new System.Drawing.Point(99, 142);
            this.departmentIdComboBox.Name = "departmentIdComboBox";
            this.departmentIdComboBox.Size = new System.Drawing.Size(200, 21);
            this.departmentIdComboBox.TabIndex = 9;
            this.departmentIdComboBox.ValueMember = "Id";
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
            // FormPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 300);
            this.Controls.Add(this.btnSavePerson);
            this.Controls.Add(this.btnCancelPerson);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPerson";
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.FormPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelPerson;
        private System.Windows.Forms.Button btnSavePerson;
        private studentDataSet studentDataSet;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private studentDataSetTableAdapters.PersonsTableAdapter personsTableAdapter;
        private studentDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.ComboBox departmentIdComboBox;
        private studentDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
    }
}