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
    public class OrderHistoryPage : BasePage
    {          
        IWebElement ordersPageText => driver.FindElement(By.Id("history"));

        public OrderHistoryPage(IWebDriver driver) : base(driver) { }

       

        public void VerifyThatUserCanCheckOrderHistoryPage()
        {
            Assert.True(ordersPageText.Displayed);
        }
    }
}
