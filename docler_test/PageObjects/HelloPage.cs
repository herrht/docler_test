using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace docler_test.PageObjects
{
    class HelloPage : CommonPage
    {
        // --- Elements ---------------------------- //
        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement LogoElement { get; set; }

        [FindsBy(How = How.Id, Using = "hello-text")]
        public IWebElement HelloTextElement { get; set; }

        // --- Variables --------------------------- //
        private IWebDriver driver;
        private String uniqueString = "/hello.html";

        // --- Constructor ------------------------- //
        public HelloPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        // --- Functions --------------------------- //
        public String GetCurrentUrl()
        {
            return driver.Url;
        }

        public String GetUniqueString()
        {
            return uniqueString;
        }

        public String HelloText()
        {
            return HelloTextElement.Text;
        }

        override public Boolean IsTheLogoVisible()
        {
            return LogoElement.Displayed;
        }
    }
}
