using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBox1.Text;
            s.Address = textBox2.Text;
            s.Mobile = textBox3.Text;
            s.RollNumber = textBox4.Text;

            string str = "Name:" + s.Name + "\n Address:" + s.Address+"\n Mobile:"+s.Mobile;
            MessageBox.Show(str);
        }
    }
}
