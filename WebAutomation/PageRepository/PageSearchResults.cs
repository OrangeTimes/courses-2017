using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using OpenQA.Selenium;

namespace WebAutomation.PageRepository
{
	public class PageSearchResults
	{
		public ReadOnlyCollection<IWebElement> SearchResultHeaders => WebDriver.GetInstance()
			.FindElements(By.XPath("//div/h3/a"));

		public string[] GetResults()
		{
			 return SearchResultHeaders
				.Select(x => x.Text)
				.Where(y => y.Any()).ToArray();
		}
	}
}