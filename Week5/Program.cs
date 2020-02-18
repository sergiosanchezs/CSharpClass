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


      }
   }
}
