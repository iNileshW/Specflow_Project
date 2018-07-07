﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using Specflow_Project.Control_Libs;

namespace Specflow_Project.PageObjects
{
    class OctopusPeoplePage
    {

        //Constructor:
        public OctopusPeoplePage()
        {
            PageFactory.InitElements(Configurations.PropertiesCollection.driver,this);
        }

        //Octopus Group Link
        [FindsBy(How = How.XPath, Using = "//a[@id='menu - item - 60']")]
        public IWebElement lnkOctopusgroup { get; set; }

        //Careers link
        [FindsBy(How = How.XPath, Using = "//a[@id='menu - item - 59']")]
        public IWebElement lnkCareers { get; set; }

        //Callus link
        [FindsBy(How = How.ClassName, Using = "call-us_link")]
        public IWebElement lnkCallUs { get; set; }

        //Website Search Textbox
        [FindsBy(How = How.Name, Using = "s")]
        public IWebElement txtwebsearch { get; set; }

        //Website Search Button
        [FindsBy(How = How.ClassName, Using = "search-form_submit")]
        public IWebElement btnWebSearch { get; set; }

        //Website login Button
        [FindsBy(How = How.ClassName, Using = "cta cta--login")]
        public IWebElement btnlogin { get; set; }

        //Decrease font size link
        [FindsBy(How = How.ClassName, Using = "font-switcher_btn-decrease")]
        public IWebElement lnkdecreasefont { get; set; }

        //Current active font link
        [FindsBy(How = How.ClassName, Using = "font-switcher_btn-orig is-active")]
        public IWebElement lnkactivefont { get; set; }

        //Current increase font link
        [FindsBy(How = How.ClassName, Using = "font-switcher_btn-increase")]
        public IWebElement lnkincreasefont { get; set; }
        
        //Homepage image
        [FindsBy(How = How.XPath, Using = "//img[@alt='Octopus Ventures']")]
        public IWebElement imgHomePage { get; set; }

        //Menu - Home Link 
        [FindsBy(How = How.Id, Using = "menu-item-53")]
        public IWebElement lnkmenuHome { get; set; }

        //Menu - Our Products Link 
        [FindsBy(How = How.Id, Using = "menu-item-55")]
        public IWebElement lnkmenuOurProducts { get; set; }

        //Menu - What we invest in Link 
        [FindsBy(How = How.Id, Using = "menu-item-56")]
        public IWebElement lnkwhatweinvestin { get; set; }

        //Menu - Adviser Centre
        [FindsBy(How = How.Id, Using = "menu-item-46")]
        public IWebElement lnkadvisercentre { get; set; }

        //Menu - Contact Us
        [FindsBy(How = How.Id, Using = "menu-item-54")]
        public IWebElement lnkcontactus { get; set; }

        //Scroll Down Link
        [FindsBy(How = How.ClassName, Using = "hero-scroll js-hero-scroll")]
        public IWebElement lnkscrolldown { get; set; }

        //Making Connection Link
        [FindsBy(How = How.ClassName, Using = "row")]
        public IWebElement lnkmakingconnection { get; set; }
        
        //person name search textbox
        [FindsBy(How = How.Name, Using = "search")]
            public IWebElement txtsearch { get; set; }

        //person name search image
        [FindsBy(How = How.XPath, Using = "/html/body/main/section[2]/div/div/div[1]/section/div[2]/form/div[1]/label/span/img")]
        public IWebElement imgsearch { get; set; }
        
        

        //person name sort dropdown
        [FindsBy(How = How.XPath, Using = "//div[@class='jq-selectbox__dropdown']")]
        public IWebElement ddlnamesort { get; set; }

        //BD Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='13']")]
        public IWebElement chkboxBDTeam { get; set; }

        //Client Relations Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='14']")]
        public IWebElement chkboxCRTeam { get; set; }

