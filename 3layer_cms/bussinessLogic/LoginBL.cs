using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Data_Access_Layer;

namespace bussinessLogic
{
 public   class LoginBL
    {
        LoginDA dallogin = new LoginDA();
     
      public string getMd5Hash(string input)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        public int ballog(string Name, string Pass)//checking the usename and password
        {
            try
            {
                int a = dallogin.userlogin(Name, Pass);
                string b = dallogin.userlog(Name, Pass);
                if (a == 1 && (b == "level-1" || b == "level-2" || b == "level-3"))
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
