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
        public int userlogin(string Name, string Pass)//checking the user name and password.If matched count 1 not 0.
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
        public string userlog(string Name, string Pass)//getting the userType
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
        public bool AddLoginSession(string Name , string type,string Pass)
        {
            try
            {   
                con.Open();
                SqlCommand cmd = new SqlCommand("select user_id from Userinfo where Name='" + Name + "'and Pass='" + Pass + "' ", con);
                SqlDataReader reader = cmd.ExecuteReader();
                long id = 0;
                while (reader.Read())
                {
                    id = (long)reader["user_id"];
                }
                reader.Close();
                SqlCommand cmd1 = new SqlCommand("INSERT INTO session (user_name ,user_type,user_id) VALUES (@Name,@type,@id) ", con);
             
               
                 cmd1.Parameters.AddWithValue("@Name", Name);
                 cmd1.Parameters.AddWithValue("@type",type);
                 cmd1.Parameters.AddWithValue("@id", id);
                 cmd1.ExecuteNonQuery();

                 return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
              
        }
    }
}
