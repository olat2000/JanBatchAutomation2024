using OpenQA.Selenium.Chrome;

namespace JanuaryBatchAutoTest.ReusableMethods
{
    public class CustomMethods
    {
        public ChromeOptions MaximizeChromeBrowser()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("start-maximized", "incognito");
            return options;
        }
    }
}
