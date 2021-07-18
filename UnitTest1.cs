using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Threading;

namespace WebTest
{
    public class Tests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            driver.Navigate().GoToUrl("https://careers.veeam.ru/vacancies");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            OpenQA.Selenium.IWebElement CookyKiller = driver.FindElement(By.Id("cookiescript_close"));
            CookyKiller.Click();
            Thread.Sleep(2000);
            OpenQA.Selenium.IWebElement Departments = driver.FindElement(By.Id("basic-nav-dropdown"));
            Departments.Click();
            Thread.Sleep(2000);
            OpenQA.Selenium.IWebElement Products_development = driver.FindElement(By.PartialLinkText("Разработка продуктов"));
            Products_development.Click();
            Thread.Sleep(2000);
            //List<OpenQA.Selenium.IWebElement> VacList = (List<IWebElement>)driver.FindElement(By.ClassName("card card-no-hover card-sm"));
            //var ExpectedList = VacList.Count;
            OpenQA.Selenium.IWebElement LanguageChange = driver.FindElement(By.Id("site-switcher"));
            LanguageChange.Click();
            Thread.Sleep(2000);
            OpenQA.Selenium.IWebElement EnglishLangOn = driver.FindElement(By.PartialLinkText("Все страны"));
            EnglishLangOn.Click();
            //List<OpenQA.Selenium.IWebElement> VacList2 = (List<IWebElement>)driver.FindElement(By.ClassName("card card-no-hover card-sm"));
            //var ActualList = VacList2.Count;

            //Assert.AreEqual(ExpectedList, ActualList, "The jobs aren't on the page or their cuantity is different."); ---не работает
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}