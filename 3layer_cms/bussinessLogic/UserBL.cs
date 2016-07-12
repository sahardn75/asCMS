using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

using Data_Access_Layer; // for acessing DataAccess class
using bussinessObject; // for acessing bussiness object class


namespace bussinessLogic
{
    public class UserBL
    {
        public int SaveUserregisrationBL(UserBO objUserBL) // passing Bussiness object Here
        {
            try
            {
                UserDA objUserda = new UserDA(); // Creating object of Dataccess

                return objUserda.AddUserDetails(objUserBL); // calling Method of DataAccess

            }
            catch
            {
                throw;
            }
        }
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

    }
}

