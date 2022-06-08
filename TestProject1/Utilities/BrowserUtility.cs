

namespace TestProject1.Utilities
{
    public class BrowserUtility
    {
        public IWebDriver Init(IWebDriver driver)
        {
           driver =  new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://pl-pl.facebook.com/";
            return driver;
        }
    }
}
