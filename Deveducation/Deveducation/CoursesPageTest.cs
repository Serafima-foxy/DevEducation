using Deveducation.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation
{
    public class CoursesPageTest : BaseDriver
    {
        CoursesPageModel coursesModel;
        BookkeepingPageModel bookkeepingModel;
        QACoursePageModel qaCourseModel;
        public CoursesPageTest()
        {
            coursesModel = new CoursesPageModel();
            bookkeepingModel = new BookkeepingPageModel();
            qaCourseModel = new QACoursePageModel();
        }

        [Test]
        public void CheckOurCoursesPage()
        {
            driver.Url = Urls.coursesPage;
            IWebElement coursesLabel = driver.FindElement(By.TagName(coursesModel.ourCoursesLabelTagName));
            string actResult = coursesLabel.Text;
            Assert.AreEqual("Наши курсы", actResult);
        }

        [Test]
        public void CheckKyivBookkeepingCourse()
        {
            driver.Url = Urls.coursesPage;
            IWebElement bookkeepingCourseButton = driver.FindElement(By.XPath(coursesModel.ourCoursesKyivBookkeepingXPath));
            bookkeepingCourseButton.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement bookkeepingLabel = driver.FindElement(By.TagName(bookkeepingModel.bookkeepingLabelTagName));
            string actResult = bookkeepingLabel.Text;
            Assert.AreEqual("Bookkeeping", actResult);
        }

        [Test]
        public void CheckKyivQACourse()
        {
            driver.Url = Urls.coursesPage;
            IWebElement qaCourseButton = driver.FindElement(By.XPath(coursesModel.ourCoursesKyivQAXPath));
            qaCourseButton.Click();
            IWebElement qaLabel = driver.FindElement(By.TagName(qaCourseModel.qaLabelTagName));
            string actResult = qaLabel.Text;
            Assert.AreEqual("QA/AT", actResult);
        }

        [Test]
        public void CheckOurCoursesSignUpForm()
        {
            driver.Url = Urls.coursesPage;
            IWebElement signUpLabel = driver.FindElement(By.TagName(coursesModel.ourCoursesSignUpFormTagName));
            string actResult = signUpLabel.Text;
            Assert.AreEqual("Записаться на курс", actResult);
        }

        [Test]
        public void ClickNextButtonInStudentReview()
        {
            driver.Url = Urls.coursesPage;
            IWebElement findFirstElement = driver.FindElement(By.XPath(coursesModel.ourCoursesStudentReviewFirstElementXPath));
            string firstElement = findFirstElement.Text;
            IWebElement nextButton = driver.FindElement(By.XPath(coursesModel.ourCoursesStudentReviewNextButtonXPath));
            nextButton.Click();
            IWebElement findNextElement = driver.FindElement(By.XPath(coursesModel.ourCoursesStudentReviewNextElementXPath));
            string nextElement = findNextElement.Text;
            Assert.AreNotEqual(firstElement, nextElement);
        }

        [Test]
        public void FilledUpInputFieldsInSignUpForm()
        {
            driver.Url = Urls.coursesPage;
            IWebElement signUpName = driver.FindElement(By.Name(coursesModel.ourCoursesSignUpNameInputName));
            signUpName.SendKeys("TEST");
            IWebElement signUpPhoneNumber = driver.FindElement(By.Name(coursesModel.ourCoursesSignUpPhoneNumberInputName));
            signUpPhoneNumber.SendKeys("+380000000000");
            IWebElement signUpEmail = driver.FindElement(By.Name(coursesModel.ourCoursesSignUpEmailInputName));
            signUpEmail.SendKeys("fbotbr@jgbnd.jru");
            IWebElement sendButton = driver.FindElement(By.XPath(coursesModel.ourCoursesSignUpSendButtonXPath));
            sendButton.Click();
        }

        [Test]
        public void ChooseFromListInSignUpForm()
        {
            driver.Url = Urls.coursesPage;
            IWebElement coursesButton = driver.FindElement(By.Name(coursesModel.ourCoursesSignUpCourseButtonName));
            coursesButton.Click();
            IWebElement chooseQA = driver.FindElement(By.XPath(coursesModel.ourCoursesSignUpCourseChooseXPath));
            chooseQA.Click();
            IWebElement cityButton = driver.FindElement(By.Name(coursesModel.ourCoursesSignUpCityButtonName));
            cityButton.Click();
            IWebElement chooseKyiv = driver.FindElement(By.XPath(coursesModel.ourCoursesSignUpCityChooseXPath));
            chooseKyiv.Click();
            IWebElement sendButton = driver.FindElement(By.XPath(coursesModel.ourCoursesSignUpSendButtonXPath));
            sendButton.Click();
        }

        [Test]
        public void SignUpForQACourseInKyiv()
        {
            driver.Url = Urls.coursesPage;
            IWebElement signUpName = driver.FindElement(By.Name(coursesModel.ourCoursesSignUpNameInputName));
            signUpName.SendKeys("TEST");
            IWebElement signUpPhoneNumber = driver.FindElement(By.Name(coursesModel.ourCoursesSignUpPhoneNumberInputName));
            signUpPhoneNumber.SendKeys("+380000000000");
            IWebElement coursesButton = driver.FindElement(By.Name(coursesModel.ourCoursesSignUpCourseButtonName));
            coursesButton.Click();
            IWebElement chooseQA = driver.FindElement(By.XPath(coursesModel.ourCoursesSignUpCourseChooseXPath));
            chooseQA.Click();
            IWebElement cityButton = driver.FindElement(By.Name(coursesModel.ourCoursesSignUpCityButtonName));
            cityButton.Click();
            IWebElement chooseKyiv = driver.FindElement(By.XPath(coursesModel.ourCoursesSignUpCityChooseXPath));
            chooseKyiv.Click();
            IWebElement signUpEmail = driver.FindElement(By.Name(coursesModel.ourCoursesSignUpEmailInputName));
            signUpEmail.SendKeys("fbotbr@jgbnd.jru");
            IWebElement sendButton = driver.FindElement(By.XPath(coursesModel.ourCoursesSignUpSendButtonXPath));
            sendButton.Click();
        }
    }
   
}
