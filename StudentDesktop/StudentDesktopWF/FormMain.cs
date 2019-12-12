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
            #region rem 4 hardcode
            //Загрузка в grid данных о персонале

            //пока грузим только hardcoded
            //Person ivan = new Person("Иванов", "Иван");
            //Person vasy = new Person("Васильев", "Вася");

            //dataGridViewPersons.Rows.Add(ivan.LastName,ivan.FirstName);
            //dataGridViewPersons.Rows.Add(vasy.LastName, vasy.FirstName);
            #endregion rem 4 hardcode
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


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            DataExchange.FileName = saveFileDialog.FileName;
            statusFilename.Text = saveFileDialog.FileName;
            saveToolStripMenuItem_Click(sender, e);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewPersons.Rows.Clear();
            statusFilename.Text = "Нет открытого файла";
        }

        private void dataGridViewPersons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPersons.Rows.Count-1 > 0 && e.ColumnIndex == 4)
            {
                //_ = MessageBox.Show("Competences");
                FormCompetence formCompetence = new FormCompetence();
                formCompetence.Text = "Выберите одну или несколько компетенций для добавления сотруднику";

                //установим владельца создаваемой формы
                //formCompetence.Owner = this;
                formCompetence.ShowDialog();

                if (DataExchange.Data.Length > 0)
                {
                    if (this.dataGridViewPersons.SelectedCells[0].Value.ToString().Length > 0)
                    {
                        this.dataGridViewPersons.SelectedCells[0].Value += ",";
                    }
                    this.dataGridViewPersons.SelectedCells[0].Value += DataExchange.Data;

                    DataExchange.Data = "";
                    this.dataGridViewPersons.Refresh();
                }
            }
        }

 

        private void вXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList personList = new ArrayList();
            DataGridViewRow row;
            if (dataGridViewPersons.Rows.Count - 1 > 0)
            {
                for (int i = 0; i < dataGridViewPersons.Rows.Count - 1; i++)//  .SelectedRows)
                {
                    row = dataGridViewPersons.Rows[i];
                    {
                        Person person = new Person();
                        person.LastName = row.Cells[0].Value.ToString();
                        person.FirstName = row.Cells[1].Value.ToString();
                        person.Birthday = Convert.ToDateTime(row.Cells[2].Value.ToString());
                        person.Department = row.Cells[3].Value.ToString();
                        person.SetCompetenceList(row.Cells[4].Value.ToString());
                        personList.Add(person);
                        //                    MessageBox.Show(person.LastName);
                    }
                }
                Person.SaveToFile(personList, statusFilename.Text);
                _ = MessageBox.Show("Данные сохранены");
            }
            else
            {
                _ = MessageBox.Show("Данных для сохранения нет");
            }


        }

        private void saveToDBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadFromXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog().ToString() != "Cancel")
            {
                ArrayList personList = Person.LoadFromFile(openFileDialog.FileName);
                statusFilename.Text = openFileDialog.FileName;
                DataExchange.FileName = openFileDialog.FileName;
                foreach (Person person in personList)
                {
                    dataGridViewPersons.Rows.Add(
                        person.LastName,
                        person.FirstName,
                        person.Birthday,
                        person.Department,
                        person.GetCompetenceList()
                        );
                }
                dataGridViewPersons.Refresh();
            }

        }

        private void loadFromBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DBManager dbManager = new DBManager();
            //dataGridViewPersons.AutoGenerateColumns = true;
            //dataGridViewPersons.DataSource = dbManager.ReadData();
            
            
            //чтение данных о Person и заполнение грида
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                const string sql = @"select p.id as id, 
                p.lastname as Фамилия, 
                p.firstname as Имя, 
                p.birthday as [Дата рождения], 
                d.name as Подразделение,
                dbo.ufnGetCompetenceList(p.id) as Компетенции
                from persons p inner join Departments d on p.departmentId = d.id";

                
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable table = new DataTable();
                            table.Load(reader);
                            this.dataGridViewPersons.DataSource = table;
                            this.dataGridViewPersons.Columns["id"].Visible = false;
                            //this.dataGridViewPersons.Columns["Компетенции"].ReadOnly = false;
                            reader.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Не могу соединиться с БД");
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }

        private void добавитьКомпетенциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPerson formPerson = new FormPerson();
            formPerson.Show();
        }
    }
}
