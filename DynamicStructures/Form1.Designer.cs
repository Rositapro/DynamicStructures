namespace DynamicStructures
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
            btnStack = new Button();
            btnQueue = new Button();
            btnLinkedList = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnStack
            // 
            btnStack.Location = new Point(110, 100);
            btnStack.Name = "btnStack";
            btnStack.Size = new Size(75, 23);
            btnStack.TabIndex = 0;
            btnStack.Text = "Stack";
            btnStack.UseVisualStyleBackColor = true;
            btnStack.Click += btnStack_Click;
            // 
            // btnQueue
            // 
            btnQueue.Location = new Point(110, 129);
            btnQueue.Name = "btnQueue";
            btnQueue.Size = new Size(75, 23);
            btnQueue.TabIndex = 1;
            btnQueue.Text = "Queue";
            btnQueue.UseVisualStyleBackColor = true;
            btnQueue.Click += btnQueue_Click;
            // 
            // btnLinkedList
            // 
            btnLinkedList.Location = new Point(110, 158);
            btnLinkedList.Name = "btnLinkedList";
            btnLinkedList.Size = new Size(75, 23);
            btnLinkedList.TabIndex = 2;
            btnLinkedList.Text = "Linked List";
            btnLinkedList.UseVisualStyleBackColor = true;
            btnLinkedList.Click += btnLinkedList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 65);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 304);
            Controls.Add(label1);
            Controls.Add(btnLinkedList);
            Controls.Add(btnQueue);
            Controls.Add(btnStack);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStack;
        private Button btnQueue;
        private Button btnLinkedList;
        private Label label1;
    }
}
