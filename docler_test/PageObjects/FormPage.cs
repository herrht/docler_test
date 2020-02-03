using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace docler_test.PageObjects
{
    class FormPage : CommonPage
    {
        private IWebDriver driver;
        private String UniqueString = "/form.html";

        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "hello-input")]
        public IWebElement InputField { get; set; }
        
        [FindsBy(How = How.Id, Using = "hello-submit")]
        public IWebElement SubmitButton { get; set; }

        public void OpenFormPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "http://uitest.duodecadits.com/form.html";
        }
        
        public HelloPage ClickOnSubmitButton()
        {
            SubmitButton.Click();
            return new HelloPage(driver);
        }

        public String GetUniqueString()
        {
            return UniqueString;
        }
    }
}
