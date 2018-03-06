using OpenQA.Selenium;
using System;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class MainPage_PageAction
    {
        private MainPage_PageObject mainpageObject = new MainPage_PageObject();

        // this would search the arrangement via catalogId
        public void SearchArrangement(IWebDriver driver, String strvalue)
        {
            driver.FindElement(mainpageObject.searchbox).SendKeys(strvalue);
            Task.Delay(2000).Wait();
            driver.FindElement(mainpageObject.searchbox).SendKeys(Keys.Enter);
        }


        // Click on the close button of the customerRwardDiv
        public void CloseRewardDiv(IWebDriver driver)
        {
            driver.FindElement(mainpageObject.closebtn_custrewardDiv).Click();
        }
    }
}
