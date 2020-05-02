using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class BookkeepingPageModel
    {
        public By bookkeepingLabel = By.TagName("h1");

        private IWebDriver _driver;
        IWebElement bookkeepingLabelElement;

        public BookkeepingPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }

        public BookkeepingPageModel FindBookkeepingLabel()
        {
            bookkeepingLabelElement = _driver.FindElement(bookkeepingLabel);
            return this;
        }
        public string GetTextFromLabel()
        {
            return bookkeepingLabelElement.Text;
        }
    }
}
