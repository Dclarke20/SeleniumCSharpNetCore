using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {
        


        [SetUp]
        public void Setup()
        {
            
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");

            Driver.FindElement(By.XPath("//body/form[@id='form1']/div[3]/div[1]/div[2]/main[1]/div[1]/div[5]/div[2]/div[2]/div[1]/ul[1]/li[1]/label[1]/div[1]/div[1]/div[1]")).Click();


            
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo-awed", "Almond");


            

            System.Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}