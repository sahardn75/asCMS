using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Data_Access_Layer;
using System.IO;
using System.Data;

namespace _3layer_cms
{
    public partial class refereeHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConferenceDA conda = new ConferenceDA();
            DashboardDA dash_da = new DashboardDA();
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
            List<string> file_name = conda.find_files(id);
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
         protected void ValidateFile(object sender, EventArgs e)
        {
            ConferenceDA conda = new ConferenceDA();
            string filePath = (sender as LinkButton).CommandArgument;
            string fileName = Path.GetFileName(filePath);
            bool result = conda.validate_file(fileName);
            Response.Redirect(Request.Url.AbsoluteUri);
        }
        
    }
}