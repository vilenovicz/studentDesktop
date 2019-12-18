using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDesktopWF
{
    class DBManager
    {

        BindingSource bindingSource = new BindingSource();
        public BindingSource ReadData()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString);
            SqlCommand command = new SqlCommand(@"select p.lastname as Фамилия, 
                p.firstname as Имя, 
                p.birthday as [Дата рождения], 
                d.name as Подразделение,
                dbo.ufnGetCompetenceList(p.id) as Компетенции
                from persons p inner join Departments d on p.departmentId = d.id");
            command.Connection = connection;

            try
            {
                connection.Open();
                command.ExecuteReader();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                if (dataSet.Tables.Count == 0)
                {
                    MessageBox.Show("Результата нет");
                    return null;
                }
                bindingSource.DataSource = dataSet.Tables[0];

            }
            catch
            {
                MessageBox.Show(Properties.Resources.dbIsNotAccessable);
            }
            finally
            {
                connection.Close();
            }
            return bindingSource;

        }


    }
}
