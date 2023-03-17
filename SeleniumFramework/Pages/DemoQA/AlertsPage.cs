using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class AlertsPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/alerts");
        }

        public static void ClickFirstButton()
        {
            Common.ClickElement("//*[@id='alertButton']");
        }

        public static void AcceptAlert()
        {
            Common.AcceptAlert();
        }

        public static bool IsAlertPresent()
        {
            return Common.IsAlertPresent();
        }

        public static void ClickThirdButton()
        {
            Common.ClickElement("//*[@id='confirmButton']");
        }

        public static string GetConfirmationAlertMessage()
        {
            return Common.GetElementText("//*[@id='confirmResult']");
        }

        public static void DismissAlert()
        {
            Common.DismissAlert();
        }

        public static void ClickFourthButton()
        {
            Common.ClickElement("//*[@id='promtButton']");
        }

        public static void EnterNameToAlert(string name)
        {
            Common.SendKeysToAlert(name);
        }

        public static string GetPromptAlertMessage()
        {
            return Common.GetElementText("//*[@id='promptResult']");
        }

        public static bool IsPromptAlertMessagePresent()
        {
            return Common.IsElementPresent("//*[@id='promptResult']");
        }
    }
}
