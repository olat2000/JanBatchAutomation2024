using OpenQA.Selenium;

namespace JanuaryBatchAutoTest.ReusableMethods;

public class DriverMethods
{
    public IWebElement FindMyConsentElement(IWebDriver driver, string locator)
    {
        IWebElement ele = driver.FindElement(By.XPath(locator));
        ele.Click();
        return ele;
    }

    public void FindMyElement(IWebDriver driver, string by, string locator, string value) 
    {
        if (by == "Id")
        {
            driver.FindElement(By.Id(locator)).SendKeys(value);
        }
        else if (by == "Css")
        {
            driver.FindElement(By.CssSelector(locator)).SendKeys(value);
        }
    }
    
    public IWebElement FindAndClickElement(IWebDriver driver, string locator)
    {
        IWebElement element = driver.FindElement(By.CssSelector(locator));
        element.Click();
        return element;
    }
    
    //public IWebElement FindMyElement3(IWebDriver driver, string locator)
    //{
    //    return driver.FindElement(By.CssSelector(locator));

    //}
}

