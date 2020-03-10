using System;

namespace TestQ3
{
   class Program
   {
      static void Main(string[] args)
      {
         int number = getNumber();
         checkNumber(number);
      }
      public static int getNumber()
      {
         Console.WriteLine("Please enter a number to check if it is positive or negative:");
         return Convert.ToInt32(Console.ReadLine());
      }
      public static void checkNumber(int number)
      {
         if (number >= 0)
            Console.WriteLine($"The number {number} is positive");
         else
            Console.WriteLine($"The number {number} is negative");
      }
   }
}
