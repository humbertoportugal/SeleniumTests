﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;

namespace SeleniumAutomation
{
    class SeleniumGetMethods
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="elementtype"></param>
        /// <returns></returns>
        public static string GetText(string element, PropertyType elementtype)
        {
            Thread.Sleep(1000);
            if (elementtype == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).Text;
            if (elementtype == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).Text;
            if (elementtype == PropertyType.ClassName)
                return PropertiesCollection.driver.FindElement(By.ClassName(element)).Text;
            if (elementtype == PropertyType.XPath)
                return PropertiesCollection.driver.FindElement(By.XPath(element)).Text;
            else return String.Empty;
        }

        public static string GetFromField(string element, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                return PropertiesCollection.driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementtype == PropertyType.Name)
                return PropertiesCollection.driver.FindElement(By.Name(element)).GetAttribute("value");
            if (elementtype == PropertyType.ClassName)
                return PropertiesCollection.driver.FindElement(By.ClassName(element)).GetAttribute("value");
            if (elementtype == PropertyType.XPath)
                return PropertiesCollection.driver.FindElement(By.XPath(element)).GetAttribute("value");
            else return String.Empty;
        }
    }
}
