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
        NavigationBar NavigationBarInstance;

        [Given(@"The navigation bar is visible")]
        public void GivenTheNavigationBarIsVisible()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            NavigationBarInstance = new NavigationBar(driver);
            Assert.IsTrue(NavigationBarInstance.IsTheNavBarDisplayed());
        }

        [When(@"I click on the ""(.*)""")]
        public void WhenIClickOnThe(string button)
        {
            CommonPageInstance = NavigationBarInstance.ClickOnButton(button);
        }

        [Then(@"I should get navigated to the ""(.*)""")]
        public void ThenIShouldGetNavigatedToThe(string newPage)
        {
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
            Assert.IsTrue((((ErrorPage)CommonPageInstance).VerifyErrorMessage()));
        }

        [AfterScenario]
        [Scope(Feature = "PageNavigation")]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }

    }
}
