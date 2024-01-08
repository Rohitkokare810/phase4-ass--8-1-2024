using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegLogin
{
    public class UserLoginReg
    {
        public string Login(string username, string password)
        {
            string result;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                result = "please provide username and password";
            }
            else
            {
                if (username == "sam" && password == "sam@123")
                {
                    result = "Login Pass";
                }
                else
                {
                    result = "Login Fail";
                }
            }
            return result;
        }

        public string Register(string username, string password)
        {
            string result;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                result = "please provide username and password";
            }
            else
            {


                result = "Registered successfully";

            }
            return result;
        }


    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
