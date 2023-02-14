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
    public partial class MoneyEx___Soroush : Form
    {
        public MoneyEx___Soroush()
        {
            InitializeComponent();
        }

        private void MoneyEx___Soroush_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex myReg = new Regex(@"\d+(\.\d+)+");
            if (radioButton1.Checked == true & radioButton6.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 1);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton1.Checked == true & radioButton7.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 0.81);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton1.Checked == true & radioButton8.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 0.66);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton1.Checked == true & radioButton9.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 0.57);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton1.Checked == true & radioButton10.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 6.47);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton2.Checked == true & radioButton6.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 1.26);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton2.Checked == true & radioButton7.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 1);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton2.Checked == true & radioButton8.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 0.83);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton2.Checked == true & radioButton9.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 0.72);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton2.Checked == true & radioButton10.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 8.10);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton3.Checked == true & radioButton6.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 1.51);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton3.Checked == true & radioButton7.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 1.20);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton3.Checked == true & radioButton8.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 1);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton3.Checked == true & radioButton9.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 0.86);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton3.Checked == true & radioButton10.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 9.76);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton4.Checked == true & radioButton6.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 1.75);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton4.Checked == true & radioButton7.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 1.40);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton4.Checked == true & radioButton8.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 1.16);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton4.Checked == true & radioButton9.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 1);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton4.Checked == true & radioButton10.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 11.33);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton5.Checked == true & radioButton6.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 0.15);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton5.Checked == true & radioButton7.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 0.12);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton5.Checked == true & radioButton8.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 0.10);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton5.Checked == true & radioButton9.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 0.088);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
            else if (radioButton5.Checked == true & radioButton10.Checked == true)
                try
                {
                    double x, y;
                    x = double.Parse(textBox1.Text);
                    y = (x * 1);
                    textBox2.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Please just enter a number!", "Error!");
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want \n to quit the application \n Money Exchange?", "Exit?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private const string path = "moneyexchange.txt";

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
