using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace SiteTest
{
    internal class SimpleCalcPage
    {
        IWebDriver drw;
        private By buttoninca = By.XPath("//button[@ng-click='inca()']");
        private By buttondeca = By.XPath("//button[@ng-click='deca()']");
        private By buttonincb = By.XPath("//button[@ng-click='incb()']");
        private By buttondecb = By.XPath("//button[@ng-click='decb()']");

        private By fielda = By.XPath("//input[@ng-model='a']");
        private By fieldb = By.XPath("//input[@ng-model='b']");

        private By operatormns = By.CssSelector("select[ng-model='operation'][value='-']");
        private By operatorpls = By.CssSelector("select[ng-model='operation'][value='+']");
        private By operatorumn = By.CssSelector("select[ng-model='operation'][value='*']");
        private By operatordel = By.CssSelector("select[ng-model='operation'][value='/']");



        public SimpleCalcPage(IWebDriver driwe)
        {
            drw = driwe;
        }

        public void Clics()
        {
            IWebElement button_inca = drw.FindElement(buttoninca);
            button_inca.Click();
            Thread.Sleep(1500);

            IWebElement button_deca = drw.FindElement(buttondeca);
            button_deca.Click();
            Thread.Sleep(1500);

            IWebElement button_incb = drw.FindElement(buttonincb);
            button_incb.Click();
            Thread.Sleep(1500);

            IWebElement button_decb = drw.FindElement(buttondecb);
            button_decb.Click();
            Thread.Sleep(1500);
        }

        public void AddData()
        {
            IWebElement text_a = drw.FindElement(fielda);
            for (int i = 0; i < 10; i++)
            {
                text_a.SendKeys($"{i}");
                Thread.Sleep(1000);
                text_a.Clear();
            }
            text_a.SendKeys("0");

            IWebElement text_b = drw.FindElement(fieldb);
            for (int i = 0; i < 10; i++)
            {
                text_b.SendKeys($"{i}");
                Thread.Sleep(1000);
                text_b.Clear();
            }
            text_b.SendKeys("0");
        }

        public void ChangeOperation()
        {
            IWebElement operator_pl = drw.FindElement(operatorpls);
            operator_pl.Click();
            Thread.Sleep(1500);

            IWebElement operator_mn = drw.FindElement(operatormns);
            operator_mn.Click();
            Thread.Sleep(1500);

            IWebElement operator_pm = drw.FindElement(operatorumn);
            operator_pm.Click();
            Thread.Sleep(1500);

            IWebElement operator_de = drw.FindElement(operatordel);
            operator_de.Click();
            Thread.Sleep(1500);
        }
    }
}
