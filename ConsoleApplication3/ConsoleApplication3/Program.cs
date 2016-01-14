using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdefg";
            string s1 = s.Substring(2, 3);

            string s2 = s.Replace("cde", "HELLO");
            Console.WriteLine(s2);

            int index = s.IndexOf("cde");
            Console.WriteLine(index);

            Console.WriteLine(s.Length);

            Console.ReadKey();
        }
    }
}
