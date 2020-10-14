using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumAutomation
{
    class Program
    {
        
        

        static void Main()
        {

        }
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver("D:\\transferencias\\chromedriver_win32");

            //Navigate to ToolsQA page
            PropertiesCollection.driver.Navigate().GoToUrl("https://demoqa.com/");
            PropertiesCollection.driver.Manage().Window.Maximize();
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.Click("/html/body/div/div/div/div[2]/div/div[1]", "XPath");
            SeleniumSetMethods.Click("/html/body/div/div/div/div[2]/div[1]/div/div/div[1]/div/ul/li[1]", "XPath");
            SeleniumSetMethods.EnterText("userName", "Test Automation 1.0", "Id");
            SeleniumSetMethods.Clear("userName", "Id");
            SeleniumSetMethods.EnterText( "userName", "Test Automation 1.1", "Id");
            //Console.WriteLine(SeleniumGetMethods.GetText(driver, "userName-label", "Id"));
            Console.WriteLine("Entered Test Automation 1.0, cleared and entered: " + SeleniumGetMethods.GetText("userName-label", "Id"));
        }
        [TearDown]
        public void CleanUp()
        {
            //Close the driver
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the Browser");
        }
    }
}
