using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class CoursesPageModel
    {
        public By ourCoursesLabel = By.TagName("h1");
        public By ourCoursesKyivLocation = By.ClassName("item__title");
        public By ourCoursesKyivBookkeeping = By.XPath("/html/body/div[1]/main/section[1]/div/div/ul/li[2]/ul/li[1]/a/span[1]");
        public By ourCoursesKyivQA = By.XPath("/html/body/div[1]/main/section[1]/div/div/ul/li[2]/ul/li[2]/a/span[1]");
        public By ourCoursesSignUpForm = By.TagName("h2");
        public By ourCoursesStudentReviewNextButton = By.XPath("/html/body/div[1]/main/section[2]/div/ul/button[2]");
        public By ourCoursesStudentReviewFirstElement = By.XPath("/html/body/div[1]/main/section[2]/div/ul/div/div/div[5]/div/li/div[2]");
        public By ourCoursesStudentReviewNextElement = By.XPath("/html/body/div[1]/main/section[2]/div/ul/div/div/div[7]/div/li/div[2]");
        public By ourCoursesSignUpNameInput = By.Name("entry.317589276");
        public By ourCoursesSignUpPhoneNumberInput = By.Name("entry.870452131");
        public By ourCoursesSignUpEmailInput = By.Name("entry.1133896419");
        public By ourCoursesSignUpCourseButton = By.Name("entry.252059992");
        public By ourCoursesSignUpCourseChoose = By.XPath("/html/body/div[1]/main/div[1]/section/div/form/div[2]/select/option[6]");
        public By ourCoursesSignUpCityButton = By.Name("entry.122376741");
        public By ourCoursesSignUpCityChoose = By.XPath("/html/body/div[1]/main/div[1]/section/div/form/div[5]/select/option[3]");
        public By ourCoursesSignUpSendButton = By.XPath("/html/body/div[1]/main/div[1]/section/div/form/div[6]/button[1]");
        
        private IWebDriver _driver;
        IWebElement coursesLabelElement;
        IWebElement bookkeepingButtonElement;
        IWebElement qaButtonElement;
        IWebElement signUpLabelElement;
        IWebElement firstInStudentReviewElement;
        IWebElement buttonNextInStudentReview;
        IWebElement nextInStudentReviewElement;
        IWebElement nameInputElement;
        IWebElement phoneNumberInputElement;
        IWebElement emailInputElement;
        IWebElement sendButtonElement;
        IWebElement courseButtonElement;
        IWebElement courseChooseElement;
        IWebElement cityButtonElement;
        IWebElement cityChooseElement;


        public CoursesPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }

        public CoursesPageModel FindCoursesLabel()
        {
            coursesLabelElement = _driver.FindElement(ourCoursesLabel);
            return this; // вернуть этот же класс
        }
        public string GetTextFromMainLabel()
        {
            return coursesLabelElement.Text;
        }

        public CoursesPageModel FindBookkeepingCourseButton()
        {
            bookkeepingButtonElement = _driver.FindElement(ourCoursesKyivBookkeeping);
            return this;
        }
        public BookkeepingPageModel ClickOnBookkeepingButton()
        {
            bookkeepingButtonElement.Click();
            return new BookkeepingPageModel(_driver);
        }

        public CoursesPageModel FindQACoursesButton()
        {
            qaButtonElement = _driver.FindElement(ourCoursesKyivQA);
            return this;
        }
        public QACoursePageModel ClickOnQACoursesButton()
        {
            qaButtonElement.Click();
            return new QACoursePageModel(_driver);
        }

        public CoursesPageModel FindSignUpLabel()
        {
            signUpLabelElement = _driver.FindElement(ourCoursesSignUpForm);
            return this;
        }
        public string GetTextFromSignUpLabel()
        {
            return signUpLabelElement.Text;
        }

        public CoursesPageModel FindFirstElementInStudentReview()
        {
            firstInStudentReviewElement = _driver.FindElement(ourCoursesStudentReviewFirstElement);
            return this;
        }
        public string GetTextFromFirstElement()
        {
            return firstInStudentReviewElement.Text;
        }
        public CoursesPageModel FindButtonNext()
        {
            buttonNextInStudentReview = _driver.FindElement(ourCoursesStudentReviewNextButton);
            return this;
        }
        public CoursesPageModel ClickOnNextButton()
        {
            buttonNextInStudentReview.Click();
            return this;
        }
        public CoursesPageModel FindNextElementInStudentReview()
        {
            nextInStudentReviewElement = _driver.FindElement(ourCoursesStudentReviewNextElement);
            return this;
        }
        public string GetTextFromNextElement()
        {
            return nextInStudentReviewElement.Text;
        }

        public CoursesPageModel FindNameInputField()
        {
            nameInputElement = _driver.FindElement(ourCoursesSignUpNameInput);
            return this;
        }
        public CoursesPageModel EnterNameInField()
        {
            nameInputElement.SendKeys("TEST");
            return this;
        }
        public CoursesPageModel FindPhoneNumberField()
        {
            phoneNumberInputElement = _driver.FindElement(ourCoursesSignUpPhoneNumberInput);
            return this;
        }
        public CoursesPageModel EnterPhoneNumberInField()
        {
            phoneNumberInputElement.SendKeys("380000000000");
            return this;
        }
        public CoursesPageModel FindEmailInputField()
        {
            emailInputElement = _driver.FindElement(ourCoursesSignUpEmailInput);
            return this;
        }
        public CoursesPageModel EnterEmailInField()
        {
            emailInputElement.SendKeys("fbotbr@jgbnd.jru");
            return this;
        }
        public CoursesPageModel FindSendButton()
        {
            sendButtonElement = _driver.FindElement(ourCoursesSignUpSendButton);
            return this;
        }
        public CoursesPageModel ClickOnButtonSend()
        {
            sendButtonElement.Click();
            return this;
        }

        public CoursesPageModel FindCoursesListButton()
        {
            courseButtonElement = _driver.FindElement(ourCoursesSignUpCourseButton);
            return this;
        }
        public CoursesPageModel ClickOnButtonCourses()
        {
            courseButtonElement.Click();
            return this;
        }
        public CoursesPageModel FindQACourseInList()
        {
            courseChooseElement = _driver.FindElement(ourCoursesSignUpCourseChoose);
            return this;
        }
        public CoursesPageModel ClickOnQACourse()
        {
            courseChooseElement.Click();
            return this;
        }
        public CoursesPageModel FindCityListButton()
        {
            cityButtonElement = _driver.FindElement(ourCoursesSignUpCityButton);
            return this;
        }
        public CoursesPageModel ClickOnCityListButton()
        {
            cityButtonElement.Click();
            return this;
        }
        public CoursesPageModel FindKyivInList()
        {
            cityChooseElement = _driver.FindElement(ourCoursesSignUpCityChoose);
            return this;
        }
        public CoursesPageModel ClickOnKyiv()
        {
            cityChooseElement.Click();
            return this;
        }
    }
}
