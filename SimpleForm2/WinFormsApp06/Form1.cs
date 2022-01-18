using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            buttonOK.Enabled = false;
            textBoxAddress.Tag = false;
            textBoxAge.Tag = false;
            textBoxName.Tag = false;
            

            textBoxAddress.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            textBoxName.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            textBoxAge.Validating += new CancelEventHandler(textBoxEmpty_Validating);
            textBoxAge.Validating += new CancelEventHandler(textBox_TextChanged);
            textBoxAge.Validating += new CancelEventHandler(textBoxAge_Validating);

        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.Tag = true;
                tb.BackColor = SystemColors.Window;
            }
            ValidateOK();
        }
        private void textBoxAge_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length > 0)
            {
                if (Int16.Parse(tb.Text.ToString()) < 18)
                {
                    tb.Tag = false;
                    tb.BackColor = Color.Red;
                }
                else
                {
                    tb.Tag = true;
                    tb.BackColor = SystemColors.Window;
                }
                ValidateOK();
            }
        }
        private void textBoxAge_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            ValidateOK();
        }
        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (((tb.Text.Length == 0) && (e.KeyChar == 48)) ||
            ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void textBoxOccupation_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.CompareTo("Програмист") == 0 || tb.Text.Length == 0)
            {

                tb.BackColor = SystemColors.Window;
                tb.Tag = true;


            }
            else
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }

            ValidateOK();
        }

        private void ValidateOK()
        {
            buttonOK.Enabled =
                  (
                   (bool)(textBoxAddress.Tag) &&
                   (bool)(textBoxAge.Tag) &&
                   (bool)(textBoxName.Tag)
                   );

        }
        private void textBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }

            ValidateOK();

        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            string output;
           
            output = "Име: " + textBoxName.Text + "\r\n";
            output += "Адрес: " + textBoxAddress.Text + "\r\n";
            output += "Професия: " + (string)(checkBoxAreYouAProgrammer.Checked ? "Програмист" : "Не е програмист") + "\r\n";
            output += "Пол: " + (string)(radioButtonFemale.Checked ? "Жена" : "Мъж") + "\r\n";
            output += "Възраст: " + textBoxAge.Text + "\r\n";

            textBoxOutput.Text = output;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string output;


            output = "Помощна информация:\r\n\r\n";
            output += "Име = Вашето име\r\n";
            output += "Адрес = Вашият адрес\r\n";
            output += "Професия = Единствената допустима стойност е 'Програмист'\r\n";
            output += "Възраст = Вашата възраст\r\n";

            textBoxOutput.Text = output;
        }

     
    }
}
