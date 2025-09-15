namespace PrcaticeDay1WindowForm
{
    partial class Student
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
            lblTag = new Label();
            lblId = new Label();
            lblName = new Label();
            lblLName = new Label();
            txtId = new TextBox();
            txtFName = new TextBox();
            txtLName = new TextBox();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTag.ForeColor = Color.FromArgb(255, 128, 0);
            lblTag.Location = new Point(232, 46);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(310, 41);
            lblTag.TabIndex = 0;
            lblTag.Text = "Student Registration";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(179, 144);
            lblId.Name = "lblId";
            lblId.Size = new Size(195, 31);
            lblId.TabIndex = 1;
            lblId.Text = "Student Your ID: ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(179, 212);
            lblName.Name = "lblName";
            lblName.Size = new Size(200, 31);
            lblName.TabIndex = 2;
            lblName.Text = "Enter Your Name:";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLName.Location = new Point(179, 272);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(200, 31);
            lblLName.TabIndex = 3;
            lblLName.Text = "Enter Last Name: ";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(398, 141);
            txtId.Name = "txtId";
            txtId.Size = new Size(202, 34);
            txtId.TabIndex = 4;
            // 
            // txtFName
            // 
            txtFName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFName.Location = new Point(398, 212);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(202, 34);
            txtFName.TabIndex = 5;
            // 
            // txtLName
            // 
            txtLName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLName.Location = new Point(398, 272);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(202, 34);
            txtLName.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Blue;
            btnSubmit.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = SystemColors.ButtonHighlight;
            btnSubmit.Location = new Point(334, 347);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(156, 47);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(txtLName);
            Controls.Add(txtFName);
            Controls.Add(txtId);
            Controls.Add(lblLName);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Controls.Add(lblTag);
            Name = "Student";
            Text = "Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTag;
        private Label lblId;
        private Label lblName;
        private Label lblLName;
        private TextBox txtId;
        private TextBox txtFName;
        private TextBox txtLName;
        private Button btnSubmit;
    }
}