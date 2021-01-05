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

            // start of the method calls section of the Main() method
            //uncomment to run the methods 

            //  division();
            //  sumOftwoNumbers();
            //  swapping();
            // multiplyThreeNumbers();
            // averageOfFourNumbers();
            characterRemover();         // method never works rekt
        }







        // Write a C# Sharp program to print the sum of two numbers
        static void sumOftwoNumbers()
        {
            System.Console.WriteLine(A + B);
            System.Console.WriteLine("==============================================");
            System.Console.WriteLine("==============================================");
            System.Console.WriteLine("==============================================");

        }


        // Print the result of dividing two numbers
        static void division()
        {

            int C = A / B;

            System.Console.WriteLine(C); // prints out 3

            System.Console.WriteLine("==============================================");
            System.Console.WriteLine("==============================================");
            System.Console.WriteLine("==============================================");

        }

        //         Write a C# Sharp program to swap two numbers. Go to the editor
        // Test Data:
        // Input the First Number : 5
        // Input the Second Number : 6
        // Expected Output:
        // After Swapping :
        // First Number : 6
        // Second Number : 5 

        static void swapping()
        {
            int AA;
            int BB;

            //take input from user using the Console.ReadLine() method 
            System.Console.WriteLine("enter the value of int AA");
            AA = Convert.ToInt32(Console.ReadLine());  // takes input and converts it to int32 (int) -- casting the value returned does not work

            System.Console.WriteLine("enter the value of int BB");
            BB = Convert.ToInt32(Console.ReadLine()); // does the same as AA

            int holder; // this variable holds the value of AA which is yet to be replaced
            holder = (int)AA;   // assigning the value of AA to holder 
            AA = BB; // giving the value of BB to AA directly
            BB = holder;  // the value of AA is given to that of holder 

            Console.WriteLine($"value of AA is{AA} and that of BB is {BB}");
            System.Console.WriteLine("==============================================");
            System.Console.WriteLine("==============================================");
            System.Console.WriteLine("==============================================");


        }


        // Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user. 
        static void multiplyThreeNumbers()
        {
            System.Console.WriteLine("enter the first number ");
            int AA = Convert.ToInt32(Console.ReadLine());       // enter the threee numbers and assign them variables

            System.Console.WriteLine("enter the second number ");
            int BB = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("enter the third number ");
            int CC = Convert.ToInt32(Console.ReadLine());

            int DD = AA * BB * CC;     // multiply the numbers 
            System.Console.WriteLine($" the product of the three is :{DD}");   // print out the product

            System.Console.WriteLine("==============================================");
            System.Console.WriteLine("==============================================");
            System.Console.WriteLine("==============================================");
        }

        // Write a C# Sharp program that takes four numbers as input to calculate and print the average
        static void averageOfFourNumbers()
        {
            System.Console.WriteLine("enter first number");
            int AAA = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("enter first number");
            int BBB = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("enter first number");
            int CCC = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("enter first number");
            int DDD = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((AAA + BBB + CCC + DDD) / 4); // prints the operation in the brackets


        }

        // Write a C# program remove specified a character from a non-empty string using index of a character
        static void characterRemover()
        {
            string myString = "collinsey";
            System.Console.WriteLine($"the provided string is   -------- {myString} -------");
            System.Console.WriteLine("enter the letter to be removed:");

            char letter = 'w';
            try
            {
                letter = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                Console.Beep();
                Console.WriteLine("there is no such character here try once more ");
                characterRemover(); // call the method if there is no character found
            }
            if (myString.Contains(letter))
            {
                string newString=myString.Remove(myString.IndexOf(letter));
                System.Console.WriteLine($"removed the '{letter}' letter from the string \n the new string is {newString}");


            }
            else
            {
                System.Console.WriteLine("the letter provided does not exist in the string given");
            }

        }






    }
}
