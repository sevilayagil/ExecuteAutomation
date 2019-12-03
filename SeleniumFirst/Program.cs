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
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html");
        }
        [Test]
        public void ExecuteTest()
        {
            //Title 
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "Sevo", "Name");
            //Click
            SeleniumSetMethods.Click(driver, "Save", "Name");
        }
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            Console.WriteLine("closed the browser");
        }
    }
}
