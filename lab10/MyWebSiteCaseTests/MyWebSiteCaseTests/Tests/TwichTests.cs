using MyWebSiteCaseTests.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;

namespace MyWebSiteCaseTests.Tests
{
    public class TwichTests
    {
        [Test]
        public void SwitchThemesTests()
        {
            TwichPage twichPage = new TwichPage(new ChromeDriver());

            twichPage.GoToPage();

            string beforeColor = twichPage.GetTheme();
            twichPage.ClickProfileButton();
            twichPage.ClickSwitchThemesButton();
            Thread.Sleep(1000);
            string afterColor = twichPage.GetTheme();

            Thread.Sleep(1000);
            twichPage.Exit();

            Assert.IsFalse(beforeColor == afterColor, "Цвета не должны совпадать");
        }

        [Test]
        public void ViewMusicCategory()
        {
            TwichPage twichPage = new TwichPage(new ChromeDriver());

            twichPage.GoToPage();

            //twichPage.Login("IlyaLetich", "********");

            twichPage.ClickButton(By.XPath("//*[@id=\"root\"]/div/div[2]/nav/div/div[1]/div[2]/div/div/div[1]/a"));
            Thread.Sleep(1000);
            twichPage.ClickButton(By.XPath("//*[@id=\"browse-root-main-content\"]/div[2]/div/div[3]/div/a"));
            Thread.Sleep(1000);

            Assert.IsTrue(twichPage.GetCurrentCategory() == "Music", "Не правильная категория");

            Thread.Sleep(5000);
            twichPage.Exit();
        }
    }
}