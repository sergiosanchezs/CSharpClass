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
               optionSelected = userInputInteger();

               if (isValidOption(optionSelected) && optionSelected >= 0)
               {
                  printErrorMessage("Please enter a valid option");
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

      private static void printErrorMessage(String dataToPrint)
      {
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.BackgroundColor = ConsoleColor.Red;
         Console.WriteLine("\n" + dataToPrint);
         Console.ForegroundColor = ConsoleColor.White;
         Console.BackgroundColor = ConsoleColor.Black;
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

      private static int userInputInteger()
      {
         int input = 0;
         try
         {
            input = Convert.ToInt32(Console.ReadLine());
         }
         catch (Exception ex)
         {
            printErrorMessage("Error: Please enter a number.");
            input = -1;
         }
         return input;
      }

      private static void printSeparator()
      {
         Console.WriteLine("\n--------------------------------------------------");
      }

      private static void printFibonacciSeries()
      {
         /* 1.	Write a C# program to display Fibonacci series on screen 
             * The Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21
             * The Fibonacci sequence is a sequence where the next term is the sum 
             * of the previous two terms. 
             * The first two terms of the Fibonacci sequence are 0 followed by 1. */

         int i, number, term1 = 0, term2 = 1, nextTerm;

         do
         {
            printSeparator();
            Console.WriteLine("Enter the number of terms: ");
            number = userInputInteger();

            if (number < 3)
            {
               printErrorMessage("Please enter a valid option. Must be 3 or more terms.");
            }

         } while (number < 3);


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
         printSeparator();
         Console.WriteLine("Alphabet Lowercase:");
         char initialAlphabetLetter = (char)97;    // a as default
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
         printSeparator();
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

         do
         {
            printSeparator();
            Console.WriteLine("Pattern increasing in number of stars as it going through.");
            Console.WriteLine("Please enter how many lines you want to print on the screen: ");
            linesUp = userInputInteger();

            if (linesUp < 5)
            {
               printErrorMessage("Please enter a valid option. Must be 5 or more terms.");
            }

         } while (linesUp < 5);

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

         do
         {
            printSeparator();
            Console.WriteLine("Pattern decreasing in number of stars as it going through.");
            Console.WriteLine("Please enter how many lines you want to print on the screen: ");
            linesDown = userInputInteger();

            if (linesDown < 5)
            {
               printErrorMessage("Please enter a valid option. Must be 5 or more terms.");
            }

         } while (linesDown < 5);
         

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
