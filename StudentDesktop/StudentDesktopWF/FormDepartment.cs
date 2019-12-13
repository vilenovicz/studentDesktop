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
    public partial class FormDepartment : Form
    {
        public FormDepartment()
        {
            InitializeComponent();
        }

        private void departmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this.studentDataSet.Departments);


        }

 
    }
}
