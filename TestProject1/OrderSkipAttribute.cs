


namespace TestProject1
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test,Order(2),Category("OrderSkipAttribute")]
        public void Test1()
        {
            //Assert.Ignore("Defect 12345");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://pl-pl.facebook.com/";
            IWebElement email = driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium c#");
            driver.Close();
        }
       
        [Test, Order(1), Category("OrderSkipAttribute")]
        public void Test3()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Url = "https://pl-pl.facebook.com/";
            IWebElement email = driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium c#");
            driver.Close();
        }

    }
}
