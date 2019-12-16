using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");
        }
        [Test]
        public void ExecuteTest()
        {
            LoginPageObjects pageLogin = new LoginPageObjects();
            EAPageObjects pageEA= pageLogin.Login("sevilay", "test");
            pageEA.FillUserForm("SA", "automation", "sevilay");

        }
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }
}
