﻿using System;


namespace ParseAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; //datatype should be float
            string stringForInt = "12345"; //datatype should be int

            float floatFromString = float.Parse(stringForFloat);
            int intFromString = Int32.Parse(stringForInt);

            Console.WriteLine(floatFromString);
            Console.WriteLine("The data type of the above value is: " + floatFromString.GetType().Name); //show the data type
            Console.WriteLine(intFromString);
            Console.WriteLine("The data type of the above value is: " + intFromString.GetType().Name);//show the data type
            Console.Read();

        }
    }
}
