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

        public long find_id(string Name)
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
            return id;

        }
        public long find_file_id(string fileName)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select article_id from article where article_name='" + fileName + "' ", con);
            SqlDataReader reader = cmd.ExecuteReader();
            long id = 0;
            while (reader.Read())
            {
                id = (long)reader["article_id"];
            }
            reader.Close();
            con.Close();
            return id;
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

       public List<string> show_files(long id)
       {
           List<string> filenames = new List<string>();
           try
           {
               SqlCommand cmd = new SqlCommand("SELECT article_name   FROM    article  WHERE user_id='" + id + "'  ", con);
               con.Open();
               SqlDataReader reader = cmd.ExecuteReader();
               while (reader.Read())
               {
                   filenames.Add((string)reader["article_name"]);
               }
               con.Close();
               return filenames;
           }
           catch (Exception e)
           {
               throw e;
           }
       }
       public bool delete_file(string file_name)
       {

           //string filename = FileUpload1.FileName;
           //FileUpload1.PostedFile.Equals(Server.MapPath("~\\Uploads\\" + filename));
           string path = file_name;


           try
           {
               con.Open();
               SqlCommand cmd = new SqlCommand();
               cmd.CommandText = "DELETE FROM article WHERE article_name='file_name'";

               cmd.CommandType = CommandType.Text;
               cmd.Connection = con;
               cmd.ExecuteNonQuery();

               if (File.Exists(path))
               {
                   File.Delete(path);

               }
               con.Close();
           }
           catch (Exception ex)
           {
               //Response.Write(ex.ToString());
               return false;
           }
           finally
           {
               //lblinfo2.Text = "";
               //lblinfo2.Text = " Deleted Successfully ";
               
           }
           return true;
       }
       public bool send_file(string fileName, long davarid, string conID)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("INSERT INTO sentArticles (article_name,davar_id,con_id) VALUES (@fileName,@davarid,@conID)", con);
               cmd.Parameters.AddWithValue("@fileName", fileName);
               cmd.Parameters.AddWithValue("@davarid", davarid);
               cmd.Parameters.AddWithValue("@conID", conID);
               con.Open();
               cmd.ExecuteNonQuery();
               
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
