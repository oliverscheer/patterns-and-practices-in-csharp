using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace OliverScheer.PatternsAndPractices.CodingThings
{
    // Inspired by: https://medium.com/write-a-catalyst/if-you-can-answer-these-7-concepts-correctly-youre-decent-at-net-a9095e412706
    //    In C#, ref and out are used to pass parameters by reference, but they have distinct characteristics.

    //ref parameters require that the variable be initialized before it is passed to a method.The method can then modify the variable’s value.
    //public void UpdateValue(ref int number)
    //    {
    //        number += 10;
    //    }

    //    int myNumber = 5;
    //    UpdateValue(ref myNumber);
    //    Console.WriteLine(myNumber); // Outputs: 15

    //out parameters do not require initialization before being passed.The method must assign a value to the out parameter before it returns.
    //public void GetValues(out int value1, out int value2)
    //    {
    //        value1 = 10;
    //        value2 = 20;
    //    }

    //    GetValues(out int a, out int b);
    //    Console.WriteLine(a); // Outputs: 10
    //Console.WriteLine(b); // Outputs: 20
    //ref is typically used when a method needs to modify an existing variable, while out is used when a method needs to return multiple values or initialize values that were not provided by the caller.

    internal class RefVsOut
    {
    }
}
