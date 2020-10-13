using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAutomation
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(IWebDriver driver,string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementtype == "Class")
                driver.FindElement(By.ClassName(element)).SendKeys(value);
            if (elementtype == "XPath")
                driver.FindElement(By.XPath(element)).SendKeys(value);
        }

        //Click buttons, checkboxs, options, etc
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
            if (elementtype == "Class")
                driver.FindElement(By.ClassName(element)).Click();
            if (elementtype == "XPath")
                driver.FindElement(By.XPath(element)).Click();
        }

        //Selecting drop down
        public static void SelectDropDown(IWebDriver driver, string element, string value,string elementtype)
        {
            if (elementtype == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementtype == "Class")
                new SelectElement(driver.FindElement(By.ClassName(element))).SelectByText(value);
            if (elementtype == "XPath")
                new SelectElement(driver.FindElement(By.XPath(element))).SelectByText(value);
        }

        public static void Clear(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Clear();
            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Clear();
            if (elementtype == "Class")
                driver.FindElement(By.ClassName(element)).Clear();
            if (elementtype == "XPath")
                driver.FindElement(By.XPath(element)).Clear();
        }
    }
}
