using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace LabEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            var lines = 5;
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }

            persons.OrderBy(p => p.FirstName)
                    .ThenBy(persons => p.Age)
                    .ToList()
                    .ForEach(persons => Console.WriteLine(persons.ToString()));
        }
    }
}
