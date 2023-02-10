using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DbTests
{
    [TestClass]
    public class TestEditProfile
    {
        [TestMethod]
        public void TestUpdateEmailPass()
        {
            UserDao userDao = new UserDao();

            bool result = userDao.EditProfile(3, "kevin@gmail.com", "kev1234");
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void TestUpdateEmailPassFalse()
        {
            UserDao userDao = new UserDao();

            bool result = userDao.EditProfile(4, "test", "123");
            Assert.IsFalse(result);
        }
    }
}
