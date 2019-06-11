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
    public partial class UploadTest : Form
    {
        public UploadTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                DialogResult dr = ofd.ShowDialog();
                if(dr==DialogResult.OK)
                {
                    File.Copy(ofd.FileName, AppContext.BaseDirectory + "\\" + ofd.SafeFileName);
                    MessageBox.Show("upload successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = AppContext.BaseDirectory;//Environment.CurrentDirectory;
            DirectoryInfo di = new DirectoryInfo(path);
           FileInfo[] files= di.GetFiles("*.png");
            dataGridView1.DataSource = files;
            int w = 110;
            int c = 0;
            foreach(FileInfo fi in files)
            {
                PictureBox pb = new PictureBox();
                pb.ImageLocation = fi.FullName;
                pb.Height = 100;
                pb.Width = 100;
                pb.Location = new Point(10+w*c, 10);
                panel1.Controls.Add(pb);
                c++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
