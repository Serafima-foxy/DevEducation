using Deveducation.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Deveducation
{
    public class MainPageTest : BaseDriver
    {
        MainPageModel pageModel;

        [Test]
        public void CheckMainLabel()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            pageModel.FindMainLabel();
            Assert.AreEqual("Международный IT-колледж", pageModel.GetTextFromMainLabel());
        }

        [Test]
        public void CheckCoursesButton()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            string actRes = pageModel.FindCourseMenuButton().
                                     ClickOnCourseButton().
                                     FindCoursesLabel().
                                     GetTextFromMainLabel();

            Assert.AreEqual("Наши курсы", actRes);
        }

        [Test]
        public void CheckGraduatesButton()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            string actRes = pageModel.FindGraduatesMenuBattton().
                                      ClickOnGraduateButton().
                                      FindGraduatesLabel().
                                      GetTextFromMainLabel();

            Assert.AreEqual("Наши выпускники", actRes);
        }

        [Test]
        public void CheckAboutUsButton()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            string actRes = pageModel.FindAboutUsMenuBatton().
                                      ClickOnAboutUsButton().
                                      FindAboutUsMainLabel().
                                      GetTextFromMainLabel();

            Assert.AreEqual("О нас", actRes);
        }

        [Test]
        public void CheckKyivLocation()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            string actRes = pageModel.FindKyivLocationElement().
                                      ClickOnKyivLocationButton().
                                      FindKyivLocationLabel().
                                      GetMainLabelText();

            Assert.AreEqual("Киев", actRes);
        }

        [Test]
        public void CheckClicableMap()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            string actRes = pageModel.FindOnMapKharkivButton().
                                      ClickOnMapOnKharkivButton().
                                      FindKharkivLocationLabel().
                                      GetMainLabelText();
            
            Assert.AreEqual("Харьков", actRes);
        }

        [Test]
        public void CheckContactsButton()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            string actRes = pageModel.FindContactsMenuBatton().
                                      ClickOnContactsButton().
                                      FindContactsMainLabel().
                                      GetMainLabelText();

            Assert.AreEqual("Наши контакты", actRes);
        }

        [Test]
        public void CheckLanguageButton()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            string actRes = pageModel.FindLanguageButton().
                                      GetTextFromLanguageButton();

            Assert.AreEqual("RU", actRes);
        }

        [Test]
        public void CheckChangeLanguageButton()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            string actRes = pageModel.FindLanguageButton().
                                      ClickOnLanguageButton().
                                      FindEnglishLanguageButton().
                                      ClickOnEnglishLanguageButton().
                                      FindMainLabelInEnglish().
                                      GetMainLabelText();

            Assert.AreEqual("International IT College", actRes);
        }

        [Test]
        public void CheckPrivacyPolicy()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            string actRes = pageModel.FindPrivacyPolicyRef().
                                      ClickOnPrivacyPolicyRef().
                                      FindMainLabel().
                                      GetTextFromLabel();

            Assert.AreEqual("Политика конфиденциальности", actRes);
        }

        [Test]
        public void CheckSignUpForCourseButtonAvailability()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            string actRes = pageModel.FindSignUpButton().
                                      GetTextFromSignUpButton();

            Assert.AreEqual("Записаться\r\nна курс", actRes);
        }

        [Test]
        public void CheckFAQLink()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            string actRes = pageModel.FindFaqButton().
                                      ClickOnFaqButton().
                                      FindMainLabel().
                                      GetTextFromLabel();

            Assert.AreEqual("FAQ", actRes);
        }

        [Test]
        public void CheckFooterYear()
        {
            pageModel = new MainPageModel(driver);
            driver.Url = Urls.mainPage;
            string actRes = pageModel.FindYearInFooter().
                                      GetYearFromFooter();

            Assert.AreEqual("2020", actRes);
        }

        //[Test]
        //public void CheckFacebookLink()
        //{
        //    driver.Url = Urls.mainPage;
        //    IWebElement instagramLink = driver.FindElement(By.XPath(pageModel.instagramLinkXPath));
        //    instagramLink.Click();
        //}
    }
}
