using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sandbox
{
    public class Obj
    {
        public Obj(IDictionary<string, object> objs)
        {
            Objs = objs;
        }

        public IDictionary<string, object> Objs { get; private set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JsonConvert.SerializeObject(new Obj(new Dictionary<string, object>{["Abc"]=true})));
            Console.ReadLine();
        }
    }
}
