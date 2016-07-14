using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bussinessLogic;
using bussinessObject;

namespace _3layer_cms
{
    public partial class login : System.Web.UI.Page
    {
        UserBO register = new UserBO();
        UserBL balregister = new UserBL();
        LoginBL ballogin = new LoginBL();
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = UserName.Text;
            string hashedPass = PassLog.Text; 
            string Pass = ballogin.getMd5Hash(hashedPass);
            int a = ballogin.ballog(Name, Pass);
            UserName.Text = "";
            PassLog.Text = "";
            if (a == 1)
            {
                Session["Name"] = Name;
                string type = ballogin.usertype(Name, Pass);
                Session["userType"] = type;
                Response.Redirect("userHome.aspx");
            }
            else if (a == 2)
            {
                Session["Name"] = Name;
                Response.Redirect("adminHome.aspx");
            }
            else
            {
                log_mess.Text = "Enter the valid id";
            }   
        }
        }
    }
