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


        [Test]
        public void CheckOurCoursesPage()
        {
            coursesModel = new CoursesPageModel(driver);
            driver.Url = Urls.coursesPage;
            string actRes = coursesModel.FindCoursesLabel().
                                         GetTextFromMainLabel();

            Assert.AreEqual("Наши курсы", actRes);
        }

        [Test]
        public void CheckKyivBookkeepingCourse()
        {
            coursesModel = new CoursesPageModel(driver);
            driver.Url = Urls.coursesPage;
            string actRes = coursesModel.FindBookkeepingCourseButton().
                                         ClickOnBookkeepingButton().
                                         FindBookkeepingLabel().
                                         GetTextFromLabel();

            Assert.AreEqual("Bookkeeping", actRes);
        }

        [Test]
        public void CheckKyivQACourse()
        {
            coursesModel = new CoursesPageModel(driver);
            driver.Url = Urls.coursesPage;
            string actRes = coursesModel.FindQACoursesButton().
                                         ClickOnQACoursesButton().
                                         FindQACoursesLabel().
                                         GetTextFromLabel();

            Assert.AreEqual("QA/AT", actRes);
        }

        [Test]
        public void CheckOurCoursesSignUpForm()
        {
            coursesModel = new CoursesPageModel(driver);
            driver.Url = Urls.coursesPage;
            string actRes = coursesModel.FindSignUpLabel().
                                         GetTextFromSignUpLabel();

            Assert.AreEqual("Записаться на курс", actRes);
        }

        [Test]
        public void ClickNextButtonInStudentReview()
        {
            coursesModel = new CoursesPageModel(driver);
            driver.Url = Urls.coursesPage;
            string firstRes = coursesModel.FindFirstElementInStudentReview().
                                           GetTextFromFirstElement();
            coursesModel.FindButtonNext().
                         ClickOnNextButton();
            string secondRes = coursesModel.FindNextElementInStudentReview().
                                            GetTextFromNextElement();

            Assert.AreNotEqual(firstRes, secondRes);
        }

        [Test]
        public void FilledUpInputFieldsInSignUpForm()
        {
            coursesModel = new CoursesPageModel(driver);
            driver.Url = Urls.coursesPage;
            coursesModel.FindNameInputField().
                         EnterNameInField().
                         FindPhoneNumberField().
                         EnterPhoneNumberInField().
                         FindEmailInputField().
                         EnterEmailInField().
                         FindSendButton().
                         ClickOnButtonSend();
        }

        [Test]
        public void ChooseElementsFromListInSignUpForm()
        {
            coursesModel = new CoursesPageModel(driver);
            driver.Url = Urls.coursesPage;
            coursesModel.FindCoursesListButton().
                         ClickOnButtonCourses().
                         FindQACourseInList().
                         ClickOnQACourse().
                         FindCityListButton().
                         ClickOnCityListButton().
                         FindKyivInList().
                         ClickOnKyiv().
                         FindSendButton().
                         ClickOnButtonSend();
        }

        [Test]
        public void SignUpForQACourseInKyiv()
        {
            coursesModel = new CoursesPageModel(driver);
            driver.Url = Urls.coursesPage;
            coursesModel.FindNameInputField().
                         EnterNameInField().
                         FindPhoneNumberField().
                         EnterPhoneNumberInField().
                         FindEmailInputField().
                         EnterEmailInField().
                         FindCoursesListButton().
                         ClickOnButtonCourses().
                         FindQACourseInList().
                         ClickOnQACourse().
                         FindCityListButton().
                         ClickOnCityListButton().
                         FindKyivInList().
                         ClickOnKyiv().
                         FindSendButton().
                         ClickOnButtonSend();
        }
    }

}
