using System;

namespace SeleniumFramework.Pages.Ignitis
{
    public class HomePage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://ignitis.lt/");
        }

        public static string GetPageTitle()
        {
            return Common.GetPageTitle();
        }
    }
}
