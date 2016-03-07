using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel
{
    public enum FieldType
    { 
        Varchar,
        Byte,
        Date
    }    

    public enum DatabaseType
    {
        SQLServer,
        Oracle
    }
}
