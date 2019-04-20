using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> years = new List<int>();
            for(int i=2000;i<=2070;i++)
            {
                years.Add(i);
            }
            comboBox1.DataSource = years;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Laptop laptop = new Laptop(id);
            laptop.Color = textBox2.Text;
            laptop.MadeYear = comboBox1.SelectedItem.ToString();
            MessageBox.Show(laptop.GetInfo());
            MessageBox.Show(laptop.GetInfo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Apple");
            dict.Add(2, "Mango");
            dict.Add(3, "Banana");

            foreach(KeyValuePair<int,string> s in dict)
            {
                MessageBox.Show(s.Value);
            }
        }
    }
}
