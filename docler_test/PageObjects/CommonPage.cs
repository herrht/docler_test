using System;


namespace docler_test.PageObjects
{
    class CommonPage
    {
        protected readonly String baseAddress = "http://uitest.duodecadits.com";

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
