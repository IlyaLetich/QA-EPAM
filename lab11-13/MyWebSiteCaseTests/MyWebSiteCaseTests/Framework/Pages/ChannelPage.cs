using MyWebSiteCaseTests.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Pages
{
    public class ChannelPage : AbstractPage
    {
        private string url = "https://www.twitch.tv/valorant/videos";

        public ChannelPage(IWebDriver webDriver) : base(webDriver) { }
        public void ClickButton(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public bool CheckFollowers()
        {
            IWebElement webeElement = driver.FindElement(By.XPath("//*[@id=\"offline-channel-main-content\"]/div[2]/div[1]/div[1]/div[2]/p"));
            if (webeElement != null)
            {
                return true;
            }
            else return false;
        }

        public void PlayVideo()
        {
            IWebElement webElement = driver.FindElement(By.XPath("//*[@id=\"offline-channel-main-content\"]/div[3]/div/div/div/div/div/div/div[2]/div[2]/div[1]/div/div/article[1]/div[2]/div/div[5]/a/div/div[1]/div[2]/div/div/div[2]/img"));
            webElement.Click();
        }

        public string GetTitle()
        {
            return driver.Title;
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
