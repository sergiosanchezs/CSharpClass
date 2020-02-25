using System;

namespace classes1
{
   class Program
   {
      static void Main(string[] args)
      {
         //sum obj = new sum();
         //obj.add();

         Calculations calc = new Calculations();
         calc.input();
      }
   }

   class sum
   {
      public void add()
      {
         int a = 20, b = 30;
         int add = a + b;
         Console.WriteLine($"Sum of two number's is {add}");
      }
   }


   class Calculations
   {

      public void input()
      {
         double a, b, c, d;
         Console.WriteLine("Enter number 1:");
         a = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter number 2:");
         b = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter number 3:");
         c = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter number 4:");
         d = Convert.ToDouble(Console.ReadLine());
         output(ref a, ref b, ref c, ref d);
         power(ref a, ref b);
         cube(ref a);
      }

      public void output(ref double a, ref double b, ref double c, ref double d)
      {
         double sum = a + b + c + d;
         double substract = a - b - c - d;
         double multiply = a * b * c * d;
         double division = a / b / c / d;

         Console.WriteLine($"The sum of 4 numbers is {sum}");
         Console.WriteLine($"The substrac of 4 numbers is {substract}");
         Console.WriteLine($"The multiply of 4 numbers is {multiply}");
         Console.WriteLine($"The division of 4 numbers is {division}");

      }

      public void power(ref double a, ref double b)
      {
         double power;
         power = 1;
         for (int i = 0; i < b; i++)
         {
            power *= a;
         }

         Console.WriteLine($"The {a} powers {b} is {power}");
      }

      public void cube(ref double a)
      {
         double cube;
         cube = 1;
         for (int i = 0; i < 3; i++)
         {
            cube *= a;
         }
         Console.WriteLine($"The cube for {a} is {cube}");
      }
   }
}
