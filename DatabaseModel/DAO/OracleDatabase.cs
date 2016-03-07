using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModel.Model;

namespace DatabaseModel.DAO
{
    public class OracleDatabase: AbstractDatabase 
    {
        public OracleDatabase(DatabaseConnection databaseConnection) : base (DatabaseType.Oracle, databaseConnection)
        { 
        }

        public override List<TableDatabase> GetTables()
        {
            
            throw new Exception();
        }

        
         protected  override void OpenConnection()
        {
           base.Connection.Open();
        }

        protected override void SetConnection()
        {
            throw new Exception();
        }

        protected override void CloseConnection()
        {
            base.Connection.Close();
        }
    }
   
}
