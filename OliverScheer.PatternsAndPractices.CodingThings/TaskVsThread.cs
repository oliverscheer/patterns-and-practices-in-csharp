using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OliverScheer.PatternsAndPractices.CodingThings
{
    internal class TaskVsThread
    {
        // Inspired by: https://medium.com/write-a-catalyst/if-you-can-answer-these-7-concepts-correctly-youre-decent-at-net-a9095e412706

//        Both Task and Thread are used for concurrent programming in C#, but they serve different purposes.

//Thread represents a single path of execution and is a lower-level construct.It provides more control over the execution but requires manual management.
//Thread thread = new Thread(() =>
//{
//    Console.WriteLine("Running on a new thread");
//});

//        thread.Start();
//Task provides an abstract functionality to implement async operations and is used along with async/await.
//Task.Run(() =>
//{
//    Console.WriteLine("Running asynchronously");
//});
//Tasks simplify the management of asynchronous operations and are often the preferred choice for modern C# development.
    }
}
