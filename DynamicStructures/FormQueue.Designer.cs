namespace DynamicStructures
{
    partial class FormQueue
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
            btnEnqueue = new Button();
            btnDequeue = new Button();
            btnShow = new Button();
            txtNumber = new TextBox();
            btnReturn = new Button();
            label1 = new Label();
            lstQueue = new ListBox();
            SuspendLayout();
            // 
            // btnEnqueue
            // 
            btnEnqueue.Location = new Point(227, 34);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(75, 23);
            btnEnqueue.TabIndex = 0;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = true;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.Location = new Point(227, 63);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(75, 23);
            btnDequeue.TabIndex = 1;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = true;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(227, 92);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(75, 23);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(121, 34);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 3;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(34, 92);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 5;
            label1.Text = "Enter a number";
            // 
            // lstQueue
            // 
            lstQueue.FormattingEnabled = true;
            lstQueue.ItemHeight = 15;
            lstQueue.Location = new Point(308, 34);
            lstQueue.Name = "lstQueue";
            lstQueue.Size = new Size(120, 94);
            lstQueue.TabIndex = 6;
            // 
            // FormQueue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstQueue);
            Controls.Add(label1);
            Controls.Add(btnReturn);
            Controls.Add(txtNumber);
            Controls.Add(btnShow);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Name = "FormQueue";
            Text = "FormQueue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnqueue;
        private Button btnDequeue;
        private Button btnShow;
        private TextBox txtNumber;
        private Button btnReturn;
        private Label label1;
        private ListBox lstQueue;
    }
}