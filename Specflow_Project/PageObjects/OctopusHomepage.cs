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
    class OctopusHomepage
    {
        //Constructor:
        public OctopusHomepage()
        {
            PageFactory.InitElements(Configurations.PropertiesCollection.driver, this);
        }

        //Octopus About Us Link
        [FindsBy(How = How.Id, Using = "menu-item-20")]
        public IWebElement lnkAboutUs { get; set; }

        //Methods for page:

        //Search Name in text box Display Ascending
        public OctopusAboutUspage OpenAboutUs()
        {
            SetMethods.Click(lnkAboutUs);
            return new OctopusAboutUspage();
        }
    }
}
