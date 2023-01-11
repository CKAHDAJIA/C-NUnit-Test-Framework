using CSharpSeleniumFramework.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using QnxTest.PageObjects.MinnyCasino.CasinoPage;
using QnxTest.PageObjects.MinnyCasino.Common.Header;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QnxTest.Tests.MinnyCasino.CasinoPage
{
    public class MinnyCasinoCasinoIFrameVerification : BaseWebDriver
    {

        public override string SiteConfigUrl { get { return "SiteConfigurations/MinnyCasinoPrerequisites.json"; } }

        [SetUp]
        public override void Setup()
        {
            base.Setup();
        }


        [Test]
        public void CasinoGameIFrameVerification()
        {
            Driver.Url = SiteConfig.extractData("siteUrl");
            var loginPageObject = new MinnyCasinoLoginWidgetObject(Driver, DefaultWait);
            loginPageObject.LoginAction(SiteConfig.extractData("authentication.username"), SiteConfig.extractData("authentication.password"));
            loginPageObject.WaitLoggedIn();
            Driver.Url = SiteConfig.extractData("games.testCasinoGameUrl");
            
            var casinoPageObject = new MinnyCasinoCasinoPageObject(Driver, DefaultWait);
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
