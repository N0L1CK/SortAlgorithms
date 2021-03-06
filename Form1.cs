using Algorithm;
using System;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public partial class Form1 : Form
    {
        AlgorithmBase<int> algorithm = new BubbleSort<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                algorithm.Items.Add(value);
                label1.Text += " " + value;
                textBox1.Text = "";
                textBox1.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            algorithm.Sort();

            var str = "";

            foreach (var item in algorithm.Items) 
            {
                str += " " + item;
            }
            label2.Text = str;
        }
    }
}
