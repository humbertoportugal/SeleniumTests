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
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementtype == PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(element)).SendKeys(value);
            if (elementtype == PropertyType.XPath)
                PropertiesCollection.driver.FindElement(By.XPath(element)).SendKeys(value);
        }

        //Click buttons, checkboxs, options, etc
        public static void Click(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Click();
            if (elementtype == PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(element)).Click();
            if (elementtype == PropertyType.XPath)
                PropertiesCollection.driver.FindElement(By.XPath(element)).Click();
        }

        //Selecting drop down
        public static void SelectDropDown(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementtype == PropertyType.ClassName)
                new SelectElement(PropertiesCollection.driver.FindElement(By.ClassName(element))).SelectByText(value);
            if (elementtype == PropertyType.XPath)
                new SelectElement(PropertiesCollection.driver.FindElement(By.XPath(element))).SelectByText(value);
        }

        public static void Clear(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.driver.FindElement(By.Id(element)).Clear();
            if (elementtype == PropertyType.Name)
                PropertiesCollection.driver.FindElement(By.Name(element)).Clear();
            if (elementtype == PropertyType.ClassName)
                PropertiesCollection.driver.FindElement(By.ClassName(element)).Clear();
            if (elementtype == PropertyType.XPath)
                PropertiesCollection.driver.FindElement(By.XPath(element)).Clear();
        }
    }
}
