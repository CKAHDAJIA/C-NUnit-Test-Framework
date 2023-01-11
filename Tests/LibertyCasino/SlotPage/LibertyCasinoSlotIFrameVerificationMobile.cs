﻿using CSharpSeleniumFramework.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using QnxTest.PageObjects.LibertyCasino.SlotPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.Tests.LibertyCasino.SlotPage
{
    public class LibertyCasinoSlotIFrameVerificationMobile : BaseWebDriver
    {

        public override string SiteConfigUrl { get { return "SiteConfigurations/LibertyCasinoPrerequisites.json"; } }

        [SetUp]
        public override void Setup()
        {
            base.Setup(true);
        }

        [Test]
        public void SlotGameIFrameVerificationMobile()
        {
            Driver.Url = SiteConfig.extractData("games.testSlotFunUrl");
            var slotPageObject = new LibertyCasinoSlotPageObject(Driver, DefaultWait);
            DefaultWait.Until(driver => slotPageObject.IFrame.Displayed);
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
