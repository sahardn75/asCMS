using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Data;
using Data_Access_Layer;
using bussinessLogic;


namespace _3layer_cms
{
    public partial class userHome : System.Web.UI.Page
    {

        DashboardDA dash_da = new DashboardDA();
        protected void Page_Load(object sender, EventArgs e)
        {
            string a=  Request.QueryString["con"];
            string []value=null;
            if (Request.Cookies["Persistance"] != null)
            {

                string cookie = Request.Cookies["Persistance"].Value;
                
                if (cookie.Contains("*"))
                {
                     value = cookie.Split('*');
                }
            }
            string userName = value[0];
            long id = dash_da.find_id(userName);
            List<string> file_name = dash_da.show_files(id);
            if (!IsPostBack)
            {
                string[] filePaths = Directory.GetFiles(Server.MapPath("~/Uploads/"));
                List<ListItem> files = new List<ListItem>();
                foreach (string filePath in file_name)
                {
                    files.Add(new ListItem(Path.GetFileName(filePath), filePath));
                }
                GridView1.DataSource = files;
                GridView1.DataBind();
                
            }
        }
        protected void DeleteFile(object sender, EventArgs e)
        {
            string filePath = (sender as LinkButton).CommandArgument;
            File.Delete(filePath);
            string fileName = Path.GetFileName(filePath);
            dash_da.delete_file(fileName);
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        protected void Upload(object sender, EventArgs e)
        {
            
            String allowedExtensions = ".pdf";
            string fileName = Path.GetFileName(uploadfiles.PostedFile.FileName);
            String fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
            if (fileExtension == allowedExtensions)
            {
                try
                {

                    string s_newfilename = fileName + fileExtension;
                    uploadfiles.PostedFile.SaveAs(Server.MapPath("~/Uploads/") + s_newfilename);


                    string[] value = null;
                    if (Request.Cookies["Persistance"] != null)
                    {

                        string cookie = Request.Cookies["Persistance"].Value;

                        if (cookie.Contains("*"))
                        {
                            value = cookie.Split('*');
                        }
                    }
                    string userName = value[0];
                    long id = dash_da.find_id(userName);
                    bool result = dash_da.add_upload_file(fileName,Server.MapPath("~/Uploads/") + s_newfilename, id);



                    
                }
                catch (Exception ex)
                {
                    Response.Write("File could not be uploaded.");
                }

            }
            else
            {
               
            }
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void SendFile(object sender, EventArgs e)
        {
            UserDA userobj = new UserDA();
            string a = Request.QueryString["con"];
            string filePath = (sender as LinkButton).CommandArgument;
            string fileName = Path.GetFileName(filePath);
            string davarName = userobj.find_name(a);
            long id = dash_da.find_id(davarName);
            bool result = dash_da.send_file(fileName, id, a);
            Response.Redirect(Request.Url.AbsoluteUri);
        }
    }

}

