using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class DynamicPropertiesPage
    {
        private static string buttonToBeEnabledLocator = "//*[@id='enableAfter']";
        private static string buttonToChangeColorLocator = "//*[@id='colorChange']";
        private static string buttonToBeVisibleLocator = "//*[@id='visibleAfter']";

        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/dynamic-properties");
        }

        public static void WaitForButtonToBeEnabled()
        {
            Common.WaitForElementToBeEnabled(buttonToBeEnabledLocator);
        }

        public static bool IsButtonIsEnabled()
        {
            return Common.GetElementEnabledStatus(buttonToBeEnabledLocator);
        }

        public static string GetButtonTextColor()
        {
            return Common.GetElementCssPropertyValue(buttonToChangeColorLocator, "color");
        }

        public static void WaitForButtonColorToBe(string expectedColor)
        {
            Common.WaitForElementCssPropertyToBe(buttonToChangeColorLocator, "color", expectedColor);
        }

        public static void WaitForButtonToBeVisible()
        {
            Common.WaitForElementToBeVisisble(buttonToBeVisibleLocator);
        }
    }
}
