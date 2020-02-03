using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium; //until PageObjects are created
using OpenQA.Selenium.Chrome; //until PageObjects are created
using NUnit.Framework;


namespace docler_test.StepDefinitions
{
    [Binding]
    public class PageAppearanceSteps
    {
        public IWebDriver driver; //until PageObjects are created

        [When(@"I am on the ""(.*)""")]
        public void WhenIAmOnThe(string page)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: WhenIAmOnThe - String");
            driver = new ChromeDriver();
            driver.Url = "http://uitest.duodecadits.com"+page;
            Assert.IsTrue(driver.Url.EndsWith(page));
        }
        
        [Then(@"The ""(.*)"" should be visible")]
        public void ThenTheShouldBeVisible(string element)
        {
            IWebElement webElement = driver.FindElement(By.Id(element));
            String elementTag = webElement.TagName ;
            if (elementTag.Equals("img"))
            {
                String image_src = webElement.GetAttribute("src");
                StringAssert.Contains("doclerholding.jpg", image_src);
            }
            else if (elementTag.Equals("input"))
            {
                Assert.IsTrue(webElement.Displayed);
            }
        }

        [Then(@"The ""(.*)"" should be ""(.*)""")]
        public void ThenTheShouldBe(string p0, string p1)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenTheShouldBe - String");
        }

        [Then(@"The title should be ""(.*)""")]
        public void ThenTheTitleShouldBe(string title_string)
        {
            String currentTitle = driver.Title;
            Assert.AreEqual(title_string, currentTitle);
        }

        [Then(@"The ""(.*)"" should turn to active status")]
        public void ThenTheShouldTurnToActiveStatus(string button)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenTheShouldTurnToActiveStatus - String");
            IWebElement button_element = driver.FindElement(By.Id(button));
            IWebElement button_parent = button_element.FindElement(By.XPath("./.."));
            String className = button_parent.GetAttribute("class");
            StringAssert.AreEqualIgnoringCase("active", className);
        }
        
        [Then(@"The text should be visible in ""(.*)"": ""(.*)""")]
        public void ThenTheTextShouldBeVisibleIn(string tagType, string textCheck)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenTheTextShouldBeVisibleIn - String");
            IWebElement element = driver.FindElement(By.TagName(tagType));
            String text = element.Text;
            Assert.AreEqual(textCheck, text);
        }
    }
}
