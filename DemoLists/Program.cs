using System;
using System.Collections.Generic;

namespace DemoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new List<int> { 1, 2, 3, 4 };
            number.Add(1);
            number.AddRange(new int[3] { 5, 6, 7 });

            foreach (var n in number)
                Console.WriteLine(n);

            //IndexOf
            Console.WriteLine();
            Console.WriteLine("Index of 1 : " + number.IndexOf(1));
            Console.WriteLine("Last index of 1 : " + number.LastIndexOf(1));

            //Count
            Console.WriteLine("Count : " + number.Count);

            //clearing ever 1 in the list
            for (var i = 0; i < number.Count; i++)
            {
                if (number[i] == 1)
                {
                    number.Remove(number[i]);
                }
            }

            Console.WriteLine("\nAll 1 is deleted : ");

            foreach (var n in number)
                Console.WriteLine(n);
        }
    }
}
