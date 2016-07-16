﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; // Required for using Dataset , Datatable and Sql
using System.Data.SqlClient; // Required for Using Sql
using System.Configuration; // for Using Connection From Web.config 
using bussinessObject;  // for acessing bussiness object class

namespace Data_Access_Layer
{
    public class UserDA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Myconstr"].ToString());
        public int AddUserDetails(UserBO ObjBO) // passing Bussiness object Here
        {
            try
            {
                /* Because We will put all out values from our (UserRegistration.aspx)
                 To in Bussiness object and then Pass it to Bussiness logic and then to
                 DataAcess
                 this way the flow carry on*/
                SqlCommand cmd = new SqlCommand("sprocUserinfoInsertUpdateSingleItem", con);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Userinfo(Name,Pass,Address,EmailID,Mobilenumber) VALUES(@Name,@Pass,@Address,@EmailID,@Mobilenumber) ";
                cmd.Parameters.AddWithValue("@Name", ObjBO.Name);
                cmd.Parameters.AddWithValue("@Pass", ObjBO.Pass);
                cmd.Parameters.AddWithValue("@Address", ObjBO.address);
                cmd.Parameters.AddWithValue("@EmailID", ObjBO.EmailID);
                cmd.Parameters.AddWithValue("@Mobilenumber", ObjBO.Mobilenumber);
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

        public bool check_pass(string Name,string Pass)
        {
            
            try
            {
                SqlCommand cmd1 = new SqlCommand("select Pass from Userinfo where Name='" + Name + "'", con);
                con.Open();
                string password= cmd1.ExecuteScalar().ToString();
                con.Close();
                if (password == Pass)
                {
                    return true;
                }else
                {
                    return false;
                }
            }

            catch (Exception ex) 
            {
                return false;
            }
        }

        public bool change_pass(string Name, string Pass) 
        {
            try
            {
                SqlCommand cmd1 = new SqlCommand("UPDATE Userinfo SET  Pass='"+Pass+"' WHERE Name='"+Name+"'", con);
                con.Open();
                cmd1.ExecuteScalar();
                con.Close();
               

                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }

           
        }
    }
}
