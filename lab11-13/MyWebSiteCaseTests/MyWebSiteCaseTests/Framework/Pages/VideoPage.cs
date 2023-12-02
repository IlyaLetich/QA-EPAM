using MyWebSiteCaseTests.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Pages
{
    public class VideoPage : AbstractPage
    {
        private string url = "https://www.twitch.tv/";

        public VideoPage(IWebDriver webDriver) : base(webDriver) { }
        public void ClickButton(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public override void GoToPage()
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
