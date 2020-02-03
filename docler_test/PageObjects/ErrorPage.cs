using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace docler_test.PageObjects
{
    class ErrorPage : CommonPage
    {
        private IWebDriver driver;
        private String UniqueString = "/error";
        private String ErrorMessage = "404 Error";

        [FindsBy(How = How.TagName , Using = "body")]
        public IWebElement ErrorPlace { get; set; }

        public ErrorPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public String GetUniqueString()
        {
            return UniqueString;
        }

        public bool VerifyErrorMessage()
        {
            if (ErrorPlace.Text.Contains(ErrorMessage))
            { return true; }
            else
            { return false; }            
        }

    }
}
