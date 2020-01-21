using System;


namespace Assignment2
{
   class Program
   {
      static void Main(string[] args)
      {
         double radius;
         const int NUM = 4; 
         double total;
         Console.WriteLine("Enter the radius: ");
         radius = Convert.ToInt32(Console.ReadLine());

         total = NUM * Math.PI * Math.Pow(radius,2);

         Console.WriteLine("The area is: {0}", total.ToString("N2"));

      }
   }
}
