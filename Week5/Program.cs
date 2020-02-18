using System;

namespace Week5
{
   class Program
   {
      static void Main(string[] args)
      {

         int i, j;

         Console.WriteLine("Please, enter a number: ");
         i = Convert.ToInt32( Console.ReadLine() );

         for (j = 2; j < i; j++)
         {
            if (i % j == 0)
            {
               Console.WriteLine($"{i} no");
               break;
            }
         }
         if (j == i)
         {
            Console.WriteLine($"{i} yes");
         }

         Console.WriteLine("\n---------------------------------------------");
         int num, ctr;
         int startNumber, endNumber;
         // Prime numbers
         Console.WriteLine("Find the prime numbers within a range of numbers:");
         Console.Write("Input starting number of range: ");
         startNumber = Convert.ToInt32(Console.ReadLine());
         Console.Write("Input ending number of range : ");
         endNumber = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine($"The prime numbers between {startNumber} and {endNumber} are :");



         for (num = startNumber; num <= endNumber; num++)
         {
            ctr = 0;
            for (i = 2; i <= (num/2); i++)
            {
               if (num % i == 0)
               {
                  ctr++;
                  break;
               }
            }
            if (ctr == 0 && num != 1)
               Console.Write($"{num} ");
         }
         Console.WriteLine();
         int counterX;
         int counterY;
         int sizeMatrix = 5;
         Console.WriteLine("\n---------------------------------------------");
         Console.WriteLine("Please enter the size of the matrix of X that you want:");
         sizeMatrix = Convert.ToInt32(Console.ReadLine());

         counterY = 0;
         do
         {
            counterX = 0;
            do
            {
               Console.Write("X ");
               counterX++;
            } while (counterX < sizeMatrix);
            Console.WriteLine();
            counterY++;
         } while (counterY < sizeMatrix);

         Console.WriteLine("\n---------------------------------------------");
         Console.WriteLine("This program calculate a number powers to a number");
         int nBase, exp, result;
         Console.WriteLine("Please enter the base:");
         nBase = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Please enter the Exponent:");
         exp = Convert.ToInt32(Console.ReadLine());

         result = 1;
         for (i = 0; i < exp; i++)
         {
            result *= nBase;
         }

         Console.WriteLine($" Base: {nBase} to Exponent: {exp} = {result}");

      }
   }
}
