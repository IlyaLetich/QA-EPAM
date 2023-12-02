using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebSiteCaseTests.Framework.Drivers
{
    public class SingletonDriver
    {
        private static IWebDriver driver;
        private SingletonDriver() { }
        public static IWebDriver GetDriver(string browserType = "chrome")
        {
            if (driver == null)
            {
                switch (browserType.ToLower())
                {
                    case "chrome":
                        driver = new ChromeDriver();
                        break;
                    case "firefox":
                        driver = new FirefoxDriver();
                        break;
                    case "edge":
                        driver = new EdgeDriver();
                        break;
                    case "ie":
                        driver = new InternetExplorerDriver();
                        break;
                    default:
                        driver = new ChromeDriver();
                        break;
                }
                driver.Manage().Window.Maximize();
            }
            return driver;
        }
        public void Exit()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
