using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class KyivLocationPageModel
    {
        public By locationKyivLabel = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/ul/li[2]/button");

        private IWebDriver _driver;
        IWebElement kyivLocationElement;

        public KyivLocationPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }

        public KyivLocationPageModel FindKyivLocationLabel()
        {
            kyivLocationElement = _driver.FindElement(locationKyivLabel);
            return this;
        }
        public string GetMainLabelText()
        {
            return kyivLocationElement.Text;
        }
    }
}
