using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_form_Instant_Math_Analyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelResult.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear(); 
            textBox4.Clear();
            textBox6.Clear();
            labelResult.ResetText();
            textBox1.Focus();
            

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //Min Max to
            double num1, num2, num3, num4, num5;
            double.TryParse(textBox1.Text, out num1);
            double.TryParse(textBox2.Text, out num2);
            double.TryParse(textBox3.Text, out num3);
            double.TryParse(textBox4.Text, out num4);
            double.TryParse(textBox6.Text, out num5);
            double max = Math.Max(Math.Max(Math.Max(Math.Max(num1, num2), num3), num4), num5);
            double min = Math.Min(Math.Min(Math.Min(Math.Min(num1, num2), num3), num4), num5);

            //Absolute values
            double absoluteValue1 = Math.Abs(num1);
            double absoluteValue2 = Math.Abs(num2);
            double absoluteValue3 = Math.Abs(num3);
            double absoluteValue4 = Math.Abs(num4);
            double absoluteValue5 = Math.Abs(num5);

            //Square roots
            double squareRoot1 = Math.Round(Math.Sqrt(num1 ), 2);
            double squareRoot2 = Math.Round(Math.Sqrt(num2 ), 2);
            double squareRoot3 = Math.Round(Math.Sqrt(num3 ), 2);
            double squareRoot4 = Math.Round(Math.Sqrt(num4 ), 2);
            double squareRoot5 = Math.Round(Math.Sqrt(num5 ), 2);

            //Floor Values
            double floornumb1 = Math.Floor(num1);
            double floornumb2 = Math.Floor(num2);
            double floornumb3 = Math.Floor(num3);
            double floornumb4 = Math.Floor(num4);
            double floornumb5 = Math.Floor(num5);

            labelResult.Text =
        "Absolute Values:" + absoluteValue1 + " " + absoluteValue2 + " " + absoluteValue3 + " " + absoluteValue4 + " " + absoluteValue5 +
        "\nSquare Roots: " + squareRoot1 + " " + squareRoot2 + " " + squareRoot3 + " " + squareRoot4 + " " + squareRoot5 +
        "\nFloor Values: " + floornumb1 + " " + floornumb2 + " " +  floornumb3 + " " + floornumb4 + " " + floornumb5 +
        "\nMinimum Value: " + min+ 
        "\nMaximum Value: " + max;
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CMB_Click(object sender, EventArgs e)
        {
        }
    }
}
