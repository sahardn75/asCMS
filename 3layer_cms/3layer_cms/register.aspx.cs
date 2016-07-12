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
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Name')", true);
            }

            else  if (txpass.Text == "")
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
            else
            {
                UserBO ObjUBO = new UserBO();
                /*
                 calling BussinessObject (UserBO) 
                 And passing all value from Control to it.
                */
                UserBL objUBL = new UserBL();

                ObjUBO.Name = txtname.Text;
                ObjUBO.address = txAddress.Text;
                ObjUBO.EmailID = txtEmailid.Text;
                ObjUBO.Mobilenumber = txtmobile.Text;
                string hashedPass = objUBL.getMd5Hash(txpass.Text);
                ObjUBO.Pass = hashedPass;

               
                int result = objUBL.SaveUserregisrationBL(ObjUBO);

                if (result > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('suceesfully regist :-)')", true);
                }

                /*
                 Calling Bussinesslogic (UserBL) 
                 And Passing Value To it  
                */
            }
        }
    }
}