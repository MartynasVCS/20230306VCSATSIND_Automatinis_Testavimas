using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class Demo
    {
        [Test]
        public void OpenGoogle()
        {
            string expectedResult = "Hello world! - „Google“ paieška";

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";

            IWebElement buttonCloseCookies = driver.FindElement(By.XPath("//*[text()='Atmesti viską']/.."));
            buttonCloseCookies.Click();

            IWebElement inputSearch = driver.FindElement(By.XPath("//*[@title='Ieškoti']"));
            inputSearch.SendKeys("Hello world!");

            IWebElement buttonSearch = driver.FindElement(By.XPath("(//*[@value='„Google“ paieška'])[2]"));
            buttonSearch.Click();

            string actualResult = driver.Title;
            
            driver.Quit();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
