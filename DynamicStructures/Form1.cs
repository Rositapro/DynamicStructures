namespace DynamicStructures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStack_Click(object sender, EventArgs e)
        {
            FormStack stack = new FormStack();
            stack.Show();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            FormQueue queue = new FormQueue();
            queue.Show();
        }

        private void btnLinkedList_Click(object sender, EventArgs e)
        {
            FormLinkedList linkedList = new FormLinkedList();
            linkedList.Show();
        }
    }
}
