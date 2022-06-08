

namespace TestProject1.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;
        public IWebDriver driver2;

        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://pl-pl.facebook.com/";

            driver2 = new ChromeDriver();
            driver2.Manage().Window.Maximize();
            driver2.Url = "https://www.facebook.com/campaign/landing.php?campaign_id=1547029385&extra_1=s%7Cc%7C360305406920%7Ce%7Cfacebook%20register%7C&placement=&creative=360305406920&keyword=facebook%20register&partner_id=googlesem&extra_2=campaignid%3D1547029385%26adgroupid%3D64438676292%26matchtype%3De%26network%3Dg%26source%3Dnotmobile%26search_or_content%3Ds%26device%3Dc%26devicemodel%3D%26adposition%3D%26target%3D%26targetid%3Dkwd-299018535828%26loc_physical_ms%3D1011367%26loc_interest_ms%3D%26feeditemid%3D%26param1%3D%26param2%3D&gclid=EAIaIQobChMI4IGavOry9wIVZSF7Ch04HwgYEAAYASAAEgKNj_D_BwE";


        }

        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
