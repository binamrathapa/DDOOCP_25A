using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        string[] names = new string[3];
        private void button1_Click(object sender, EventArgs e)
        {            
            names[count] = textBox1.Text;
            count++;
            MessageBox.Show("Added successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i=0;i<names.Length;i++)
            {
                MessageBox.Show(names[i]);

            }
        }
    }
}
