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
        // --- Elements ---------------------------- //
        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement LogoElement { get; set; }
        
        [FindsBy(How = How.Id, Using = "home")]
        public IWebElement HomeButton { get; set; }

        [FindsBy(How = How.TagName, Using = "h1")]
        public IWebElement H1Tag { get; set; }

        [FindsBy(How = How.TagName, Using = "p")]
        public IWebElement PTag { get; set; }

        // --- Variables --------------------------- //
        private IWebDriver driver;
        private String UniqueString = "/";
        public IWebElement HomeButtonParent;

        // --- Constructor ------------------------- //
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        
        // --- Functions --------------------------- //
        public String GetUniqueString()
        {
            return UniqueString;
        }

        override public Boolean IsTheLogoVisible()
        {
            return LogoElement.Displayed;
        }

        override public Boolean IsButtonActive()
        {
            HomeButtonParent = HomeButton.FindElement(By.XPath("./.."));
            String className = HomeButtonParent.GetAttribute("class");
            return String.Equals("active", className);
        }

        public Boolean IsTheTextVisible(String tagType, String textCheck)
        {
            if (tagType.Contains("h1"))
            {
                return String.Equals(textCheck, H1Tag.Text);
            }
            else if (tagType.Contains("p"))
            {
                return String.Equals(textCheck, PTag.Text);
            }
            else
            {
                return false;
            }
        }

    }
}
