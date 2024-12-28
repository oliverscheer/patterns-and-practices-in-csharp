using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliverScheer.PatternsAndPractices.CodingThings
{
    internal class PropertyPatternMatching
    {

        // Documentation: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/pattern-matching

        // Comparision before and after

        public void ComparisionBefore()
        {
            Person person = null!;

            if (person != null && 
                person.Age >= 18 &&
                person.FirstName.Length > 3)
            {
                Console.WriteLine($"Hello {person.FirstName}");
            }
        }

        public void ComparisionAfter()
        {
            Person person = null!;

            if (person is { Age: > 18, FirstName.Length: > 3 } adult)
            {
                Console.WriteLine($"Hello {adult.FirstName}");
            }
        }

        // Null check before and after

        public void NullCheckBefore()
        {
            Person person = null!;
            if (person != null && person.FirstName != null)
            {
                Console.WriteLine($"Hello {person.FirstName}");
            }
        }

        public void NullCheckAfter()
        {
            Person person = null!;
            if (person is { FirstName: not null } p)
            {
                Console.WriteLine($"Hello {p.FirstName}");
            }
        }

        // Type check before and after

        public void TypeCheckBefore()
        {
            object obj = "Hello";
            if (obj is string)
            {
                Console.WriteLine("It's a string");
            }
        }

        public void TypeCheckAfter()
        {
            object obj = "Hello";
            if (obj is string s)
            {
                Console.WriteLine($"It's the string: {s}");
            }
        }
    }

    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
