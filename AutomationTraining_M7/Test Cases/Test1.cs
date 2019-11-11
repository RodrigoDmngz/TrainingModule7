using AutomationTraining_M7.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Test_Cases {
    class Test1 : BaseTest {

        [Test]
        public void TestLogin1()
        {
            //driver.FindElement(By.Name("userName")).SendKeys(ConfigurationManager.AppSettings.Get("username"));
            //driver.FindElement(By.Name("password")).SendKeys(ConfigurationManager.AppSettings.Get("password"));
            FnSendkeyAndClear(By.Name("userName"), ConfigurationManager.AppSettings.Get("username"));
            FnSendkeyAndClear(By.Name("password"), ConfigurationManager.AppSettings.Get("password"));
            driver.FindElement(By.Name("login")).Click();
        }

        [Test]
        public void TestLogin2()
        {
            FnSendkeyAndClear(By.XPath("//*[@name='userName']"), ConfigurationManager.AppSettings.Get("username2"));
            FnSendkeyAndClear(By.XPath("//*[@name='password']"), ConfigurationManager.AppSettings.Get("password2"));
            driver.FindElement(By.Name("login")).Click();
        }

        [Test]
        public void GetElementHrefList()
        {
            IList<IWebElement> ElementList = driver.FindElements(By.XPath("//a"));
            foreach (IWebElement el in ElementList)
            {
                el.GetAttribute("href");
            }
        }
    }
}
