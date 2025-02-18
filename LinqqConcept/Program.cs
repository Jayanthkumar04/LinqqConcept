using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqqConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var evenNumbers = from mynums in numbers where mynums % 2 == 0 select mynums;

            Console.WriteLine("all even numbers");

            foreach(int i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            var oddNumbers = from mynums in numbers where mynums % 2 == 1 select mynums;
            Console.WriteLine("odd numbers");

            foreach(int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
           

            var evens = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("second way even numbers");
            foreach (int i in evens)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("second way odd numbers");

            var odds = numbers.Where(n => n % 2 == 1);
            foreach(int i in odds)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("total numbers in array \t"+numbers.Count());

            Console.WriteLine("average of numbers in array \t"+numbers.Average());

            Console.WriteLine("sum of numbers in array\t"+numbers.Sum());

            Console.WriteLine("Max of numbers in array\t" + numbers.Max());

            Console.WriteLine("Min of numbers in array\t" + numbers.Min());

            string[] names = { "aman", "sam", "ravi", "amit", "vijay", "jai", "durgesh", "jai", "deep", "anil" };

            var query = names.Where(n => n.Contains("n"));

            foreach(var name in query)
            {
                Console.WriteLine(name);
            }

            var query2 = names.Where(n => n.Contains("r") && n.Length >= 5);

            Console.WriteLine("contains r and length greater than equal to 5");

            foreach(var name in query2)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();



        }
    }
}
