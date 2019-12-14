using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //EnterText method
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }
        //Click method into button,checkbox,option...
        public static void Click(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }
        //Selecting method a drop down control
        public static void SelectDropDown(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
        }

    }
}