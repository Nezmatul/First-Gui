using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Gui
{
    public partial class Form1 : Form
    {
        public static int math;
        public static int english;
        public static int history;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string final = "u";
            string pass = "Pass";
            bool works = false;
            bool works2 = false;
            bool works3 = false;
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter an Input";
            }
            if (!(textBox2.Text == ""))
            {
                if (int.TryParse(textBox2.Text, out int happy))
                {
                    if (happy > 0 )
                    {
                        math = happy;
                        works = true;
                    }
                }
            }
            else
            {
                works = false;
            }
            if (!(textBox3.Text == ""))
            {
                if (int.TryParse(textBox2.Text, out int happy2))
                {
                    if (happy2 > 0)
                    {
                        english = happy2;
                        works2 = true;
                    }
                }
            }
            else
            {
                works2 = false;
            }
            if (!(textBox4.Text == ""))
            {
                if (int.TryParse(textBox4.Text, out int happy3))
                {
                    if (happy3 > 0)
                    {
                        history = happy3;
                        works3 = true;
                    }
                }
            }
            else
            {
                works3 = false;
            }
            if (works && works2 && works3)
            {
                double avg = ((math + english + history) / 3.0);
                if (avg >= 90)
                {
                    final = "A";
                }
                else if (avg >= 80)
                {
                    final = "B";
                }
                else if (avg >= 70)
                {
                    final = "C";
                }
                else if (avg >= 60)
                {
                    final = "D";
                }
                else
                {
                    final = "F";
                    pass = "Fail";
                }

                textBox5.Text = Convert.ToString(avg);
                textBox6.Text = final;
                textBox7.Text = pass;
            }
            else
            {
                textBox5.Text = "input not valid";
                textBox6.Text = "input not valid";
                textBox7.Text = "input not valid";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.AutoSize = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.AutoSize = true;
        }
    }
}
