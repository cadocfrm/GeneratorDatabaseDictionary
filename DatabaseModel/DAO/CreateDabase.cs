using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.DAO
{
    public class CreateDabase
    {
        private DatabaseType Type { get; set; }
        private DatabaseConnection ConnectionData { get; set; }
                        
        public CreateDabase(DatabaseType databaseType, DatabaseConnection databaseConnection)
        {
            Type = databaseType;
            ConnectionData = databaseConnection; 
        }

        public AbstractDatabase GetDatabase()
        {
            switch (Type)            {
                case DatabaseType.SQLServer:
                    return new SqlServerDatabase(ConnectionData);                    
                case DatabaseType.Oracle:
                    return new OracleDatabase(ConnectionData);   
                default:
                    return null;
            }
           
        }


    }
}
