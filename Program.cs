using System;
using System.Collections.Generic;
using System.Linq;

namespace Encapsulation_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = 5;

            var persons = new List<Person>();

            for (int i = 0; i < lines; i++)

            {

                var cmdArgs = Console.ReadLine().Split();

                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));

                persons.Add(person);

            }
            Console.ReadLine();

            persons.OrderBy(p => p.Firstname)

            .ThenBy(p => p.Age)

            .ToList()

            .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
