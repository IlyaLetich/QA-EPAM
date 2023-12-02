using MyWebSiteCaseTests.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Pages
{
    public class DirectoryPage : AbstractPage
    {
        private string url = "https://www.twitch.tv/directory/";

        public DirectoryPage(IWebDriver webDriver) : base(webDriver) { }
        public void ClickButton(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public void SetMusicCategory()
        {
            IWebElement elem = driver.FindElement(By.XPath("//*[@id=\"browse-root-main-content\"]/div[2]/div/div[3]/div/a"));
            elem.Click();
        }

        public string GetCurrentCategory()
        {
            return driver.Title.Trim();
        }

        public override void GoToPage()
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
