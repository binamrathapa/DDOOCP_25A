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
    public partial class NewBatch : Form
    {
        public int myId;
        int id;
        public NewBatch(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string qq = "insert into Batch values('" + textBox1.Text + "')";
                if(id>0)
                {
                    qq = "update batch set name='"+textBox1.Text+"' where id="+id;
                }
                Database db = new Database(qq);
                db.ExecuteNonQuery();
                MessageBox.Show("Added successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewBatch_Load(object sender, EventArgs e)
        {
            if (id > 0)
            {
                try
                {
                    string query = "select * from Batch where id=" + id;
                    Database db = new Database(query);
                    DataTable dt = db.GetData();
                    textBox1.Text = dt.Rows[0]["Name"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
