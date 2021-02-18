using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using AutomationTestingTask.DriverManager;
using AutomationTestingTask.Pages;

namespace AutomationTestingTask.Tests
{
    public class BaseTest
    {
        IWebDriver driver;
       protected LandingPage landingPage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChooseDriver().CreateDriver("chrome");
            driver.Navigate().GoToUrl("http://www.automationpractice.com");
            driver.Manage().Window.Maximize();
            landingPage = new LandingPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
           // driver.Close();
        //    driver.Quit();
        }
    }
}
