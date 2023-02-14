using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?","Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Question).ToString() == "Yes")
            { 
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculator obj = new Calculator();
            obj.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lotto_Max obj = new Lotto_Max();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lotto_649 obj = new Lotto_649();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoneyEx___Soroush obj = new MoneyEx___Soroush();
            obj.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Temp_App___Soroush obj = new Temp_App___Soroush();
            obj.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IP4_Validator obj = new IP4_Validator();
            obj.ShowDialog();
        }
    }
}
