using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

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

        public static void SetupDriver(string userDataDir, string profileDir)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"--user-data-dir={userDataDir}");
            options.AddArgument($"--profile-directory={profileDir}");
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

        public static void TakeScreenshot(string methodName)
        {
            string screenshotDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss-fff")}";
            string screenshotFilePath = $"{screenshotDirectoryPath}\\{screenshotName}.png";

            Directory.CreateDirectory(screenshotDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
        }
    }
}
