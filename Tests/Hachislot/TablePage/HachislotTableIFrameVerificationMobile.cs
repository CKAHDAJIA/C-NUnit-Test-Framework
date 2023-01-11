﻿using CSharpSeleniumFramework.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using QnxTest.PageObjects.Hachislot.TablePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.Tests.Hachislot.TablePage
{
    internal class HachislotTableIFrameVerificationMobile : BaseWebDriver
    {
        public override string SiteConfigUrl { get { return "SiteConfigurations/HachislotPrerequisites.json"; } }

        [SetUp]
        public override void Setup()
        {
            base.Setup(true);
        }

        [Test]
        public void TableGameIFrameVerificationMobile()
        {
            Driver.Url = SiteConfig.extractData("games.testTableGameUrl");
            var tablePageObject = new HachislotTablePageObject(Driver, DefaultWait);
            DefaultWait.Until(driver => tablePageObject.IFrame.Displayed);
            var size = tablePageObject.IFrame.Size;
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
