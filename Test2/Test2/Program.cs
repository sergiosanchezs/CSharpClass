using System;

namespace Test2
{
   class Program
   {
      static void Main(string[] args)
      {
         int sum;
         findOddNumbers();
         sum = sumOddNumbers();
         Console.WriteLine($"The sum of odd numbers from 0 to 100 is {sum}");
      }

      public static void findOddNumbers()
      {
         //All odd numbers in the first 100 numbers
         for(int i = 0; i <= 100; i++)
            if (i % 2 == 1)
               Console.Write(i + " ");
         Console.WriteLine();
      }
      public static int sumOddNumbers()
      {
         int sum = 0;
         for (int i = 0; i <= 100; i++)
            if (i % 2 == 1)
               sum += i;
         return sum;
      }
   }
}
