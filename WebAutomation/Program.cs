using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
namespace WebAutomation
{
	class Program
	{
		static void Main(string[] args)
		{

		}
	}

	[TestFixture]
	public class TestFixture
	{
		private IWebDriver driver;

		[SetUp]
		public void TestSetup()
		{
			driver = new InternetExplorerDriver();
		}

		[Test]
		public void GoogleSearch()
		{
			string[] expectedHeaders =
				{"Booking.com - Готелі"};

			driver.Navigate().GoToUrl("www.google.com");
			//Assert.AreEqual("www.google.com", driver.Url);
			StringAssert.Contains("www.google.com", driver.Url);
			driver.FindElement(By.Name("q")).SendKeys("booking");
			driver.FindElement(By.Name("q")).SendKeys(Keys.Escape);
			driver.FindElement(By.Name("btnK")).Click();
			var googleResultsHeaders = driver.FindElements(By.XPath("//div/h3/a"))
				.Select(x => x.Text)
				.Where(y => y.Any());
			Assert.AreEqual(8, googleResultsHeaders.Count());
			// this can fail since Google's  result can change over time
			CollectionAssert.Contains(googleResultsHeaders, "Booking.com — Вікіпедія");
		}

		
		[TearDown]
		public void TestCleanUp()
		{
			driver.Quit();
		}
	}
}
