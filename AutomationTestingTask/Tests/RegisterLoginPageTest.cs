using AutomationTestingTask.Pages;
using AutomationTestingTask.Tests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingTask
{
    [TestFixture]
    class RegisterLoginPageTest : BaseTest
    {
        [Test]
        public void VerifyThatUserHasBeenGivenRegisterForm()
        {
            RegisterLoginPage registerLogin = landingPage.SignInOrRegister();
            registerLogin.Register("proba1.1proba@proba.com");
            registerLogin.VerifyThatUserHasBeenGivenRegisterForm();
        }

    }
}
