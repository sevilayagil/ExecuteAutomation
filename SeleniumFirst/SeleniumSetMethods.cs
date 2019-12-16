using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public static class SeleniumSetMethods
    {
        /// <summary>
        /// EnterText method for entering text in the control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        
        public static void EnterText(this IWebElement element,string value)
        {
            element.SendKeys(value);
        }
        //
        /// <summary>
        /// Click method into button,checkbox,option...
        /// </summary>
        /// <param name="element"></param>
        public static void Clicks(this IWebElement element)
        {
            element.Submit();
        }
        /// <summary>
        /// Selecting method a drop down control
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectDropDown(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }

    }
}