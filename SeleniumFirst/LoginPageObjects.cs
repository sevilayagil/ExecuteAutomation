﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObjects
    {
        public LoginPageObjects()
        {
          PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How=How.Name,Using ="UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

      public EAPageObjects Login(string userName,string password)
        {
            //UserName
            txtUserName.SendKeys(userName);
            //password
            txtPassword.SendKeys(password);
            //click button
            btnLogin.Submit();
            //return the page objects
            return new EAPageObjects();
        }    
    }
}