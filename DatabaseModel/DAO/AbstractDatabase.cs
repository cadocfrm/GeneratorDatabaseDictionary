using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModel.Model;
using System.Data;

namespace DatabaseModel.DAO
{
    public abstract class AbstractDatabase
    {
        public DatabaseType Type { get; set; }
        public DatabaseConnection ConnectionData { get; set; }
        
        protected IDbConnection Connection { get; set; }


        public AbstractDatabase(DatabaseType databaseType, DatabaseConnection databaseConnection)
        {
            Type = databaseType;
            ConnectionData = databaseConnection; 
        }

        public abstract List<TableDatabase> GetTables();
        protected abstract void OpenConnection();
        protected abstract void SetConnection();
        protected abstract void CloseConnection();
        

    }
}
