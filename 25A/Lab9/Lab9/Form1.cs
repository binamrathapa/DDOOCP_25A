using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> arr = new Dictionary<int, string>();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arr.Add(count, textBox1.Text);
            MessageBox.Show("Added successfully");
            count++;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            int c = 0;
            foreach (KeyValuePair<int, string> s in arr)
            {
                if (c > 0)
                {
                    str += "\n";
                }
                str += "Key:" + s.Key + "\n Value:" + s.Value;
                c++;
            }
            MessageBox.Show(str);
        }
    }
}
