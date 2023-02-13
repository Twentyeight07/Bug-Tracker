using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DbTests
{
    [TestClass]
    public class TestSignin
    {
        [TestMethod]
        public void TestSignInTrue()
        {
            UserDao userDao = new UserDao();

            bool result = userDao.Signin("testing2", true, "testname", "", "test2@gmail.com", "test234");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestSignInFalse()
        {
            UserDao userDao = new UserDao();

            bool result = userDao.Signin("", true, "", "", "test2@gmail.com", "test234");
            Assert.IsFalse(result);
        }
    }
}
