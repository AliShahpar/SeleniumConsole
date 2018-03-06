using OpenQA.Selenium;


namespace ConsoleApplication1
{
    class MainPage_PageObject
    {
        // this is the page definition for the Home Page 

        public By searchbox = By.Id("txtSearch"); 
        public By custrewardDiv = By.Id("divCustomerRewards");
        public By closebtn_custrewardDiv = By.XPath("//*[@id='divCustomerRewards']//*[contains(text(), 'CLOSE')]");
    }
}
