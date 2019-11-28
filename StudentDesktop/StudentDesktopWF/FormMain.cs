using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vcz.StudentDesktopWF
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

        private void dataGridViewPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //dataGridViewPersons.SelectAll();
            ArrayList personList = new ArrayList();
            DataGridViewRow row;
            for (int i = 0; i < dataGridViewPersons.Rows.Count-1; i++)//  .SelectedRows)
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
            Person.SaveToFile(personList);
            _ = MessageBox.Show("Данные сохранены");
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            //Загрузка в grid данных о персонале

            //пока грузим только hardcoded
            Person ivan = new Person("Иванов", "Иван");
            Person vasy = new Person("Васильев", "Вася");

            //dataGridViewPersons.Rows.Add(ivan.LastName,ivan.FirstName);
            //dataGridViewPersons.Rows.Add(vasy.LastName, vasy.FirstName);

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList personList = Person.LoadFromFile();
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

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompetence form = new FormCompetence();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
