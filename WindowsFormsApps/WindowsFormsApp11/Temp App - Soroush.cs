using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApp11
{
    public partial class Temp_App___Soroush : Form
    {
        public Temp_App___Soroush()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {

            }
            else
            {
                textBox1.ReadOnly = false;
            }
            if (radioButton2.Checked == true)
            {

            }
            else
            {
                textBox2.ReadOnly = true;
                textBox2.Clear();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {

            }
            else
            {
                textBox1.ReadOnly = true;
                textBox1.Clear();
            }

            if (radioButton2.Checked == false)
            {
            }
            else
            {
                textBox2.ReadOnly = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex myReg = new Regex("^[0 - 9] *$");
            if (radioButton1.Checked == true)
            {
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 9 / 5) + 32;
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            }
            if (radioButton2.Checked == true)
            {
                try
                {
                    double x, y;
                    x = double.Parse(textBox2.Text);
                    y = (x - 32) * 5 / 9;
                    textBox1.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            }
            if (textBox1.Text == "100" & radioButton1.Checked == true || textBox2.Text == "212" & radioButton2.Checked == true)
            {
                richTextBox1.Text = "Water Boils";
            }
            else
            {
                richTextBox1.Clear();
                if (textBox1.Text == "40" & radioButton1.Checked == true || textBox2.Text == "104" & radioButton2.Checked == true)
                {
                    richTextBox1.Text = "Hot Bath";
                }
                else
                {
                    richTextBox1.Clear();

                    if (textBox1.Text == "37" & radioButton1.Checked == true || textBox2.Text == "98.6" & radioButton2.Checked == true)
                    {
                        richTextBox1.Text = "Body Temperature";
                    }
                    else
                    {
                        richTextBox1.Clear();
                        if (textBox1.Text == "30" & radioButton1.Checked == true || textBox2.Text == "86" & radioButton2.Checked == true)
                        {
                            richTextBox1.Text = "Beach Weather";
                        }
                        else
                        {
                            richTextBox1.Clear();
                            if (textBox1.Text == "21" & radioButton1.Checked == true || textBox2.Text == "70" & radioButton2.Checked == true)
                            {
                                richTextBox1.Text = "Room Temperature";
                            }
                            else
                            {
                                richTextBox1.Clear();
                                if (textBox1.Text == "10" & radioButton1.Checked == true || textBox2.Text == "50" & radioButton2.Checked == true)
                                {
                                    richTextBox1.Text = "Cool Day";
                                }
                                else
                                {
                                    richTextBox1.Clear();
                                    if (textBox1.Text == "0" & radioButton1.Checked == true || textBox2.Text == "32" & radioButton2.Checked == true)
                                    {
                                        richTextBox1.Text = "Freezing Point of Weather";
                                    }
                                    else
                                    {
                                        richTextBox1.Clear();
                                        if (textBox1.Text == "-18" & radioButton1.Checked == true || textBox2.Text == "0" & radioButton2.Checked == true)
                                        {
                                            richTextBox1.Text = "Very Cold Day";
                                        }
                                        else
                                        {
                                            richTextBox1.Clear();
                                            if (textBox1.Text == "-40" & radioButton1.Checked == true || textBox2.Text == "-40" & radioButton2.Checked == true)
                                            {
                                                richTextBox1.Text = "Extreme Cold Day";
                                            }
                                            else
                                            {
                                                richTextBox1.Clear();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit this Application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private const string path = "TemperatureConversion.txt";

        private void WriteToFile(string text)
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(text);
            sw.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            fs.Close();
            sr.Close();
            MessageBox.Show(content, "History", MessageBoxButtons.OK);
        }
    }
}
