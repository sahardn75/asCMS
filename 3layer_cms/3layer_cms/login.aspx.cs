﻿using System;
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
            string Name = UserName.Value;
            string hashedPass = PassLog.Value;
            string Pass = ballogin.getMd5Hash(hashedPass);
            int a = ballogin.ballog(Name, Pass);

            HttpCookie aCookieValPer = new HttpCookie("Persistance");

            UserName.Value = "";
            PassLog.Value = "";
            if (a == 1)
            {

                string type = ballogin.usertype(Name, Pass);
                aCookieValPer.Value = Name + "***" + type;
                aCookieValPer.Expires = DateTime.Now.AddDays(1);
                //    bool result = dallogin.AddLoginSession(aCookieValPer.Value.ToString(), Pass);
                Response.Cookies.Add(aCookieValPer);
                Response.Redirect("userHome.aspx");
            }
            if (a == 2)
             {

                string type = ballogin.usertype(Name, Pass);
                aCookieValPer.Value = Name + "***" + type;
                aCookieValPer.Expires = DateTime.Now.AddDays(1);
                //    bool result = dallogin.AddLoginSession(aCookieValPer.Value.ToString(), Pass);
                Response.Cookies.Add(aCookieValPer);
                Response.Redirect("refereeHome.aspx");
            }
            else if (a == 3)
            {


                string type = "admin";
                aCookieValPer.Value = Name + "*" + type;
                aCookieValPer.Expires = DateTime.Now.AddDays(1);
                // bool result = dallogin.AddLoginSession(Session["Name"].ToString(), type, Pass);

                Response.Cookies.Add(aCookieValPer);
                Response.Redirect("adminHome.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Enter the valid id')", true);
            }

        }
    }
}
