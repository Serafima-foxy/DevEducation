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

        [Test]
        public void CheckOurContactsLabel()
        {
            contactsModel = new ContactsPageModel(driver);
            driver.Url = Urls.contactsPage;
            string actRes = contactsModel.FindContactsMainLabel().
                                          GetMainLabelText();

            Assert.AreEqual("Наши контакты", actRes);
        }

        [Test]
        public void CheckDniproAdress()
        {
            contactsModel = new ContactsPageModel(driver);
            driver.Url = Urls.contactsPage;
            string actRes = contactsModel.FindDniproCityButton().
                                          ClickOnDniproCityButton().
                                          FindDniproAddress().
                                          GetTextFromDniproAddressBlock();

            Assert.AreEqual("ул.Симферопольская, 17", actRes);
        }

        [Test]
        public void CheckKyivAdress()
        {
            contactsModel = new ContactsPageModel(driver);
            driver.Url = Urls.contactsPage;
            string actRes = contactsModel.FindKyivCityButton().
                                          ClickOnKyivCityButton().
                                          FindKyivAddress().
                                          GetTextFromKyivAddressBlock();

            Assert.AreEqual("ст. метро Васильковская, ул. Сумская,1", actRes);
        }

        [Test]
        public void CheckKharkivAdress()
        {
            contactsModel = new ContactsPageModel(driver);
            driver.Url = Urls.contactsPage;
            string actRes = contactsModel.FindKharkivCityButton().
                                          ClickOnKharkivCityButton().
                                          FindKharkivAddress().
                                          GetTextFromKharkivAddressBlock();

            Assert.AreEqual("ул. Донец Захаржевского, 2,\r\nздание Сбербанка, этаж 5", actRes);
        }

        [Test]
        public void CheckAskQuestionButton()
        {
            contactsModel = new ContactsPageModel(driver);
            driver.Url = Urls.contactsPage;
            string actRes = contactsModel.FindAskQuationButton().
                                          GetTextFromAskQuationButton();

            Assert.AreEqual("ЗАДАТЬ ВОПРОС", actRes);
        }


    }
}
