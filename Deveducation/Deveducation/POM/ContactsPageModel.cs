using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class ContactsPageModel
    {
        public By ourContactsLabel = By.TagName("h1");
        public By contactsDniproCity = By.XPath("/html/body/div[1]/main/section[1]/div/div[1]/button[1]");
        public By contactsDniproAddresss = By.XPath("/html/body/div[1]/main/section[1]/div/div[2]/div[1]/div[1]/div[2]/div[1]");
        public By contactsKyivCity = By.XPath("/html/body/div[1]/main/section[1]/div/div[1]/button[2]");
        public By contactsKyivAddresss = By.XPath("/html/body/div[1]/main/section[1]/div/div[2]/div[2]/div[1]/div[2]/div[1]");
        public By contactsKharkivCity = By.XPath("/html/body/div[1]/main/section[1]/div/div[1]/button[5]");
        public By contactsKharkivAddresss = By.XPath("/html/body/div[1]/main/section[1]/div/div[2]/div[5]/div[1]/div[2]/div[1]");
        public By contactsAskQuestionButton = By.XPath("/html/body/div[1]/main/section[2]/div/button");

        private IWebDriver _driver;
        IWebElement contactsLabelElement;
        IWebElement contactsDniproCityElement;
        IWebElement contactsDniproAddresssElement;
        IWebElement contactsKyivCityElement;
        IWebElement contactsKyivAddresssElement;
        IWebElement contactsKharkivCityElement;
        IWebElement contactsKharkivAddresssElement;
        IWebElement contactsAskQuestionButtonElement;


        public ContactsPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public ContactsPageModel FindContactsMainLabel()
        {
            contactsLabelElement = _driver.FindElement(ourContactsLabel);
            return this;
        }
        public string GetMainLabelText()
        {
            return contactsLabelElement.Text;
        }

        public ContactsPageModel FindDniproCityButton()
        {
            contactsDniproCityElement = _driver.FindElement(contactsDniproCity);
            return this;
        }
        public ContactsPageModel ClickOnDniproCityButton()
        {
            contactsDniproCityElement.Click();
            return this;
        }
        public ContactsPageModel FindDniproAddress()
        {
            contactsDniproAddresssElement = _driver.FindElement(contactsDniproAddresss);
            return this;
        }
        public string GetTextFromDniproAddressBlock()
        {
            return contactsDniproAddresssElement.Text;
        }

        public ContactsPageModel FindKyivCityButton()
        {
            contactsKyivCityElement = _driver.FindElement(contactsKyivCity);
            return this;
        }
        public ContactsPageModel ClickOnKyivCityButton()
        {
            contactsKyivCityElement.Click();
            return this;
        }
        public ContactsPageModel FindKyivAddress()
        {
            contactsKyivAddresssElement = _driver.FindElement(contactsKyivAddresss);
            return this;
        }
        public string GetTextFromKyivAddressBlock()
        {
            return contactsKyivAddresssElement.Text;
        }

        public ContactsPageModel FindKharkivCityButton()
        {
            contactsKharkivCityElement = _driver.FindElement(contactsKharkivCity);
            return this;
        }
        public ContactsPageModel ClickOnKharkivCityButton()
        {
            contactsKharkivCityElement.Click();
            return this;
        }
        public ContactsPageModel FindKharkivAddress()
        {
            contactsKharkivAddresssElement = _driver.FindElement(contactsKharkivAddresss);
            return this;
        }
        public string GetTextFromKharkivAddressBlock()
        {
            return contactsKharkivAddresssElement.Text;
        }

        public ContactsPageModel FindAskQuationButton()
        {
            contactsAskQuestionButtonElement = _driver.FindElement(contactsAskQuestionButton);
            return this;
        }
        public string GetTextFromAskQuationButton()
        {
            return contactsAskQuestionButtonElement.Text;
        }
    }
}
