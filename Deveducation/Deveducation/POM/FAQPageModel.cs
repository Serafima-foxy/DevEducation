using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class FAQPageModel
    {
        public By FAQLabel = By.TagName("h1");

        private IWebDriver _driver;
        IWebElement faqLabelElement;

        public FAQPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public FAQPageModel FindMainLabel()
        {
            faqLabelElement = _driver.FindElement(FAQLabel);
            return this;
        }
        public string GetTextFromLabel()
        {
            return faqLabelElement.Text;
        }
    }
}
