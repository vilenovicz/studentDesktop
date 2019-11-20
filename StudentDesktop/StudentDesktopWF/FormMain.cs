using System;
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
            MessageBox.Show("Заглушка:Сохранено");
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            Person ivan = new Person("Иванов", "Иван");
            Person vasy = new Person("Васильев", "Вася");
            dataGridViewPersons.Rows.Add(ivan.LastName,ivan.FirstName);
            dataGridViewPersons.Rows.Add(vasy.LastName, vasy.FirstName);

        }
    }
}
