using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class SignUpButtonFormModel
    {
        public By signUpButtonForm = By.XPath("/html/body/div[1]/main/div[2]/div/div/form/div[6]/button[1]");

        private IWebDriver _driver;

        public SignUpButtonFormModel(IWebDriver driver)
        {
            this._driver = driver;
        }
    }
}
