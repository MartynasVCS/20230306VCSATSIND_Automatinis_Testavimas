namespace SeleniumFramework.Pages.Google
{
    public class HomePage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.google.com");
        }

        public static void ClickSearchButton()
        {
            string locator = "(//*[@value='„Google“ paieška'])[2]";
            Common.ClickElement(locator);
        }

        public static void EnterSearchPhrase(string phrase)
        {
            string locator = "//*[@title='Ieškoti']";
            Common.SendKeys(locator, phrase);
        }

        public static void RejectAllCookies()
        {
            string locator = "//*[text()='Atmesti viską']/..";
            Common.ClickElement(locator);
        }
    }
}
