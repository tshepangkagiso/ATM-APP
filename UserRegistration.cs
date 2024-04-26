using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ATM_APP
{
    public class UserRegistration
    {
        //property fields
        private string FullName = "User Full Names";
        private int Pincode;
        private double AccountValue;

        //constructor
        public UserRegistration(string _FullName, int _Pincode, double _AccountValue)
        {
            FullName= _FullName;
            Pincode= _Pincode;
            AccountValue= _AccountValue;
        }

        public string _FullName
        {
            get { return FullName; }
            set { FullName = value; }
        
        }

        public int _Pincode
        {
            get { return Pincode; }
            set
            {
                if (value == 0)
                {
                    Pincode = 0000;
                }
                else
                {
                    Pincode = value;
                }
            }
        }

        public double _AccountValue
        {
            get { return AccountValue; }
            set
            {
                if (value < 100)
                {
                    AccountValue = 0;
                }
                else
                {
                    AccountValue = value;
                }
            }
        }


        
    }

}
