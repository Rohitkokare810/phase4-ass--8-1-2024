using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegLogin
{
    [TestFixture]
    public class SampleTest
    {
        UserLoginReg loginReg;
        [SetUp]

        public void SetUp()
        {
            loginReg = new UserLoginReg();
        }
        [Test]
        public void LogTest()
        {
            string name, password,res;
            name = "sam";
            password = "sam@123";
            res = "Login Pass";
            Assert.AreSame(res, loginReg.Login(name, password));
        }

        [Test]
        public void LogTest2()
        {
            string name, password, res;
            name = "rohit";
            password = "rohit@123";
            res = "Login Fail";
            Assert.AreSame(res, loginReg.Login(name, password));
        }

        [Test]
        public void RegTest()
        {
            string name, password, res;
            name = "rohit";
            password = "rohit@123";
            res = "Registered successfully";
            Assert.AreSame(res, loginReg.Register(name, password));
        }

        [Test]
        public void RegTest2()
        {
            string name, password, res;
            name = "";
            password = "";
            res = "please provide username and password";
            Assert.AreSame(res, loginReg.Register(name, password));
        }



    }
}
