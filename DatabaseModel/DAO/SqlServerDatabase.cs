using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModel.Model;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseModel.DAO
{
    public class SqlServerDatabase : AbstractDatabase 
    {
       
        public SqlServerDatabase(DatabaseConnection databaseConnection) : base (DatabaseType.SQLServer, databaseConnection)
        {
            
            
        }

        public override List<TableDatabase> GetTables()
        {
            string query;
            query = "select name from sys.objects  where type = 'U'";
            List<TableDatabase> TableDatabaseList = new List<TableDatabase>();

            this.SetConnection();

            using (SqlDataAdapter dataAdapterQuery = new SqlDataAdapter(query, (SqlConnection)base.Connection))
            {
                DataTable dataTableResult = new DataTable();                             
                dataAdapterQuery.Fill(dataTableResult);
                
                foreach(DataRow rw in dataTableResult.Rows)
                {
                    TableDatabase table = new TableDatabase();
                    table.Name = rw["name"].ToString();
                    TableDatabaseList.Add(table);
                }
            }

            return TableDatabaseList;
            
        }

        protected  override void OpenConnection()
        {
           base.Connection.Open();
        }

        protected override void SetConnection()
        {   
            string connectionString = string.Format("Password={0};Persist Security Info=True;User ID={1};Initial Catalog={2};Data Source={3}", base.ConnectionData.Password, base.ConnectionData.User, base.ConnectionData.Database, base.ConnectionData.Server);
            base.Connection = new SqlConnection(connectionString);
        }

        protected override void CloseConnection()
        {
            base.Connection.Close();
        }
    }
}
