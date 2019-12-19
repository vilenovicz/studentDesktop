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
    public partial class FormListOfPersonCompetence : Form
    {
        int competenceId = 1;
        //public int CourseId { get; set; }

        public FormListOfPersonCompetence()
        {
            InitializeComponent();
        }

        public FormListOfPersonCompetence(int competenceId)
        {
            InitializeComponent();
            this.competenceId = competenceId;
        }
        private void personsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void FormSelectPerson_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Competences' table. You can move, or remove it, as needed.
            this.competencesTableAdapter.Fill(this.studentDataSet.Competences);
            // TODO: This line of code loads data into the 'studentDataSet.Persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.FillByCompetence(this.studentDataSet.Persons, this.competenceId);
            //this.personsBindingSource.Filter = "CompetenceId = " + this.competenceId;

        }



        private void btnCancelToCourse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbDepartment_TextChanged(object sender, EventArgs e)
        {

            string ss = cbDepartment.Text;
            if (cbDepartment.SelectedValue != null)
            {
                this.competenceId = (int)cbDepartment.SelectedValue;
                this.personsTableAdapter.FillByCompetence(this.studentDataSet.Persons, this.competenceId);
            }

        }
    }
}
