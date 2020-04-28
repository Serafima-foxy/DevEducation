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
    public class AboutUsPageTest : BaseDriver
    {
        AboutUsPageModel aboutUsModel;
        MainPageModel pageModel;

        public AboutUsPageTest()
        {
            aboutUsModel = new AboutUsPageModel();
            pageModel = new MainPageModel();
        }

        [Test]
        public void CheckAboutUsLabel()
        {
            driver.Url = Urls.aboutUsPage;
            IWebElement aboutUsLebel = driver.FindElement(By.TagName(aboutUsModel.aboutUsLabelTagName));
            string actRes = aboutUsLebel.Text;
            Assert.AreEqual("О нас", actRes);
        }
        [Test]
        public void CheckGoToMainPageButton()
        {
            driver.Url = Urls.aboutUsPage;
            IWebElement mainPageButton = driver.FindElement(By.ClassName(aboutUsModel.mainPageButtonClassName));
            mainPageButton.Click();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            IWebElement mainPageLabel = driver.FindElement(By.TagName(pageModel.mainLabelTagName));
            string actRes = mainPageLabel.Text;
            Assert.AreEqual("Международный IT-колледж", actRes);
        }

        [Test]
        public void CheckAlexeyInOurTeachersBlock()
        {
            driver.Url = Urls.aboutUsPage;
            IWebElement ourTeacher = driver.FindElement(By.XPath(aboutUsModel.aboutUsTeacherAlexeyXPath));
            string actRes = ourTeacher.Text;
            Assert.AreEqual("Алексей", actRes);
        }

        [Test]
        public void CheckInspirer()
        {
            driver.Url = Urls.aboutUsPage;
            IWebElement buttonReadMore = driver.FindElement(By.XPath(aboutUsModel.readMoreButtonXPath));
            buttonReadMore.Click();
            IWebElement findInspirer = driver.FindElement(By.TagName(aboutUsModel.inspirerLabelTagName));
            string actRes = findInspirer.Text;
            Assert.AreEqual("Вдохновитель", actRes);
        }
    }
}
