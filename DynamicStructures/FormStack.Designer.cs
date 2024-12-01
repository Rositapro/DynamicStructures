namespace DynamicStructures
{
    partial class FormStack
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
            label1 = new Label();
            btnReturn = new Button();
            btnShow = new Button();
            btnPop = new Button();
            lstStack = new ListBox();
            txtNumber = new TextBox();
            btnPush = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 35);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 13;
            label1.Text = "Enter a number";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(42, 103);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 12;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(223, 90);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 11;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(223, 61);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(75, 23);
            btnPop.TabIndex = 10;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // lstStack
            // 
            lstStack.FormattingEnabled = true;
            lstStack.ItemHeight = 15;
            lstStack.Location = new Point(304, 32);
            lstStack.Name = "lstStack";
            lstStack.Size = new Size(120, 94);
            lstStack.TabIndex = 9;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(104, 32);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 8;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(223, 32);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(75, 23);
            btnPush.TabIndex = 7;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // FormStack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnReturn);
            Controls.Add(btnShow);
            Controls.Add(btnPop);
            Controls.Add(lstStack);
            Controls.Add(txtNumber);
            Controls.Add(btnPush);
            Name = "FormStack";
            Text = "Stack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReturn;
        private Button btnShow;
        private Button btnPop;
        private ListBox lstStack;
        private TextBox txtNumber;
        private Button btnPush;
    }
}