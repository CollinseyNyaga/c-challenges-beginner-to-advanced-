// the challenges are in form of methods 
using System;

namespace easy_challenges
{
    class Program
    {

        //global variables to be shared in the methods 
        static int A = 12;
        static int B = 4;




        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // start of the method calls section of the Main method
            division();
            sumOftwoNumbers();
            

        }
        // Write a C# Sharp program to print the sum of two numbers
        static void sumOftwoNumbers()
        {
            System.Console.WriteLine(A+B);
        }


        // Print the result of dividing two numbers
        static void division()
        {

            int C = A / B;

            System.Console.WriteLine(C); // prints out 3
        }



    }
}
