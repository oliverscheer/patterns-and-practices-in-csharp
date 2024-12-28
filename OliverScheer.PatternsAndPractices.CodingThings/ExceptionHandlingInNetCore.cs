using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OliverScheer.PatternsAndPractices.CodingThings
{
//    Handling exceptions gracefully is crucial for maintaining robust and user-friendly applications. .NET Core provides various mechanisms for exception handling.

//Local exception handling: Use try-catch blocks to catch and handle exceptions.
//try
//{
//        int result = 10 / 0; // This will throw a DivideByZeroException
//    }
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("An error occurred: " + ex.Message);
//}
//Global exception handling in ASP.NET Core can be managed using middleware.Catch all types of exceptions in a common place which helps developers to manage user-friendly/common error messages for users.
//public void Configure(IApplicationBuilder app)
//{
//    app.UseExceptionHandler("/Home/Error");
//}
//Global exception handling middleware provides a common place to handle all application errors and exceptions. It ensures application consistently handles responses.

    internal class ExceptionHandlingInNetCore
    {
    }
}
