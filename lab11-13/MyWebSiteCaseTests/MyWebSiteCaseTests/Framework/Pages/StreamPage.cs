using MyWebSiteCaseTests.Framework.Models;
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
    public class StreamPage : AbstractPage
    {
        private string url = "https://www.twitch.tv/cepreu_inq";
        
        public StreamPage(IWebDriver webDriver) : base(webDriver) { }
        
        public void OpenSettings()
        {
            ClickButton(By.XPath("//*[@id=\"settings-video\"]"));
        }
        public void OpenErrorItem()
        {
            ClickButton(By.XPath("//*[@id=\"settings-errors\"]"));
        }
        public void SetError(string message)
        {
            driver.FindElement(By.XPath("//*[@id=\"settings-errors-input\"]")).SendKeys(message);
        }
        public void SendError()
        {
            ClickButton(By.XPath("//*[@id=\"button-send-error\"]"));
        }
        public bool CheckErrorSended()
        {
            string text = driver.FindElement(By.XPath("//*[@id=\"settings-errors-isSended\"]")).Text;
            if(text == "send successfly")
                return true;
            else return false;
        }
        public void OpenQualityControl()
        {
            ClickButton(By.XPath("//*[@id=\"settings-quality\"]"));
            
        }
        public void ChangeQuality(string quality)
        {
            ClickButton(By.XPath($"//*[@id=\"settings-quality-{quality}\"]"));
        }

        public void OpenOther()
        {
            ClickButton(By.XPath($"//*[@id=\"settings-other\"]"));
        }
        public void SetShowStatistics()
        {
            ClickButton(By.XPath($"//*[@id=\"settings-other-statistics-select\"]"));
        }
        public void OpenRightMenu()
        {
            ClickButton(By.XPath("//*[@id=\"video-burger\"]"));
        }
        public void OpenModerators()
        {
            ClickButton(By.XPath("//*[@id=\"menu-video-moderators\"]"));
        }
        public bool CheckStatistics()
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"video-statistics\"]"));
            if (element != null)
                return true;
            else return false;
        }
        public bool CheckVideoQuality()
        {
            string text = driver.FindElement(By.XPath("//*[@id=\"video-quality-span\"]")).Text;
            if (text == "720p60")
                return true;
            else return false;
        }
        public bool CheckModeratorsList()
        {
            IWebElement webElement = driver.FindElement(By.XPath("//*[@id=\"moderators-list\"]"));
            if (webElement != null)
                return true;
            else return false;
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
