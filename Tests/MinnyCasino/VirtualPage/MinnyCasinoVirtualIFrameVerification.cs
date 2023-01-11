using CSharpSeleniumFramework.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using QnxTest.PageObjects.MinnyCasino.VirtualPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.Tests.MinnyCasino.VirtualPage
{
    public class MinnyCasinoVirtualIFrameVerification : BaseWebDriver
    {

        public override string SiteConfigUrl { get { return "SiteConfigurations/MinnyCasinoPrerequisites.json"; } }

        [SetUp]
        public override void Setup()
        {
            base.Setup();
        }

        [Test]
        public void VirtualGameIFrameVerification()
        {
            Driver.Url = SiteConfig.extractData("games.testVirtualFunGameUrl");
            var virtualPageObject = new MinnyCasinoVirtualPageObject(Driver, DefaultWait);
            DefaultWait.Until(driver => virtualPageObject.IFrame.Displayed);
            var size = virtualPageObject.IFrame.Size;
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
