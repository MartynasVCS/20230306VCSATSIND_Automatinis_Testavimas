using System;

namespace SeleniumFramework.Pages.DemoQA
{
    public class SelectMenuPage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/select-menu");
        }

        public static void SelectColorInOldStyleSelectMenu(string color)
        {
            Common.SelectOptionByText("//*[@id='oldSelectMenu']", color);
        }

        public static string GetSelectedColorInOldStyleSelectMenu()
        {
            return Common.GetSelectedOption("//*[@id='oldSelectMenu']");
        }

        public static void SelectValueInSelectOneMenu(string value)
        {
            Common.ClickElement("//*[@id='selectOne']");
            Common.ClickElement($"//*[contains(@id,'react-select-3-option') and text()='{value}']");
        }

        public static string GetSelectedValueInSelectOneMenu()
        {
            return Common.GetElementText("//*[@id='selectOne']//*[contains(@class,'singleValue')]");
        }
    }
}
