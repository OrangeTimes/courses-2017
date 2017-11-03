using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.PageRepository;

namespace WebAutomation
{
	public class Pages
	{
		public static PageHome PageHome => new PageHome();
		public static PageSearchResults PageSearchResults => new PageSearchResults();
	}
}
