using System;
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
    public partial class FormSelectPerson : Form
    {
        int departmentId = 0;
        public int CourseId { get; set; }

        public FormSelectPerson()
        {
            InitializeComponent();
        }

        public FormSelectPerson(int courseId)
        {
            InitializeComponent();
            this.CourseId = courseId;
        }
        private void personsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void FormSelectPerson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.studentDataSet.Departments);
            // TODO: This line of code loads data into the 'studentDataSet.Persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.Fill(this.studentDataSet.Persons);
            this.personsBindingSource.Filter = "DepartmentId = " + this.departmentId;

        }

        private void AddToCourse()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);
            SqlCommand command = null;
            
            command = new SqlCommand("uspPersonToCourse", connection);
            command.CommandType = CommandType.StoredProcedure;
            
            command.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int));
            command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int));

            connection.Open();

            command.Parameters["@CourseId"].Value = this.CourseId;


            foreach (DataGridViewRow row in personsDataGridView.SelectedRows)
            {

                command.Parameters["@PersonId"].Value = row.Cells[0].Value;


                try
                {
                    command.ExecuteNonQuery();

                }
                catch
                {
                    _ = MessageBox.Show("Направить сотрудника на курс не удалось");
                }
            }

            //DataExchange.Data = compCode;
            connection.Close();
                this.Close();
        }
        private void btnToCourse_Click(object sender, EventArgs e)
        {
            AddToCourse();
        }

        private void btnCancelToCourse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbDepartment_TextChanged(object sender, EventArgs e)
        {
                if (cbDepartment.SelectedValue != null)
                {
                    this.departmentId = (int)cbDepartment.SelectedValue;
                    this.personsTableAdapter.Fill(this.studentDataSet.Persons);
                    this.personsBindingSource.Filter = "DepartmentId = " + this.departmentId;
            }

        }
    }
}
