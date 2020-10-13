using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumAutomation
{
    class Program
    {
        //Initialize a new instance of the Chromedriver
        IWebDriver driver = new ChromeDriver("D:\\transferencias\\chromedriver_win32");
        

        static void Main()
        {

        }
        [SetUp]
        public void Initialize()
        {
            //Navigate to ToolsQA page
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.Click(driver, "/html/body/div/div/div/div[2]/div/div[1]", "XPath");
            SeleniumSetMethods.Click(driver, "/html/body/div/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[1]", "XPath");
            SeleniumSetMethods.EnterText(driver, "userName", "Test Automation 1.0", "Id");
            SeleniumSetMethods.Clear(driver,"userName", "Id");
            SeleniumSetMethods.EnterText(driver, "userName", "Test Automation 1.1", "Id");
            Console.WriteLine("Entered Test Automation 1.0, cleared and entered Test Automation 1.1");
        }
        [TearDown]
        public void CleanUp()
        {
            //Close the driver
            driver.Close();
            Console.WriteLine("Closed the Browser");
        }
    }
}
