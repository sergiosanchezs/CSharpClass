using System;

namespace Assignment1
{
   class Program
   {
      static void Main(string[] args)
      {
         // Excersice 2 - Write a program to calculate average of 6 variables
         float num1 = 45,
             num2 = 23,
             num3 = 75,
             num4 = 84,
             num5 = 23,
             num6 = 57,
             average;

         average = (num1 + num2 + num3 + num4 + num5 + num6) / 6;

         Console.WriteLine("num1 = {0}\n" +
                           "num2 = {1}\n" +
                           "num3 = {2}\n" +
                           "num4 = {3}\n" +
                           "num5 = {4}\n" +
                           "num6 = {5}\n", num1, num2, num3, num4, num5, num6);

         Console.WriteLine("The average of these 6 numbers is {0}", average);
      }
   }
}
