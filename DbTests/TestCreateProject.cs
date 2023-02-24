using Data.PostgreSQL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DbTests
{
    [TestClass]
    public class TestCreateProject
    {
        [TestMethod]
        public void TestCreateProjectTrue()
        {
            ProjectDao projectDao = new ProjectDao();

            int[] codes;
            codes = new int[17];
            codes = new int[18];

            bool res = projectDao.Create_Project(14, "Root Company, C.A.", "Login Module", "Here we can track problems in the Login Module", new DateTime(2023/02/24), new DateTime(2023/03/15), codes);

            Assert.AreEqual(true, res);
        }
    }
}
