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

        [Test]
        public void CheckAboutUsLabel()
        {
            aboutUsModel = new AboutUsPageModel(driver);
            driver.Url = Urls.aboutUsPage;
            string actRes = aboutUsModel.FindAboutUsMainLabel().
                                         GetTextFromMainLabel();

            Assert.AreEqual("О нас", actRes);
        }

        [Test]
        public void CheckGoToMainPageButton()
        {
            aboutUsModel = new AboutUsPageModel(driver);
            driver.Url = Urls.aboutUsPage;
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            string actRes = aboutUsModel.FindMainPageButton().
                                         ClickMainPageButton().
                                         FindMainLabel().
                                         GetTextFromMainLabel();

            Assert.AreEqual("Международный IT-колледж", actRes);
        }

        [Test]
        public void CheckAlexeyInOurTeachersBlock()
        {
            aboutUsModel = new AboutUsPageModel(driver);
            driver.Url = Urls.aboutUsPage;
            string actRes = aboutUsModel.FindOurTeacherAlexey().
                                         GetTextFromBlock();

            Assert.AreEqual("Алексей", actRes);
        }

        [Test]
        public void CheckInspirer()
        {
            aboutUsModel = new AboutUsPageModel(driver);
            driver.Url = Urls.aboutUsPage;
            string actRes = aboutUsModel.FindReadMoreButton().
                                         ClickOnReadMoreButton().
                                         FindInspirerLabel().
                                         GetTextFromLabel();

            Assert.AreEqual("Вдохновитель", actRes);
        }
    }
}
