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
            IWebElement element1 = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div/main/div[1]/div[3]/div/div/div[2]/div/div[2]/div/div[3]/div/div/div[2]"));
            Thread.Sleep(1000);
            element1.Click();
            Thread.Sleep(1000);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"channel-player\"]/div/div[2]/div[1]/div[2]/div/button"));
            Thread.Sleep(1000);
            element.Click();
        }
        public void SetError()
        {
            IWebElement elem = driver.FindElement(By.XPath("/html/body/div[5]/div/div/div/div/div[1]/div/div/div[2]/div[2]/div/select/option[5]"));
            Thread.Sleep(1000);
            elem.Click();
        }

        public void SendError()
        {
            IWebElement elem = driver.FindElement(By.XPath("/html/body/div[5]/div/div/div/div/div[1]/div/div/div[2]/div[3]/button"));
            Thread.Sleep(1000);
            elem.Click();
        }

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
