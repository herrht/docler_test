using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace docler_test.PageObjects
{
    class NavigationBar : CommonPage
    {
        // --- Elements ---------------------------- //
        [FindsBy(How = How.Id, Using = "navbar")]
        public IWebElement NavigationBarElement { get; set; }

        [FindsBy(How = How.Id, Using = "home")]
        public IWebElement HomeButton { get; set; }

        [FindsBy(How = How.Id, Using = "form")]
        public IWebElement FormButton { get; set; }

        [FindsBy(How = How.Id, Using = "error")]
        public IWebElement ErrorButton { get; set; }
        
        [FindsBy(How = How.Id, Using = "site")]
        public IWebElement UiTestingButton { get; set; }

        // --- Variables --------------------------- //
        private IWebDriver driver;

        // --- Constructor ------------------------- //
        public NavigationBar(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        // --- Functions --------------------------- //
        public Boolean IsTheNavBarDisplayed()
        {
            return NavigationBarElement.Displayed;
        }

        public CommonPage ClickOnButton(String button)
        {
            if (String.Equals(button, "Home"))
            {
                HomeButton.Click();
                return new HomePage(driver);    
            }
            else if (String.Equals(button, "Form"))
            {
                FormButton.Click();
                return new FormPage(driver);
            }
            else if (String.Equals(button, "UI Testing"))
            {
                UiTestingButton.Click();
                return new HomePage(driver);
            }
            else if (String.Equals(button, "error"))
            {
                ErrorButton.Click();
                return new ErrorPage(driver);
            }
            else
            {   return new CommonPage();   }
        }

    }
}
