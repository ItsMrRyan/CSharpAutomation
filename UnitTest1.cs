using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace c_
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestAgeRange()
        {
            driver.Url = "http://automationpractice.com/index.php";
            IWebElement logo = driver.FindElement(By.Id("header_logo"));
            string LogoID = logo.GetAttribute("header_logo");
            Assert.

        [OneTimeTearDown]
        public void Close(){
            //driver.Close()
        }
    }
}