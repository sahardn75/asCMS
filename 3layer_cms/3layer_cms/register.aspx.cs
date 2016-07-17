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
            int a = 0;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtname.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Name')", true);
            }

            else if (txpass.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter Password')", true);
            }
            else if (txAddress.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter City')", true);
            }
            else if (txtEmailid.Value == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Please Enter EmailID')", true);
            }
            else if (txtmobile.Value == "")
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

                ObjUBO.Name = txtname.Value;
                ObjUBO.address = txAddress.Value;
                ObjUBO.EmailID = txtEmailid.Value;
                ObjUBO.Mobilenumber = txtmobile.Value;
                string hashedPass = objUBL.getMd5Hash(txpass.Value);
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
