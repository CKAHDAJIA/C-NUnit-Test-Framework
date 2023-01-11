using CSharpSeleniumFramework.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using QnxTest.PageObjects.GC88.CasinoPage;
using QnxTest.PageObjects.GC88.Common.Header;
using QnxTest.PageObjects.GC88.LoginPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QnxTest.Tests.GC88.CasinoPage
{
    public class GC88CasinoIFrameVerification : BaseWebDriver
    {

        public override string SiteConfigUrl { get { return "SiteConfigurations/GC88Prerequisites.json"; } }

        [SetUp]
        public override void Setup()
        {
            base.Setup();
        }


        [Test]
        public void CasinoGameIFrameVerification()
        {
            Driver.Url = SiteConfig.extractData("siteUrl");
            var loginPageObject = new GC88LoginPageObject(Driver, DefaultWait);
            loginPageObject.LoginAction(SiteConfig.extractData("authentication.username"), SiteConfig.extractData("authentication.password"));
            loginPageObject.WaitLoggedIn();
            Driver.Url = SiteConfig.extractData("games.testCasinoGameUrl");
            
            var casinoPageObject = new GC88CasinoPageObject(Driver, DefaultWait);
            DefaultWait.Until(driver => casinoPageObject.IFrame.Displayed);
            var size = casinoPageObject.IFrame.Size;
            TestContext.Out.WriteLine(size.ToString());
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            var width = executor.ExecuteScript("return document.body.clientWidth;");
            TestContext.Out.WriteLine(width.ToString());
            Assert.GreaterOrEqual(size.Height, 650); 
            Assert.AreEqual(size.Width, 1375); // TODO fix to the differance existing with the default padding 

        }

        [TearDown]
        public override void TearDown()
        {
            base.TearDown();
        }
    }
}