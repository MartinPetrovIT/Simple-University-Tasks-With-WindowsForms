using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        
        const int MaxNormalBMI = 25;
        const string Message1 = "Нормалният ИТМ за вашата възрастова група е между {0}-{1}";
        const string Message5 = "Вашето тегло: ";
        const string Message2= "Поднормено тегло";
        const string Message3= "Нормално тегло";
        const string Message4= "Наднормено тегло";
        public Form1()
        {
            InitializeComponent();
            
            button2.Enabled = false;
            textBox1.Tag = false;
            textBox2.Tag = false;
            textBox3.Tag = false;

            textBox1.Validating += new CancelEventHandler(textBox_Validating);
            textBox2.Validating += new CancelEventHandler(textBox2_Validating);
            textBox3.Validating += new CancelEventHandler(textBox3_Validating);
        }

        private void Validator()
        {
            button2.Enabled =
                  (
                   (bool)(textBox1.Tag) &&
                   (bool)(textBox2.Tag) &&
                   (bool)(textBox3.Tag) 
                   );

        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (((tb.Text.Length == 0) && (e.KeyChar == 48)) ||
            ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            double heigth;
            var IsValid = double.TryParse(tb.Text, out heigth);
            if (tb.Text.Length == 0 )
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else if (!IsValid)
            {
                MessageBox.Show("Грешка при въвеждането на данни в полето 'Височина'!");
                tb.BackColor = Color.Red;
                tb.Clear();
                tb.Tag = false;
            }
            else if (IsValid)
            {
                if (heigth < 100)
                {
                    MessageBox.Show("Минималнa височина 100 !");
                    tb.BackColor = Color.Red;
                    tb.Clear();
                    tb.Tag = false;
                }
                else if (heigth > 220)
                {
                    MessageBox.Show("Максимална височина 220 !");
                    tb.BackColor = Color.Red;
                    tb.Clear();
                    tb.Tag = false;
                }
            }
         
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
       

            Validator();

        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            double width;
            var IsValid = double.TryParse(tb.Text, out width);

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else if (!IsValid)
            {
                MessageBox.Show("Грешка при въвеждането на данни в полето 'Килограми'!");
                tb.BackColor = Color.Red;
                tb.Clear();
                tb.Tag = false;
            }
            else if (IsValid)
            {
                if (width < 30)
                {
                    MessageBox.Show("Минимални килограми 30 !");
                    tb.BackColor = Color.Red;
                    tb.Clear();
                    tb.Tag = false;
                }
                else if (width > 150)
                {
                    MessageBox.Show("Максимални килограми 150 !");
                    tb.BackColor = Color.Red;
                    tb.Clear();
                    tb.Tag = false;
                }
            }
           
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
          
            Validator();

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int age;
            var IsValid = int.TryParse(tb.Text, out age);

            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;
            }
            else if (!IsValid)
            {
                MessageBox.Show("Грешка при въвеждането на данни в полето 'Години'!");
                tb.BackColor = Color.Red;
                tb.Clear();
                tb.Tag = false;
            }
            else if (IsValid)
            {
                if (age < 18)
                {
                    MessageBox.Show("Минимални години 18 !");
                    tb.BackColor = Color.Red;
                    tb.Clear();
                    tb.Tag = false;
                }
                else if (age > 100)
                {
                    MessageBox.Show("Максимални години 100 !");
                    tb.BackColor = Color.Red;
                    tb.Clear();
                    tb.Tag = false;
                }
            }
           
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            

            Validator();

        }


        private void button2_Click(object sender, EventArgs e)
        {
           
            StringBuilder sb = new StringBuilder();
            double heigth = double.Parse(textBox1.Text);
            int age = int.Parse(textBox3.Text);
            heigth = heigth / 100;
            double width = double.Parse(textBox2.Text);

            double bmi = width / (heigth * heigth);
            bmi = Math.Round(bmi, 2);

           

            sb.AppendLine($"Вашият ИТМ е: {bmi}");
            var che = ChecksAgeGroup(age);

            

            sb.AppendLine(string.Format(Message1, (che - 5), (che)));
            sb.Append(Message5);

            if (bmi > che)
            {
                sb.Append(Message4);
                pictureBox1.Image = imageList1.Images[1];
            }

            else if (bmi < che - 5)
            {
                sb.Append(Message2);
                pictureBox1.Image = imageList1.Images[2];
            }
            else
            {
                sb.Append(Message3);
                pictureBox1.Image = imageList1.Images[0];
            }
         


            richTextBox1.Text = sb.ToString().TrimEnd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output;

            output = "Как работи:\r\n\r\n";
            output += "Височина = вашата височина във сантиметри (Минимум 100 сантимера)\r\n";
            output += "Килограми = Вашето тегло в килограми (Минимум 30 килограма)\r\n";
            output += "Години = Вашата възраст (Не по-малко от 18 години)\r\n";
            richTextBox1.Text = output;

        }



        private int ChecksAgeGroup(int age)
        {
            if (age >= 18 && age <= 24)
                return MaxNormalBMI;
            else if (age >= 25 && age <= 34)
                return MaxNormalBMI + 1;
            else if (age >= 35 && age <= 44)
                return MaxNormalBMI + 2;
            else if (age >= 45 && age <= 54)
                return MaxNormalBMI + 3;
            else if (age >= 55 && age <= 64)
                return MaxNormalBMI + 4;
           
                return MaxNormalBMI + 5;
        }

      
    }
}
