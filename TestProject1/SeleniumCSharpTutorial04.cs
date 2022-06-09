

namespace TestProject1
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        [Test]
        [Author("Mateusz Nosel 13397", "mateusz.nosel@microsoft.wsei.edu.pl")]
        [Description("Facebook login verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                 driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //driver.Url = "https://pl-pl.facebook.com/";

                driver.Url = urlName;


                IWebElement email = driver.FindElement(By.XPath(".//*[@id='email']"));
                email.SendKeys("Selenium c#");

                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\Mateusz\\OneDrive - Wyższa Szkoła Ekonomii i Informatyki w Krakowie\\Pulpit\\src\\sq.jpeg",ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }
           
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();

            list.Add("https://pl-pl.facebook.com/");
            /*list.Add("https://youtube.com/");
            list.Add("https://gmail.com/");*/
            return list;
        }
    }
}
