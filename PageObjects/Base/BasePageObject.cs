using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.Base
{
    internal abstract class BasePageObject : BaseObject
    {
        public BasePageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
    }
}
