using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium; //until PageObjects are created
using OpenQA.Selenium.Chrome; //until PageObjects are created
using NUnit.Framework;


namespace docler_test.StepDefinitions
{
    [Binding]
    public class PageNavigationSteps
    {
        public IWebDriver driver; //until PageObjects are created

        [Given(@"The ""(.*)"" is visible")]
        public void GivenTheIsVisible(string navigationBar)
        {
            System.Console.WriteLine("Printer: GivenThe - String - IsVisible");
            driver = new ChromeDriver();
            driver.Url = "http://uitest.duodecadits.com/";
            Assert.IsTrue(driver.FindElement(By.Id("navbar")).Displayed); //use string variable here
        }

        [When(@"I click on the ""(.*)""")]
        public void WhenIClickOnThe(string button)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: WhenIClickOnThe - String");
            driver.FindElement(By.Id(button)).Click();
        }

        [Then(@"I should get navigated to the ""(.*)""")]
        public void ThenIShouldGetNavigatedToThe(string urlEnd)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenIShouldGetNavigatedToThe - String");
            Assert.IsTrue(driver.Url.EndsWith(urlEnd));
        }

        [Then(@"I should get an error response code")]
        public void ThenIShouldGetAnErrorResponseCode()
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenIShouldGetAnErrorResponseCode - String");
            Assert.IsTrue(driver.PageSource.Contains("404 Error"));
        }
    }
}
