namespace DynamicStructures
{
    partial class FormLinkedList
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
            btnAdd = new Button();
            btnRemove = new Button();
            btnShow = new Button();
            txtNumber = new TextBox();
            lstLinkedList = new ListBox();
            btnReturn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(217, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(217, 62);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(217, 91);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(111, 33);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 3;
            // 
            // lstLinkedList
            // 
            lstLinkedList.FormattingEnabled = true;
            lstLinkedList.ItemHeight = 15;
            lstLinkedList.Location = new Point(298, 33);
            lstLinkedList.Name = "lstLinkedList";
            lstLinkedList.Size = new Size(120, 94);
            lstLinkedList.TabIndex = 4;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(12, 91);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 5;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 6;
            label1.Text = "Enter a number";
            // 
            // FormLinkedList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnReturn);
            Controls.Add(lstLinkedList);
            Controls.Add(txtNumber);
            Controls.Add(btnShow);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Name = "FormLinkedList";
            Text = "FormLinkedList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnRemove;
        private Button btnShow;
        private TextBox txtNumber;
        private ListBox lstLinkedList;
        private Button btnReturn;
        private Label label1;
    }
}