using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Threading;

namespace SeleniumFramework
{
    public class Driver
    {
        private static string browser = TestContext.Parameters["browser"];
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void SetupDriver()
        {
            switch(browser)
            {
                case "chrome":
                    ChromeOptions options = new ChromeOptions();
                    options.AddArgument("--ignore-certificate-errors");
                    options.AddArgument("--headless"); // Run in headless mode, i.e., without a UI or display server dependencies.
                    //options.AddArgument("--start-maximized"); // Starts the browser maximized, regardless of any previous settings.
                    //options.AddArgument("--window-size=1920,1080"); // Sets the initial window size. Provided as string in the format "800,600".
                    driver.Value = new ChromeDriver(options);
                    break;
                case "firefox":
                    driver.Value = new FirefoxDriver();
                    break;
                default:
                    driver.Value = new ChromeDriver();
                    break;
            }
        }

        public static void SetupDriver(string userDataDir, string profileDir)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"--user-data-dir={userDataDir}");
            options.AddArgument($"--profile-directory={profileDir}");
            driver.Value = new ChromeDriver(options);
        }

        public static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        public static void OpenUrl(string url)
        {
            driver.Value.Url = url;
        }

        public static void CloseDriver()
        {
            driver.Value.Quit();
        }

        public static string TakeScreenshot(string methodName)
        {
            string screenshotDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff")}";
            string screenshotFilePath = $"{screenshotDirectoryPath}\\{screenshotName}.png";

            Directory.CreateDirectory(screenshotDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
            return screenshotFilePath;
        }
    }
}
