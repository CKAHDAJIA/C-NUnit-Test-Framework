using CSharpSeleniumFramework.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using QnxTest.PageObjects.SevenStar.CasinoPage;
using QnxTest.PageObjects.SevenStar.Common.Header;
using QnxTest.PageObjects.SevenStar.LoginPage;
using QnxTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QnxTest.Tests.SevenStar.CasinoPage
{
    public class SevenStarCasinoIFrameVerification : BaseWebDriver
    {

        public override string SiteConfigUrl { get { return "SiteConfigurations/SevenStarPrerequisites.json"; } }

        [SetUp]
        public override void Setup()
        {
            base.Setup();
        }


        [Test]
        public void CasinoGameIFrameVerification()
        {
            Driver.Url = SiteConfig.extractData("pages.loginPageUrl");
            var loginPageObject = new SevenStarLoginPageObject(Driver, DefaultWait);
            loginPageObject.LoginActionWithJavascript(SiteConfig.extractData("authentication.email"), SiteConfig.extractData("authentication.password"));
            loginPageObject.WaitLoggedIn();
            Driver.Url = SiteConfig.extractData("games.testCasinoGameUrl");
            var casinoPageObject = new SevenStarCasinoPageObject(Driver, DefaultWait);
            DefaultWait.Until(driver => casinoPageObject.IFrame.Displayed);
            var size = casinoPageObject.IFrame.Size;
            TestContext.Out.WriteLine(size.ToString());
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            var width = executor.ExecuteScript("return document.body.clientWidth;");
            TestContext.Out.WriteLine(width.ToString());
            Assert.GreaterOrEqual(size.Height, 650);
            Assert.AreEqual(size.Width, width);

        }

        [TearDown]
        public override void TearDown()
        {
            base.TearDown();
        }

    }
}
