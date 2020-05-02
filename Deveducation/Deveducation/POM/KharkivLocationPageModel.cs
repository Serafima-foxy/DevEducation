using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class KharkivLocationPageModel
    {
        public By kharkivLocationLabel = By.XPath("/html/body/div[1]/div[1]/header/div/div[1]/ul/li[2]/button");
        private IWebDriver _driver;
        IWebElement kharkivLocationElement;

        public KharkivLocationPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }

        public KharkivLocationPageModel FindKharkivLocationLabel()
        {
            kharkivLocationElement = _driver.FindElement(kharkivLocationLabel);
            return this;
        }
        public string GetMainLabelText()
        {
            return kharkivLocationElement.Text;
        }
    }
}
