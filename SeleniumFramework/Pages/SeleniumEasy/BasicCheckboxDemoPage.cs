namespace SeleniumFramework.Pages.SeleniumEasy
{
    public class BasicCheckboxDemoPage
    {
        private static string checkboxMultipleLocator = "//*[@class='cb1-element']";
        private static string buttonMultipleCheckboxLocator = "//*[@id='check1']";

        public static void Open()
        {
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        public static void ClickAllCheckboxes()
        {
            Common.ClickElements(checkboxMultipleLocator);
        }

        public static string GetButtonText()
        {
            return Common.GetElementAttributeValue(buttonMultipleCheckboxLocator, "value");
        }

    }
}
