using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseModel
{
    public class DatabaseConnection
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string Server  { get; set; }
        public string Database { get; set; }
        public string Schema { get; set; }
    }
}
