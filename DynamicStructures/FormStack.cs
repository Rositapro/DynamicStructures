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
    public partial class FormStack : Form
    {
        private Stack<int> stack;

        public FormStack()
        {
            InitializeComponent();
            stack = new Stack<int>();
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                int element = stack.Pop();
                MessageBox.Show("Element " + element + " removed from the stack.");
            }
            else
            {
                MessageBox.Show("Stack is empty.");
            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int elemento))
            {
                stack.Push(elemento);
                MessageBox.Show("Element" + elemento + " added to the stack.");
                txtNumber.Clear();
            }
            else
            {
                MessageBox.Show("Please, emter a valid number.");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstStack.Items.Clear();
            foreach (var elemento in stack)
            {
                lstStack.Items.Add(elemento);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
