using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using WebDriverManager;

namespace SeleniumDevDocumentationWebDriver
{
    public class SeleniumTests
    {
        IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(),
           VersionResolveStrategy.MatchingBrowser);
            _driver = new ChromeDriver();
        }

        [Test]
        public void CorrectPageLoaded_When_NavigateToGridComponents()
        {
            _driver.Navigate().GoToUrl("https://www.selenium.dev/documentation/en/getting_started");
            _driver.Manage().Window.Maximize();
            _driver.FindElement(By.XPath("//*[@id='m-documentationgrid']")).Click();
            _driver.FindElement(By.XPath("//*[@id='m-documentationgridcomponents']")).Click();

            Assert.That(_driver.Title, Is.EqualTo("Selenium Grid Components | Selenium"));           
        }

        [Test]
        public void CorrectPageLoaded_When_NavigateToGitHubRepo()
        {
            _driver.Navigate().GoToUrl("https://www.selenium.dev/documentation/grid/components/");
            _driver.Manage().Window.Maximize();
            _driver.FindElement(By.XPath("//footer//*[contains(@class,'fab fa-github')] ")).Click();
            
            Assert.That(_driver.Title, Is.EqualTo("Selenium Grid Components | Selenium"));           
        }

        [TearDown]
        public void close_Browser()
        {
            _driver.Quit();
        }

    }
}