using System;

namespace ConsoleApp2
{
   class Program
   {
      static void Main(string[] args)
      {
         String firstName = "Sergio";
         String lastName = "Sanchez";
         int age = 33;
         String email = "c0767520@mylambton.ca";
         int a = 76, b = 4, c = 7, d = 2;
         int sum = a + b + c + d;
         int multiplication = a * b * c * d;
         int substraction = a - b - c - d;
         float division = (float)a / (float)b / (float)c / (float)d;

         Console.WriteLine("\n-------------------------------------------------------------");
         Console.WriteLine("Exercise 1: ");
         Console.WriteLine();
         Console.WriteLine("My name is {0} {1}",firstName, lastName);
         Console.WriteLine("My age is {0}", age);
         Console.WriteLine("My email address is {0}", email);
         Console.WriteLine("The variables are: a = {0}, b = {1}, c = {2}, d = {3}", a, b, c, d);
         Console.WriteLine("The Sum of four numbers is {0}", sum);
         Console.WriteLine("The Multiplication of four numbers is {0}", multiplication);
         Console.WriteLine("The Subtraction of four numbers is {0}", substraction);
         Console.WriteLine("The Division of four numbers is {0}\n", division);

         Console.WriteLine("-------------------------------------------------------------");
         Console.WriteLine("Exercise 2: \n");
         int x = 30, y = 45, z = 78, w = 64, v = 27;

         float operation = ((float)x + (float)y + (float)z) * (float)w / (float)v;
         Console.WriteLine("The variables are: x = {0}, y = {1}, z = {2}, w = {3}, v = {4}", x, y, z, w, v);
         Console.WriteLine("Operation (x + y + z) * w / v");
         Console.WriteLine("The result is {0}", operation);
         Console.WriteLine("\n-------------------------------------------------------------");
      }
   }
}
