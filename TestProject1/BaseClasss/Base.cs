using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1.BaseClasss
{
    public class Base
    {
       public IWebDriver driver;
        [SetUp]
        public void open()
        {

             driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com";

        }
        [TearDown]
        public void Close()
        {
            driver.Quit();

        }

    }
}
