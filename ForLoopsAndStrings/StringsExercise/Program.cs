﻿using System;

namespace StringsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloworld = "Hello World";

            //programm kuvab konsoolis sõna esimest tähte ja viimast tähte
            /*
            Console.WriteLine("Hello World");
            Console.WriteLine(helloworld[0]);
            Console.WriteLine(helloworld[10]);
            */

            Console.WriteLine(helloworld[0]);

            int helloworldlength = helloworld.Length;
            Console.WriteLine(helloworld[helloworldlength - 1]);


        }
    }

