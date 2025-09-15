namespace PrcaticeDay1WindowForm
{
    partial class ListBox
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
            lblItem = new Label();
            lblIndex = new Label();
            txtName = new TextBox();
            txtIndex = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnClear = new Button();
            btnInsert = new Button();
            btnRemoveAt = new Button();
            btnClose = new Button();
            lstBox = new System.Windows.Forms.ListBox();
            lblTg = new Label();
            SuspendLayout();
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.Location = new Point(235, 16);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(0, 20);
            lblTag.TabIndex = 0;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(131, 89);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(87, 20);
            lblItem.TabIndex = 1;
            lblItem.Text = "Select Item ";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(128, 142);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(89, 20);
            lblIndex.TabIndex = 2;
            lblIndex.Text = "Select Index";
            // 
            // txtName
            // 
            txtName.Location = new Point(264, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            // 
            // txtIndex
            // 
            txtIndex.Location = new Point(263, 142);
            txtIndex.Name = "txtIndex";
            txtIndex.Size = new Size(125, 27);
            txtIndex.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(364, 218);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(373, 269);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(379, 332);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(591, 224);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAt
            // 
            btnRemoveAt.Location = new Point(598, 283);
            btnRemoveAt.Name = "btnRemoveAt";
            btnRemoveAt.Size = new Size(94, 29);
            btnRemoveAt.TabIndex = 9;
            btnRemoveAt.Text = "RemoveAt";
            btnRemoveAt.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(598, 339);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lstBox
            // 
            lstBox.FormattingEnabled = true;
            lstBox.Location = new Point(32, 227);
            lstBox.Name = "lstBox";
            lstBox.Size = new Size(173, 184);
            lstBox.TabIndex = 11;
            // 
            // lblTg
            // 
            lblTg.AutoSize = true;
            lblTg.Location = new Point(252, 18);
            lblTg.Name = "lblTg";
            lblTg.Size = new Size(169, 20);
            lblTg.TabIndex = 12;
            lblTg.Text = "ListBox in Window Form";
            // 
            // ListBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTg);
            Controls.Add(lstBox);
            Controls.Add(btnClose);
            Controls.Add(btnRemoveAt);
            Controls.Add(btnInsert);
            Controls.Add(btnClear);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(txtIndex);
            Controls.Add(txtName);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(lblTag);
            Name = "ListBox";
            Text = "ListBox";
            Load += ListBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTag;
        private Label lblItem;
        private Label lblIndex;
        private TextBox txtName;
        private TextBox txtIndex;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnClear;
        private Button btnInsert;
        private Button btnRemoveAt;
        private Button btnClose;
        private System.Windows.Forms.ListBox lstBox;
        private Label lblTg;
    }
}