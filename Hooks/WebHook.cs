using JanuaryBatchAutoTest.ObjectRepository;
using JanuaryBatchAutoTest.ReusableMethods;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using static JanuaryBatchAutoTest.Enums.browserTypes;

//Inline
namespace JanuaryBatchAutoTest.Hooks;

public class WebHook : Objects
{
    [SetUp]
    public void Setup()
    {
        driver = ChooseBrowser(browserType.Chrome);
        driver.Navigate().GoToUrl(Environment.url);
        driver.Manage().Cookies.DeleteAllCookies();
        driver.Manage().Timeouts().ImplicitWait = 
            TimeSpan.FromSeconds(double.Parse(Environment.Timeout));
        driver.Manage().Timeouts().PageLoad = 
            TimeSpan.FromSeconds(double.Parse(Environment.Timeout));
    }

    //Ternary If Statement
    public IWebDriver ChooseBrowser(browserType browserType)
    {
        return browserType == browserType.Chrome
            ? driver = new ChromeDriver(new CustomMethods().MaximizeChromeBrowser())
            : browserType == browserType.Edge
            ? driver = new EdgeDriver()
            : browserType == browserType.Firefox
            ? driver = new FirefoxDriver()
            : throw new Exception("No such browser exist");
    }

    [TearDown]
    public void Teardown()
    {
        if (driver != null)
        {
            driver.Quit();
        }
    }
}
