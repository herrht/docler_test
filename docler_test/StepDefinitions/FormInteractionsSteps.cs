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
            /*
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "http://uitest.duodecadits.com"+page;
            Assert.IsTrue(driver.Url.EndsWith(page));
            */
            driver = new ChromeDriver();
            FormPageInstance = new FormPage(driver);
            FormPageInstance.OpenFormPage();
        }

        [When(@"I type ""(.*)"" in the input field")]
        public void WhenITypeInTheInputField(string name)
        {
            //driver.FindElement(By.Id(input_field)).SendKeys(name);
            FormPageInstance.InputField.SendKeys(name);
        }

        [When(@"Click on the submit button")]
        public void WhenClickOnTheSubmitButton()
        {
            //driver.FindElement(By.Id(submit_button)).Click();
            //FormPageInstance.SubmitButton.Click();

            HelloPageInstance = FormPageInstance.ClickOnSubmitButton();
            //CurrentPage = FormPageInstance.ClickOnSubmitButton();
        }

        [Then(@"I should be redirected to the Hello page")]
        public void ThenIShouldBeRedirectedToTheHelloPage()
        {
            //Assert.IsTrue(driver.Url.Contains(hello_page));
            
            Assert.IsTrue(driver.Url.Contains(HelloPageInstance.GetUniqueString()));
            //Assert.IsTrue(driver.Url.Contains(((HelloPage)CurrentPage).GetUniqueString()));
        }

        [Then(@"A ""(.*)"" text should appear")]
        public void ThenATextShouldAppear(string welcome)
        {
            //Assert.IsTrue(driver.PageSource.Contains(welcome));

            Assert.IsTrue(HelloPageInstance.HelloText().Contains(welcome));
        }
    }
}
