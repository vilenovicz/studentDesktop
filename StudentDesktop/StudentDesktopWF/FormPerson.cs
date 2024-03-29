﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDesktopWF
{
    public partial class FormPerson : Form
    {
        public int personId { get; set; }
//        public bool toBeDeleted { get; set; }
        public FormPerson()
        {
            InitializeComponent();
        }

        public FormPerson(int personId)
        {
            InitializeComponent();
            this.personId = personId;
        }


        private void FormPerson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.studentDataSet.Departments);
            // TODO: This line of code loads data into the 'studentDataSet.Persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.Fill(this.studentDataSet.Persons);
            // TODO: This line of code loads data into the 'studentDataSet.Departments' table. You can move, or remove it, as needed.
            this.personsBindingSource.Filter = "id = " + personId;



        }

        public bool DeletePerson()
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);
            SqlCommand command = null;
            command = new SqlCommand("uspDeletePerson", connection);

            command.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int));
            command.Parameters["@PersonId"].Value = this.personId;

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            try
            {
                command.ExecuteNonQuery();
                result = true;
            }
            catch
            {
                _ = MessageBox.Show("Удаление сотрудника не удалось");
            }
            finally
            {
                connection.Close();
            }

            return result;

        }

        private void btnSavePerson_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);
            SqlCommand command = null;
            if (personId != 0) //update record
            {
                command = new SqlCommand("uspUpdatePerson", connection);
                
                command.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int));
                command.Parameters["@PersonId"].Value = this.personId;
            }
            else //insert record
            {
                command = new SqlCommand("uspNewPerson", connection);
            }
            
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar,50));
            command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar,50));
            command.Parameters.Add(new SqlParameter("@Birthday", SqlDbType.DateTime));
            command.Parameters.Add(new SqlParameter("@DepartmentId", SqlDbType.Int));


            connection.Open();
            try
            {
                //String compCode = "";


                //saving to DB
                command.Parameters["@LastName"].Value = lastNameTextBox.Text;
                command.Parameters["@FirstName"].Value = firstNameTextBox.Text;
                command.Parameters["@Birthday"].Value = birthdayDateTimePicker.Value;
                command.Parameters["@DepartmentId"].Value = departmentIdComboBox.SelectedValue;


                command.ExecuteNonQuery();

            }
            catch
            {
                _ = MessageBox.Show("Сохранение сотрудника не удалось");
            }
            finally
            {
                connection.Close();
            }

            //DataExchange.Data = compCode;
            this.Close();
        }

        private void btnCancelPerson_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }
    }
}
