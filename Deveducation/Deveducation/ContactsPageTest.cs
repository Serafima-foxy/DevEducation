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
    public class ContactsPageTest : BaseDriver
    {
        ContactsPageModel contactsModel;
        public ContactsPageTest()
        {
            contactsModel = new ContactsPageModel();
        }

        [Test]
        public void CheckOurContactsLabel()
        {
            driver.Url = Urls.contactsPage;
            IWebElement contactsLabel = driver.FindElement(By.TagName(contactsModel.ourContactsLabelTagName));
            string actResult = contactsLabel.Text;
            Assert.AreEqual("Наши контакты", actResult);
        }

        [Test]
        public void CheckDniproAdress()
        {
            driver.Url = Urls.contactsPage;
            IWebElement dniproButton = driver.FindElement(By.XPath(contactsModel.contactsDniproCityXPath));
            dniproButton.Click();
            IWebElement dniproAdress = driver.FindElement(By.XPath(contactsModel.contactsDniproAdressXPath));
            string actResult = dniproAdress.Text;
            Assert.AreEqual("ул.Симферопольская, 17", actResult);
        }

        [Test]
        public void CheckKyivAdress()
        {
            driver.Url = Urls.contactsPage;
            IWebElement kyivButton = driver.FindElement(By.XPath(contactsModel.contactsKyivCityXPath));
            kyivButton.Click();
            IWebElement kyivAdress = driver.FindElement(By.XPath(contactsModel.contactsKyivAdressXPath));
            string actResult = kyivAdress.Text;
            Assert.AreEqual("ст. метро Васильковская, ул. Сумская,1", actResult);
        }

        [Test]
        public void CheckKharkivAdress()
        {
            driver.Url = Urls.contactsPage;
            IWebElement kharkivButton = driver.FindElement(By.XPath(contactsModel.contactsKharkivCityXPath));
            kharkivButton.Click();
            IWebElement kharkivAdress = driver.FindElement(By.XPath(contactsModel.contactsKharkivAdressXPath));
            string actResult = kharkivAdress.Text;
            Assert.AreEqual("ул. Донец Захаржевского, 2,\r\nздание Сбербанка, этаж 5", actResult);
        }

        [Test]
        public void CheckAskQuestionButton()
        {
            driver.Url = Urls.contactsPage;
            IWebElement askQuestionButton = driver.FindElement(By.XPath(contactsModel.contactsAskQuestionButtonXPath));
            string actResult = askQuestionButton.Text;
            Assert.AreEqual("ЗАДАТЬ ВОПРОС", actResult);
        }


    }
}
