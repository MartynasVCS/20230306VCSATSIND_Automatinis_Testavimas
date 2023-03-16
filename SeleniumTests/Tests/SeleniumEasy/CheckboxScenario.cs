using NUnit.Framework;
using SeleniumFramework.Pages.SeleniumEasy;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests.SeleniumEasy
{
    internal class CheckboxScenario : BaseTest
    {
        [Test]
        public void ClickMultipleCheckboxes()
        {
            string expectedButtonText = "Uncheck All";

            BasicCheckboxDemoPage.Open();
            BasicCheckboxDemoPage.ClickAllCheckboxes();
            string actualButtonText = BasicCheckboxDemoPage.GetButtonText();
            
            Assert.AreEqual(expectedButtonText, actualButtonText);
        }
    }
}
