using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SiteTest
{
    public class Tests
    {
        IWebDriver drw;
        [SetUp]
        public void Setup()
        {
            drw = new ChromeDriver();
            drw.Url = "https://www.globalsqa.com/angularJs-protractor/SimpleCalculator/";
        }
        [TearDown]
        public void TearDown()
        {
            drw.Quit();
        }

        [Test]
        public void Test1()
        {
            var x = new SimpleCalcPage(drw);
            x.Clics();
        }
        [Test]
        public void Test2()
        {
            var x = new SimpleCalcPage(drw);
            x.AddData();
        }
        [Test]
        public void Test3()
        {
            var x = new SimpleCalcPage(drw);
            x.ChangeOperation();
        }
    }
}