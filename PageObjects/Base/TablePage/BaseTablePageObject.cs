using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.Base.Common.TablePage
{
    internal abstract class BaseTablePageObject : BasePageObject
    {
        public abstract IWebElement IFrame { get; set; }
        protected BaseTablePageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public virtual void WaitIFrameDisplayed()
        {
            Wait.Until(driver => IFrame.Displayed);
        }

    }
}
