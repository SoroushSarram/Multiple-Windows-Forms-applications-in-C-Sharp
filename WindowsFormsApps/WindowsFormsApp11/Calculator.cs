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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        Calc_soroush obj = new Calc_soroush();

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the Calculator App.?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Clear();
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            obj.CurrentValue = Convert.ToDouble(textBox1.Text);
            double num = obj.Sub();
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            obj.CurrentValue = Convert.ToDouble(textBox1.Text);
            double num = obj.Add();
            textBox1.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            obj.CurrentValue = Convert.ToDouble(textBox1.Text);
            double num = obj.Mul();
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            obj.CurrentValue = Convert.ToDouble(textBox1.Text);
            double num = obj.Div();
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            obj.Operand2 = Convert.ToDouble(textBox1.Text);
            double num = obj.Equals();
            textBox1.Text = num.ToString();
        }
    }
}

class Calc_soroush
{

    private double currentValue;
    private string op;
    private double operand1;
    private double operand2;
    

    public double CurrentValue
    {
        set
        {
            currentValue = value;
        }
        get
        {
            return currentValue;
        }
    }
    public double Operand1
    {
        set
        {
            operand1 = value;
        }
        get
        {
            return operand1;
        }
    }
    public double Operand2
    {
        set
        {
            operand2 = value;
        }
        get
        {
            return operand2;
        }
    }
    public Calc_soroush()
    {

    }
    public Calc_soroush(double currentValue, double operand1, double operand2)
    {
        this.CurrentValue = currentValue;
        this.Operand1 = operand1;
        this.Operand2 = operand2;
    }
    public double Sub()
    {
        operand1 = currentValue;
        op = "-";
        return operand1;
    }
    public double Add()
    {
        operand1 = currentValue;
        op = "+";
        return operand1;
    }
    public double Mul()
    {
        operand1 = currentValue;
        op = "*";
        return operand1;
    }
    public double Div()
    {
        operand1 = currentValue;
        op = "/";
        return operand1;
    }
    public double Equals()
    {
        if (op == "-")
        {
            operand2 = operand1 - operand2;
            return operand2;
        }
        else if (op == "+")
        {
            operand2 = operand1 + operand2;
            return operand2;
        }
        else if (op == "*")
        {
            operand2 = operand1 * operand2;
            return operand2;
        }
        else if (op == "/")
        {
            operand2 = operand1 / operand2;
            return operand2;
        }
        else return 0;
    }
}
