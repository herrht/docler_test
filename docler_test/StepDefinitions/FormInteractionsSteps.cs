using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using docler_test.PageObjects;


namespace docler_test.StepDefinitions
{
    [Binding]
    public class FormInteractionsSteps
    {
        public IWebDriver driver;
        FormPage FormPageInstance;
        HelloPage HelloPageInstance;

        [Given(@"I am on the form page")]
        public void GivenIAmOnTheFormPage()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            FormPageInstance = new FormPage(driver);
            FormPageInstance.OpenFormPage();
        }

        [When(@"I type ""(.*)"" in the input field")]
        public void WhenITypeInTheInputField(string name)
        {
            FormPageInstance.InputField.SendKeys(name);
        }

        [When(@"Click on the submit button")]
        public void WhenClickOnTheSubmitButton()
        {
            HelloPageInstance = FormPageInstance.ClickOnSubmitButton();
        }

        [Then(@"I should be redirected to the Hello page")]
        public void ThenIShouldBeRedirectedToTheHelloPage()
        {
            Assert.IsTrue(driver.Url.Contains(HelloPageInstance.GetUniqueString()));
        }

        [Then(@"A ""(.*)"" text should appear")]
        public void ThenATextShouldAppear(string welcome)
        {
            Assert.IsTrue(HelloPageInstance.HelloText().Contains(welcome));
        }

        [AfterScenario]
        [Scope(Feature = "FormInteractions")]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }

    }
}
