using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModel.DAO;
using DatabaseModel.Model;

namespace DatabaseModel
{
    public class Facade
    {
        private AbstractDatabase Database;

        public Facade(DatabaseType databaseType, DatabaseConnection databaseConnection)
        {
            Database = new CreateDabase(databaseType, databaseConnection).GetDatabase();
        }

        public List<TableDatabase> GetTables()
        {
            return Database.GetTables();
        }
    }
}
