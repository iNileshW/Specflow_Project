using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Specflow_Project.Control_Libs
{
    class SetMethods
    {

        //Enter Text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        //Click
        public static void Click(IWebElement element)
        {
            element.Click();
        }

        //Select Dropdown
        public static void Selectddl(IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
