using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
namespace OliverScheer.PatternsAndPractices.CodingThings
{

    // Inspired by: https://medium.com/write-a-catalyst/if-you-can-answer-these-7-concepts-correctly-youre-decent-at-net-a9095e412706

    //    The appsettings.json file is used for managing application credentials, such as configuration strings and other application-specific keys. The configuration settings can be divided as per environments too

    //Example appsettings.json file:
    //{
    //        "ConnectionStrings": {
    //            "DefaultConnection": "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"
    //        },
    //  "Logging": {
    //            "LogLevel": {
    //                "Default": "Warning"
    //            }
    //        }
    //    }
    //    Accessing configuration values in your application is straightforward using the built-in configuration system.
    //public class MyService
    //    {
    //        private readonly string _connectionString;

    //        public MyService(IConfiguration configuration)
    //        {
    //            _connectionString = configuration.GetConnectionString("DefaultConnection");
    //        }
    //}
    //The appsettings.json file allows for easily fetch configuration settings, needs to handled efficiently.
    internal class AppSettings
    {
    }
}
