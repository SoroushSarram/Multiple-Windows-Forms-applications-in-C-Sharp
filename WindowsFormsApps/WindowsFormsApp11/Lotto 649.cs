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

namespace WindowsFormsApp11
{
    public partial class Lotto_649 : Form
    {
        public Lotto_649()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit this application?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private const string path = "lotto649.txt";

        private void WriteFile(int[] numbers)
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("649,{0}", DateTime.Now);
            for (int index = 0; index < 6; index++)
            {
                sw.Write(",{0}", numbers[index]);
            }
            sw.WriteLine(" Extra {0}", numbers[6]);
            sw.Close();
            fs.Close();
        }
        private void ShowNumbers(int[] numbers)
        {
            for (int i = 0; i < 7; i++)
            {
                textBox1.AppendText(numbers[i].ToString());
                textBox1.AppendText(Environment.NewLine);
            }
        }
        private int[] GenerateNumbers()
        {
            int[] numbers = new int[7];
            Random random = new Random();
            for (int index = 0; index < 7; index++)
            {
                numbers[index] = random.Next(1, 49);
            }
            return numbers;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int[] numbers = GenerateNumbers();
            WriteFile(numbers);
            ShowNumbers(numbers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arrNum = new int[7];
            Random random = new Random();
            string tempo = "";
            int randomNumber = 0;
            textBox1.Text = "";

            arrNum[0] = random.Next(1, 49);
            for (int i = 0; i < 7; i++)
            {
                randomNumber = random.Next(1, 49);
                arrNum[i] = randomNumber;
            }
            for (int j = 0; j < 6; j++)
            {
                tempo = tempo + arrNum[j] + ", ";
                textBox1.Text += arrNum[j] + "\n";
            }
            tempo = tempo + " Extra: " + arrNum[6];
            textBox1.Text += arrNum[6];
            MessageBox.Show(DateTime.Now.ToString() + " - " + tempo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            fs.Close();
            sr.Close();
            MessageBox.Show(textBox1.Text + "\n" + "\n" + "Soroush", "Winning numbers are:");
            textBox1.Focus();
        }
    }
}
