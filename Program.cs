using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;


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
            PropertiesCollection.driver.Navigate().GoToUrl("https://pt.primaverabss.com/");
            PropertiesCollection.driver.Manage().Window.Maximize();
            Console.WriteLine("Opened URL");
        }
        [Test]
        public void ExecuteTest()
        {
            SeleniumSetMethods.Click("/html/body/footer/div[1]/div[1]/ul[4]/li[3]/a", PropertyType.XPath);
            SeleniumSetMethods.EnterText("nomeInput", "Humberto", PropertyType.Id);
            SeleniumSetMethods.EnterText("apelidoInput", "Portugal", PropertyType.Id);
            SeleniumSetMethods.EnterText("telefoneInput", "213321123", PropertyType.Id);
            SeleniumSetMethods.EnterText("emailInput", "testmail@gmail.com", PropertyType.Id);
            SeleniumSetMethods.EnterText("localidadeInput", "Braga", PropertyType.Id);
            SeleniumSetMethods.EnterText("motivoInput", "Motivo de teste 1", PropertyType.Id);
            SeleniumSetMethods.EnterText("mensagemInput", "Mensagem de teste 1", PropertyType.Id);
            SeleniumSetMethods.Clear("mensagemInput", PropertyType.Id);
            SeleniumSetMethods.EnterText("mensagemInput", "Mensagem de teste 2", PropertyType.Id);
            SeleniumSetMethods.Click("/html/body/div[5]/div[2]/div/div/div/div/div/form/ul[8]/li/label/input", PropertyType.XPath);
            SeleniumSetMethods.Click("/html/body/div[5]/div[2]/div/div/div/div/div/form/div[2]/input", PropertyType.XPath);
            Console.WriteLine("Filled the form cleared and entered a new message: " + SeleniumGetMethods.GetFromField("/html/body/div[5]/div[2]/div/div/div/div/div/form/ul[7]/li/input", PropertyType.XPath));
        }
        [TearDown]
        public void CleanUp()
        {
            //Close the driver
//            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the Browser");
        }
    }
}
