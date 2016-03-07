using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel.Model
{
    public class FieldTable
    {
        /// <summary>
        /// Identifer of column at table
        /// </summary>
        public Int32 Id { set; get; }

        /// <summary>
        /// Name column 
        /// </summary>
        public string Name { set; get; }

        /// <summary>
        /// Type of field: varchar, datetime, byte,....
        /// </summary>
        public FieldType Type { set; get; }

        /// <summary>
        /// Length of field, when field is varchar for sample
        /// </summary>
        public Int32 Length { set; get; }
    }
}
