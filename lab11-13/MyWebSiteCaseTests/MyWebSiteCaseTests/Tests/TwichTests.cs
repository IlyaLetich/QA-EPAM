using MyWebSiteCaseTests.Framework.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebSiteCaseTests.Framework.Creators;
using MyWebSiteCaseTests.Framework.Drivers;
using MyWebSiteCaseTests.Framework.Utils;

namespace MyWebSiteCaseTests.Tests
{
    public class TwichTests
    {
        [Test]
        public void SwitchThemesTest()
        {
            Logger.Log("SwitchThemesTest started");
            HomePage homePage = new HomePage(SingletonDriver.GetDriver());

            homePage.GoToPage();

            string beforeColor = homePage.GetTheme();
            homePage.ClickProfileButton();
            homePage.ClickSwitchThemesButton();
            string afterColor = homePage.GetTheme();

            homePage.Exit();

            Assert.IsFalse(beforeColor == afterColor, "Цвета не должны совпадать");
        }
        [Test]
        public void SearchStreamsByMusicCategoryTest()
        {
            Logger.Log("SearchStreamsByMusicCategoryTest started");
            DirectoryPage directoryPage = new DirectoryPage(SingletonDriver.GetDriver());

            directoryPage.GoToPage();
            directoryPage.SetMusicCategory(CategoryCreator.Create().CategoryName);

            Assert.IsTrue(directoryPage.GetCurrentCategory() == CategoryCreator.Create().CategoryName, "Не правильная категория");

            Thread.Sleep(5000);
            directoryPage.Exit();
        }

        [Test]
        public void ChangeSpeedPlayVideoTest()
        {
            Logger.Log("ChangeSpeedPlayVideoTest started");
            VideoPage videoPage = new VideoPage(SingletonDriver.GetDriver());

            videoPage.GoToPage();
            videoPage.OpenSettings();
            videoPage.OpenSpeedControl();
            videoPage.ChangeSpeed(SpeedCreator.Create().SpeedVideo);

            Assert.IsTrue(videoPage.CheckCurrentVideoSpeed(), "Скорость не изменилась");
            videoPage.Exit();
        }
        [Test]
        public void SendErrorMessageTest()
        {
            Logger.Log("SendErrorMessageTest started");
            StreamPage streamPage = new StreamPage(SingletonDriver.GetDriver());

            streamPage.GoToPage();
            streamPage.OpenSettings();
            streamPage.OpenErrorItem();
            streamPage.SetError(ErrorCreator.Create().ErrorMessage);
            streamPage.SendError();

            Assert.IsTrue(streamPage.CheckErrorSended(), "Сообщение об ошибке не отправлено");
            streamPage.Exit();
        }
        [Test]
        public void PlayVideoOnChannelTest()
        {
            Logger.Log("PlayVideoOnChannelTest started");
            ChannelPage channelPage = new ChannelPage(SingletonDriver.GetDriver());

            channelPage.GoToPage();
            channelPage.ClickVideo();

            Assert.IsTrue(channelPage.CheckPlayVideoScreen(), "Видео не воспроизвелось");
            channelPage.Exit();
        }
        [Test]
        public void ChangeQualityStreamTest()
        {
            Logger.Log("ChangeQualityStreamTest started");
            StreamPage streamPage = new StreamPage(SingletonDriver.GetDriver());

            streamPage.GoToPage();
            streamPage.OpenSettings();
            streamPage.OpenQualityControl();
            streamPage.ChangeQuality(QualityCreator.Create().QualityVideo);

            Assert.IsTrue(streamPage.CheckVideoQuality(), "Качество не соответствует ожидаемому");
            streamPage.Exit();
        }

        [Test]
        public void ShowStatisticStreamTest()
        {
            Logger.Log("ShowStatisticStreamTest started");
            StreamPage streamPage = new StreamPage(SingletonDriver.GetDriver());

            streamPage.GoToPage();
            streamPage.OpenSettings();
            streamPage.OpenOther();
            streamPage.SetShowStatistics();

            Assert.IsTrue(streamPage.CheckStatistics(), "Статистика не отображается");
            streamPage.Exit();
        }
        [Test]
        public void SearchStreamByKeyWordTest()
        {
            Logger.Log("SearchStreamByKeyWordTest started");
            DirectoryPage directoryPage = new DirectoryPage(SingletonDriver.GetDriver());

            directoryPage.GoToPage();

            directoryPage.WriteSearch();

            Assert.IsTrue(directoryPage.CheckStreamsFilterByWord(), "Не найдено стримов с заданным параметром");
            directoryPage.Exit();
        }
        [Test]
        public void SeeListModerators()
        {
            Logger.Log("SeeListModerators started");
            StreamPage streamPage = new StreamPage(SingletonDriver.GetDriver());

            streamPage.GoToPage();

            streamPage.OpenRightMenu();
            streamPage.OpenModerators();

            Assert.IsTrue(streamPage.CheckModeratorsList(), "Лист модераторов не найден");
            streamPage.Exit();
        }
        [Test]
        public void FilterStreamsByLanguageTest()
        {
            Logger.Log("FilterStreamsByLanguageTest started");
            DirectoryPage directoryPage = new DirectoryPage(SingletonDriver.GetDriver());

            directoryPage.GoToPage();

            directoryPage.OpenLanguagesFilter();
            directoryPage.SetLanguageItem(LanguageCreator.Create().LanguageVideos);

            Assert.IsTrue(directoryPage.CheckStreamsFilterByLanguages(), "Не найдено стримов с заданными языками");
            directoryPage.Exit();
        }
    }
}