        //Corporate Development Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='15']")]
        public IWebElement chkboxCDTeam { get; set; }

        //Energy Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='16']")]
        public IWebElement chkboxETeam { get; set; }

        //Institutional Funds Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='17']")]
        public IWebElement chkboxIFTeam { get; set; }

        //Intermediate Capital Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='18']")]
        public IWebElement chkboxICTeam { get; set; }

        //Multi Manager Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='19']")]
        public IWebElement chkboxMMTeam { get; set; }

        //Property Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='20']")]
        public IWebElement chkboxOPTeam { get; set; }

        //Risk & Compliance Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='21']")]
        public IWebElement chkboxRCTeam { get; set; }

        //Sales Support Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='22']")]
        public IWebElement chkboxSSTeam { get; set; }

        //Senior Management Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='23']")]
        public IWebElement chkboxSMTeam { get; set; }

        //Small Companies Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='24']")]
        public IWebElement chkboxSCTeam { get; set; }

        //Specialist Finance Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='25']")]
        public IWebElement chkboxSFTeam { get; set; }

        //Strategic Partnership Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='26']")]
        public IWebElement chkboxSPTeam { get; set; }

        //Tax Efficient Team Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='27']")]
        public IWebElement chkboxTETeam { get; set; }

        //Footer - About Us Link
        [FindsBy(How = How.Id, Using = "menu-item-61")]
        public IWebElement lnkAboutUs { get; set; }

        //Footer - Our Products Link
        [FindsBy(How = How.Id, Using = "menu-item-64")]
        public IWebElement lnkOurProducts { get; set; }

        //Footer - What we invest in Link
        [FindsBy(How = How.Id, Using = "menu-item-65")]
        public IWebElement lnkWhatWeInvestIn { get; set; }

        //Footer - Adviser Centre Link
        [FindsBy(How = How.Id, Using = "menu-item-62")]
        public IWebElement lnkAdviserCentre { get; set; }

        //Footer - Contact Us Link
        [FindsBy(How = How.Id, Using = "menu-item-63")]
        public IWebElement lnkContactUs { get; set; }

        //Footer - Sitemap Link
        [FindsBy(How = How.Id, Using = "menu-item-70")]
        public IWebElement lnkSitemap { get; set; }

        //Footer - T&C Link
        [FindsBy(How = How.Id, Using = "menu-item-2810")]
        public IWebElement lnkTandC { get; set; }

        //Footer - Privacy Policy Link
        [FindsBy(How = How.Id, Using = "menu-item-2809")]
        public IWebElement lnkPPUs { get; set; }

        //Footer - Modern Slavery Act Link
        [FindsBy(How = How.Id, Using = "menu-item-61")]
        public IWebElement lnkMSA { get; set; }

        //Footer - Terms of business Link
        [FindsBy(How = How.Id, Using = "menu-item-61")]
        public IWebElement lnkTermsOfBusiness { get; set; }

        //Footer - Twitter Link
        [FindsBy(How = How.ClassName, Using = "fa fa-twitter")]
        public IWebElement lnkTwitter { get; set; }

        //Footer - Linkedin Link
        [FindsBy(How = How.ClassName, Using = "fa fa-linkedin-square")]
        public IWebElement lnkLinkedin { get; set; }

        //Methods for page:

        //Search Name in text box Display Ascending
        public void fill_display_ascending(string pName)
        {
            SetMethods.EnterText(txtsearch, pName);
            SetMethods.Selectddl(ddlnamesort, "Sort A-Z");
            SetMethods.Click(imgsearch);
        }

        //Search Name in text box Display Descending
        public void fill_display_descending(string pName)
        {
            SetMethods.EnterText(txtsearch, pName);
            SetMethods.Selectddl(ddlnamesort, "Sort Z-A");
            SetMethods.Click(imgsearch);
        }

        public string pageTitle(IWebDriver driver)
        {
            string Title = driver.Title;
            return Title;
        }
    }
}
