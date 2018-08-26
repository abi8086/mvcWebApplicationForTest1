using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1_Test.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebApplication1_Tesst.Tests
{
    [TestClass()]
    public class HomeController2Tests
    {
        [TestMethod()]
        public void About2Test()
        {
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("I am being tested", result.ViewBag.testMessage);
        }
    }
}