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
    public class VideoPage : AbstractPage
    {
        private string url = "https://www.twitch.tv/";

        public VideoPage(IWebDriver webDriver) : base(webDriver) { }
        public void ChangeSpeed(string speed)
        {
            ClickButton(By.XPath($"//*[@id=\"settings-speed-{speed}\"]"));
        }
        public void OpenSpeedControl()
        {
            ClickButton(By.XPath("//*[@id=\"settings-speed\"]"));
        }
        public bool CheckCurrentVideoSpeed()
        {
            string text = driver.FindElement(By.XPath("//*[@id=\"videoPlay-speed\"]")).Text;
            if (text == "2x")
                return true;
            else return false;
        }
        public void OpenSettings()
        {
            ClickButton(By.XPath("//*[@id=\"settings-video\"]"));
        }
        public void ClickButton(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public override void GoToPage()
        {
            Logger.Log(url + "oppen");
            driver.Navigate().GoToUrl(url);
        }
    }
}
