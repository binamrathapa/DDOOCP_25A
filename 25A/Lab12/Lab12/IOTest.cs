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

namespace Lab12
{
    public partial class IOTest : Form
    {
        public IOTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                try
                {
                    string pp = Environment.CurrentDirectory;
                    if (!Directory.Exists(pp + "\\" + textBox1.Text))
                    {
                        Directory.CreateDirectory(pp + "\\" + textBox1.Text);
                    }
                    MessageBox.Show("created successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory;
           
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] arr = di.GetDirectories();
            dataGridView1.DataSource = arr;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string delete = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if(delete=="Delete")
            {
             string path= dataGridView1.Rows[e.RowIndex].Cells["FullName"].Value.ToString();
                //Directory.Delete(path);
                DirectoryInfo di = new DirectoryInfo(path);
                 di.Delete();
                MessageBox.Show("deleted successfully");
            }
        }
    }
}
