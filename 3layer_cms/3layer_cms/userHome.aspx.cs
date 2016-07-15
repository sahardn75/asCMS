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


namespace _3layer_cms
{
    public partial class userHome : System.Web.UI.Page
    {

        DashboardDA dash_da = new DashboardDA();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["Persistance"] != null)
            {

                string cookie = Request.Cookies["Persistance"].Value;
                string[] value;
                if (cookie.Contains("*"))
                {
                    value = cookie.Split('*');
                }
            }
            if (!IsPostBack)
            {
                string[] filePaths = Directory.GetFiles(Server.MapPath("~/Uploads/"));
                List<ListItem> files = new List<ListItem>();
                foreach (string filePath in filePaths)
                {
                    files.Add(new ListItem(Path.GetFileName(filePath), filePath));
                }
                //GridView1.DataSource = files;
                //GridView1.DataBind();
            }
        }
        protected void Upload(object sender, EventArgs e)
        {
            String allowedExtensions = ".pdf";
            string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);
            String fileExtension = System.IO.Path.GetExtension(fileName).ToLower();
            if (fileExtension == allowedExtensions)
            {
                try
                {
                    
                    string s_newfilename = DateTime.Now.Year.ToString() +
                        DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() +
                        DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + fileExtension;
                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Uploads/") + s_newfilename);
                   
                    
                    string[] cookieValue={"atila" , "level-1"};
                    if (Request.Cookies["Persistance"] != null)
                    {

                        string cookie = Request.Cookies["Persistance"].Value;
                        
                        if (cookie.Contains("*"))
                        {
                            cookieValue = cookie.Split('*');
                        }
                    }
                    string userName = cookieValue[0];
                    long id = dash_da.find_id(userName);
                    bool result = dash_da.add_upload_file(Server.MapPath("~/Uploads/") + s_newfilename, fileName, id);
                    
                    response.Text = "file uploaded successfully";
                }
                catch (Exception ex)
                {
                    Response.Write("File could not be uploaded.");
                }

            }
            else 
            {
                response.Text = "File could not be uploaded.";
            }
            Response.Redirect(Request.Url.AbsoluteUri);
        }




    }





}

