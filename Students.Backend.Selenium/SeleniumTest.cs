using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Opera;

namespace Students.Backend.Selenium
{
    [TestClass]
    public class SeleniumTest
    {
        private IWebDriver opera;
        private IWebDriver chrome;
        [TestInitialize]
        public void Init()
        {
            chrome = new ChromeDriver();
            opera = new OperaDriver();
        }

        [TestMethod]
        public void TestPing()
        {

        }

        [TestMethod]
        public void SeleniumGetAllTests()
        {

        }
    }
}
