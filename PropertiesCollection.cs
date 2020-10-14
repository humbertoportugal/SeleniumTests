using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomation
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName,
        XPath
    }

    class PropertiesCollection
    {
        //Auto-implemented Property
        public static IWebDriver driver { get; set; }
    }
}
