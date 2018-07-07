using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Specflow_Project.Control_Libs
{
    class GetMethods
    {

        //Get Text
        public static string GetText(IWebElement element, string value)
        {
            return element.GetAttribute(value);
        }

        //Get Dropdown Text
        public static string GetddlText(IWebElement element, string value)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

        

    }
}
