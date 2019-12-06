using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vcz.StudentDesktopWF
{
    class DBManager
    {
        string srvName = "gsv";
        string dbName = "student";
        string userId = "Serge";

        BindingSource bindingSource = new BindingSource();
        public BindingSource ReadData()
        {
            OleDbConnection connection = CreateConnection();
            OleDbCommand command = new OleDbCommand(@"select p.lastname as Фамилия, 
                p.firstname as Имя, 
                p.birthday as [Дата рождения], 
                d.name as Подразделение,
                dbo.ufnGetCompetenceList(p.id) as Компетенции
                from persons p inner join Departments d on p.departmentId = d.id");
            command.Connection = connection;

            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            connection.Close();

            if(dataSet.Tables.Count == 0)
            {
                MessageBox.Show("Результата нет");
                return null;
            }
            bindingSource.DataSource = dataSet.Tables[0];
            return bindingSource;

        }

        private  OleDbConnection CreateConnection()
        {
            OleDbConnection connection = new OleDbConnection();
            string connString = @"Provider = SQLOLEDB.1; Integrated Security = SSPI; Persist Security Info = False; ";
            connString += @"User ID = " + userId + ";";
            connString += @"Initial Catalog = " + dbName + ";"; 
            connString += @"Data Source = gsv"; 
            connection.ConnectionString = connString;

            try
            {
                connection.Open();
            }
            catch
            {
                MessageBox.Show("Не могу соединиться с БД");
            }

            return connection;
                
        }
    }
}
