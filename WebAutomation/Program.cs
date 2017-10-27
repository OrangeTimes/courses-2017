using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace WebAutomation
{
	class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new InternetExplorerDriver();
			driver.Navigate().GoToUrl("www.google.com");
			driver.FindElement(By.Name("q")).SendKeys("booking");
			driver.FindElement(By.Name("q")).SendKeys(Keys.Escape);
			driver.FindElement(By.Name("btnK")).Click();
			var googleResultsHeaders = driver.FindElements(By.XPath("//div/h3/a"))
														.Select(x => x.Text)
															.Where(y => y.Any());
		}
	}
}
