using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterStudent rs = new RegisterStudent(0);
            rs.Show();
        }

        private void displayStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayStudents ds = new DisplayStudents();
            ds.Show();
        }

        private void newBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBatch nb = new NewBatch(0);
            nb.Show();
        }

        private void displayBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayBatches batches = new DisplayBatches();
            batches.Show();
        }
    }
}
