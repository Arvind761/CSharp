namespace PrcaticeDay1WindowForm
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
            btnRed = new Button();
            btnGreen = new Button();
            btnYellow = new Button();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnRed
            // 
            btnRed.BackColor = SystemColors.ActiveCaptionText;
            btnRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnRed.ForeColor = Color.Red;
            btnRed.Location = new Point(196, 246);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(94, 29);
            btnRed.TabIndex = 0;
            btnRed.Text = "RED";
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += button1_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = SystemColors.ButtonHighlight;
            btnGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGreen.ForeColor = Color.Lime;
            btnGreen.Location = new Point(387, 246);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(94, 29);
            btnGreen.TabIndex = 1;
            btnGreen.Text = "Green";
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = SystemColors.ButtonHighlight;
            btnYellow.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnYellow.ForeColor = Color.Yellow;
            btnYellow.Location = new Point(592, 246);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(94, 29);
            btnYellow.TabIndex = 2;
            btnYellow.Text = "Yellow";
            btnYellow.UseVisualStyleBackColor = false;
            btnYellow.Click += btnYellow_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(322, 151);
            txtName.Name = "txtName";
            txtName.Size = new Size(298, 43);
            txtName.TabIndex = 3;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 853);
            Controls.Add(txtName);
            Controls.Add(btnYellow);
            Controls.Add(btnGreen);
            Controls.Add(btnRed);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRed;
        private Button btnGreen;
        private Button btnYellow;
        private TextBox txtName;
    }
}
