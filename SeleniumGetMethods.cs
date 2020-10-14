using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;



namespace SeleniumAutomation
{
    class SeleniumGetMethods
    {
        public static string GetText(string element, string elementtype)
        {
            if (elementtype == "Id")
                return PropertiesCollection.driver.FindElement(By.Id(element)).Text;
            if (elementtype == "Name")
                return PropertiesCollection.driver.FindElement(By.Name(element)).Text;
            if (elementtype == "Class")
                return PropertiesCollection.driver.FindElement(By.ClassName(element)).Text;
            if (elementtype == "XPath")
                return PropertiesCollection.driver.FindElement(By.XPath(element)).Text;
            else return String.Empty;
        }

        public static string GetFromField(string element, string elementtype)
        {
            if (elementtype == "Id")
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == "Name")
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            if (elementtype == "Class")
                return PropertiesCollection.driver.FindElement(By.ClassName(element)).GetAttribute("value");
            if (elementtype == "XPath")
                return PropertiesCollection.driver.FindElement(By.XPath(element)).GetAttribute("value");
            else return String.Empty;
        }
    }
}
