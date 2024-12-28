using Microsoft.VisualBasic;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OliverScheer.PatternsAndPractices.CodingThings
{
    internal class Class1
    {
        // Inspired by: https://medium.com/write-a-catalyst/if-you-can-answer-these-7-questions-correctly-youre-a-decent-developer-c8928a09d847

//        This next set of questions will test your knowledge of advanced.NET concepts and practices.

//1. Exploring Middleware in ASP.NET Core
//The Middleware components of ASP.NET Core are the pieces that take part in the request and response pipeline.They provide an opportunity to insert custom logic, handle authentication, handle errors, etc.
//        Question: How to create and use a custom middleware component in ASP.NET Core? The steps to be done are to be described and illustrated by a simple example.

//To implement a custom Middleware you need to write a class which contains an Invoke or InvokeAsync method, afterwards, you need to register this middleware in the Configure method of Startup.cs:

//public class CustomMiddleware
//        {
//            private readonly RequestDelegate _next;
//            public CustomMiddleware(RequestDelegate next)
//            {
//                _next = next;
//            }
//            public async Task InvokeAsync(HttpContext context)
//            {
//                await context.Response.WriteAsync("Hello from custom middleware!");
//                await _next(context);
//            }
//        }
//        // In Startup.cs
//        public void Configure(IApplicationBuilder app)
//        {
//            app.UseMiddleware<CustomMiddleware>();
//            // Other middleware registrations
//        }
//        The middleware can be used to do logging, authentication, etc.

//2. Understanding Entity Framework Core Migrations
//EF Core Migrations are pretty important in handling changes that come about over time in your database schema.They keep the current state of the data model of your application, together with the scheme of the database.

//Question: How do you create and apply migrations in Entity Framework Core? What are the usual commands?

//Use the following EF Core migration commands:

//# Create a new migration
//dotnet ef migrations add InitialCreate

//# Apply the migration to the database
//dotnet ef database update
//Example migration file:

//public partial class InitialCreate : Migration
//        {
//            protected override void Up(MigrationBuilder migrationBuilder)
//            {
//                migrationBuilder.CreateTable(
//                    name: "Products",
//                    columns: table => new
//                    {
//                        Id = table.Column<int>(nullable: false)
//                            .Annotation("SqlServer:Identity", "1, 1"),
//                        Name = table.Column<string>(nullable: true),
//                        Price = table.Column<decimal>(nullable: false)
//                    },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_Products", x => x.Id);
//                });
//            }

//            protected override void Down(MigrationBuilder migrationBuilder)
//            {
//                migrationBuilder.DropTable(
//                    name: "Products");
//            }
//        }
//        Migrations enable systematic database schema evolution.
        
//3. Exploring LINQ Query Syntax vs.Method Syntax
//        LINQ provides two primary syntaxes for querying data: query syntax and method syntax.Both are powerful but have different use cases.


//        Question: What are the differences between LINQ query syntax and method syntax? Provide examples of each.

//        LINQ query syntax resembles SQL and is often used for simple queries:


//        var listOfInts = new List<int> { 23, 2, 3, 4, 54 }
        
//                      where n % 2 == 0

//                      select n;
//        Method syntax uses lambda expressions and is more versatile for complex queries:

//var listOfInts = new List<int> { 23, 2, 3, 4, 54 }
//              .Where(n => n % 2 == 0);
//        Both syntaxes are interchangeable but method syntax can be more flexible.

//4. Understanding and Using Delegates and Events
//Delegates and events are central to event-driven programming in .NET. They provide a way to define and handle notifications and callbacks.

//Question: What are delegates and events in C#? Provide a simple example.

//Define a delegate and use it to create events. Example:

//public delegate void Notify(string message);

//        public class Notifier
//        {
//            public Notify OnNotify;
//            public void Trigger(string message)
//            {
//                OnNotify?.Invoke(message);
//            }
//        }
//        // Usage
//        public class Program
//        {
//            public static void Main()
//            {
//                Notifier notifier = new Notifier();
//                notifier.OnNotify = message => Console.WriteLine("Notification: " + message);
//                notifier.Trigger("Hello, world!"); // Outputs: Notification: Hello, world!
//            }
//        }
//        Delegates are used for method references and events are built on delegates.
        
//5. Exploring.NET Core Performance Tuning
//        Optimizing.NET Core applications for performance involves various strategies, including profiling and improving resource management.


//        Question: What are some key techniques for performance tuning in .NET Core applications?

//        Techniques include:


//        Asynchronous I/O operations: Use async/await to keep the application responsive.
//Optimize database access: Use efficient queries and caching strategies.
//Profile and analyze: Utilize tools like dotnet-counters and dotnet-trace to monitor and diagnose performance issues.
//        Effective performance tuning ensures your application handles load efficiently.
        
//6. Understanding Value Types vs. Reference Types
//        In.NET, understanding the difference between value types and reference types is fundamental for memory management and data manipulation.

//        Question: What are value and reference types in C#? Provide examples.

//Value types hold data directly and are usually stack-allocated (e.g., int, float, struct). Reference types hold references to data and are heap-allocated(e.g., class, string).

//Value Type Example:

//int a = 10;
//        int b = a;
//        b++;
//Console.WriteLine(a); // Outputs: 10
//Reference Type Example:

//class Person
//        {
//            public string Name { get; set; }
//        }

//        Person person1 = new Person { Name = "Alice" };
//        Person person2 = person1;
//        person2.Name = "Bob";
//Console.WriteLine(person1.Name);
//7. Exploring.NET Core Configuration and Dependency Injection Integration
//.NET Core integrates configuration management with dependency injection, allowing for efficient settings management.

//Question: How do you use IOptions<T> to manage configuration settings in .NET Core? Provide an example.

//Use the IOptions<T> interface to bind configuration settings to strongly typed classes.

//Example Configuration File(appsettings.json) :

//{
//            "MySettings": {
//                "SomeSetting": "Value"
//            }
//        }
//        Settings Class:

//public class MySettings
//        {
//            public string SomeSetting { get; set; }
//        }
//        Startup Configuration:

//public void ConfigureServices(IServiceCollection services)
//        {
//            services.Configure<MySettings>(Configuration.GetSection("MySettings"));
//        }
//        Accessing Settings:

//public class MyService
//        {
//            private readonly MySettings _settings;
//            public MyService(IOptions<MySettings> options)
//            {
//                _settings = options.Value;
//            }
//        }
//        This approach streamlines configuration management and integrates smoothly with dependency injection.

    }
}
