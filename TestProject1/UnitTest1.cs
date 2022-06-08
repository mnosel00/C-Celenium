
namespace TestProject1
{
    [TestFixture]
    public class Tests:BaseTest
    {
      

        [Test,Category("Smoke testing ")]
        public void Test1()
        {
            
            IWebElement monthDropDownList = driver2.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropDownList);
            element.SelectByIndex(1);
            Thread.Sleep(1000);
            element.SelectByText("wrz");
            Thread.Sleep(1000);
            element.SelectByValue("10");
            Thread.Sleep(1000);
           

        }

        [Test,Category("Regression testing")]
        public void Test2()
        {

            IWebElement email = driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium c#");

        }

        [Test, Category("Smoke testing")]
        public void Test3()
        {

            IWebElement email = driver.FindElement(By.XPath(".//*[@id='email']"));
            email.SendKeys("Selenium c#");
            Thread.Sleep(5000);

        }
    }
}