using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp11
{
    public partial class IP4_Validator : Form
    {
        public IP4_Validator()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");
            if (reg.IsMatch(textBox1.Text.Trim()) == true)
            {
                MessageBox.Show(textBox1.Text + "\n" + "The IP is correct", "Valid IP");
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show(textBox1.Text + "\n" + "The IP must have 4 bytes \n" + "integer number between 0 to 255 \n"
                + "seperated by a dot (255.255.255.255)", "Error");
                textBox1.Focus();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit this Application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }
        private void IP4_Validator_Load(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Now;
            string temp = "";
            temp = dateNow.ToString("dd-MM-yy");
            label1.Text = "Today: " + temp;
        }
    }
}
