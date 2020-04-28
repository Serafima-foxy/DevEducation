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
        CoursesPageModel coursesModel;
        KyivLocationPageModel kyivLocationModel;
        PrivacyPolicyPageModel privacyPolicyModel;
        SignUpButtonFormModel signUpButtonModel;
        ContactsPageModel contactsModel;
        GraduatesPageModel graduatesModel;
        AboutUsPageModel aboutUsModel;
        public MainPageTest()
        {
            pageModel = new MainPageModel();
            coursesModel = new CoursesPageModel();
            kyivLocationModel = new KyivLocationPageModel();
            privacyPolicyModel = new PrivacyPolicyPageModel();
            signUpButtonModel = new SignUpButtonFormModel();
            contactsModel = new ContactsPageModel();
            graduatesModel = new GraduatesPageModel();
            aboutUsModel = new AboutUsPageModel();
        }

        [Test]
        public void CheckMainLabel()
        {
            driver.Url = Urls.mainPage;
            IWebElement mainLabel = driver.FindElement(By.TagName(pageModel.mainLabelTagName));
            string actResult = mainLabel.Text;
            Assert.AreEqual("Международный IT-колледж", actResult);
        }

        [Test]
        public void CheckCoursesButton()
        {
            driver.Url = Urls.mainPage;
            IWebElement coursesButton = driver.FindElement(By.XPath(pageModel.courseMenuButtonXPath));
            coursesButton.Click();
            IWebElement ourCoursesLabel = driver.FindElement(By.TagName(coursesModel.ourCoursesLabelTagName));
            string actResult = ourCoursesLabel.Text;
            Assert.AreEqual("Наши курсы", actResult);
        }
        [Test]
        public void CheckGraduatesButton()
        {
            driver.Url = Urls.mainPage;
            IWebElement graduatesButton = driver.FindElement(By.XPath(pageModel.graduatesMenuButtonXpath));
            graduatesButton.Click();
            IWebElement gradualesLabel = driver.FindElement(By.TagName(graduatesModel.graduatesLabelTagName));
            string actResult = gradualesLabel.Text;
            Assert.AreEqual("Наши выпускники", actResult);
        }

        [Test]
        public void CheckAboutUsButton()
        {
            driver.Url = Urls.mainPage;
            IWebElement aboutUsButton = driver.FindElement(By.XPath(pageModel.aboutMenuButtonXPath));
            aboutUsButton.Click();
            IWebElement aoutUsLabel = driver.FindElement(By.TagName(aboutUsModel.aboutUsLabelTagName));
            string actResult = aoutUsLabel.Text;
            Assert.AreEqual("О нас", actResult);
        }

        [Test]
        public void CheckKyivLocation()
        {
            driver.Url = Urls.mainPage;
            IWebElement locationKyivButton = driver.FindElement(By.XPath(pageModel.locationKyivButtonXPath));
            locationKyivButton.Click();
            IWebElement locationKyivLabel = driver.FindElement(By.XPath(kyivLocationModel.locationKyivLabelXPath));
            string actResult = locationKyivLabel.Text;
            Assert.AreEqual("Киев", actResult);
        }

        [Test]
        public void CheckClicableMap()
        {
            driver.Url = Urls.mainPage;
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            IWebElement kharkivButton = driver.FindElement(By.XPath(pageModel.clicableMapKharkivXPath));
            kharkivButton.Click();
            IWebElement locationKharkivLabel = driver.FindElement(By.XPath(pageModel.kharkivLocationLabelXPath));
            string actResult = locationKharkivLabel.Text;
            Assert.AreEqual("Харьков", actResult);
        }

        [Test]
        public void CheckContactsButton()
        {
            driver.Url = Urls.mainPage;
            IWebElement contactsButton = driver.FindElement(By.XPath(pageModel.contactsMenuButtonXPath));
            contactsButton.Click();
            IWebElement ourContactsLabel = driver.FindElement(By.TagName(contactsModel.ourContactsLabelTagName));
            string actResult = ourContactsLabel.Text;
            Assert.AreEqual("Наши контакты", actResult);
        }

        [Test]
        public void CheckLanguageButton()
        {
            driver.Url = Urls.mainPage;
            IWebElement languageButton = driver.FindElement(By.ClassName(pageModel.selectLanguageButtonClassName));
            string actResult = languageButton.Text;
            Assert.AreEqual("RU", actResult);
        }

        [Test]
        public void CheckChangeLanguageButton()
        {
            driver.Url = Urls.mainPage;
            IWebElement languageButton = driver.FindElement(By.ClassName(pageModel.selectLanguageButtonClassName));
            languageButton.Click();
            IWebElement engLanguage = driver.FindElement(By.XPath(pageModel.englishLanguageButtonXPath));
            engLanguage.Click();
            IWebElement mainLabelInEnglish = driver.FindElement(By.TagName(pageModel.mainLabelInEnglishTagName));
            string actRes = mainLabelInEnglish.Text;
            Assert.AreEqual("International IT College", actRes);
        }

        [Test]
        public void CheckPrivacyPolicy()
        {
            driver.Url = Urls.mainPage;
            IWebElement privacyPolicyRef = driver.FindElement(By.ClassName(pageModel.privacyPolicyRefClassName));
            privacyPolicyRef.Click();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(3);
            IWebElement privacyPolicyLabel = driver.FindElement(By.TagName(privacyPolicyModel.privacyPolicyLabelTagName));
            string actResult = privacyPolicyLabel.Text;
            Assert.AreEqual("Политика конфиденциальности", actResult);
        }

        [Test]
        public void CheckSignUpForCourseButtonAvailability()
        {
            driver.Url = Urls.mainPage;
            IWebElement signUpButton = driver.FindElement(By.XPath(pageModel.signUpForCourseButtonXPath));
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            string actResult = signUpButton.Text;
            Assert.AreEqual("Записаться\r\nна курс", actResult);
        }

        [Test]
        public void CheckFAQLink()
        {
            driver.Url = Urls.mainPage;
            IWebElement faqLink = driver.FindElement(By.XPath(pageModel.FAQLinkXPath));
            faqLink.Click();
            IWebElement faqLabel = driver.FindElement(By.TagName(pageModel.FAQLabelTafName));
            string actRes = faqLabel.Text;
            Assert.AreEqual("FAQ", actRes);
        }

        [Test]
        public void CheckFooterYear()
        {
            driver.Url = Urls.mainPage;
            IWebElement yearFooter = driver.FindElement(By.ClassName(pageModel.footerYearClassName));
            string actRes = yearFooter.Text;
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
