using Newtonsoft.Json.Linq;

namespace ChildProject
{
    class ChildProject
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