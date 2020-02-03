using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace docler_test.PageObjects
{
    class ErrorPage : CommonPage
    {
        // --- Elements ---------------------------- //
        [FindsBy(How = How.TagName , Using = "body")]
        public IWebElement ErrorPlace { get; set; }

        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement LogoElement { get; set; }
        
        // --- Variables --------------------------- //
        private IWebDriver driver;
        private readonly String uniqueString = "/error";
        private readonly String ErrorMessage = "404 Error";
        
        // --- Constructor ------------------------- //
        public ErrorPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        // --- Functions --------------------------- //
        public String GetUniqueString()
        {
            return uniqueString;
        }
        public Boolean VerifyErrorMessage()
        {
            if (ErrorPlace.Text.Contains(ErrorMessage))
            { return true; }
            else
            { return false; }            
        }
        override public Boolean IsTheLogoVisible()
        {
            return LogoElement.Displayed;
        }
    }
}
