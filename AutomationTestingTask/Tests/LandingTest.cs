using AutomationTestingTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingTask.Tests
{
    [TestFixture]
    class LandingTest : BaseTest
    {

        [Test]
        public void VerifyThatUserCanGoToRegisterLoadPage()
        {
            RegisterLoginPage registerLogin = landingPage.SignInOrRegister();
        }
    }
}

