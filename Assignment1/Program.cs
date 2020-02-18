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

         // Excersice 3 - Write a program to calculate following calculations

         Console.WriteLine(" The operation (-1 + 4 * 6) = {0}", (-1 + 4 * 6));
         Console.WriteLine(" The operation (( 35+ 5 ) % 7) = {0}", ((35 + 5) % 7));
         Console.WriteLine(" The operation (14 + -4 * 6 / 11) = {0}", (14 + -4 * 6.0 / 11));
         Console.WriteLine(" The operation (-1 + 4 * 6) = {0}", (2 + 15.0 / 6 * 1 - 7 % 2));

         // Excersice 4 - Write a program to swap two number

         int a = 4, b = 9, t;
         Console.WriteLine(" Swaping 2 numbers: a = {0}, b = {1}", a, b);
         t = a;
         a = b;
         b = t;
         Console.WriteLine(" Now they are: a = {0}, b = {1}", a, b);
      }
   }
}
