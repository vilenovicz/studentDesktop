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
    public partial class FormCourses : Form
    {
        //private BindingSource masterBindingSource = new BindingSource();
        //private BindingSource detailsBindingSource = new BindingSource();
        private void LoadFromDB()
        {
            this.coursesDataGridView.DataSource = this.coursesBindingSource; //masterBindingSource;
            this.personsDataGridView.DataSource = this.personsBindingSource; //detailsBindingSource;

            const string sqlCourses = @"select cr.id as id, 
                cr.Name as [Название курса], 
                c.Name as [Компетенция],
                cr.DateFrom [Дата начала],
                cr.DateTo [Дата окончания]
                from courses cr inner join Competences c on cr.competenceId = c.id";

            const string sqlPersonsOnCourse = @"select cp.CourseId, p.id as PersonId, p.LastName as Фамилия, p.FirstName as Имя from Persons p inner join course_person cp on p.id = cp.PersonId";

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);

                DataSet data = new DataSet();
                data.Locale = System.Globalization.CultureInfo.InvariantCulture;

                //данные из таблицы Courses в DataSet
                SqlDataAdapter masterDataAdapter = new SqlDataAdapter(sqlCourses, connection);
                masterDataAdapter.Fill(data, "Courses");


                //данные по Компетенциям в DataSet
                SqlDataAdapter detailDataAdapter = new SqlDataAdapter(sqlPersonsOnCourse, connection);
                detailDataAdapter.Fill(data, "PersonsOnCourse");

                //Отношения между двумя таблицами
                DataRelation relation = new DataRelation("PersonsOnCourse",
                    data.Tables["Courses"].Columns["Id"],
                    data.Tables["PersonsOnCourse"].Columns["CourseId"]);
                data.Relations.Add(relation);

                //Соединяем мастерДата с таблицей Persons
                //masterBindingSource.DataSource = data;
                coursesBindingSource.DataSource = data;
                //masterBindingSource.DataMember = "Courses";
                coursesBindingSource.DataMember = "Courses";

                //соединяем детейлДата с таблицей Competences
                //detailsBindingSource.DataSource = masterBindingSource;
                personsBindingSource.DataSource = coursesBindingSource;
                //detailsBindingSource.DataMember = "PersonsOnCourse";
                personsBindingSource.DataMember = "PersonsOnCourse";


                coursesBindingNavigator.BindingSource = coursesBindingSource; //masterBindingSource;
                //bnCompetence.BindingSource = detailsBindingSource;
                //bnPerson.BindingSource = masterBindingSource;

            }
            catch
            {
                MessageBox.Show(Properties.Resources.dataNotLoaded);
            }
        }
        public FormCourses()
        {
            InitializeComponent();
        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        public bool DeletePersonFromCourse()
        {
            bool result = false;
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);
            SqlCommand command = null;
            command = new SqlCommand("uspDelPersonFromCourse", connection);

            command.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int));
            command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int));

            command.Parameters["@PersonId"].Value = this.personsDataGridView.SelectedRows[0].Cells["PersonId"].Value;
            command.Parameters["@CourseId"].Value = this.coursesDataGridView.SelectedRows[0].Cells["Id"].Value;

            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            try
            {
                command.ExecuteNonQuery();
                result = true;
            }
            catch
            {
                _ = MessageBox.Show("Отзыв сотрудника с курса не удался");
            }
            finally
            {
                connection.Close();
            }

            return result;

        }
        private void FormCourses_Load(object sender, EventArgs e)
        {
            LoadFromDB();

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);

            //SqlCommand command = new SqlCommand("uspDeleteCourse", connection);
            //command.CommandType = CommandType.StoredProcedure;

            //command.Parameters.Add(new SqlParameter("@CourseId", SqlDbType.Int));

            //connection.Open();
            ////try
            ////{
            ////String compCode = "";

            ////saving to DB
            //int selectedRowIndex = Int32.Parse(this.coursesBindingNavigator.PositionItem.Text)-1;
            //command.Parameters["@CourseId"].Value = this.coursesDataGridView.SelectedRows[selectedRowIndex].Cells["Id"].Value;
            //coursesBindingSource.RemoveCurrent();
            ////
            //    command.ExecuteNonQuery();

            ////}
            ////catch
            ////{
            //    _ = MessageBox.Show("Удаление курса не удалось");
            ////}
            ////finally
            ////{
            //    connection.Close();
            ////}

            ////DataExchange.Data = compCode;
            //this.Close();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewCourse formNewCourse = new FormNewCourse((int)this.coursesDataGridView.SelectedRows[0].Cells[0].Value);
            formNewCourse.ShowDialog();
            this.LoadFromDB();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewCourse formNewCourse = new FormNewCourse();
            formNewCourse.ShowDialog();
            this.LoadFromDB();
        }

        private void closeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void delCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewCourse formNewCourse = new FormNewCourse((int)this.coursesDataGridView.SelectedRows[0].Cells[0].Value);
            //formPerson.toBeDeleted = true;
            if (formNewCourse.deleteCourse())
            {
                MessageBox.Show("Курс удален");
            }
            formNewCourse.Dispose();
            this.LoadFromDB();
        }

        private void направитьНаКурсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSelectPerson formSelectPerson = new FormSelectPerson((int)this.coursesDataGridView.SelectedRows[0].Cells[0].Value);
            formSelectPerson.ShowDialog();
            this.LoadFromDB();
        }

        private void delPersonFromCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DeletePersonFromCourse();
            this.LoadFromDB();
        }
    }
}
