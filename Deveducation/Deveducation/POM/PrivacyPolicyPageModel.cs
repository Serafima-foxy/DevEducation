using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class PrivacyPolicyPageModel
    {
        public By privacyPolicyLabel = By.TagName("h1");

        private IWebDriver _driver;
        IWebElement privacyPolicyElement;

        public PrivacyPolicyPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }
        public PrivacyPolicyPageModel FindMainLabel()
        {
            privacyPolicyElement = _driver.FindElement(privacyPolicyLabel);
            return this;
        }
        public string GetTextFromLabel()
        {
            return privacyPolicyElement.Text;
        }
    }
}
