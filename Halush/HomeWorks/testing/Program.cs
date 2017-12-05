using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using OpenQA.Selenium;


namespace testing
{

    public class Program
    {
        public static void Main()
        {
            IWebDriver Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Navigate().GoToUrl("http://google.com");
            Browser.Manage().Window.Maximize();

            IWebElement SearchField = Browser.FindElement(By.Id("lst-ib"));
            SearchField.SendKeys("Selenium Web Driver" + Keys.Enter);
        }
    }
}
