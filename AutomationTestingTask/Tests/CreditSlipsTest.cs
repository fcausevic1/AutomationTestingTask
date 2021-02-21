using AutomationTestingTask.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestingTask.Tests
{
    [TestFixture]
    class CreditSlipsTest : BaseTest
    {
        [Test]
        public void VerifyThatUserCanCheckCreditSlips()
        {
            RegisterLoginPage registerLoginPage = landingPage.SignInOrRegister();
            UserProfilePage userProfilePage = registerLoginPage.LogIn();
            CreditSlipsPage creditSlipsPage = userProfilePage.CheckCreditSlips();
            creditSlipsPage.VerifyThatUserCanCheckCreditSlips();
        }

    }
}
