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
    public partial class adminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_refereeClick(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Name')", true);
            }

            else if (txpass.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Password')", true);
            }
            else if (txAddress.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter City')", true);
            }
            else if (txtEmailid.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter EmailID')", true);
            }
            else if (txtmobile.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Mobile no')", true);
            }
            else if (TextType.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter user type')", true);
            }
            else
            {
                UserBO ObjUBO = new UserBO();
               
                UserBL objUBL = new UserBL();

                ObjUBO.Name = txtname.Text;
                ObjUBO.address = txAddress.Text;
                ObjUBO.EmailID = txtEmailid.Text;
                ObjUBO.Mobilenumber = txtmobile.Text;
                string hashedPass = objUBL.getMd5Hash(txpass.Text);
                ObjUBO.Pass = hashedPass;
                ObjUBO.Usertype = TextType.Text;


                int result = objUBL.SaveRefereeregisrationBL(ObjUBO);
      
                if (result > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('suceesfully regist :-)')", true);
                }

                
            }
        
        }

        protected void BtnSave_confrenceClick(object sender, EventArgs e)
        {
            if (cName.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Conference Name')", true);
            }

            else if (dName.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Referee Name')", true);
            }

            ConferenceBO cbo = new ConferenceBO();
            ConferenceBL cbl = new ConferenceBL();
            DashboardDA dashda = new DashboardDA();

            cbo.Name = cName.Text;
            cbo.davarName = dName.Text;
            string Name = dName.Text;
            long id = dashda.find_id(Name);
            cbo.davarid = id;

            int result = cbl.SaveAddConferenceBL(cbo);
            if (result > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('suceesfully added :-)')", true);
            }
        }
      
    }
}