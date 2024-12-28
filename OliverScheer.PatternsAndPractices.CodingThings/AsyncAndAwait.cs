using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OliverScheer.PatternsAndPractices.CodingThings
{
    // Inspired by: https://medium.com/write-a-catalyst/if-you-can-answer-these-7-concepts-correctly-youre-decent-at-net-a9095e412706

//    In .NET, asynchronous programming is essential for writing efficient applications that perform well under load.The async and await keywords simplify working with asynchronous operations.

//async methods allow you to perform tasks asynchronously. Mark a method with the async keyword to enable the use of await inside it.
//public async Task<string> FetchDataAsync()
//    {
//        await Task.Delay(1000); // Simulates an asynchronous operation
//        return "Data fetched";
//    }
//    await helps application UI by not blocking the main thread.
//public async Task ShowDataAsync()
//    {
//        string data = await FetchDataAsync();
//        Console.WriteLine(data);
//    }
//    Summary: If you want improve performance of your application use async and await effectively and at the same time keeping application UI responsive.

    internal class AsyncAndAwait
    {
    }
}
