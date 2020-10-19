using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using System.Threading;


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
            PropertiesCollection.wait = new WebDriverWait(PropertiesCollection.driver, TimeSpan.FromSeconds(15));
            PropertiesCollection.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            PropertiesCollection.driver.Navigate().GoToUrl("https://demoblaze.com/");
            PropertiesCollection.driver.Manage().Window.Maximize();
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTests()
        {
            SeleniumSetMethods.Click("login2", PropertyType.Id);
            SeleniumSetMethods.EnterText("loginusername", "admin", PropertyType.Id);
            SeleniumSetMethods.EnterText("loginpassword", "admin", PropertyType.Id);
            try
            {
                SeleniumSetMethods.Click("/html/body/div[3]/div/div/div[3]/button[2]", PropertyType.XPath);
                PropertiesCollection.driver.SwitchTo().Alert().Accept();
            }
            catch (NoAlertPresentException)
            {

            }
            Console.WriteLine("Login on application");

            //Add products to cart
            SeleniumSetMethods.Click("/html/body/div[5]/div/div[2]/div/div[5]/div/div/h4/a", PropertyType.XPath);
            SeleniumSetMethods.Click("/html/body/div[5]/div/div[2]/div[2]/div/a", PropertyType.XPath);
            try
            {
                PropertiesCollection.driver.SwitchTo().Alert().Accept();
            }
            catch (NoAlertPresentException)
            {

            }
            PropertiesCollection.driver.Navigate().GoToUrl("https://demoblaze.com/index.html");
            SeleniumSetMethods.Click("/html/body/div[5]/div/div[1]/div/a[4]", PropertyType.XPath);
            SeleniumSetMethods.Click("/html/body/div[5]/div/div[2]/div/div[2]/div/div/h4/a", PropertyType.XPath);
            SeleniumSetMethods.Click("/html/body/div[5]/div/div[2]/div[2]/div/a", PropertyType.XPath);
            try
            {
                PropertiesCollection.driver.SwitchTo().Alert().Accept();
            }
            catch (NoAlertPresentException)
            {

            }
            Console.WriteLine("The products are added to the cart");

            //Finish the order and payments
            PropertiesCollection.driver.Navigate().GoToUrl("https://demoblaze.com/cart.html");
            string total = SeleniumGetMethods.GetText("totalp", PropertyType.Id);
            Console.WriteLine("The total is: " + total);
            SeleniumSetMethods.Click("/html/body/div[6]/div/div[2]/button", PropertyType.XPath);
            SeleniumSetMethods.EnterText("name", "Teste", PropertyType.Id);
            SeleniumSetMethods.EnterText("card", "1234", PropertyType.Id);
            SeleniumSetMethods.Click("/html/body/div[3]/div/div/div[3]/button[2]", PropertyType.XPath);

            //Manipulate the string to make sure the total paid was 1020 USD   
            string alldata = SeleniumGetMethods.GetText("/html/body/div[10]/p", PropertyType.XPath);
            int firstStringPosition = alldata.IndexOf("Amount");
            string totalpaid = alldata.Substring(firstStringPosition + 7, 9);
            Console.WriteLine("The total paid is: " + totalpaid);
        }
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the Browser");
        }
    }
}

