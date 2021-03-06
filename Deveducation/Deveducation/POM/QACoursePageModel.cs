﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class QACoursePageModel
    {
        public By qaLabel = By.TagName("h1");

        private IWebDriver _driver;
        IWebElement qaCourseslabelElement;

        public QACoursePageModel(IWebDriver driver)
        {
            this._driver = driver;
        }

        public QACoursePageModel FindQACoursesLabel()
        {
            qaCourseslabelElement = _driver.FindElement(qaLabel);
            return this;
        }
        public string GetTextFromLabel()
        {
            return qaCourseslabelElement.Text;
        }
    }
}
