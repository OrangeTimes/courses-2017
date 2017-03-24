using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq; // this was added to make available JSON object

namespace ConsoleApplicationRoman
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class TestClass
    {
        public static JObject Test()
        {
            JObject obj = new JObject();
            return obj;
        }
    }
}
