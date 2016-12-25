using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CartDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test demo with sample data
            CheckOutManager obj = new CheckOutManager();
            Console.WriteLine(obj.CheckOut(new List<string> { "Apples" }));
            Console.WriteLine(obj.CheckOut(new List<string> { "Apples", "Apples" }));
            Console.WriteLine(obj.CheckOut(new List<string> { "Apples", "Apples", "Apples" }));
            Console.WriteLine(obj.CheckOut(new List<string> { "Apples", "Apples", "Oranges" }));
        }
    }
}
