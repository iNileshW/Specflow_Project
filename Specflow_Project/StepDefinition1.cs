using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Specflow_Project
{
    [Binding]
    public sealed class StepDefinition1 
    {
        //// For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef

        //[Given("I have entered (.*) into the calculator")]
        //public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        //{
        //    //TODO: implement arrange (precondition) logic
        //    // For storing and retrieving scenario-specific data see http://go.specflow.org/doc-sharingdata 
        //    // To use the multiline text or the table argument of the scenario,
        //    // additional string/Table parameters can be defined on the step definition
        //    // method. 

        //    ScenarioContext.Current.Pending();
        //}

        //[When("I press add")]
        //public void WhenIPressAdd()
        //{
        //    //TODO: implement act (action) logic

        //    ScenarioContext.Current.Pending();
        //}

        //[Then("the result should be (.*) on the screen")]
        //public void ThenTheResultShouldBe(int result)
        //{
        //    //TODO: implement assert (verification) logic

        //    ScenarioContext.Current.Pending();
        //}

        IWebDriver driver = null;

        Homepage page = new OctopusHomepage();


        [Given(@"I am on Octopus Investments Homepage of website")]
        public void GivenIAmOnOctopusInvestmentsHomepageOfWebsite()
        {
            browser.Current.Navigate().GoToUrl(Configuration);
        }

        [When(@"I click on About Us")]
        public void WhenIClickOnAboutUs()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on View our People button")]
        public void WhenIClickOnViewOurPeopleButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am presented with our people")]
        public void ThenIAmPresentedWithOurPeople()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
