using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class InspirerPageModel
    {
        public By inspirerLabel = By.TagName("h1");

        private IWebDriver _driver;
        IWebElement inspirerElement;

        public InspirerPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }

        public InspirerPageModel FindInspirerLabel()
        {
            inspirerElement = _driver.FindElement(inspirerLabel);
            return this;
        }
        public string GetTextFromLabel()
        {
            return inspirerElement.Text;
        }
    }
}
