using CSharpSeleniumFramework.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.QueenCasino.CasinoPage;
using QnxTest.PageObjects.QueenCasino.Common.Header;
using QnxTest.PageObjects.QueenCasino.Common.Home_Page;
using QnxTest.PageObjects.QueenCasino.Common.TablePage;
using QnxTest.PageObjects.QueenCasino.SlotPage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace QnxTest.Tests.QueenCasino.SlotPage
{
    [TestFixture]
    
    public class QCSlotIFrameVerificationMobile : BaseWebDriver
    {

        public override string SiteConfigUrl { get { return "SiteConfigurations/QueenCasinoPrerequisites.json"; } }

        [SetUp]
        public override void Setup()
        {
            base.Setup(true);
        }

        [Test]
        public void SlotGameIFrameVerificationMobile()
        {
            Driver.Url = SiteConfig.extractData("games.testSlotFunUrl");
            var slotPageObject = new QueenCasinoSlotPageObject(Driver, DefaultWait);
            slotPageObject.WaitIFrameDisplayed();
            var size = slotPageObject.IFrame.Size;
            TestContext.Out.WriteLine(size.ToString());
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            var width = executor.ExecuteScript("return document.body.clientWidth;");
            var height = executor.ExecuteScript("return document.body.clientHeight;");
            TestContext.Out.WriteLine(height.ToString());
            TestContext.Out.WriteLine(width.ToString());
            Assert.AreEqual(size.Height, height);
            Assert.AreEqual(size.Width, width);

        }

        [TearDown]
        public override void TearDown()
        {
            base.TearDown();
        }

    }
}