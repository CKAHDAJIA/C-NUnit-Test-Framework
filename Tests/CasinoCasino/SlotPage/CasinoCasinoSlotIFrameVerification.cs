using CSharpSeleniumFramework.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using QnxTest.PageObjects.CasinoCasino.SlotPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.Tests.CasinoCasino.SlotPage
{
    public class CasinoCasinoSlotIFrameVerification : BaseWebDriver
    {
        public override string SiteConfigUrl { get { return "SiteConfigurations/CasinoCasinoPrerequisites.json"; } }

        [SetUp]
        public override void Setup()
        {
            base.Setup();
        }

        [Test]
        public void SlotGameIFrameVerification()
        {

            Driver.Url = SiteConfig.extractData("games.testSlotFunUrl");
            var slotPageObject = new CasinoCasinoSlotPageObject(Driver, DefaultWait);
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
