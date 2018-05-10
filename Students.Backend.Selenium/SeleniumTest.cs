using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;

namespace Students.Backend.Selenium
{
    [TestClass]
    public class SeleniumTest
    {
        private IWebDriver firefox;
        private IWebDriver chrome;
        [TestInitialize]
        public void Init()
        {
            chrome = new ChromeDriver();
            firefox = new FirefoxDriver();
        }

        [TestMethod]
        public void SeleniumGetAllTests()
        {
            chrome.Url = "http://localhost:5000/api/Student";
            firefox.Url = "http://localhost:5000/api/Student";
        }

    }
}
