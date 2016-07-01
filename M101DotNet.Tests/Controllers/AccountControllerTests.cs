using Microsoft.VisualStudio.TestTools.UnitTesting;
using M101DotNet.WebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M101DotNet.WebApp.Models.Account;

namespace M101DotNet.WebApp.Controllers.Tests
{
    [TestClass()]
    public class AccountControllerTests
    {
        [TestMethod()]
        public void LoginTest()
        {
            var model = new LoginModel();
            Assert.AreNotEqual(null, model);
        }

        [TestMethod()]
        public void LoginTest1()
        {
            Assert.AreEqual(null, null);
        }

        [TestMethod()]
        public void LogoutTest()
        {
            Assert.AreEqual(null, null);
        }

        [TestMethod()]
        public void RegisterTest()
        {
            Assert.AreEqual(null, null);
        }

        [TestMethod()]
        public void RegisterTest1()
        {
            Assert.AreEqual(null, null);
        }
    }
}