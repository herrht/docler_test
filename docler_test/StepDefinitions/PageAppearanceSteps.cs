using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using docler_test.PageObjects;


namespace docler_test.StepDefinitions
{
    [Binding]
    public class PageAppearanceSteps
    {
        public IWebDriver driver;
        CommonPage CurrentPage;
        HomePage HomePageInstance;
        FormPage FormPageInstance;
        ErrorPage ErrorPageInstance;
        HelloPage HelloPageInstance;

        [When(@"I am on the ""(.*)""")]
        public void WhenIAmOnThe(string page)
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            if (String.Equals(page, "Home"))
            {
                HomePageInstance = new HomePage(driver);
                driver.Url = HomePageInstance.GetBaseAddress() + HomePageInstance.GetUniqueString();
                CurrentPage = HomePageInstance;
            }
            else if (String.Equals(page, "Form"))
            {
                FormPageInstance = new FormPage(driver);
                driver.Url = FormPageInstance.GetBaseAddress() + FormPageInstance.GetUniqueString();
                CurrentPage = FormPageInstance;
            }
            else if (String.Equals(page, "Error"))
            {
                ErrorPageInstance = new ErrorPage(driver);
                driver.Url = ErrorPageInstance.GetBaseAddress() + ErrorPageInstance.GetUniqueString();
                CurrentPage = ErrorPageInstance;
            }
            else if (String.Equals(page, "Hello"))
            {
                HelloPageInstance = new HelloPage(driver);
                driver.Url = HelloPageInstance.GetBaseAddress() + HelloPageInstance.GetUniqueString();
                CurrentPage = HelloPageInstance;
            }
            else
            {
                System.Console.WriteLine("Invalid Page");
                Assert.Fail();
            }
        }

        [Then(@"The ""(.*)"" should be visible")]
        public void ThenTheShouldBeVisible(string element)
        {
            switch (element)
            {
                case "form":
                    {
                        System.Console.WriteLine("Checking visibility: form");
                        Assert.IsTrue(((FormPage)CurrentPage).IsTheFormVisible());
                        break;
                    }
                case "input field":
                    {
                        System.Console.WriteLine("Checking visibility: input field");
                        Assert.IsTrue(((FormPage)CurrentPage).IsTheInputFieldVisible());
                        break;
                    }
                case "submit button":
                    {
                        System.Console.WriteLine("Checking visibility: submit");
                        Assert.IsTrue(((FormPage)CurrentPage).IsTheSubmitButtonVisible());
                        break;
                    }
                case "company logo":
                    {
                        System.Console.WriteLine("Checking visibility: logo");
                        Assert.IsTrue(CurrentPage.IsTheLogoVisible());
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Invalid Element");
                        Assert.Fail();
                        break;
                    }
            }
        }

        [Then(@"The title should be ""(.*)""")]
        public void ThenTheTitleShouldBe(string title_string)
        {
            String currentTitle = driver.Title;
            Assert.AreEqual(title_string, currentTitle);
        }


        [Then(@"The ""(.*)"" button should turn to active status")]
        public void ThenTheButtonShouldTurnToActiveStatus(string button)
        {
            Assert.IsTrue(CurrentPage.IsButtonActive());
        }
        
        [Then(@"The text should be visible in ""(.*)"": ""(.*)""")]
        public void ThenTheTextShouldBeVisibleIn(string tagType, string textCheck)
        {
            Assert.IsTrue(((HomePage)CurrentPage).IsTheTextVisible(tagType, textCheck));
        }

        [AfterScenario]
        [Scope(Feature = "PageAppearance")]
        public void AfterScenario()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}
