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


      }
   }
}
