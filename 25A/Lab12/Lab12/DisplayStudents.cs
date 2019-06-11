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
    public partial class DisplayStudents : Form
    {
        public DisplayStudents()
        {
            InitializeComponent();
        }

        private void DisplayStudents_Load(object sender, EventArgs e)
        {
            try
            {
                //string query = "select * from student";
                //Database db = new Database(query);
                StudentService ss = new StudentService();
                DataTable dt=  ss.GetAllStudents();
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id =Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "delete")
            {
                if (MessageBox.Show("Are you", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string q = "delete from student where id=" + id;
                    Database db = new Database(q);
                    db.ExecuteNonQuery();
                }
            }
            else
            {
                RegisterStudent rs = new RegisterStudent(id);
                rs.Show();
            }
        }
    }
}
