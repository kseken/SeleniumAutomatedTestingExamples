using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestExample.Framework
{
    [TestClass]
    public class SeleniumTest
    {
        protected IWebDriver driver;

        //public TestContext TestContext { get; set; }

        [TestInitialize]
        public void CreateDriver()
        {
            driver = new ChromeDriver();
        }

        [TestCleanup]
        public void QuitDriver()
        {
            if (driver != null)
                driver.Quit();
        }
    }
}
