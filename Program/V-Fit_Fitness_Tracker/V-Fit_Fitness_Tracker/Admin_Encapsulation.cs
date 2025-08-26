using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V_Fit_Fitness_Tracker
{
    class Admin_Encapsulation
    {
        private string _AdminID, _AdminName, _Email, _PhoneNo, _Password, _ConfirmPassword, _Address;

        public string AdminID
        {
            set
            {
                _AdminID = value;
            }
            get
            {
                return _AdminID;
            }
        }
        public string AdminName
        {
            set
            {
                _AdminName = value;
            }
            get
            {
                return _AdminName;
            }
        }
        public string Email
        {
            set
            {
                _Email = value;
            }
            get
            {
                return _Email;
            }
        }
        public string PhoneNo
        {
            set
            {
                _PhoneNo = value;
            }
            get
            {
                return _PhoneNo;
            }
        }
        public string Password
        {
            set
            {
                _Password = value;
            }
            get
            {
                return _Password;
            }
        }
        public string ConfirmPassword
        {
            set
            {
                _ConfirmPassword = value;
            }
            get
            {
                return _ConfirmPassword;
            }
        }
        public string Address
        {
            set
            {
              _Address  = value;
            }
            get
            {
                return _Address ;
            }
        }
    }
}
