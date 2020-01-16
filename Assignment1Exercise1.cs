using System;

namespace Assignment1
{
   class Program
   {
      static void Main(string[] args)
      {
         // Excersice 1 - Write a program to print multiplication table of a number 5 (without loop)
         const int OPERATOR1 = 5;
         int result, operator2;
         operator2 = 1;
         result = OPERATOR1 * operator2;
         Console.WriteLine("{0} * {1} = {2}", OPERATOR1, operator2, result);
         operator2 += 1;
         result = OPERATOR1 * operator2;
         Console.WriteLine("{0} * {1} = {2}", OPERATOR1, operator2, result);
         operator2 += 1;
         result = OPERATOR1 * operator2;
         Console.WriteLine("{0} * {1} = {2}", OPERATOR1, operator2, result);
         operator2 += 1;
         result = OPERATOR1 * operator2;
         Console.WriteLine("{0} * {1} = {2}", OPERATOR1, operator2, result);
         operator2 += 1;
         result = OPERATOR1 * operator2;
         Console.WriteLine("{0} * {1} = {2}", OPERATOR1, operator2, result);
         operator2 += 1;
         result = OPERATOR1 * operator2;
         Console.WriteLine("{0} * {1} = {2}", OPERATOR1, operator2, result);
         operator2 += 1;
         result = OPERATOR1 * operator2;
         Console.WriteLine("{0} * {1} = {2}", OPERATOR1, operator2, result);
         operator2 += 1;
         result = OPERATOR1 * operator2;
         Console.WriteLine("{0} * {1} = {2}", OPERATOR1, operator2, result);
         operator2 += 1;
         result = OPERATOR1 * operator2;
         Console.WriteLine("{0} * {1} = {2}", OPERATOR1, operator2, result);
         operator2 += 1;
         result = OPERATOR1 * operator2;
         Console.WriteLine("{0} * {1} = {2}", OPERATOR1, operator2, result);
         Console.WriteLine("---------------------------------------------------");

         // Optimized version of this is using a for loop

         for (int numberTimes = 1; numberTimes <= 10; numberTimes++)
         {
            result = OPERATOR1 * numberTimes;
            Console.WriteLine("{0} * {1} = {2}", OPERATOR1, numberTimes, result);
         }
      }
   }
}
