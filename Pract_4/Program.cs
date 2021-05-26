using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pract_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var collect = new List<string>();
            collect.Add("1");
            collect.Add("a");
            collect.Add("2");
            collect.Add("3");
            collect.Add("b");
            collect.Add("C");
            collect.Add("4");
            collect.Add("D");
            collect.Add("5");
            collect.Add("6");
            collect.Add("В");
            collect.Add("7");
            collect.Add("F");
            collect.Add("g");
            collect.Add("8");
            
            foreach(string n in collect)
            {
             string tmp = Regex.Replace(n,"[^0-9]+", "");
             Console.Write(tmp);
            }
            Console.WriteLine("\n");
            foreach (string n in collect)
            {
             string tmp2 = Regex.Replace(n, "[^A-ZА-Я]+", "");
             Console.Write(tmp2);
            }
        }
    }
}
