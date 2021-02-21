using AutomationTestingTask.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingTask.Tests
{
	public class BasePage
	{
		public IWebDriver driver;
		LandingPage landingPage;
		public BasePage(IWebDriver driver)
		{
			this.driver = driver;
		}
		public static void WaitToLoad(IWebDriver driver, double seconds)
		{
			driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
		}

		public LandingPage Start()
        {
			return new LandingPage(driver);
        }
	}
}

