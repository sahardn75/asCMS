using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace bussinessLogic
{
 public   class LoginBL
    {
        LoginDA dallogin = new LoginDA();
        public int ballog(string Name, string Pass)//checking the usename and password
        {
            try
            {
                int a = dallogin.userlogin(Name, Pass);
                string b = dallogin.userlog(Name, Pass);
                if (a == 1 && (b == "Level-1" || b == "Level-2" || b == "Level-3"))
                {
                    return 1;
                }
                else if (a == 1 && b == "admin")
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ec)
            {
                ec.GetType();
            }
            return 0;
        }
        public string usertype(string Name, string Pass)//checking the userType
        {
            try
            {
                return dallogin.userlog(Name, Pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
