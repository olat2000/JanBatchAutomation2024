using JanuaryBatchAutoTest.ReusableMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace JanuaryBatchAutoTest.ObjectRepository;

public class Objects
{
    public IWebDriver driver;
    public DriverMethods driverMethods = new();
    public WebDriverWait wait(IWebDriver driver) => new(driver, TimeSpan.FromSeconds(20));
}
