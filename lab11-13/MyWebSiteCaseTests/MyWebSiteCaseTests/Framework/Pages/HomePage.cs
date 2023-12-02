using MyWebSiteCaseTests.Framework.Utils;
using MyWebSiteCaseTests.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Pages
{
    public class HomePage : AbstractPage
    {
        private string url = "https://www.twitch.tv/";

        public HomePage(IWebDriver webDriver) : base(webDriver) { }
        public void ClickButton(By locator)
        {
            driver.FindElement(locator).Click();
        }
        public void ClickProfileButton()
        {
            ClickButton(By.XPath("//*[@id=\"profile-button\"]"));
        }

        public void ClickSwitchThemesButton()
        {
            ClickButton(By.XPath("//*[@id=\"theme-button\"]"));
        }

        public void Login(string login, string password)
        {
            ClickButton(By.XPath("//*[@id=\"login\"]"));
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//*[@id=\"login-username\"]")).SendKeys(login);
            driver.FindElement(By.XPath("//*[@id=\"password-input\"]")).SendKeys(password);
            Thread.Sleep(10000);
        }

        public string GetTheme()
        {
            IWebElement body = driver.FindElement(By.TagName("body"));
            string backgroundColor = body.GetCssValue("background-color");
            return backgroundColor;
        }

        public override void GoToPage()
        {
            Logger.Log(url + "oppen");
            driver.Navigate().GoToUrl(url);
        }
    }
}
