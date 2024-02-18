using JanuaryBatchAutoTest.Enums;
using JanuaryBatchAutoTest.Hooks;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using static JanuaryBatchAutoTest.Enums.browserTypes;
//Outline
namespace JanuaryBatchAutoTest.Tests
{
    public class JanAutoTest : WebHook
    {
        [Test]
        public void Test01()
        {
            driverMethods.FindMyConsentElement(driver,"//*[@class='fc-button fc-cta-consent fc-primary-button']");
            driverMethods.FindMyElement(driver, nameof(locatorType.Id), nameof(labelsType.userName), "TestUser");
            //Thread.Sleep(1000);
            wait(driver).Until(ExpectedConditions.ElementToBeClickable(By.Id("password")));
            driverMethods.FindMyElement(driver, nameof(locatorType.Id), nameof(labelsType.password), "Password01!");
            
            ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0, window.innerHeight / 2)");
            
            wait(driver).Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#login")));
            driverMethods.FindAndClickElement(driver, "#login");
             
            wait(driver).Until(ExpectedConditions.ElementToBeClickable(By.Id("userName-value")));
            IWebElement UserLoggedName = driver.FindElement(By.Id("userName-value"));
            var user = UserLoggedName.Text;

            Assert.That(user.Equals("TestUser"), Is.True); //Nunit Assertion
            //user.Should().Be("TestUser"); //Fluent Assertion
        }
    }
}
