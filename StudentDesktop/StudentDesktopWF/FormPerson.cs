﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDesktopWF
{
    public partial class FormPerson : Form
    {
        public FormPerson()
        {
            InitializeComponent();
        }

        private void personsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void FormPerson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.studentDataSet.Departments);
            // TODO: This line of code loads data into the 'studentDataSet.Persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.Fill(this.studentDataSet.Persons);
            // TODO: This line of code loads data into the 'studentDataSet.Departments' table. You can move, or remove it, as needed.


        }

        private void personsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.personsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void personsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.personsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void personsBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.personsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }
    }
}
