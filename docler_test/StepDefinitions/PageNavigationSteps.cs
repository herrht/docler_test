using System;
using TechTalk.SpecFlow;

namespace docler_test.StepDefinitions
{
    [Binding]
    public class PageNavigationSteps
    {
        [Given(@"The ""(.*)"" is visible")]
        public void GivenTheIsVisible(string p0)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: GivenThe - String - IsVisible");
        }
        
        [When(@"I click on the ""(.*)""")]
        public void WhenIClickOnThe(string p0)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: WhenIClickOnThe - String");
        }
        
        [Then(@"I should get navigated to the ""(.*)""")]
        public void ThenIShouldGetNavigatedToThe(string p0)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenIShouldGetNavigatedToThe - String");
        }

        [Then(@"I should get a ""(.*)""")]
        public void ThenIShouldGetA(string p0)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenIShouldGetA - String");
        }
    }
}
