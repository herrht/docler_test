using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace docler_test.PageObjects
{
    class HomePage : CommonPage
    {
        private IWebDriver driver;
        private String UniqueString = "/";

        [FindsBy(How = How.Id, Using = "")]
        public IWebElement Element { get; set; }

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public String GetUniqueString()
        {
            return UniqueString;
        }
    }
}
