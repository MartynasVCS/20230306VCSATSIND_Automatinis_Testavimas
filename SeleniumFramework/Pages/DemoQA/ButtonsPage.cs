using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class ButtonsPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/buttons");
        }

        public static void DoubleClickButton()
        {
            Common.DoubleClickElement("//*[@id='doubleClickBtn']");
        }

        public static string GetDoubleClickActionResult()
        {
            return Common.GetElementText("//*[@id='doubleClickMessage']");
        }
    }
}
