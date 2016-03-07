using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseModel;
using DatabaseModel.Model;

namespace GeneratorDatabaseDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DatabaseModel.Facade _facadeDatabase;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGetTable_Click(object sender, EventArgs e)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            List<TableDatabase> tableList;
                    
            databaseConnection.Server = "LAB-PC\\SQL2012";
            databaseConnection.Database = "WSP";
            databaseConnection.User = "sa";
            databaseConnection.Password = "123456";

            _facadeDatabase = new Facade(DatabaseType.SQLServer, databaseConnection);
            tableList = _facadeDatabase.GetTables();
          

            foreach (TableDatabase table in tableList)
            {
                lstTable.Items.Add(table.Name);
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstTable.Clear();
            lstTable.Columns.Add("Table Name", "TableName", 400);
        }
    }
}
