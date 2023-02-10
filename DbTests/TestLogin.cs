using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Data;


namespace DbTests
{
    [TestClass]
    public class TestLogin
    {
        [TestMethod]
        public void TestLoginTrue()
        {
            UserDao userDao = new UserDao();

           bool result = userDao.Login("test@gmail.com", "123456");
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void TestLoginFalse()
        {
            UserDao userDao = new UserDao();

            bool result = userDao.Login("test@gmail.com", "1234567");
            Assert.IsFalse(result);

        }

        
    }
}
