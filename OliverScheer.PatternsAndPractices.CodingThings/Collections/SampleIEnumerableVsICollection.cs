using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OliverScheer.PatternsAndPractices.CodingThings.Collections
{
    public class SampleIEnumerableVsICollection
    {
        // Inspired by this article: https://medium.com/write-a-catalyst/if-you-can-answer-these-7-concepts-correctly-youre-decent-at-net-a9095e412706

        // Difference between IEnumerable<T> vs.ICollection<T>
        // While writing logic in C#, developers frequently encounter IEnumerable<T> and ICollection<T>.
        // They may look quite similar but they serve different purposes in software development

        // IEnumerable<T> acts as the base interface for non-generic collections.
        // It helps to iterate over a collection of a defined type.
        // Good to have a lightweight collection which is more secure,
        // as data manipulation is not allowed. Any collection if you want to prevent data manipulation,
        // its recommended to use IEnumerable<T>

        //IEnumerable<int> numbers = new List<int> { 1, 2, 3 }; 

        //foreach (var number in numbers) {     

        //  Console.WriteLine(number); // Outputs: 1 2 3 
        //}
        //ICollection<T> extends IEnumerable<T> allows modifications with the help of alteration methods.This interface consists of methods to add, remove and check counts in the collection.
        //ICollection<int> data = new List<int> { 12, 43, 556 };
        //    data.Add(4); 
        //Console.WriteLine(data.Count); // Outputs: 4
        //It is recommended to ICollection<T> when alter methods are required for the collection and IEnumerable<T> for simple read actions.
        public void Run()
        {
            IEnumerable<int> enumerable = new List<int> { 1, 2, 3, 4, 5 };
            ICollection<int> collection = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("IEnumerable:");
            foreach (var item in enumerable)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("ICollection:");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            collection.Add(6);
        }
    }
}
