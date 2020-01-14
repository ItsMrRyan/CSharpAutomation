using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;

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
            Thread.Sleep(50);
            Assert.IsTrue(driver.FindElement(By.Id("header_logo")).Displayed);
        }

        [OneTimeTearDown]
        public void Close(){
            driver.Close();
        }
    }
}