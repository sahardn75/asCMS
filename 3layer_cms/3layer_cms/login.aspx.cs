using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using bussinessLogic;
using bussinessObject;
using Data_Access_Layer;



namespace _3layer_cms
{
    public partial class login : System.Web.UI.Page
    {
        UserBO register = new UserBO();
        UserBL balregister = new UserBL();
        LoginBL ballogin = new LoginBL();
        LoginDA dallogin = new LoginDA();
        DashboardDA dash_da = new DashboardDA();

        HttpCookie aCookieValPer = new HttpCookie("Persistance");
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Name = UserName.Text;
            string hashedPass = PassLog.Text; 
            string Pass = ballogin.getMd5Hash(hashedPass);
            int a = ballogin.ballog(Name, Pass);

            HttpCookie aCookieValPer = new HttpCookie("Persistance");
           
            UserName.Text = "";
            PassLog.Text = "";
            if (a == 1)
            {
              
                string type = ballogin.usertype(Name, Pass);
                aCookieValPer.Value = Name + "***" + type;
                aCookieValPer.Expires = DateTime.Now.AddDays(1);
            //    bool result = dallogin.AddLoginSession(aCookieValPer.Value.ToString(), Pass);

                Response.Redirect("userHome.aspx");
            }
            else if (a == 2)
            {
                
               
                string type = "admin";
                aCookieValPer.Value = Name + "*" + type;
                aCookieValPer.Expires = DateTime.Now.AddDays(1);
               // bool result = dallogin.AddLoginSession(Session["Name"].ToString(), type, Pass);
                   
              
               Response.Redirect("adminHome.aspx");
            }
            else
            {
                log_mess.Text = "Enter the valid id";
            }
           
        }
      }
  }
