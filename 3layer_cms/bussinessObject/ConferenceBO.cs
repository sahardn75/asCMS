using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussinessObject
{
  public  class ConferenceBO
    {
        private string _Name;

        private string _davarName;

        private long _davarid;

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
        public string davarName
        {
            get
            {
                return _davarName;
            }
            set
            {
                _davarName = value;
            }
        }
        public long davarid
        {
            get
            {
                return _davarid;
            }
            set
            {
                _davarid = value;
            }
        }
    }
}
