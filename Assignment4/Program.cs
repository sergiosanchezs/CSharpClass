using System;

namespace Assignment4
{
   class Program
   {
      static void Main(string[] args)
      {
         /* Assignment 3 */
         int optionSelected;
         bool isEndSelected = false;

         do
         {
            do
            {
               printMainMenu();
               optionSelected = 0;
               try
               {
                  optionSelected = Convert.ToInt32(Console.ReadLine());
               }
               catch (Exception ex)
               {
                  Console.ForegroundColor = ConsoleColor.Yellow;
                  Console.BackgroundColor = ConsoleColor.Red;
                  Console.WriteLine("\nError: Please enter a number.");
                  Console.ResetColor();
               }

            } while (isValidOption(optionSelected));

            switch (optionSelected)
            {
               case 1:
                  printFibonacciSeries();
                  break;
               case 2:
                  printAlphabetUppercase();
                  break;
               case 3:
                  printAlphabetLowercase();
                  break;
               case 4:
                  printPatternStarsIncrementing();
                  break;
               case 5:
                  printPatternStarsDecrementing();
                  break;
               case 6:
                  isEndSelected = true;
                  break;
            }

         } while (!isEndSelected);

         Console.WriteLine("\nThanks for using my program!");

      }

      private static bool isValidOption(int option)
      {
         return (option >= 1 && option <= 6) ? false : true;
      }

      private static void printMainMenu()
      {
         Console.ForegroundColor = ConsoleColor.Cyan;
         Console.WriteLine("\n------------ Menu -----------");
         Console.WriteLine("1. Print Fibonnacci Series.");
         Console.WriteLine("2. Print the Alphabet in Uppercase.");
         Console.WriteLine("3. Print the Alphabet in Lowercase.");
         Console.WriteLine("4. Print the Star Pattern Incrementing.");
         Console.WriteLine("5. Print the Star Pattern Decrementing.");
         Console.WriteLine("6. Exit the program.");
         Console.Write("\nYour Option: ");
         Console.ForegroundColor = ConsoleColor.White;
      }

      private static void printFibonacciSeries()
      {
         /* 1.	Write a C# program to display Fibonacci series on screen 
             * The Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21
             * The Fibonacci sequence is a sequence where the next term is the sum 
             * of the previous two terms. 
             * The first two terms of the Fibonacci sequence are 0 followed by 1. */

         int i, number, term1 = 0, term2 = 1, nextTerm;

         Console.WriteLine("\n--------------------------------------------------");
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
      }

      private static void printAlphabetLowercase()
      {
         /* 2.	Write a C# program that will print Alphabets on screen (a-z)
          * Alphabet a in ascii is 97 and the z is 122 */
         Console.WriteLine("\n--------------------------------------------------");
         Console.WriteLine("Alphabet Lowercase:");
         char initialAlphabetLetter = (char)97;    // a
         char finalAlphabetLetter = (char)122;     // z

         for (char letter = initialAlphabetLetter; letter <= finalAlphabetLetter; letter++)
         {
            Console.Write($"{letter} ");
         }
         Console.WriteLine();

      }

      private static void printAlphabetUppercase()
      {
         /* 2.	Write a C# program that will print Alphabets on screen (a-z)
          * Alphabet a in ascii is 97 and the z is 122 */
         Console.WriteLine("\n--------------------------------------------------");
         Console.WriteLine("Alphabet Uppercase:");
         char initialAlphabetLetter = (char)65;    // a
         char finalAlphabetLetter = (char)90;     // z

         for (char letter = initialAlphabetLetter; letter <= finalAlphabetLetter; letter++)
         {
            Console.Write($"{letter} ");
         }
         Console.WriteLine();

      }


      private static void printPatternStarsIncrementing()
      {
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

         for (int k = 1; k <= linesUp; k++)
         {
            for (int l = 1; l <= k; l++)
            {
               Console.Write("*");
            }
            Console.WriteLine();
         }
      }

      private static void printPatternStarsDecrementing()
      {
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
