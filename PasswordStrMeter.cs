using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSM
{
    public class PasswordStrMeter
    {
        public int Strength = 2, UpperCase = 0, LowerCase = 0, SpChDigi = 0;

        public bool IsUpperCase(char Input) 
        {
            if (Convert.ToInt32(Input) > 64 && Convert.ToInt32(Input) < 91)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool IsLowerCase(char Input) 
        {
            if (Convert.ToInt32(Input) > 96 && Convert.ToInt32(Input) < 123)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSpCharDigit(char Input) 
        {
            if (Convert.ToInt32(Input) > 31 && Convert.ToInt32(Input) < 65 || Convert.ToInt32(Input) > 122 && Convert.ToInt32(Input) < 127 || Convert.ToInt32(Input) > 90 && Convert.ToInt32(Input) < 97)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Check(string password) 
        {
            for (int i = 0; i < password.Length; i++) 
            {
                if (IsLowerCase(password[i])) 
                {
                    LowerCase++;
                }
                else if (IsUpperCase(password[i])) 
                {
                    UpperCase++;
                }
                else if (IsSpCharDigit(password[i])) 
                {
                    SpChDigi++;
                }
            }
        }

        public void StrengthSetter(string Password) 
        {
            if (UpperCase >= 3 && LowerCase >= 3 && SpChDigi >= 2 && Password.Length > 12) 
            {
                Strength = 10;
            }
            else if (UpperCase >= 2 && LowerCase >= 2 && SpChDigi >= 2 && Password.Length > 10) 
            {
                Strength = 8;
            }
            else if (Password.Length > 6 && UpperCase >= 1 && LowerCase >= 1 && SpChDigi >= 1) 
            {
                Strength = 6;
            }
            else if (Password.Length > 4 && (UpperCase >= 1 && LowerCase >= 1) || (SpChDigi >= 1)) 
            {
                Strength = 4;
            }
            else if (Password.Length < 5 && (UpperCase == 0 || LowerCase == 0 || SpChDigi == 0)) 
            {
                Strength = 2;
            }
        }
        
        

    }
}
