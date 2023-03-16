using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFramework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void SetupDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--ignore-certificate-errors");
            driver = new ChromeDriver(options);
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenUrl(string url)
        {
            driver.Url = url;
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }
    }
}
