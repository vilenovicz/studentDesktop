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
    public partial class FormCompetence : Form
    {
        private BindingSource bindingSource = new BindingSource();
        public int personId = 0;

        public FormCompetence()
        {
            InitializeComponent();
        }

        private void dataGridViewCompet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCompetence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.Competences' table. You can move, or remove it, as needed.
            this.competencesTableAdapter.Fill(this.studentDataSet.Competences);

            //ArrayList compList = Competence.LoadFromFile();
            //foreach (Competence comp in compList)
            //{
            //    dataGridViewCompetence.Rows.Add(
            //        comp.Code,
            //        comp.Name
            //        );
            //}
            //dataGridViewCompetence.Refresh();
            //DBManager dbManager = new DBManager();
            //dataGridViewPersons.AutoGenerateColumns = true;
            //dataGridViewPersons.DataSource = dbManager.ReadData();

            //dgvCompetences.DataSource = bindingSource;
            //const string sqlCompetences = @"select Id, Code, Name  from Competences";

            //try
            //{
            //    SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);

            //    DataSet data = new DataSet();
            //    data.Locale = System.Globalization.CultureInfo.InvariantCulture;

            //    //данные по Компетенциям в DataSet
            //    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCompetences, connection);
            //    dataAdapter.Fill(data, "Competences");

            //    //Соединяем мастерДата с таблицей Persons
            //    bindingSource.DataSource = data;
            //    bindingSource.DataMember = "Competences";

              
            //}
            //catch
            //{
            //    MessageBox.Show("Не удалось считать данные компетенций");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList compList = new ArrayList();
            DataGridViewRow row;
            for (int i = 0; i < dgvCompetences.Rows.Count - 1; i++)//  .SelectedRows)
            {
                row = dgvCompetences.Rows[i];
                {
                    Competence competence = new Competence();
                    competence.Code = row.Cells[0].Value.ToString();
                    competence.Name = row.Cells[1].Value.ToString();
                    compList.Add(competence);
                }
            }
            Competence.SaveToFile(compList);
            _ = MessageBox.Show(Properties.Resources.dataSaved);
            this.Dispose();
        }

        private void bCompetenceCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bSaveChoosen_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);
            
            SqlCommand command = new SqlCommand("uspNewCompetence", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter("@PersonId", SqlDbType.Int));
            command.Parameters.Add(new SqlParameter("@CompetenceId", SqlDbType.Int));

            connection.Open();
            try
            {
                //String compCode = "";

                foreach (DataGridViewRow row in dgvCompetences.SelectedRows)
                {
                    //if (compCode != "")
                    //{
                    //    compCode += ", ";
                    //}
                    //compCode += row.Cells[0].Value;

                    //saving to DB
                    command.Parameters["@PersonId"].Value = personId;
                    command.Parameters["@CompetenceId"].Value = row.Cells[0].Value;

                    command.ExecuteNonQuery();
                    
                }

            }
            catch
            {
                _ = MessageBox.Show("Сохранение компетенций не удалось");
            }
            finally
            {
                connection.Close();
            }

            //DataExchange.Data = compCode;
            this.Close();

            //dataGridViewPerson
            //dataGridViewCompetence.SelectedRows
        }

        private void competencesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.competencesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

     }
}
