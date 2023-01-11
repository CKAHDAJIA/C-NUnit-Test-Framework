//using CSharpSeleniumFramework.utilities;
//using NUnit.Framework;
//using OpenQA.Selenium;
//using QnxTest.PageObjects.LuxBet88.CasinoPage;
//using QnxTest.PageObjects.LuxBet88.LoginPage;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace QnxTest.Tests.LuxBet88.CasinoPage
//{
//    public class LuxBet88CasinoIFrameVerificationMobile : BaseWebDriver
//    {

//        public override string SiteConfigUrl { get { return "SiteConfigurations/LuxBet88Prerequisites.json"; } }

//        [SetUp]
//        public override void Setup()
//        {
//            base.Setup(true);
//        }

//        [Test]
//        public void CasinoGameIFrameVerificationMobile()
//        {
//            Driver.Url = SiteConfig.extractData("pages.loginPageUrl");
//            var loginPageObject = new LuxBet88LoginPageObject(Driver, DefaultWait);
//            loginPageObject.LoginActionWithJavascript(SiteConfig.extractData("authentication.username"), SiteConfig.extractData("authentication.password"));
//            loginPageObject.WaitLoggedIn();
//            Driver.Url = SiteConfig.extractData("games.testCasinoGameUrl");
//            var casinoPageObject = new LuxBet88CasinoPageObject(Driver, DefaultWait);
//            DefaultWait.Until(driver => casinoPageObject.IFrame.Displayed);
//            var size = casinoPageObject.IFrame.Size;
//            TestContext.Out.WriteLine(size.ToString());
//            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
//            var width = executor.ExecuteScript("return document.body.clientWidth;");
//            var height = executor.ExecuteScript("return document.body.clientHeight;");
//            TestContext.Out.WriteLine(height.ToString());
//            TestContext.Out.WriteLine(width.ToString());
//            Assert.AreEqual(size.Height, height);
//            Assert.AreEqual(size.Width, width);

//        }

//        [TearDown]
//        public override void TearDown()
//        {
//            base.TearDown();
//        }
//    }
//}
