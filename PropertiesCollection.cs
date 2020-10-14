using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomation
{
    class PropertiesCollection
    {
        //Auto-implemented Property
        public static IWebDriver driver { get; set; }

        ////Initialize a new instance of the Chromedriver
        //IWebDriver driver = new ChromeDriver("D:\\transferencias\\chromedriver_win32");
    }
}
