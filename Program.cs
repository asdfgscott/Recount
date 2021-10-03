using System;
using System.Collections.Generic;
using System.Linq;

namespace Recount
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, int> candidates = new Dictionary<string, int>();
            string name;
            string maxname;
            int x;
            int maxCount = 0;
            int count = 0;

            do{
                name = Console.ReadLine();
                Console.WriteLine(name);
            } 
            while(name != "***");
        }
    }
}
