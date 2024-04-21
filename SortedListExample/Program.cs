using System;
using System.Collections.Generic;

namespace SortedListExample
{
    class Program
    {
        static void Main()
        {

            //created a sortedlist
            SortedList<int, string> employees = new SortedList<int, string>()
            {
                {101, "Scott" },
                {102, "Smith" },
                {103, "Sally" },
                {104, "Adam" },
                {105, "Edwin" },
                {106, "Jame" },

            };

            //Add element
            employees.Add(107, "Matt");

            //Remove element
            employees.Remove(103);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Key + ", " + employee.Value);

            }

            //get value based on key
            string eName = employees[105];
            Console.WriteLine(eName);

            //search specific key
            bool b = employees.ContainsKey(105);
            Console.WriteLine(b);

            //search for a pecific value
            bool v = employees.ContainsValue("Scott");
            Console.WriteLine(v);

            //index of specific jey
            int ki = employees.IndexOfKey(101);
            Console.WriteLine(ki);

            //index of specific value
            int va = employees.IndexOfValue("Scott");
            Console.WriteLine(va);

            Console.ReadKey();


        }
    }
}
