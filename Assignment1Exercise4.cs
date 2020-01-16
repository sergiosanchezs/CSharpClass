using System;

namespace Assignment1
{
   class Program
   {
      static void Main(string[] args)
      {
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
