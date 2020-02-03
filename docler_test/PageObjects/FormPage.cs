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
        // --- Elements ---------------------------- //
        [FindsBy(How = How.Id, Using = "hello-input")]
        public IWebElement InputField { get; set; }

        [FindsBy(How = How.Id, Using = "hello-submit")]
        public IWebElement SubmitButton { get; set; }
        
        [FindsBy(How = How.Id, Using = "hello-form")]
        public IWebElement HelloForm { get; set; }

        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement LogoElement { get; set; }
        
        [FindsBy(How = How.Id, Using = "form")]
        public IWebElement FormButton { get; set; }

        // --- Variables --------------------------- //
        private IWebDriver driver;
        private String UniqueString = "/form.html";
        public IWebElement FormButtonParent;

        // --- Constructor ------------------------- //
        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        // --- Functions --------------------------- //
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
        override public Boolean IsTheLogoVisible()
        {
            return LogoElement.Displayed;
        }
        public Boolean IsTheFormVisible()
        {
            return HelloForm.Displayed;
        }
        public Boolean IsTheInputFieldVisible()
        {
            return InputField.Displayed;
        }
        public Boolean IsTheSubmitButtonVisible()
        {
            return SubmitButton.Displayed;
        }
        override public Boolean IsButtonActive()
        {
            FormButtonParent = FormButton.FindElement(By.XPath("./.."));
            String className = FormButtonParent.GetAttribute("class");
            return String.Equals("active", className);
        }
    }
}
