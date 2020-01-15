using System;

namespace ConsoleApp1
{
   class Program
   {
      static void Main(string[] args)
      {
         int number = 345;
         int squared = number * number;
         Console.WriteLine("The square of {0} is {1}", number, squared);
         Console.WriteLine("Square of two number is " + squared);
         //Console.ReadKey();

         // Adding 4 numbers
         int num = 0;
         int sum = 0;
         int multiplication = 1;
         int substraction = 0;
         float division = 0;
         Console.WriteLine("This program is going to sum 4 numbers");
         Console.WriteLine("The numbers must be above 0");
         for (int i = 0; i < 4; i++)
         {
            while (num <= 0)
            {
               Console.WriteLine("Enter the number No.{0}: ", i);
               num = Convert.ToInt32(Console.ReadLine());
            }
            sum += num;
            
            multiplication *= num;
            
            // Substraction and division
            // The first number must be the big number to substract from or divide from.
            if (i == 0)
            {
               substraction = num;
               division = (float)num;
            }
            else
            {
               substraction -= num;
               division /= (float)num;
            }
         }
         Console.WriteLine("The Sum is {0}", sum);
         Console.WriteLine("The Average is {0}", (float) sum / 4);
         Console.WriteLine("The Multiplication is {0}", multiplication);
         Console.WriteLine("The Substraction is {0}", substraction);
         Console.WriteLine("The Division is {0}", division);
      }
   }
}
