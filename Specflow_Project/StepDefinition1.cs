using System;
using System.Configuration;
using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;
using OpenQA.Selenium;
using Specflow_Project.PageObjects;
using TechTalk.SpecFlow;

namespace Specflow_Project
{
    [Binding]
    public sealed class StepDefinition1 
    {
        IWebDriver driver = null;
        OctopusHomepage page = new OctopusHomepage();
        
        [Given(@"I am on Octopus Investments Homepage of website")]
        public void GivenIAmOnOctopusInvestmentsHomepageOfWebsite()
        {
            Browser.Current.Navigate().GoToUrl(ConfigurationManager.AppSettings["seleniumBaseUrl"]);

        }

        [When(@"I click on About Us")]
        public void WhenIClickOnAboutUs()
        {
            page.OpenAboutUs();
        }

        [When(@"I click on View our People button")]
        public void WhenIClickOnViewOurPeopleButton()
        {
            OctopusAboutUspage openpeopelepage = new OctopusAboutUspage();
            openpeopelepage.OpenPeoplePage();
        }

        [Then(@"I am presented with our people")]
        public void ThenIAmPresentedWithOurPeople()
        {
            OctopusPeoplePage peoplePage = new OctopusPeoplePage();
            Console.WriteLine(peoplePage.pageTitle(Configurations.PropertiesCollection.driver)); 
        }

    }
}
