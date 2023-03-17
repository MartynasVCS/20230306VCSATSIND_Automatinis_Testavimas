using NUnit.Framework;
using SeleniumFramework.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Tests.DemoQA
{
    internal class AlertScenario : BaseTest
    {
        [Test]
        public void SimpleAlert()
        {
            AlertsPage.Open();
            AlertsPage.ClickFirstButton();
            bool isAlertPresent = AlertsPage.IsAlertPresent();
            Assert.True(isAlertPresent);

            AlertsPage.AcceptAlert();
            isAlertPresent = AlertsPage.IsAlertPresent();
            Assert.False(isAlertPresent);
        }

        [Test]
        public void ConfirmationAlert()
        {
            string expectedAcceptedMessage = "You selected Ok";
            string expectedRejectedMessage = "You selected Cancel";

            AlertsPage.Open();
            AlertsPage.ClickThirdButton();
            AlertsPage.AcceptAlert();
            string actualMessage = AlertsPage.GetConfirmationAlertMessage();
            Assert.AreEqual(expectedAcceptedMessage, actualMessage);

            AlertsPage.ClickThirdButton();
            AlertsPage.DismissAlert();
            actualMessage = AlertsPage.GetConfirmationAlertMessage();
            Assert.AreEqual(expectedRejectedMessage, actualMessage);
        }

        [Test]
        public void PromtAlert()
        {
            string name = "Petras";
            string expectedOutput = $"You entered {name}";

            AlertsPage.Open();
            AlertsPage.ClickFourthButton();
            AlertsPage.EnterNameToAlert(name);
            AlertsPage.AcceptAlert();
            string actualOutput = AlertsPage.GetPromptAlertMessage();
            Assert.AreEqual(expectedOutput, actualOutput);

            AlertsPage.ClickFourthButton();
            AlertsPage.EnterNameToAlert(name);
            AlertsPage.DismissAlert();
            Assert.False(AlertsPage.IsPromptAlertMessagePresent());

            AlertsPage.ClickFourthButton();
            AlertsPage.AcceptAlert();
            Assert.False(AlertsPage.IsPromptAlertMessagePresent());
        }
    }
}
