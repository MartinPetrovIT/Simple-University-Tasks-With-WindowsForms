using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                listBox1.Items.Clear();


                foreach (var item in checkedListBox1.CheckedItems)
                {
                    listBox1.Items.Add(item.ToString());
                }

                

                var checkedItems = checkedListBox1.CheckedIndices;
                foreach (var item in checkedItems)
                {
                    checkedListBox1.SetItemCheckState((int)item, CheckState.Unchecked);
                }
               
            }
        }
    }
}
