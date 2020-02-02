using System;
using TechTalk.SpecFlow;

namespace docler_test.StepDefinitions
{
    [Binding]
    public class FormInteractionsSteps
    {
        [Given(@"I am on the ""(.*)""")]
        public void GivenIAmOnThe(string p0)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: GivenIAmOnThe - String");
        }

        [When(@"I type ""(.*)"" in the ""(.*)""")]
        public void WhenITypeInThe(string p0, string p1)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: WhenITypeInThe - String");
        }

        [When(@"Click on the ""(.*)""")]
        public void WhenClickOnThe(string p0)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: WhenClickOnThe - String");
        }

        [Then(@"I should be redirected to the ""(.*)""")]
        public void ThenIShouldBeRedirectedToThe(string p0)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenIShouldBeRedirectedToThe - String");
        }

        [Then(@"A ""(.*)"" text should appear")]
        public void ThenATextShouldAppear(string p0)
        {
            //ScenarioContext.Current.Pending();
            System.Console.WriteLine("Printer: ThenATextShouldAppear - String");
        }
    }
}
