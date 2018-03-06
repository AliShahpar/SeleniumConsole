using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading.Tasks;



namespace ConsoleApplication1
{
    class TestCase1
    {
        private IWebDriver driver;
        private MainPage_PageAction mainpageactionObject;

        // constructor 
        public TestCase1()
        {
            ChromeOptions options = new ChromeOptions();
            options.EnableMobileEmulation("iPhone 6");
            driver = new ChromeDriver(options); 
            mainpageactionObject = new MainPage_PageAction();
        }

        // this is a Test Case which would perform some operations
        public void TestCaseMainPage()
        {
            driver.Navigate().GoToUrl("https://m.ediblearrangements.com/?showteststore=1");
            Task.Delay(2000).Wait();
            mainpageactionObject.SearchArrangement(driver, "4073");
        }

    }
}
