using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;
using WebDriverManager;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Xml.XPath;
using OpenQA.Selenium.Interactions;
using NUnit.Framework.Internal;

namespace Bluehost
{
    public class BluehostTests
    {
        IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig(),
           VersionResolveStrategy.MatchingBrowser);
            _driver = new ChromeDriver();
        }
        private IWebElement WaitAndFindElement(By by)
        {
            var webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            return webDriverWait.Until(ExpectedConditions.ElementExists(by));
        }


        [Test]
        public void ErrorMessageDisplayed_When_IncorrectCredentalsAreEnter()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            //Cookie cookie = new Cookie("aelastsite", "ul2YpilsJR%2BdxDKTeHgJXr2MOq9WbSBdmDZwLjPdt8KahpegzuxHKM0MvOUYy2ok");
            //_driver.Manage().Cookies.AddCookie(cookie);
            //_driver.Manage().Cookies.DeleteCookie(cookie);
            _driver.Navigate().GoToUrl("https://login.bluehost.com/hosting/webmail");
            _driver.Manage().Window.Maximize();
            var rejectCookie = _driver.FindElement(By.XPath("//button[@id='onetrust-reject-all-handler']"));
            rejectCookie.Click();
            var email = _driver.FindElement(By.XPath("//form//input[@id='email']"));
            email.SendKeys("test@yahoo.com");
            var password = _driver.FindElement(By.XPath("//form//input[@id='password']"));
            password.SendKeys("password");
            Actions act = new Actions(_driver);
            act.MoveToElement(_driver.FindElement(By.XPath("//form//div/following-sibling::input"))).Click().Perform();

            IWebElement searchResult = wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[contains(text(),\"Error\")]")));
            Assert.That(searchResult.Text, Is.EqualTo("Error"));
        }
        [Test]
        public void ErrorMssageDisplayed_When_CredentalsAreNotEnter()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(13));

            _driver.Navigate().GoToUrl("https://login.bluehost.com/hosting/webmail");
            _driver.Manage().Window.Maximize();
            var rejectCookie = _driver.FindElement(By.XPath("//button[@id='onetrust-reject-all-handler']"));
            rejectCookie.Click();
            Actions act = new Actions(_driver);
            act.MoveToElement(_driver.FindElement(By.XPath("//form//div/following-sibling::input"))).Click().Perform();

            IWebElement errorMessage = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'Email is required.')]")));
            Assert.IsTrue(_driver.FindElement(By.XPath("//span[contains(text(),'Email is required')]")).Displayed);
        }
        [TearDown]
        public void close_Browser()
        {
            _driver.Quit();
        }
    }
}