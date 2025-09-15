namespace PrcaticeDay1WindowForm
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            lblReg = new Label();
            lblId = new Label();
            lblName = new Label();
            lblSal = new Label();
            lblGen = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtSalary = new TextBox();
            btnSubmit = new Button();
            rdBtnMale = new RadioButton();
            rdBtnFemale = new RadioButton();
            lblAll = new Label();
            SuspendLayout();
            // 
            // lblReg
            // 
            lblReg.AutoSize = true;
            lblReg.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReg.ForeColor = Color.Red;
            lblReg.Location = new Point(235, 30);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(287, 38);
            lblReg.TabIndex = 0;
            lblReg.Text = "Student Registration";
            lblReg.Click += lblReg_Click;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(115, 102);
            lblId.Name = "lblId";
            lblId.Size = new Size(146, 31);
            lblId.TabIndex = 1;
            lblId.Text = "Employee ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(115, 148);
            lblName.Name = "lblName";
            lblName.Size = new Size(184, 31);
            lblName.TabIndex = 2;
            lblName.Text = "Employee Name";
            // 
            // lblSal
            // 
            lblSal.AutoSize = true;
            lblSal.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSal.Location = new Point(115, 197);
            lblSal.Name = "lblSal";
            lblSal.Size = new Size(187, 31);
            lblSal.TabIndex = 3;
            lblSal.Text = "Employee Salary";
            // 
            // lblGen
            // 
            lblGen.AutoSize = true;
            lblGen.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGen.Location = new Point(115, 248);
            lblGen.Name = "lblGen";
            lblGen.Size = new Size(90, 31);
            lblGen.TabIndex = 4;
            lblGen.Text = "Gender";
            // 
            // txtID
            // 
            txtID.Location = new Point(344, 108);
            txtID.Name = "txtID";
            txtID.Size = new Size(168, 27);
            txtID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(344, 152);
            txtName.Name = "txtName";
            txtName.Size = new Size(168, 27);
            txtName.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(343, 197);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(169, 27);
            txtSalary.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(307, 297);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(110, 39);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // rdBtnMale
            // 
            rdBtnMale.AutoSize = true;
            rdBtnMale.Location = new Point(312, 255);
            rdBtnMale.Name = "rdBtnMale";
            rdBtnMale.Size = new Size(63, 24);
            rdBtnMale.TabIndex = 9;
            rdBtnMale.TabStop = true;
            rdBtnMale.Text = "Male";
            rdBtnMale.UseVisualStyleBackColor = true;
            // 
            // rdBtnFemale
            // 
            rdBtnFemale.AutoSize = true;
            rdBtnFemale.Location = new Point(393, 255);
            rdBtnFemale.Name = "rdBtnFemale";
            rdBtnFemale.Size = new Size(78, 24);
            rdBtnFemale.TabIndex = 10;
            rdBtnFemale.TabStop = true;
            rdBtnFemale.Text = "FeMale";
            rdBtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblAll
            // 
            lblAll.AutoSize = true;
            lblAll.Location = new Point(278, 351);
            lblAll.Name = "lblAll";
            lblAll.Size = new Size(55, 20);
            lblAll.TabIndex = 11;
            lblAll.Text = "Details";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(lblAll);
            Controls.Add(rdBtnFemale);
            Controls.Add(rdBtnMale);
            Controls.Add(btnSubmit);
            Controls.Add(txtSalary);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lblGen);
            Controls.Add(lblSal);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(lblReg);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReg;
        private Label lblId;
        private Label lblName;
        private Label lblSal;
        private Label lblGen;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtSalary;
        private Button btnSubmit;
        private RadioButton rdBtnMale;
        private RadioButton rdBtnFemale;
        private Label lblAll;
    }
}