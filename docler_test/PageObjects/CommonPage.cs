using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace docler_test.PageObjects
{
    class CommonPage// : AbstractPage
    {
        private readonly String baseAddress = "http://uitest.duodecadits.com";

        public String GetBaseAddress()
        {
            return baseAddress;
        }

        virtual public Boolean IsTheLogoVisible()
        { return false; }

        virtual public Boolean IsButtonActive()
        { return false; }
    }
}
