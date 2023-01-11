using CSharpSeleniumFramework.utilities;
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
    internal class HachislotTableIFrameVerification : BaseWebDriver
    {
        public override string SiteConfigUrl { get { return "SiteConfigurations/HachislotPrerequisites.json"; } }

        [SetUp]
        public override void Setup()
        {
            base.Setup();
        }

        [Test]
        public void TableGameIFrameVerification()
        {

            Driver.Url = SiteConfig.extractData("games.testTableGameUrl");
            var tablePageObject = new HachislotTablePageObject(Driver, DefaultWait);
            DefaultWait.Until(driver => tablePageObject.IFrame.Displayed);
            var size = tablePageObject.IFrame.Size;
            TestContext.Out.WriteLine(size.ToString());
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            var width = executor.ExecuteScript("return document.body.clientWidth;");
            TestContext.Out.WriteLine(width.ToString());
            Assert.GreaterOrEqual(size.Height, 650);
            Assert.AreEqual(size.Width + 30, width);

        }


        [TearDown]
        public override void TearDown()
        {
            base.TearDown();
        }
    }
}
