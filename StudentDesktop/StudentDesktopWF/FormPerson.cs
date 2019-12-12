using System;
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
            // TODO: This line of code loads data into the 'studentDataSet.person_competence' table. You can move, or remove it, as needed.
            this.person_competenceTableAdapter.Fill(this.studentDataSet.person_competence);
            // TODO: This line of code loads data into the 'studentDataSet.Persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.Fill(this.studentDataSet.Persons);
            // TODO: This line of code loads data into the 'studentDataSet.person_competence' table. You can move, or remove it, as needed.
            this.person_competenceTableAdapter.Fill(this.studentDataSet.person_competence);
            // TODO: This line of code loads data into the 'studentDataSet.Persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.Fill(this.studentDataSet.Persons);

        }

        private void personsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.personsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }
    }
}
