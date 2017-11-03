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
		//private IWebDriver driver;

		[SetUp]
		public void TestSetup()
		{
			//driver = new InternetExplorerDriver();
		}

		[Test]
		public void GoogleSearch()
		{
			//WebDriver.GetInstance().Navigate().GoToUrl("www.google.com");
			//Assert.AreEqual("www.google.com", driver.Url);
			//StringAssert.Contains("www.google.com", WebDriver.GetInstance().Url);
			//WebDriver.GetInstance().FindElement(By.Name("q")).SendKeys("booking");
			//WebDriver.GetInstance().FindElement(By.Name("q")).SendKeys(Keys.Escape);
			//WebDriver.GetInstance().FindElement(By.Name("btnK")).Click();
			//var googleResultsHeaders = WebDriver.GetInstance().FindElements(By.XPath("//div/h3/a"))
			//	.Select(x => x.Text)
			//	.Where(y => y.Any());
			
			Pages.PageHome.GoTo();
			Pages.PageHome.Search("booking");
			var results = Pages.PageSearchResults.GetResults();
			Assert.AreEqual(8, results.Count());
			// this can fail since Google's  result can change over time
			CollectionAssert.Contains(results, "Booking.com — Вікіпедія");
		}

		
		[TearDown]
		public void TestCleanUp()
		{
			WebDriver.GetInstance().Quit();
		}
	}
}
