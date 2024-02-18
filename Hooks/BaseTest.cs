//using JanuaryBatchAutoTest.Enums;
//using JanuaryBatchAutoTest.ObjectRepository;
//using JanuaryBatchAutoTest.ReusableMethods;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Edge;
//using OpenQA.Selenium.Firefox;
//using static JanuaryBatchAutoTest.Enums.browserTypes;

////Inline
//namespace JanuaryBatchAutoTest.Hooks;

//public static class Url
//{
//    public static string urlName = "https://demoqa.com/login";
//}

//public class BaseTest : Objects
//{
//    string url = "https://demoqa.com/login";

//    //Objects objects = new Objects();

//    [SetUp]
//    public void Setup()
//    {
//        //IWebDriver driver = new ChromeDriver(MaximizeChromeBrowser());

//        CustomMethods customMethods = new CustomMethods();

//        driver = ChooseBrowser(browserType.Edge);
//        //driver = new ChromeDriver(new CustomMethods().MaximizeChromeBrowser());
//        //driver.Manage().Window.Maximize();
//        driver.Navigate().GoToUrl(url);
//        driver.Manage().Cookies.DeleteAllCookies();
//        driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
//    }

//Traditional If Statement
//    public IWebDriver ChooseBrowser(browserType browserType)
//    {
//        if (browserType == browserType.Chrome)
//        {
//            driver = new ChromeDriver(new CustomMethods().MaximizeChromeBrowser());
//        }
//        else if (browserType == browserType.Firefox)
//        {
//            driver = new FirefoxDriver();
//            driver.Manage().Window.Maximize();
//        }
//        else if (browserType == browserType.Edge)
//        {
//            driver = new EdgeDriver();
//            driver.Manage().Window.Maximize();
//        }
//        return driver;
//    }

//    [TearDown]
//    public void Teardown()
//    {
//        if (driver != null)
//        {
//            driver.Quit();
//        }

//    }

//}
