using System;
using System.Collections.Generic;

namespace ConsoleAppCommonSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string secondName = "";

            firstName = "Sabina";
            secondName = "Mazure";
            string fullName = "";
            fullName = $"{ firstName } {secondName}";

            Console.WriteLine(fullName);
        }
    }
}