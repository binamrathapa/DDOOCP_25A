using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Lab12
{
    public class StudentService
    {
        public DataTable GetAllStudents()
        {
            try
            {
                string select = "select * from student";
                Database db = new Database(select);
                return db.GetData();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool InsertStudent(Student s)
        {
            try
            {
                string q = "insert into student values('" + s.Name + "','" + s.Email + "'," + s.BatchId + ",'" + s.Password + "','" + s.Gender + "')";
                Database db = new Database(q);
                db.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateStudent(Student s)
        {
            try
            {
               string q = "update student set name='" + s.Name + "',email='" + s.Email + "',batchid=" + s.BatchId + ",password='" + s.Password + "',gender='" + s.Gender + "' where id=" + s.Id;
                Database db = new Database(q);
                db.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool CheckUserAndPassword(string userName,string password)
        {
            string q = "select * from student where email='" + userName + "' and password='" + password + "'";
                Database db = new Database(q);
                DataTable dt = db.GetData();
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
