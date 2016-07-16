using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Data_Access_Layer;

namespace Data_Access_Layer
{
     
  public   class DashboardDA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconstr"].ToString());

        public long find_id( string Name)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select user_id from Userinfo where Name='" + Name + "' ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            long id = 0;
            while (reader.Read())
            {
                id = (long)reader["user_id"];
            }
            reader.Close();
            con.Close();
            return id ;
        }
       public bool add_upload_file(string article_name,string article_address , long userId)
       {


           SqlCommand cmd = new SqlCommand("INSERT INTO article(article_name,article_address,user_id) VALUES (@Name,@Address,@id)", con);
           cmd.Parameters.AddWithValue("@Name", article_name);
           cmd.Parameters.AddWithValue("@Address", article_address);
           cmd.Parameters.AddWithValue("@id", userId);
           con.Open();
           cmd.ExecuteNonQuery();
           con.Close();

       return true;
       }
      
    }
}
