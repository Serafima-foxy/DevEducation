using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class AboutUsPageModel
    {
        public By aboutUsLabel = By.TagName("h2");
        public By aboutUsTeacherAlexey = By.XPath("/html/body/div[1]/main/section/div/div/div[14]/div/div[2]/div[1]");
        public By mainPageButton = By.ClassName("_logo__image");
        public By readMoreButton = By.XPath("/html/body/div[1]/main/div[3]/div/div/a");

        private IWebDriver _driver;
        IWebElement aboutUsLabelElement;
        IWebElement mainPageButtonElement;
        IWebElement teacherAlexeyElement;
        IWebElement readMoreButtonElement;

        public AboutUsPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }

        public AboutUsPageModel FindAboutUsMainLabel()
        {
            aboutUsLabelElement = _driver.FindElement(aboutUsLabel);
            return this;
        }

        public string GetTextFromMainLabel()
        {
            return aboutUsLabelElement.Text;
        }

        public AboutUsPageModel FindMainPageButton()
        {
            mainPageButtonElement = _driver.FindElement(mainPageButton);
            return this;
        }
        public MainPageModel ClickMainPageButton()
        {
            mainPageButtonElement.Click();
            return new MainPageModel(_driver);
        }

        public AboutUsPageModel FindOurTeacherAlexey()
        {
            teacherAlexeyElement = _driver.FindElement(aboutUsTeacherAlexey);
            return this;
        }
        public string GetTextFromBlock()
        {
            return teacherAlexeyElement.Text;
        }

        public AboutUsPageModel FindReadMoreButton()
        {
            readMoreButtonElement = _driver.FindElement(readMoreButton);
            return this;
        }
        public InspirerPageModel ClickOnReadMoreButton()
        {
            readMoreButtonElement.Click();
            return new InspirerPageModel(_driver);
        }
    }
}
