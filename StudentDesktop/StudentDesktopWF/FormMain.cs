using System;
using System.Collections;
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
    public partial class formMain : Form
    {
        private BindingSource masterBindingSource = new BindingSource();
        private BindingSource detailsBindingSource = new BindingSource();

        public formMain()
        {
            InitializeComponent();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            LoadFromDB();



            #region rem 4 hardcode
            //Загрузка в grid данных о персонале

            //пока грузим только hardcoded
            //Person ivan = new Person("Иванов", "Иван");
            //Person vasy = new Person("Васильев", "Вася");

            //dataGridViewPersons.Rows.Add(ivan.LastName,ivan.FirstName);
            //dataGridViewPersons.Rows.Add(vasy.LastName, vasy.FirstName);
            #endregion rem 4 hardcode
        }

        private void LoadFromDB()
        {
            dgvPersons.DataSource = masterBindingSource;
            dgvCompetences.DataSource = detailsBindingSource;

            const string sqlPersons = @"select p.id as id, 
                p.lastname as Фамилия, 
                p.firstname as Имя, 
                p.birthday as [Дата рождения], 
                d.name as Подразделение
                from persons p inner join Departments d on p.departmentId = d.id";

            const string sqlCompetences = @"select pc.PersonId, c.Id as CompetenceId, c.Code, c.Name  from Competences c inner join person_competence pc on c.id = pc.CompetenceId";

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);

                DataSet data = new DataSet();
                data.Locale = System.Globalization.CultureInfo.InvariantCulture;

                //данные из таблицы Person в DataSet
                SqlDataAdapter masterDataAdapter = new SqlDataAdapter(sqlPersons, connection);
                masterDataAdapter.Fill(data, "Persons");

                //данные по Компетенциям в DataSet
                SqlDataAdapter detailDataAdapter = new SqlDataAdapter(sqlCompetences, connection);
                detailDataAdapter.Fill(data, "Competences");

                //Отношения между двумя таблицами
                DataRelation relation = new DataRelation("PersonsCompetences",
                    data.Tables["Persons"].Columns["Id"],
                    data.Tables["Competences"].Columns["PersonId"]);
                data.Relations.Add(relation);

                //Соединяем мастерДата с таблицей Persons
                masterBindingSource.DataSource = data;
                masterBindingSource.DataMember = "Persons";

                //соединяем детейлДата с таблицей Competences
                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = "PersonsCompetences";

                dgvPersons.Columns["Id"].Visible = false;
                dgvCompetences.Columns["PersonId"].Visible = false;
                dgvCompetences.Columns["CompetenceId"].Visible = false;

                //Навигаторы к бою!
                bnCompetence.BindingSource = detailsBindingSource;
                bnPerson.BindingSource = masterBindingSource;

            }
            catch
            {
                MessageBox.Show(Properties.Resources.dataNotLoaded);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompetence form = new FormCompetence();
            form.Text = "Справочник компетенций";
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            DataExchange.FileName = saveFileDialog.FileName;
            statusFilename.Text = saveFileDialog.FileName;
            saveToolStripMenuItem_Click(sender, e);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvPersons.Rows.Clear();
            statusFilename.Text = "Нет открытого файла";
        }

        private void DataGridViewPersons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            addCompetenceToolStripMenuItem_Click(sender, e);
            //if (dataGridViewPersons.Rows.Count-1 > 0 && e.ColumnIndex == 4)
            //{
            //    //_ = MessageBox.Show("Competences");
            //    FormCompetence formCompetence = new FormCompetence();
            //    formCompetence.Text = "Выберите одну или несколько компетенций для добавления сотруднику";

            //    //установим владельца создаваемой формы
            //    //formCompetence.Owner = this;
            //    formCompetence.ShowDialog();

            //    //if (DataExchange.Data.Length > 0)
            //    //{
            //    //    if (this.dataGridViewPersons.SelectedCells[0].Value.ToString().Length > 0)
            //    //    {
            //    //        this.dataGridViewPersons.SelectedCells[0].Value += ",";
            //    //    }
            //    //    this.dataGridViewPersons.SelectedCells[0].Value += DataExchange.Data;

            //    //    DataExchange.Data = "";
            //    //    this.dataGridViewPersons.Refresh();
            //    //}
            //}
        }

 

        private void вXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList personList = new ArrayList();
            DataGridViewRow row;
            //if (dataGridViewPersons.Rows.Count - 1 > 0)
            //{
            //    for (int i = 0; i < dataGridViewPersons.Rows.Count - 1; i++)//  .SelectedRows)
            //    {
            //        row = dataGridViewPersons.Rows[i];
            //        {
            //            Person person = new Person();
            //            person.LastName = row.Cells[0].Value.ToString();
            //            person.FirstName = row.Cells[1].Value.ToString();
            //            person.Birthday = Convert.ToDateTime(row.Cells[2].Value.ToString());
            //            person.Department = row.Cells[3].Value.ToString();
            //            person.SetCompetenceList(row.Cells[4].Value.ToString());
            //            personList.Add(person);
            //            //                    MessageBox.Show(person.LastName);
            //        }
            //    }
            //    Person.SaveToFile(personList, statusFilename.Text);
            //    _ = MessageBox.Show(Properties.Resources.dataSaved);
            //}
            //else
            //{
            //    _ = MessageBox.Show(Properties.Resources.noData2Save);
            //}


        }

        private void saveToDBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadFromXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (openFileDialog.ShowDialog().ToString() != "Cancel")
            //{
            //    ArrayList personList = Person.LoadFromFile(openFileDialog.FileName);
            //    statusFilename.Text = openFileDialog.FileName;
            //    DataExchange.FileName = openFileDialog.FileName;
            //    foreach (Person person in personList)
            //    {
            //        dataGridViewPersons.Rows.Add(
            //            person.LastName,
            //            person.FirstName,
            //            person.Birthday,
            //            person.Department,
            //            person.GetCompetenceList()
            //            );
            //    }
            //    dataGridViewPersons.Refresh();
            //}

        }

        private void loadFromBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DBManager dbManager = new DBManager();
            //dataGridViewPersons.AutoGenerateColumns = true;
            //dataGridViewPersons.DataSource = dbManager.ReadData();

            //dataGridViewPersons.DataSource = masterBindingSource;
            //dgvCompetences.DataSource = detailsBindingSource;

            //const string sqlPersons = @"select p.id as id, 
            //    p.lastname as Фамилия, 
            //    p.firstname as Имя, 
            //    p.birthday as [Дата рождения], 
            //    d.name as Подразделение
            //    from persons p inner join Departments d on p.departmentId = d.id";

            //const string sqlCompetences = @"select pc.PersonId, c.Code, c.Name  from Competences c inner join person_competence pc on c.id = pc.CompetenceId";

            //try
            //{
            //    SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);

            //    DataSet data = new DataSet();
            //    data.Locale = System.Globalization.CultureInfo.InvariantCulture;

            //    //данные из таблицы Person в DataSet
            //    SqlDataAdapter masterDataAdapter = new SqlDataAdapter(sqlPersons, connection);
            //    masterDataAdapter.Fill(data, "Persons");

            //    //данные по Компетенциям в DataSet
            //    SqlDataAdapter detailDataAdapter = new SqlDataAdapter(sqlCompetences, connection);
            //    detailDataAdapter.Fill(data, "Competences");

            //    //Отношения между двумя таблицами
            //    DataRelation relation = new DataRelation("PersonsCompetences",
            //        data.Tables["Persons"].Columns["Id"],
            //        data.Tables["Competences"].Columns["PersonId"]);
            //    data.Relations.Add(relation);

            //    //Соединяем мастерДата с таблицей Persons
            //    masterBindingSource.DataSource = data;
            //    masterBindingSource.DataMember = "Persons";

            //    //соединяем детейлДата с таблицей Competences
            //    detailsBindingSource.DataSource = masterBindingSource;
            //    detailsBindingSource.DataMember = "PersonsCompetences";
            //    bnCompetence.BindingSource = detailsBindingSource;

            //}
            //catch
            //{
            //    MessageBox.Show(Properties.Resources.dataNotLoaded);
            //}

            #region oldCode
            //чтение данных о Person и заполнение грида
            //using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            //{
            //    const string sql = @"select p.id as id, 
            //    p.lastname as Фамилия, 
            //    p.firstname as Имя, 
            //    p.birthday as [Дата рождения], 
            //    d.name as Подразделение,
            //    dbo.ufnGetCompetenceList(p.id) as Компетенции
            //    from persons p inner join Departments d on p.departmentId = d.id";


            //    using (SqlCommand command = new SqlCommand(sql, connection))
            //    {
            //        try
            //        {
            //            connection.Open();
            //            using (SqlDataReader reader = command.ExecuteReader())
            //            {
            //                DataTable table = new DataTable();
            //                table.Load(reader);
            //                this.dataGridViewPersons.DataSource = table;
            //                this.dataGridViewPersons.Columns["id"].Visible = false;
            //                //this.dataGridViewPersons.Columns["Компетенции"].ReadOnly = false;
            //                reader.Close();
            //            }
            //        }
            //        catch
            //        {
            //            MessageBox.Showc
            //        finally
            //        {
            //            connection.Close();
            //        }

            //    }
            //}
            #endregion oldCode
        }

        private void addCompetenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCompetences(sender, e);

        }

        private void addCompetences(object sender, EventArgs e)
        {
            FormCompetence formCompetence = new FormCompetence();
            formCompetence.personId = (int)dgvPersons.SelectedRows[0].Cells[0].Value;
            formCompetence.bSaveChoosen.Visible = true;
            formCompetence.ShowDialog();
            formCompetence.bSaveChoosen.Visible = false;
            LoadFromDB();
        }


        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPerson formPerson = new FormPerson();
            formPerson.Show();
        }

        private void департаментыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepartment formDepartment = new FormDepartment();
            formDepartment.ShowDialog();
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            addCompetences(sender, e);
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {
            FormPerson formPerson = new FormPerson();
            formPerson.ShowDialog();
            LoadFromDB();
        }

        private void курсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCourses formCourses = new FormCourses();
            formCourses.Show();
        }



        private void editPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPerson formPerson = new FormPerson((int)this.dgvPersons.SelectedRows[0].Cells[0].Value);
            formPerson.ShowDialog();
            this.LoadFromDB();
        }

 
        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPerson formPerson = new FormPerson((int)this.dgvPersons.SelectedRows[0].Cells[0].Value);
            //formPerson.toBeDeleted = true;
            if (formPerson.DeletePerson())
            {
                MessageBox.Show("Сотрудник удален");
            }
            formPerson.Dispose();
            this.LoadFromDB();
        }

        private void delCompToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompetence formCompetence = new FormCompetence(
                (int)this.dgvCompetences.SelectedRows[0].Cells["PersonId"].Value,
                (int)this.dgvCompetences.SelectedRows[0].Cells["CompetenceId"].Value);
            //formCompetence.ShowDialog();
            formCompetence.DelPersonCompetence();
            this.LoadFromDB();
        }
    }
}
