using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using QnxTest.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs;
using WebDriverManager.DriverConfigs.Impl;

namespace CSharpSeleniumFramework.utilities
{
    [TestFixture]
    public abstract class BaseWebDriver
    {
        public abstract string SiteConfigUrl { get; }
        public IWebDriver Driver { get; private set; }
        public jsonReader SiteConfig { get; private set; }

        public WebDriverWait DefaultWait;

        private TestReporting _reporting;


        public virtual void Setup()
        {
            SetupDesktop();

        }

        public virtual void Setup(bool isMobile)
        {
            if (isMobile)
            {
                SetupMobile();
            }
            else
            {
                SetupDesktop();
            }
        }

        public void SetupDesktop()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArgument("window-size=1920,1080");
            SetupInternal(options);
        }

        public void SetupMobile()
        {
            ChromeOptions options = new ChromeOptions();
            
            options.EnableMobileEmulation("iPhone 12 Pro");
            SetupInternal(options);
        }
      

        private void SetupInternal(ChromeOptions options)
        {
            // reading the inital configuration for site
            options.AddArgument("Headless");
            SiteConfig = new jsonReader(SiteConfigUrl);

            //config manager
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //BrowserFactory(TestBrowser.Chrome);
            //creating options for Chrome

            Driver = new ChromeDriver(options);
            //creating implicit wait
            DefaultWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(12));
            _reporting = new TestReporting(Driver);
        }



        [TearDown]
        public virtual void TearDown()
        {
            //_reporting.Capture();
            Driver.Quit();
        }

        private void BrowserFactory(TestBrowser browser)
        {
            switch (browser)
            {
                case TestBrowser.Chrome:
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    Driver = new ChromeDriver();
                    break;
                case TestBrowser.Firefox:
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    Driver = new FirefoxDriver();
                    break;
                case TestBrowser.Edge:
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
                    Driver = new EdgeDriver();
                    break;
            }
        }
    }
}

public enum TestBrowser
{
    Chrome = 1,
    Firefox = 2,
    Edge = 3,
}
