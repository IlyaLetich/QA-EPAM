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
    public class ChannelPage : AbstractPage
    {
        private string url = "https://www.twitch.tv/pahapel";

        public ChannelPage(IWebDriver webDriver) : base(webDriver) { }
        public void ClickButton(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public bool CheckPlayVideoScreen()
        {
            IWebElement containerVideo = driver.FindElement(By.XPath("//*[@id=\"browse-root-main-content\"]/"));

            if (containerVideo != null)
            {
                return true;
            }
            else return false;
        }

        public override void GoToPage()
        {
            Logger.Log(url + "oppen");
            driver.Navigate().GoToUrl(url);
        }
        public void ClickVideo()
        {
            ClickButton(By.XPath("//*[@id=\"browse-root-main-content\"]/div1"));
        }

        
    }
}
