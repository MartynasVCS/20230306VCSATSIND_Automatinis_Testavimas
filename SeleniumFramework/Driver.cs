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
            //options.AddArgument("--headless"); // Run in headless mode, i.e., without a UI or display server dependencies.
            //options.AddArgument("--start-maximized"); // Starts the browser maximized, regardless of any previous settings.
            //options.AddArgument("--window-size=1920,1080"); // Sets the initial window size. Provided as string in the format "800,600".
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
