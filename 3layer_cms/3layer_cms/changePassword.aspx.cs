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
    public partial class changePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_submit_click(object sender, EventArgs e)
        {
            UserBL objUBL = new UserBL();
            UserDA objUDA = new UserDA();


            if (TextBox_oldpass.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Old Password')", true);
            }

            else if (TextBox_newpass.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Password')", true);
            }
            else if (TextBox_confirm_pass.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Confirm Your Password')", true);
            }


            string[] cookieValue = { "atila", "level-1" };
            if (Request.Cookies["Persistance"] != null)
            {

                string cookie = Request.Cookies["Persistance"].Value;

                if (cookie.Contains("*"))
                {
                    cookieValue = cookie.Split('*');
                }
            }
            string userName = cookieValue[0];

            if (TextBox_newpass.Value == TextBox_confirm_pass.Value)
            {

                string hashedpass_old = TextBox_oldpass.Value;
                string hashedpass_new = TextBox_newpass.Value;
                string old_pass_hash = objUBL.getMd5Hash(hashedpass_old);
                string Pass = objUBL.getMd5Hash(hashedpass_new);

                bool pass_result = objUDA.check_pass(userName, old_pass_hash);

                if (pass_result)
                {
                    bool new_pass = objUDA.change_pass(userName, Pass);
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(your old passwod not correct);", true);
                }

            }

            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert(your entered paswords not Equal);", true);
            }
        }
    }
}