using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace WebAutomation
{
	public class WebDriver
	{
		private static IWebDriver _driver;
		private WebDriver()
		{
			
		}

		public static IWebDriver GetInstance()
		{
			_driver = _driver ?? new InternetExplorerDriver();
			return _driver;
		}
	}
}
