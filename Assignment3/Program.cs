using System;

namespace Assignment3
{
   class Program
   {
      static void Main(string[] args)
      {
         /* 1.	Write a C# program to display Fibonacci series on screen 
          * The Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21
          * The Fibonacci sequence is a sequence where the next term is the sum 
          * of the previous two terms. 
          * The first two terms of the Fibonacci sequence are 0 followed by 1. */

         int i, number, term1 = 0, term2 = 1, nextTerm;
         Console.WriteLine("Enter the number of terms: ");
         number = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Fibonacci Series: ");
         for (i = 1; i <= number; ++i)
         {
            if (i == number)
               Console.Write($"{term1}");
            else
               Console.Write($"{term1}, ");

            nextTerm = term1 + term2;
            term1 = term2;
            term2 = nextTerm;
         }
         Console.WriteLine();

         /* 2.	Write a C# program that will print Alphabets on screen (a-z)
          * Alphabet a in ascii is 97 and the z is 122 */
         Console.WriteLine("\n--------------------------------------------------");
         Console.WriteLine("Printing all the alphabet from a to z in lowercase");
         char initialAlphabetLetter = (char)97;    // a
         char finalAlphabetLetter = (char)122;     // z

         for (char letter = initialAlphabetLetter; letter <= finalAlphabetLetter; letter++)
         {
            Console.Write($"{letter} ");
         }
         Console.WriteLine();

         /* 3.	Write a program to display following pattern in screen 
          * a.	*                                                   
               **
               ***
               ****
               *****       */
         int linesUp;
         Console.WriteLine("\n--------------------------------------------------");
         Console.WriteLine("Pattern increasing in number of stars as it going through.");
         Console.WriteLine("Please enter how many lines you want to print on the screen: ");
         linesUp = Convert.ToInt32(Console.ReadLine());

         for (int k  = 1; k <= linesUp; k++)
         {
            for (int l = 1; l <= k ; l++)
            {
               Console.Write("*");
            }
            Console.WriteLine();
         }

         /* 4.	Write a program to display following pattern in screen 
          * b.	*****                                                   
               ****
               ***
               **
               *       */
         int linesDown;
         Console.WriteLine("\n--------------------------------------------------");
         Console.WriteLine("Pattern decreasing in number of stars as it going through.");
         Console.WriteLine("Please enter how many lines you want to print on the screen: ");
         linesDown = Convert.ToInt32(Console.ReadLine());

         for (int k = linesDown; k >= 1; k--)
         {
            for (int l = 1; l <= k; l++)
            {
               Console.Write("*");
            }
            Console.WriteLine();
         }

      }
   }
}
