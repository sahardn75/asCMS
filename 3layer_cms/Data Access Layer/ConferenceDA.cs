using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient; 
using System.Configuration; 
using bussinessObject;

namespace Data_Access_Layer
{
   public class ConferenceDA
    {
       SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconstr"].ToString());
       public int AddConference(ConferenceBO ObjBO)
       {
           try
           {
               
               SqlCommand cmd = new SqlCommand("sprocUserinfoInsertUpdateSingleItem", con);
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = "INSERT INTO confrence(c_name,davar_name,davar_id) VALUES(@confname,@davarname,@davarid) ";
               cmd.Parameters.AddWithValue("@confname", ObjBO.Name);
               cmd.Parameters.AddWithValue("@davarname", ObjBO.davarName);
               cmd.Parameters.AddWithValue("@davarid", ObjBO.davarid);
              

               con.Open();
               int Result = cmd.ExecuteNonQuery();
               cmd.Dispose();
               return Result;
           }

           catch (Exception e)
           {
               string s = e.ToString();
               throw;
           }
       }
       public List<string> find_files(long id)
       {
           List<string> fileids = new List<string>();
           try
           {
               SqlCommand cmd = new SqlCommand("SELECT article_name   FROM    sentArticles  WHERE davar_id='" + id + "'  ", con);
               con.Open();
               SqlDataReader reader = cmd.ExecuteReader();
               while (reader.Read())
               {
                   fileids.Add((string)reader["article_name"]);
               }
               con.Close();
               return fileids;
           }
           catch (Exception e)
           {
               throw e;
           }
       }
       public bool validate_file(string fileName) 
       {
           try
           {
               SqlCommand cmd1 = new SqlCommand("UPDATE sentArticles SET  validate='yes' WHERE article_name='" + fileName + "'", con);
               con.Open();
               cmd1.ExecuteNonQuery();
               con.Close();
               return true;
           }
           catch (Exception e) 
           {
               return false;
           }
       }
    }
}
