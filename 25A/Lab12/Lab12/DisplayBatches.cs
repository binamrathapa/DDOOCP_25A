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
    public partial class DisplayBatches : Form
    {
        public DisplayBatches()
        {
            InitializeComponent();
        }

        private void DisplayBatches_Load(object sender, EventArgs e)
        {
            LoadBatch();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower() == "delete")
                {
                    if(MessageBox.Show("Are you","Delete",MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        string q = "delete from batch where id=" + id;
                        Database db = new Database(q);
                        db.ExecuteNonQuery();
                    }
                }
                else
                {
                    NewBatch nb = new NewBatch(id);
                    nb.myId = id;
                    nb.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadBatch();
        }
        private void LoadBatch()
        {
            try
            {
                string q = "select * from Batch";
                Database db = new Database(q);
                DataTable dt = db.GetData();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
