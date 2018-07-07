using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Specflow_Project.Control_Libs;
namespace Specflow_Project.PageObjects
{
    class OctopusAboutUspage
    {
        //Constructor:
        public OctopusAboutUspage()
        {
            PageFactory.InitElements(Configurations.PropertiesCollection.driver, this);
        }
        //Octopus View Our People Button
        [FindsBy(How = How.XPath, Using = "//a[@class='arrow-link--purple']")]
        public IWebElement lnkPeople { get; set; }

        //Methods for page:

        //Search Name in text box Display Ascending
        public OctopusPeoplePage OpenAboutUs()
        {
            SetMethods.Click(lnkPeople);
            return new OctopusPeoplePage();
        }

    }
}
