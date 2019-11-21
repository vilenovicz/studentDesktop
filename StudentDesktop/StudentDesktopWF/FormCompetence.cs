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
            ArrayList compList = Competence.Load();
            foreach (Competence comp in compList)
            {
                dataGridViewCompetence.Rows.Add(
                    comp.Code,
                    comp.Name
                    );
            }
            dataGridViewCompetence.Refresh();
        }
    }
}
