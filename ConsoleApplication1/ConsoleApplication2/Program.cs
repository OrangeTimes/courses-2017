using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
//Need to add refference "using Newtonsoft.Json.Linq;"
//The "(DateTime.Now)" should be replaced with ()