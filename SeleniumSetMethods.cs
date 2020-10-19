using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace SeleniumAutomation
{
    class SeleniumSetMethods
    {
        /// <summary>
        /// Enter text on a element field or textbox
        /// </summary>
        /// <param name="element">The Web element</param>
        /// <param name="value">The value you want to insert on the textbox</param>
        /// <param name="elementtype">Type of search for the element</param>
        public static void EnterText(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(element))).SendKeys(value);
            if (elementtype == PropertyType.Name)
                PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(element))).SendKeys(value);
            if (elementtype == PropertyType.ClassName)
                PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(element))).SendKeys(value);
            if (elementtype == PropertyType.CssSelector)
                PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(element))).SendKeys(value);
            if (elementtype == PropertyType.XPath)
                PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(element))).SendKeys(value);
        }

        /// <summary>
        /// Action click on buttons, checkboxs, options, etc
        /// </summary>
        /// <param name="element">The Web element</param>
        /// <param name="elementtype">Type of search for the element</param>
        public static void Click(string element, PropertyType elementtype)
        {
            Thread.Sleep(2000);
            try
                {
                    if (elementtype == PropertyType.Id)
                        PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(element))).Click();
                    if (elementtype == PropertyType.Name)
                        PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Name(element))).Click();
                    if (elementtype == PropertyType.ClassName)
                        PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName(element))).Click();
                    if (elementtype == PropertyType.CssSelector)
                        PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(element))).Click();
                    if (elementtype == PropertyType.XPath)
                        PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(element))).Click();
                }
                catch (NoSuchElementException)
                {
                }
        }

        /// <summary>
        /// Selecting drop down list element
        /// </summary>
        /// <param name="element">The Web element</param>
        /// <param name="value">The value you want to find on the dropdow list</param>
        /// <param name="elementtype">Type of search for the element</param>
        public static void SelectDropDown(string element, string value, PropertyType elementtype)
        {
            if (elementtype == PropertyType.Id)
                new SelectElement(PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(element)))).SelectByText(value);
            if (elementtype == PropertyType.Name)
                new SelectElement(PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(element)))).SelectByText(value);
            if (elementtype == PropertyType.ClassName)
                new SelectElement(PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(element)))).SelectByText(value);
            if (elementtype == PropertyType.XPath)
                new SelectElement(PropertiesCollection.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(element)))).SelectByText(value);
        }

        /// <summary>
        /// Clearing the textbox
        /// </summary>
        /// <param name="element">The Web element</param>
        /// <param name="elementtype">Type of search for the element</param>
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
