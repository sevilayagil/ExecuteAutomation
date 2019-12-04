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
            PropertiesCollection.driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html");
        }
        [Test]
        public void ExecuteTest()
        {
            //Title 
            SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", "Id");
            //Initial
            SeleniumSetMethods.EnterText("Initial", "Sevo", "Name");
            Console.WriteLine("The value from my title" + SeleniumGetMethods.GetText("TitleId", "Id"));
            Console.WriteLine("The value from my title" + SeleniumGetMethods.GetText("Initial", "Name"));

            //Click
            SeleniumSetMethods.Click("Save", "Name");
        }
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("closed the browser");
        }
    }
}
