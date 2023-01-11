using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.Utilities
{
    internal class TestReporting
    {
        private IWebDriver _driver;
        public ExtentReports ExtentReports;
        public ExtentTest Test;
        public TestReporting(IWebDriver driver)
        {
            this._driver = driver;
            var workingDirectory = Environment.CurrentDirectory;
            var projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName; //we are in utilities , we are getting the parent of the parent of utilities
            var reportPath = projectDirectory + "//index.html";
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            ExtentReports = new ExtentReports(); // we need to create it again to alocate memory to it or it fails null exception
            ExtentReports.AttachReporter(htmlReporter);
            ExtentReports.AddSystemInfo("Host Name", "Local Host");
            ExtentReports.AddSystemInfo("Environment", "QA");
            ExtentReports.AddSystemInfo("Username", "Slav Slavov");
            Test = ExtentReports.CreateTest(TestContext.CurrentContext.Test.Name);
        } 
        public void Capture()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status; 
            var stackTrace = TestContext.CurrentContext.Result.StackTrace; 



            if (status == TestStatus.Failed)
            {
                DateTime time = DateTime.Now;
                String fileName = "Screenshot_" + time.ToString("h_mm_ss") + ".png";
                Test.Fail("Test Failed", CaptureScreenShot(fileName));
                Test.Log(Status.Fail, "test failed with log trace" + stackTrace);
            }
            else if (status == TestStatus.Passed)
            {

            }

            ExtentReports.Flush(); 

        }

        public MediaEntityModelProvider CaptureScreenShot(String screenShotName) 
        {
            ITakesScreenshot ts = (ITakesScreenshot)_driver;
            var screenshot = ts.GetScreenshot().AsBase64EncodedString;

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, screenShotName).Build();
        }
    }
}
