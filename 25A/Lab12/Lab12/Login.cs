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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string q = "select * from student where email='" + txtUserName.Text + "' and password='" + txtPassword.Text + "'";
                //Database db = new Database(q);
                //DataTable dt = db.GetData();
                StudentService ss = new StudentService();
              bool b= ss.CheckUserAndPassword(txtUserName.Text, txtPassword.Text);
                if (b)
                {
                    Form1 f = new Form1();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Username or password incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
