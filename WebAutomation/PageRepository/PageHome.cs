using OpenQA.Selenium;

namespace WebAutomation.PageRepository
{
	public class PageHome
	{

		private string _url = "www.google.com";

		public string Url => _url;
		public IWebElement TxtSearch => WebDriver.GetInstance().FindElement(By.Name("q"));
		public IWebElement BtnSearch => WebDriver.GetInstance().FindElement(By.Name("btnK"));

		public void GoTo()
		{
			WebDriver.GetInstance().Navigate().GoToUrl(Url);
		}

		public void Search(string booking)
		{
			TxtSearch.SendKeys("booking");
			TxtSearch.SendKeys(Keys.Escape);
			BtnSearch.Click();
		}
	}
}