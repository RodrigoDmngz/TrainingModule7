using AutomationTraining_M7.Base_Files;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7 {
    class Program : BaseTest {
        static void Main(string[] args)
        {
            SetUp();

            //driver.FindElement(By.Name("userName")).SendKeys(ConfigurationManager.AppSettings.Get("username"));
            //driver.FindElement(By.Name("password")).SendKeys(ConfigurationManager.AppSettings.Get("password"));

            FnSendkeyAndClear(By.Name("userName"), ConfigurationManager.AppSettings.Get("username"));
            FnSendkeyAndClear(By.Name("password"), ConfigurationManager.AppSettings.Get("password"));

            FnSendkeyAndClear(By.XPath("//*[@name='userName']"), ConfigurationManager.AppSettings.Get("username2"));
            FnSendkeyAndClear(By.XPath("//*[@name='password']"), ConfigurationManager.AppSettings.Get("password2"));
            driver.FindElement(By.Name("login")).Click();

            AfterTest();

            Console.ReadKey();
        }
    }
}
