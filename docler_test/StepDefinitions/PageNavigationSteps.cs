using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using docler_test.PageObjects;


namespace docler_test.StepDefinitions
{
    [Binding]
    public class PageNavigationSteps
    {
        public IWebDriver driver;
        CommonPage CommonPageInstance;
        HomePage HomePageInstance;
        FormPage FormPageInstance;
        ErrorPage ErrorPageInstance;
        NavigationBar NavigationBarInstance;

        [Given(@"The navigation bar is visible")]
        public void GivenTheNavigationBarIsVisible()
        {
            /*
            driver = new ChromeDriver();
            driver.Url = "http://uitest.duodecadits.com/";
            Assert.IsTrue(driver.FindElement(By.Id("navbar")).Displayed); //use string variable here
            */
            driver = new ChromeDriver();
            driver.Url = "http://uitest.duodecadits.com/";
            NavigationBarInstance = new NavigationBar(driver);
            Assert.IsTrue(NavigationBarInstance.IsTheNavBarDisplayed());
        }

        [When(@"I click on the ""(.*)""")]
        public void WhenIClickOnThe(string button)
        {
            //driver.FindElement(By.Id(button)).Click();
            CommonPageInstance = NavigationBarInstance.ClickOnButton(button);
        }

        [Then(@"I should get navigated to the ""(.*)""")]
        public void ThenIShouldGetNavigatedToThe(string newPage)
        {
            //Assert.IsTrue(driver.Url.EndsWith(urlEnd));

            if (String.Equals(newPage, "Home"))
            {
                System.Console.WriteLine("You have navigated to the Home Page");
                Assert.IsTrue(driver.Url.Contains(((HomePage)CommonPageInstance).GetUniqueString()));
            }
            else if (String.Equals(newPage, "Form"))
            {
                System.Console.WriteLine("You have navigated to the Form Page");
                Assert.IsTrue(driver.Url.Contains(((FormPage)CommonPageInstance).GetUniqueString()));
            }
            else if (String.Equals(newPage, "UI Testing"))
            {
                System.Console.WriteLine("You have navigated to the Home Page");
                Assert.IsTrue(driver.Url.Contains(((HomePage)CommonPageInstance).GetUniqueString()));
            }
            else
            {
                System.Console.WriteLine("Invalid Page");
                Assert.Fail(); 
            }
        }

        [Then(@"I should get an error response code")]
        public void ThenIShouldGetAnErrorResponseCode()
        {
            //Assert.IsTrue(driver.PageSource.Contains("404 Error"));
            Assert.IsTrue((((ErrorPage)CommonPageInstance).VerifyErrorMessage()));
        }

    }
}
