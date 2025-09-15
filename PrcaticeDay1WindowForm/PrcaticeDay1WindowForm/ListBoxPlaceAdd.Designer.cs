namespace PrcaticeDay1WindowForm
{
    partial class ListBoxPlaceAdd
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
            listBox1 = new System.Windows.Forms.ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox2 = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Arvind", "Arjun", "Sneha", "Rekha" });
            listBox1.Location = new Point(67, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(151, 264);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(332, 68);
            button1.Name = "button1";
            button1.Size = new Size(113, 49);
            button1.TabIndex = 2;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(332, 214);
            button2.Name = "button2";
            button2.Size = new Size(113, 49);
            button2.TabIndex = 3;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(332, 146);
            button3.Name = "button3";
            button3.Size = new Size(113, 49);
            button3.TabIndex = 4;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(332, 283);
            button4.Name = "button4";
            button4.Size = new Size(113, 49);
            button4.TabIndex = 5;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Items.AddRange(new object[] { "Abhinav", "Aditya", "bharat", "vaibhav" });
            listBox2.Location = new Point(526, 57);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 284);
            listBox2.TabIndex = 6;
            // 
            // ListBoxPlaceAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "ListBoxPlaceAdd";
            Text = "ListBoxPlaceAdd";
            Load += ListBoxPlaceAdd_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.ListBox listBox2;
    }
}