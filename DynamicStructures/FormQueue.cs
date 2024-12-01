using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicStructures
{
    public partial class FormQueue : Form
    {
        private Queue<int> cola;
        public FormQueue()
        {
            InitializeComponent();
            cola = new Queue<int>();
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int element))
            {
                cola.Enqueue(element);
                MessageBox.Show("Element " + element + " added to the queue.");
                txtNumber.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (cola.Count > 0)
            {
                int element = cola.Dequeue();
                MessageBox.Show("Element" + element + " removed from queue.");
            }
            else
            {
                MessageBox.Show("Queue is empty.");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstQueue.Items.Clear();
            foreach (var element in cola)
            {
                lstQueue.Items.Add(element);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
