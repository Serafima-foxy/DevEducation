using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deveducation.POM
{
    public class MainPageModel
    {
        public string mainLabelTagName = "h1";
        public string courseMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[1]/a";
        public string graduatesMenuButtonXpath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[2]/a";
        public string aboutMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[5]/a";
        public string contactsMenuButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[6]/a";
        public string selectLanguageButtonClassName = "lang-switcher-header-btn";
        public string locationKyivButtonXPath = "/html/body/div[1]/main/section/div/div[2]/div/a[1]/span[2]";
        public string privacyPolicyRefClassName = "ofooter-policy__link";
        public string signUpForCourseButtonXPath = "/html/body/div[1]/main/div[7]/button";
        public string englishLanguageButtonXPath = "/html/body/div[1]/div[1]/header/div/div[1]/ul/li/ul/li[3]/a";
        public string mainLabelInEnglishTagName = "h1";
        public string clicableMapKharkivXPath = "/html/body/div[1]/main/section/div/div[2]/div/a[3]/span[2]";
        public string kharkivLocationLabelXPath = "/html/body/div[1]/div[1]/header/div/div[1]/ul/li[2]/button";
        public string FAQLinkXPath = "/html/body/div[1]/footer/div/nav/ul/li[7]/a";
        public string FAQLabelTafName = "h1";
        public string instagramLinkXPath = "/html/body/div[1]/footer/div/ul/li[3]/a/img";
        public string footerYearClassName = "ofooter-year";


    }
}
