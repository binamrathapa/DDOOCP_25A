using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        // Student[] students = new Student[5];
        List<Student> students = new List<Student>();
        //int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBox1.Text;
            s.Email = textBox2.Text;
            s.Gender = radioButton1.Checked ? "Male" : "Female";
            s.Batch = comboBox1.SelectedItem.ToString();
            if (checkBox1.Checked)
                s.Language = "Nepali";
            else if (checkBox2.Checked)
                s.Language = "English";
            else
                s.Language = "Hindi";
            //students[count] = s;
            students.Add(s);
            // count++;
            //MessageBox.Show("saved successfully");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str="";
            
            foreach (Student s in students)
            {
                if(s!=null)
                str = s.Name + s.Email + s.Gender+s.Batch + s.Language;
                
            }
            MessageBox.Show(str);
        }
    }
}
