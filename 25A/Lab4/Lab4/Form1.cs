using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator c = new Calculator();
         int result=  c.Operation("+",Convert.ToInt32(textBox1.Text),Convert.ToInt32(textBox2.Text));
            textBox3.Text =Convert.ToString(result);  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int var1 = Convert.ToInt32(textBox1.Text);
            int var2 = Convert.ToInt32(textBox2.Text);
            string str = var1 > var2 ? "G" : "S";
            MessageBox.Show(str);
        }
    }
}
