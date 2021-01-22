// the challenges are in form of methods 
using System;
using System.IO;

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
            // characterRemover();         // method never works rekt



            // System.Console.WriteLine(method1(x: 23, y: 23));   // key:value pair syntax of calling a method that has params
            // System.Console.WriteLine(method1(x: 24, y: 56));

            // oddPrinter();
            //
            // fileCheck();
            // arrayMultiplier();
            // System.Console.WriteLine(twentyCheck());
            OddArrayCheck();

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
                string newString = myString.Remove(myString.IndexOf(letter));
                System.Console.WriteLine($"removed the '{letter}' letter from the string \n the new string is {newString}");


            }
            else
            {
                System.Console.WriteLine("the letter provided does not exist in the string given");
            }

        }
        // Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum
        static int method1(int x, int y) // the method caller should provide the following arguments
        {
            if (x == y)
            {
                return (x + y) * 3;
            }
            return x + y;
        }


        // Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
        // odd numbers are not divisible by 2 and dont have a reminder 
        static void oddPrinter()
        {
            int lastNumber = 99;


            for (int currentNumber = 1; currentNumber <= lastNumber; currentNumber++)
            {
                int divisionBy2rem = currentNumber % 2;   // divide the number by 2 and get the remainder 

                if (divisionBy2rem != 0)
                {
                    System.Console.Write(currentNumber + " ");

                }

            }
            System.Console.WriteLine();
            System.Console.WriteLine("press any key to exit ");
            Console.ReadKey();
        }

        // Write a C# program to find the size of a specified file in bytes.
        // To do this , you need the System.IO namespace which deals with output 

        static void fileCheck()
        {
            string filePath = "C:\\Users\\monsi\\Desktop\\myGitWorkstation\\c-challenges-beginner-to-advanced-\\easy-challenges\\Program.cs";


            FileInfo f = new FileInfo(filePath);    // creates an instance of the class and constructs the class with a filepath parameter.

            System.Console.WriteLine(f.Length);     // the length property pulls out the size of the file of the filepath 
        }




        //  Write a C# program to multiply corresponding elements of two arrays of integers 
        // eg: Array1: [1, 3, -5, 4]
        //Array2: [1, 4, -5, -2]
        //Multiply corresponding elements of two arrays:  1 12 25 -8

        static void arrayMultiplier()
        {
            int[] myarr1 = { 1, 3, -5, 4 };
            int[] myarr2 = { 1, 4, -5, 2 };
            int[] resultArray = new int[4];
            int a = 0;

            // start looping through the elements of the array.
            for (int i = 0; i < myarr1.Length; i++)
            {
                int multiplicationResult = myarr1[i] * myarr2[i]; // multiplies the value of the arrays at the index i
                System.Console.WriteLine(multiplicationResult);

                resultArray[a] = multiplicationResult;
                a++;

            }

            System.Console.WriteLine($"{resultArray[0]} , {resultArray[1]} ,{resultArray[2]} ,  {resultArray[3]} ");
            System.Console.WriteLine($"the length of the array is : {resultArray.Length}"); // prints the length of the resultArray using string interpolation


        } // end of the method



        // Write a C# program to check the nearest value of 20 of two given integers and return 0 if two numbers are same. 
        // eg: First Number : 21
        //     Second Number : 12
        //     The nearest = 21

        static int twentyCheck()
        {

            System.Console.WriteLine("CHECK FOR THE NEAREST NUMBER TO TWENTY ");

            System.Console.WriteLine("enter the first number:");
            int X = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("enter the second number:");
            int Y = Convert.ToInt32(Console.ReadLine());

            uint number = 20;       // we use unsigned integer to remove the sign of the number
            uint Xdiff = number - (uint)X;      // cast the entered X integer to an unsigned integer 
            uint Ydiff = number - (uint)Y;       // cast the entered Y also

            if (Xdiff > Ydiff)                  // if xdiff is greater than ydiff
            {
                return X;
            }
            else if (Ydiff > Xdiff)            // if ydiff is greater than xdiff
            {
                return Y;
            }
            else if (Xdiff == Ydiff)            // if xdiff is equal to ydiff
            {
                return 0;
            }

            return 0;                           // the default return value

        }  // end of the method.


        // Write a C# program to check if an array contains an odd number.
        static void OddArrayCheck()
        {
            int[] arr1 = { 2, 1, 5, 7, 9 };
            int evenCheck;
            int oddCheck;

            foreach (int i in arr1)
            {
                evenCheck = i % 2;  // checks for even number 
                oddCheck = i % 3;   // checks for odd

                if (evenCheck != 0 && oddCheck == 0)
                {
                    System.Console.WriteLine($"The number is an odd number . At {i}");
                }
            }

        }   // end of the method 




    }
}
