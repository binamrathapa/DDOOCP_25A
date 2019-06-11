using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Lab12
{
    public class Database
    {
        SqlConnection con;
        string query;
        public Database(string query)//constructor with parameter
        {
            con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=25A;Integrated Security=True");
            this.query = query;
        }
        public int ExecuteNonQuery()//insert,update,delete
        {

            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                cmd.Connection.Open();
              return  cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(cmd.Connection.State!=ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }
        public DataTable GetData()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else
                    return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        }
    }
