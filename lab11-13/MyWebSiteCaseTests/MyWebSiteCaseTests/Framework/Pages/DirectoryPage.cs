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
    public class DirectoryPage : AbstractPage
    {
        private string url = "https://www.twitch.tv/directory/";

        public DirectoryPage(IWebDriver webDriver) : base(webDriver) { }
        public void ClickButton(By locator)
        {
            driver.FindElement(locator).Click();
        }

        public void SetMusicCategory(string category)
        {
             ClickButton(By.XPath("//*[@id=\"category\"]"));
        }
        public void OpenLanguagesFilter()
        {
            ClickButton(By.XPath("//*[@id=\"languages-filter-sort\"]"));
        }
        public void WriteSearch()
        {
            IWebElement webElement = driver.FindElement(By.XPath("//*[@id=\"search\"]"));
            webElement.SendKeys("геминг");
            webElement.Click();
        }

        public void SetLanguageItem(string language)
        {
            ClickButton(By.XPath($"//*[@id=\"language-{language}\"]"));
        }

        public string GetCurrentCategory()
        {
            return driver.Title.Trim();
        }

        public bool CheckStreamsFilterByLanguages()
        {
            string nameFirstStreamLanguage = driver.FindElement(By.XPath("//*[@id=\"container\"]/div[1]")).Text;
            if (nameFirstStreamLanguage == "Русский")
                return true;
            else return false;
        }
        public bool CheckStreamsFilterByWord()
        {
            string nameFirstStream = driver.FindElement(By.XPath("//*[@id=\"container\"]/div[1]/span")).Text;
            if (nameFirstStream == "гейминг")
                return true;
            else return false;
        }

        public override void GoToPage()
        {
            Logger.Log(url + "oppen");
            driver.Navigate().GoToUrl(url);
        }


    }
}
