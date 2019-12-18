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
    public partial class FormNewCourse : Form
    {
        public int courseId { get; set; }
        public FormNewCourse()
        {
            InitializeComponent();
        }

        public FormNewCourse(int courseId)
        {
            InitializeComponent();
            this.courseId = courseId;
        }



        private void NewCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Competences' table. You can move, or remove it, as needed.
            this.competencesTableAdapter.Fill(this.studentDataSet.Competences);
            // TODO: This line of code loads data into the 'studentDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.studentDataSet.Courses);
            this.coursesBindingSource.Filter = "id = " + courseId;

        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void coursesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        public bool deleteCourse()
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);
            SqlCommand command = null;
            command = new SqlCommand("uspDeleteCourse", connection);

            command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int));
            command.Parameters["@CourseId"].Value = this.courseId;

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            try
            {
                command.ExecuteNonQuery();
                result = true;
            }
            catch
            {
                _ = MessageBox.Show("Удаление курса не удалось");
            }
            finally
            {
                connection.Close();
            }

            return result;
        }

        private void btnSaveCourse_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);
            SqlCommand command = null;
            if (courseId != 0) //update record
            {
                command = new SqlCommand("uspUpdateCourse", connection);

                command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int));
                command.Parameters["@CourseId"].Value = this.courseId;
            }
            else //insert record
            {
                command = new SqlCommand("uspNewCourse", connection);
            }

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 250));
            command.Parameters.Add(new SqlParameter("@CompetenceId", SqlDbType.Int));
            command.Parameters.Add(new SqlParameter("@StatusId", SqlDbType.Int));
            command.Parameters.Add(new SqlParameter("@Datefrom", SqlDbType.SmallDateTime));
            command.Parameters.Add(new SqlParameter("@Dateto", SqlDbType.SmallDateTime));

            connection.Open();

            try
            {
                //String compCode = "";


                //saving to DB
                command.Parameters["@Name"].Value = nameTextBox.Text;
                command.Parameters["@CompetenceId"].Value = competenceIdComboBox.SelectedValue;
                command.Parameters["@StatusId"].Value = DBNull.Value;
                command.Parameters["@Datefrom"].Value = dateFromDateTimePicker.Value;
                command.Parameters["@Dateto"].Value = dateToDateTimePicker.Value;


                command.ExecuteNonQuery();

            }
            catch
            {
                _ = MessageBox.Show("Сохранение курса не удалось");
            }
            finally
            {
                connection.Close();
            }

            //DataExchange.Data = compCode;
            this.Close();
        }
    }
}
