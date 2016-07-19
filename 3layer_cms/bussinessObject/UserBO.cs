using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussinessObject
{
  public  class UserBO
    {

        private string _Name;
     
        private string _Pass;

        private string _Address;

        private string _EmailID;

        private string _Mobilenumber;

       private string _Usertype;


        // Get and set values

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Pass
        {
            get
            {
                return _Pass;
            }
            set
            {
                _Pass = value;
            }
        }
        public string address
        {
            get
            {
                return _Address;
            }

            set
            {
                _Address = value;
            }
        }

        public string EmailID
        {
            get
            {
                return _EmailID;
            }

            set
            {
                _EmailID = value;
            }
        }

        public string Mobilenumber
        {

            get
            {
                return _Mobilenumber;
            }
            set
            {
                _Mobilenumber = value;
            }
        }
        public string Usertype
        {

            get
            {
                return _Usertype;
            }
            set
            {
                _Usertype = value;
            }
        }
    }
}
