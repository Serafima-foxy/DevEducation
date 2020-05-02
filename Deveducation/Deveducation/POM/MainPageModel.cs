using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class MainPageModel
    {
        public By mainLabel = By.TagName("h1");
        public By courseMenuButton = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[1]/a");
        public By graduatesMenuButton = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[2]/a");
        public By aboutUsMenuButton = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[5]/a");
        public By contactsMenuButton = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[6]/a");
        public By locationKyivButton = By.XPath("/html/body/div[1]/main/section/div/div[2]/div/a[1]/span[2]");
        public By privacyPolicyRef = By.ClassName("ofooter-policy__link");
        public By signUpForCourseButton = By.XPath("/html/body/div[1]/main/div[7]/button");
        public By selectLanguageButton = By.ClassName("lang-switcher-header-btn");
        public By englishLanguageButton = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/ul/li/ul/li[3]/a");
        public By mainLabelInEnglish = By.TagName("h1");
        public By clicableMapKharkiv = By.XPath("/html/body/div[1]/main/section/div/div[2]/div/a[3]/span[2]");
        public By FAQLink = By.XPath("/html/body/div[1]/footer/div/nav/ul/li[7]/a");
        public By instagramLink = By.XPath("/html/body/div[1]/footer/div/ul/li[3]/a/img");
        public By footerYear = By.ClassName("ofooter-year"); 

        private IWebDriver _driver;
        IWebElement mainLabelElement;
        IWebElement courseMenuButtonElement;
        IWebElement graduatesMenuButtonElement;
        IWebElement aboutUsMenuBattonElement;
        IWebElement kyivLocationElement;
        IWebElement clicableMapKharkivElement;
        IWebElement contactsMenuButtonElement;
        IWebElement languageButtonElement;
        IWebElement englishLanguageButtonElement;
        IWebElement mainLabelInEnglishElement;
        IWebElement privacyPolicyElement;
        IWebElement signUpForTheCourseButtonElement;
        IWebElement faqButtonElement;
        IWebElement footerYearElement;

        public MainPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        //Test "chack main page label"
        public MainPageModel FindMainLabel()
        {
            mainLabelElement = _driver.FindElement(mainLabel);
            return this; // вернуть этот же класс
        }
        public string GetTextFromMainLabel()
        {
            return mainLabelElement.Text;
        }
        //Test "go to page courses"
        public MainPageModel FindCourseMenuButton()
        {
            courseMenuButtonElement = _driver.FindElement(courseMenuButton);
            return this; // вернуть этот же класс
        }
        public CoursesPageModel ClickOnCourseButton()
        {
            courseMenuButtonElement.Click();
            return new CoursesPageModel(_driver);
        }
        //Test "go to page graduates"
        public MainPageModel FindGraduatesMenuBattton()
        {
            graduatesMenuButtonElement = _driver.FindElement(graduatesMenuButton);
            return this;
        }
        public GraduatesPageModel ClickOnGraduateButton()
        {
            graduatesMenuButtonElement.Click();
            return new GraduatesPageModel(_driver);
        }
        //Test "go to page about ua"
        public MainPageModel FindAboutUsMenuBatton()
        {
            aboutUsMenuBattonElement = _driver.FindElement(aboutUsMenuButton);
            return this;
        }
        public AboutUsPageModel ClickOnAboutUsButton()
        {
            aboutUsMenuBattonElement.Click();
            return new AboutUsPageModel(_driver);
        }
        //Test "check Kyiv location"
        public MainPageModel FindKyivLocationElement()
        {
            kyivLocationElement = _driver.FindElement(locationKyivButton);
            return this;
        }
        public KyivLocationPageModel ClickOnKyivLocationButton()
        {
            kyivLocationElement.Click();
            return new KyivLocationPageModel(_driver);
        }
        //Test "check clicable map Kharkiv location"
        public MainPageModel FindOnMapKharkivButton()
        {
            clicableMapKharkivElement = _driver.FindElement(clicableMapKharkiv);
            return this;
        }
        public KharkivLocationPageModel ClickOnMapOnKharkivButton()
        {
            clicableMapKharkivElement.Click();
            return new KharkivLocationPageModel(_driver);
        }
        //Test "go to page contacts"
        public MainPageModel FindContactsMenuBatton()
        {
            contactsMenuButtonElement = _driver.FindElement(contactsMenuButton);
            return this;
        }
        public ContactsPageModel ClickOnContactsButton()
        {
            contactsMenuButtonElement.Click();
            return new ContactsPageModel(_driver);
        }
        //Test "check/change language button"
        public MainPageModel FindLanguageButton()
        {
            languageButtonElement = _driver.FindElement(selectLanguageButton);
            return this;
        }
        public string GetTextFromLanguageButton()
        {
            return languageButtonElement.Text;
        }
        public MainPageModel ClickOnLanguageButton()
        {
            languageButtonElement.Click();
            return this;
        }
        public MainPageModel FindEnglishLanguageButton()
        {
            englishLanguageButtonElement = _driver.FindElement(englishLanguageButton);
            return this;
        }
        public MainPageModel ClickOnEnglishLanguageButton()
        {
            englishLanguageButtonElement.Click();
            return this;
        }
        public MainPageModel FindMainLabelInEnglish()
        {
            mainLabelInEnglishElement = _driver.FindElement(mainLabelInEnglish);
            return this;
        }
        public string GetMainLabelText()
        {
            return mainLabelInEnglishElement.Text;
        }
        //Test "check privacy policy"
        public MainPageModel FindPrivacyPolicyRef()
        {
            privacyPolicyElement = _driver.FindElement(privacyPolicyRef);
            return this;
        }
        public PrivacyPolicyPageModel ClickOnPrivacyPolicyRef()
        {
            privacyPolicyElement.Click();
            return new PrivacyPolicyPageModel(_driver);
        }
        //Test "sign up button"
        public MainPageModel FindSignUpButton()
        {
            signUpForTheCourseButtonElement = _driver.FindElement(signUpForCourseButton);
            return this;
        }
        public string GetTextFromSignUpButton()
        {
            return signUpForTheCourseButtonElement.Text;
        }
        //Test "FAQ link"
        public MainPageModel FindFaqButton()
        {
            faqButtonElement = _driver.FindElement(FAQLink);
            return this;
        }
        public FAQPageModel ClickOnFaqButton()
        {
            faqButtonElement.Click();
            return new FAQPageModel(_driver);
        }
        //Test "check year in footer"
        public MainPageModel FindYearInFooter()
        {
            footerYearElement = _driver.FindElement(footerYear);
            return this;
        }
        public string GetYearFromFooter()
        {
            return footerYearElement.Text;
        }
    }
}
