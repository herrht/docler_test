using System;
using TechTalk.SpecFlow;

namespace docler_test.StepDefinitions
{
    [Binding]
    public class PageAppearanceSteps
    {
        [When(@"I am on the ""(.*)""")]
        public void WhenIAmOnThe(string p0)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: WhenIAmOnThe - String");
        }
        
        [Then(@"The ""(.*)"" should be visible")]
        public void ThenTheShouldBeVisible(string p0)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenTheShouldBeVisible - String");
        }
        
        [Then(@"The ""(.*)"" should be ""(.*)""")]
        public void ThenTheShouldBe(string p0, string p1)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenTheShouldBe - String");
        }
        
        [Then(@"The ""(.*)"" should turn to active status")]
        public void ThenTheShouldTurnToActiveStatus(string p0)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenTheShouldTurnToActiveStatus - String");
        }
        
        [Then(@"The text should be visible in ""(.*)"": ""(.*)""")]
        public void ThenTheTextShouldBeVisibleIn(string p0, string p1)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenTheTextShouldBeVisibleIn - String");
        }
    }
}
