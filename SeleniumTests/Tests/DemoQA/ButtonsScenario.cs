using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests.DemoQA
{
    internal class ButtonsScenario : BaseTest
    {
        [Test]
        public void DoubleClickButton()
        {
            string expectedResult = "You have done a double click";

            ButtonsPage.Open();
            ButtonsPage.DoubleClickButton();
            string actualResult = ButtonsPage.GetDoubleClickActionResult();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
