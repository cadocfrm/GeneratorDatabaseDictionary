namespace GeneratorDatabaseDictionary
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetTable = new System.Windows.Forms.Button();
            this.lstTable = new System.Windows.Forms.ListView();
            this.TableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetTable
            // 
            this.btnGetTable.Location = new System.Drawing.Point(95, 357);
            this.btnGetTable.Name = "btnGetTable";
            this.btnGetTable.Size = new System.Drawing.Size(200, 23);
            this.btnGetTable.TabIndex = 0;
            this.btnGetTable.Text = "GetTable";
            this.btnGetTable.UseVisualStyleBackColor = true;
            this.btnGetTable.Click += new System.EventHandler(this.btnGetTable_Click);
            // 
            // lstTable
            // 
            this.lstTable.AllowColumnReorder = true;
            this.lstTable.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TableName});
            this.lstTable.FullRowSelect = true;
            this.lstTable.GridLines = true;
            this.lstTable.Location = new System.Drawing.Point(21, 23);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(369, 298);
            this.lstTable.TabIndex = 1;
            this.lstTable.UseCompatibleStateImageBehavior = false;
            this.lstTable.View = System.Windows.Forms.View.Details;
            // 
            // TableName
            // 
            this.TableName.Text = "Table Name";
            this.TableName.Width = 400;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(95, 386);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 425);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstTable);
            this.Controls.Add(this.btnGetTable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetTable;
        private System.Windows.Forms.ListView lstTable;
        private System.Windows.Forms.ColumnHeader TableName;
        private System.Windows.Forms.Button btnClear;
    }
}

