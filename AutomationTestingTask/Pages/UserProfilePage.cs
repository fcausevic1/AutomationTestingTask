using AutomationTestingTask.Tests;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingTask.Pages
{
    public  class UserProfilePage : BasePage
    {
        

        IWebElement accountButton => driver.FindElement(By.ClassName("account"));
        IWebElement signOutButton => driver.FindElement(By.ClassName("logout"));
        IWebElement orderHistory => driver.FindElement(By.ClassName("icon-list-ol"));
        IWebElement creditSlips => driver.FindElement(By.ClassName("icon-ban-circle"));

        public UserProfilePage(IWebDriver driver) : base(driver) { }

        public void VerifyThatUserIsLoggedIn()
        {
            Assert.True(accountButton.Displayed);
        }

        public LandingPage LogOut()
        {
            signOutButton.Click();
            return new LandingPage(driver);
        }

        public OrderHistoryPage CheckOrderHistory()
        {
            orderHistory.Click();
            return new OrderHistoryPage(driver);
        }

        public CreditSlipsPage CheckCreditSlips()
        {
            creditSlips.Click();
            return new CreditSlipsPage(driver);
        }
            


    }
}
