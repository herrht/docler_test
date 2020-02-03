using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium; //until PageObjects are created
using OpenQA.Selenium.Chrome; //until PageObjects are created
using NUnit.Framework;


namespace docler_test.StepDefinitions
{
    [Binding]
    public class FormInteractionsSteps
    {
        public IWebDriver driver; //until PageObjects are created

        [Given(@"I am on the ""(.*)""")]
        public void GivenIAmOnThe(string page)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: GivenIAmOnThe - String");
            driver = new ChromeDriver();
            driver.Url = "http://uitest.duodecadits.com"+page;
            Assert.IsTrue(driver.Url.EndsWith(page));
        }

        [When(@"I type ""(.*)"" in the ""(.*)""")]
        public void WhenITypeInThe(string name, string input_field)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: WhenITypeInThe - String");
            driver.FindElement(By.Id(input_field)).SendKeys(name);
        }

        [When(@"Click on the ""(.*)""")]
        public void WhenClickOnThe(string submit_button)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: WhenClickOnThe - String");
            driver.FindElement(By.Id(submit_button)).Click();
        }

        [Then(@"I should be redirected to the ""(.*)""")]
        public void ThenIShouldBeRedirectedToThe(string hello_page)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenIShouldBeRedirectedToThe - String");
            Assert.IsTrue(driver.Url.Contains(hello_page));
        }

        [Then(@"A ""(.*)"" text should appear")]
        public void ThenATextShouldAppear(string welcome)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenATextShouldAppear - String");
            Assert.IsTrue(driver.PageSource.Contains(welcome));
        }
    }
}
