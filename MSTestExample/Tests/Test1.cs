using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using MSTestExample.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestExample.Tests
{
    [TestClass]
    public class Test1 : SeleniumTest
    {
        [TestMethod]
        public void GoToUrlAndClickButton()
        {
            driver.Navigate().GoToUrl("https://academic.oup.com/eurheartj/article-abstract/44/9/738/6987246?redirectedFrom=fulltext");

            IWebElement AcceptCookiesButton = driver.FindElement(By.Id("accept-button"));
            IWebElement PermissionsButton = driver.FindElement(By.Id("PermissionsLink"));

            AcceptCookiesButton.Click();
            PermissionsButton.Click();
        }
    }
}
