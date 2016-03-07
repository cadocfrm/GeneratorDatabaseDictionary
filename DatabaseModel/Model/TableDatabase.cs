using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.Model
{
    public class TableDatabase
    {
        #region "Property"

        /// <summary>
        /// Identifer of table at database
        /// </summary>
        public Int32 Id { set; get; }

        /// <summary>
        /// Name table at database
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// Collection of columns of table at Database
        /// </summary>
        public List<FieldTable> FieldTableList { set; get; }
       

        #endregion 
    }
}
