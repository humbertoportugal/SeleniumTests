using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAutomation
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssSelector,
        ClassName,
        XPath
    }

    public class PropertiesCollection
    {
        //Auto-implemented Property
        public static IWebDriver driver { get; set; }

        public static WebDriverWait wait { get; set; }
    }
}
