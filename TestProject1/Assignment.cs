using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace TestProject1
{
    [TestFixture]
    public class Assignment
    {
        [Test]
        public void login()
        {
           
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "invoicesmash-staging.com/logon";
            IWebElement EmailElement=driver.FindElement(By.XPath(".//*[@class='form-control ng-isolate-scope ng-valid-email ng-valid-maxlength ng-dirty ng-valid ng-valid-required ng-touched'"));
            EmailElement.SendKeys("abhikrant@gmail.com");
            IWebElement PasswordElement = driver.FindElement(By.XPath(".//*[@class='form-control ng-isolate-scope ng-dirty ng-valid-parse ng-valid ng-valid-required ng-touched']"));
            PasswordElement.SendKeys("123123123");
            IWebElement loginButton = driver.FindElement(By.XPath(".//*[@class='btn btn-lg btn-primary btn-block']"));
            loginButton.Click();
        //    Thread.Sleep(5000);
            Thread.Sleep(5000);
            IWebElement userSession = driver.FindElement(By.XPath(".//*[@href='/AppAdmin/Admin/TakeOverUserSession']"));
            userSession.Click();
            Thread.Sleep(2000);
            IWebElement subscriptionElement = driver.FindElement(By.XPath(".//*[@class='chosen-single chosen-default']"));
            subscriptionElement.Click();
            IWebElement instanceELement = driver.FindElement(By.XPath(".//*[@class='chosen-search']"));
            instanceELement.SendKeys("invoice-smash-master.coupadev.com");
            IWebElement takeOverButton = driver.FindElement(By.XPath(".//*[@class='btn btn-primary']"));
            takeOverButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@class='navbar-brand']")));

            IWebElement homeElement = driver.FindElement(By.XPath(".//*[@href='/Account/ISAdmin']"));
            homeElement.Click();
            Thread.Sleep(2000);
            driver.Close();


                 
        
        
        }
    }
}
