namespace Ado.NETTask
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bnOdbc = new Button();
            btnOLEDB = new Button();
            btOledb = new Button();
            SuspendLayout();
            // 
            // bnOdbc
            // 
            bnOdbc.Location = new Point(22, 151);
            bnOdbc.Name = "bnOdbc";
            bnOdbc.Size = new Size(165, 79);
            bnOdbc.TabIndex = 0;
            bnOdbc.Text = "Connect with ODBC Driver";
            bnOdbc.UseVisualStyleBackColor = true;
            bnOdbc.Click += bnOdbc_Click;
            // 
            // btnOLEDB
            // 
            btnOLEDB.Location = new Point(383, 151);
            btnOLEDB.Name = "btnOLEDB";
            btnOLEDB.Size = new Size(172, 79);
            btnOLEDB.TabIndex = 1;
            btnOLEDB.Text = "Connect with SQL Driver";
            btnOLEDB.UseVisualStyleBackColor = true;
            btnOLEDB.Click += btnOLEDB_Click;
            // 
            // btOledb
            // 
            btOledb.Location = new Point(202, 151);
            btOledb.Name = "btOledb";
            btOledb.Size = new Size(165, 79);
            btOledb.TabIndex = 2;
            btOledb.Text = "Connect with OLEDB Driver";
            btOledb.UseVisualStyleBackColor = true;
            btOledb.Click += btOledb_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btOledb);
            Controls.Add(btnOLEDB);
            Controls.Add(bnOdbc);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bnOdbc;
        private Button btnOLEDB;
        private Button btOledb;
    }
}
