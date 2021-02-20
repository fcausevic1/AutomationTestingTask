using AutomationTestingTask.Tests;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationTestingTask
{
    public class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver driver) : base(driver) {}

        

        public void FillRegistrationForm(string email, string title="mr", string firstName="Test", string lastName="Test", string password="test123", int dayOfBirth=1, string monthOfBirth="January", short yearOfBirth=1970, string address="adressa", string city="Sarajevo", string state="Alabama", string country="United States", string mobilePhone="123456789") {
            
        }
    }
}
