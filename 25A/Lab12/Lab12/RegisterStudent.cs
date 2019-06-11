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
    public partial class RegisterStudent : Form
    {
        int id = 0;
        public RegisterStudent(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void RegisterStudent_Load(object sender, EventArgs e)
        {
            try
            {
                string q = "select * from Batch";
                Database db = new Database(q);
                DataTable dt = db.GetData();
                cbBatch.DisplayMember = "Name";
                cbBatch.ValueMember = "Id";
                cbBatch.DataSource = dt;
                if (id > 0)
                {
                    string selectStudent = "select * from student where id=" + id;
                    db = new Database(selectStudent);
                    DataTable dts = db.GetData();
                    if (dts.Rows.Count > 0)
                    {
                        cbBatch.SelectedValue = dts.Rows[0]["BatchId"];
                        txtName.Text = dts.Rows[0]["Name"].ToString();
                        txtEmail.Text = dts.Rows[0]["Email"].ToString();
                        txtPassword.Text = dts.Rows[0]["Password"].ToString();
                        txtConfirmPassword.Text = dts.Rows[0]["Password"].ToString();
                        if (dts.Rows[0]["Gender"].ToString() == "M")
                        {
                            rbM.Checked = true;
                        }
                        else
                        {
                            rbF.Checked = true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Helper h = new Helper();
                if (h.CheckPassword(txtPassword.Text, txtConfirmPassword.Text))
                {
                    if (h.CheckEmail(txtEmail.Text))
                    {
                        string gender = "M";
                        if (rbM.Checked)
                        {
                            gender = "M";
                        }
                        else
                        {
                            gender = "F";
                        }
                        int bid = Convert.ToInt32(cbBatch.SelectedValue);
                        //string q = "insert into student values('"+txtName.Text+"','"+txtEmail.Text+"',"+bid+",'"+txtPassword.Text+"','"+gender+"')";
                        /*if(id>0)
                        {
                            q = "update student set name='"+txtName.Text+"',email='"+txtEmail.Text+"',batchid="+bid+",password='"+txtPassword.Text+"',gender='"+gender+"' where id="+id;

                        }
                        Database db = new Database(q);
                        db.ExecuteNonQuery();*/
                        Student s = new Student();
                        s.Name = txtName.Text;
                        s.Email = txtEmail.Text;
                        s.BatchId = bid;
                        s.Password = txtPassword.Text;
                        s.Gender = gender;
                        StudentService ss = new StudentService();
                        if (id > 0)
                        {
                            s.Id = id;
                            ss.UpdateStudent(s);
                        }
                        else
                        {
                            ss.InsertStudent(s);
                        }
                        MessageBox.Show("saved successfully");
                    }
                    else
                        MessageBox.Show("email is invalid");
                }
                else
                    MessageBox.Show("password not match");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
