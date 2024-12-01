using System;
using System.Collections;
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
    public partial class FormLinkedList : Form
    {
        private LinkedList<int> list;
        public FormLinkedList()
        {
            InitializeComponent();
            list = new LinkedList<int>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int element))
            {
                list.AddLast(element);
                MessageBox.Show("Elemento" + element + " added to the list.");
                txtNumber.Clear();
            }
            else
            {
                MessageBox.Show("Please, enter a valid number.");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int element))
            {
                if (list.Remove(element))
                {
                    MessageBox.Show("Element" + element + " removed from the list.");
                }
                else
                {
                    MessageBox.Show("Element " + element + " not found.");
                }
                txtNumber.Clear();
            }
            else
            {
                MessageBox.Show("Please, enter a valid number.");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstLinkedList.Items.Clear();
            foreach (var element in list)
            {
                lstLinkedList.Items.Add(element);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
