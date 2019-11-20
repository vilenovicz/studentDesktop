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
            //MessageBox.Show("Заглушка:Сохранено");



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
                    personList.Add(person);
//                    MessageBox.Show(person.LastName);
                }
            }
            Person.SaveToFile(personList);
            MessageBox.Show("Данные сохранены");
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
                dataGridViewPersons.Rows.Add(person.LastName, person.FirstName);
            }
            dataGridViewPersons.Refresh();
        }
    }
}
