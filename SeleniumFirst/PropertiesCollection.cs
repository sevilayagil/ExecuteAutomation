﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        ClassName,
        CssName,
        XPath
    }
    class PropertiesCollection
    {
       public static IWebDriver driver { get; set; }
    }
}
