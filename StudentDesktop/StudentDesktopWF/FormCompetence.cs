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
    public partial class FormCompetence : Form
    {
        public FormCompetence()
        {
            InitializeComponent();
        }

        private void dataGridViewCompet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCompetence_Load(object sender, EventArgs e)
        {
            ArrayList compList = Competence.LoadFromFile();
            foreach (Competence comp in compList)
            {
                dataGridViewCompetence.Rows.Add(
                    comp.Code,
                    comp.Name
                    );
            }
            dataGridViewCompetence.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList compList = new ArrayList();
            DataGridViewRow row;
            for (int i = 0; i < dataGridViewCompetence.Rows.Count - 1; i++)//  .SelectedRows)
            {
                row = dataGridViewCompetence.Rows[i];
                {
                    Competence competence = new Competence();
                    competence.Code = row.Cells[0].Value.ToString();
                    competence.Name = row.Cells[1].Value.ToString();
                    compList.Add(competence);
                }
            }
            Competence.SaveToFile(compList);
            _ = MessageBox.Show("Данные сохранены");
        }

        private void bCompetenceCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
