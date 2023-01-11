﻿using CSharpSeleniumFramework.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using QnxTest.PageObjects.SportsLab.SlotPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.Tests.Sportslab.SlotPage
{
    public class SportslabSlotIFrameVerification : BaseWebDriver
    {

        public override string SiteConfigUrl { get { return "SiteConfigurations/SportslabPrerequisites.json"; } }

        [SetUp]
        public override void Setup()
        {
            base.Setup();
        }

        [Test]
        public void SlotGameIFrameVerification()
        {
            Driver.Url = SiteConfig.extractData("games.testSlotFunUrl");
            var slotPageObject = new SportslabSlotPageObject(Driver, DefaultWait);
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
