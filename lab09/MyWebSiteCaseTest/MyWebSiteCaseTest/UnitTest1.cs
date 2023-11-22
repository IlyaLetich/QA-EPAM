using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;

namespace MyWebSiteCaseTest
{
    public class Tests
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.twitch.tv/";
            verificationErrors = new StringBuilder();

        }

        [TearDown]
        public void TearDownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Assert.That(verificationErrors.ToString(), Is.EqualTo(""));
        }

        [Test]
        public void SwitchThemesTests()
        {
            driver.Navigate().GoToUrl(baseURL);

            IWebElement body = driver.FindElement(By.TagName("body"));
            string backgroundColor = body.GetCssValue("background-color");

            driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/nav/div/div[3]/div[3]/div/div[2]/div/div[1]/button/button")).Click();


            driver.FindElement(By.XPath("/html/body/div[5]/div/div/div/div/div/div/div/div/div/div/div/div[3]/div/div/div[2]/div/div/div[2]")).Click();
            IWebElement bodyChange = driver.FindElement(By.TagName("body"));
            string backgroundColorChange = body.GetCssValue("background-color");

            Thread.Sleep(5000);

            Assert.That(backgroundColor.Equals(backgroundColorChange));
        }
    }
}