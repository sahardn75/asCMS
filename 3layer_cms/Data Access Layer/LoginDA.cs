using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Data_Access_Layer
{
   public class LoginDA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconstr"].ToString());
        public int userlogin(string Name, string Pass)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from Userinfo where Name='" + Name + "'and Pass='" + Pass + "'", con);
                int a = Convert.ToInt32(cmd.ExecuteScalar());
                return a;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public string userlog(string Name, string Pass)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select userType from Userinfo where Name='" + Name + "' and Pass='" + Pass + "'", con);
                string a = cmd.ExecuteScalar().ToString();
                return a;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
       
    }
}
