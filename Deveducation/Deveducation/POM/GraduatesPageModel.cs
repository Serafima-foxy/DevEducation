using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class GraduatesPageModel
    {
        public By ourGraduatesLabel = By.TagName("h1");

        private IWebDriver _driver;
        IWebElement gaduatesLabel;

        public GraduatesPageModel(IWebDriver driver)
        {
            this._driver = driver;
        }

        public GraduatesPageModel FindGraduatesLabel()
        {
            gaduatesLabel = _driver.FindElement(ourGraduatesLabel);
            return this; // вернуть этот же класс
        }

        public string GetTextFromMainLabel()
        {
            return gaduatesLabel.Text;
        }
    }
}
