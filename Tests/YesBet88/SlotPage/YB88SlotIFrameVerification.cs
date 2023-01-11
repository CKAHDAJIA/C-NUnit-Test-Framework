using CSharpSeleniumFramework.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using QnxTest.PageObjects.YesBet88.LoginPage;
using QnxTest.PageObjects.YesBet88.SlotPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QnxTest.Tests.YesBet88.SlotPage
{
    internal class YB88SlotIFrameVerification : BaseWebDriver
    {
        public override string SiteConfigUrl { get { return "SiteConfigurations/YesBet88Prerequisites.json"; } }

        [SetUp]
        public override void Setup()
        {
            base.Setup();
        }

        [Test]
        public void SlotGameIFrameVerification()
        {
            Driver.Url = SiteConfig.extractData("siteUrl");
            var loginPageObject = new YesBet88LoginPageObject(Driver, DefaultWait);
            loginPageObject.LoginAction(SiteConfig.extractData("authentication.username"), SiteConfig.extractData("authentication.password"));
            Driver.Url = SiteConfig.extractData("games.testSlotFunUrl");
            var slotPageObject = new YesBet88SlotPageObject(Driver, DefaultWait);
            slotPageObject.WaitIFrameDisplayed();
            var size = slotPageObject.IFrame.Size;
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

