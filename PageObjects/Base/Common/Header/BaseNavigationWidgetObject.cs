using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.Base.Common.Home_Page
{

    internal abstract class BaseNavigationWidgetObject : BaseWidgetObject
    {
        

        public abstract IWebElement LiveCasino { get; set; }
        public abstract IWebElement Slots { get; set; }
        public abstract IWebElement TableGames { get; set; }
        public abstract IWebElement SportsBet { get; set; }
        public abstract IWebElement Esports { get; set; }
        public abstract IWebElement Virtual { get; set; }
        public abstract IWebElement Promotions { get; set; }
        public abstract IWebElement Deposits { get; set; }

        protected BaseNavigationWidgetObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public virtual void LiveCasinoMenuClick()
        {
            Wait.Until(driver => LiveCasino.Displayed);
            LiveCasino.Click();
          
        }
        public virtual void SlotsMenuClick()
        {
            Wait.Until(driver => Slots.Displayed);
            Slots.Click();

        }

        public virtual void TableGamesMenuClick()
        {
            Wait.Until(driver => TableGames.Displayed);
            TableGames.Click();
        }

        public virtual void SportsBetGamesMenuClick()
        {
            Wait.Until(driver => SportsBet.Displayed);
            SportsBet.Click();
        }

        public virtual void EsportsGamesMenuClick()
        {
            Wait.Until(driver => Esports.Displayed);
            Esports.Click();
        }

        public virtual void VirtualGamesMenuClick()
        {
            Wait.Until(driver => Virtual.Displayed);
            Virtual.Click();
        }

        public virtual void PromotionsMenuClick()
        {
            Wait.Until(driver => Promotions.Displayed);
            Promotions.Click();
        }
        public virtual void DepositsMenuClick()
        {
            Wait.Until(driver => Deposits.Displayed);
            Deposits.Click();
        }
    }
}
