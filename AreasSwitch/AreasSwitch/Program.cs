using System;
using System.Linq.Expressions;

namespace AreasSwitch
{
   class Program
   {
      static void Main(string[] args)
      {
         int option;

         Console.WriteLine("Select the option to calculate:");
         Console.WriteLine("1. Area of Triangle.");
         Console.WriteLine("2. Area of Rectangle.");
         Console.WriteLine("3. Area of Trapezoid.");
         Console.WriteLine("4. Area of Ellipse.");
         Console.WriteLine("5. Area of Square.");
         Console.WriteLine("6. Area of Parallelogram.");
         Console.WriteLine("7. Area of Circle.");
         Console.WriteLine("8. Area of a Sector.");

         option = Convert.ToInt32(Console.ReadLine());

         switch (option)
         {
            case 1:
               Console.WriteLine($"The Area of Triagle is { getTriangleArea(3, 4) }");
               break;
            case 2:
               Console.WriteLine($"The Area of Rectangle is { getRectangleArea(3, 4) }");
               break;
            case 3:
               Console.WriteLine($"The Area of Trapezoid is { getTrapezoidArea(3, 4, 2.5) }");
               break;
            case 4:
               Console.WriteLine($"The Area of Ellipse is { getEllipseArea(3, 4) }");
               break;
            case 5:
               Console.WriteLine($"The Area of Square is { getSquareArea(3) }");
               break;
            case 6:
               Console.WriteLine($"The Area of Parallelogram is { getParallelogramArea(5, 6) }");
               break;
            case 7:
               Console.WriteLine($"The Area of Circle is { getCircleArea(5.5) }");
               break;
            case 8:
               Console.WriteLine($"The Area of Sector is { getSectorArea(5.5, 0.45) }");
               break;
            default:
               break;
         }

         // Second Excercise:
         separator();
         string sentence = "Today is Wednesday and its raining";
         Console.WriteLine($"The sentence: {sentence}");
         Console.WriteLine($" -> The smallest word is: \"{ getSmallestWord(sentence) }\"");
         Console.WriteLine($" -> The largest word is: \"{ getLargestWord(sentence) }\"");

         // Third exercise
         separator();
         Console.WriteLine("Please enter a number to sum all the digits");
         int digits = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine($"The sum of the digits is { getSumOfDigits(digits) }");

         // Fourth Exercise
         separator();
         Console.WriteLine("Input the Array 1 values in 2x2");
         int[,] array1 = new int[2, 2];
         array1 = getUserArrayValues();
         Console.WriteLine("The complete Array 1:");
         printInt2DArray(array1);
         Console.WriteLine("Input the Array 2 values in 2x2");
         int[,] array2 = new int[2, 2];
         array2 = getUserArrayValues();
         Console.WriteLine("The complete Array 2:");
         printInt2DArray(array2);
         printInt2DArray(sumTwoDimentionalArray(array1, array2));
      }

      private static double getTriangleArea(double tBase, double vertialHeight)
      {
         return (tBase * vertialHeight * 0.5);
      }
      private static double getRectangleArea(double width, double height)
      {
         return (width * height);
      }
      private static double getTrapezoidArea(double a, double b, double h)
      {
         return ((a + b) * h * 1/2);
      }
      private static double getEllipseArea(double a, double b)
      {
         return (Math.PI * a * b);
      }
      private static double getSquareArea(double a) 
      { 
         return Math.Pow(a, 2);
      }
      private static double getParallelogramArea(double b, double h)
      {
         return (b * h);
      }
      private static double getCircleArea(double r)
      {
         return (Math.PI * Math.Pow(r, 2));
      }
      private static double getSectorArea(double r, double angle)
      {
         return (0.5 * Math.Pow(r, 2) * angle);
      }

      private static string getSmallestWord(string sentence)
      {
         string[] arr = sentence.Split(" ");
         int idxFound = 0;
         string element = arr[0];

         for (int i = 1; i < arr.Length; i++)
         {
            if (element.Length > arr[i].Length)
            {
               idxFound = i;
               element = arr[i];
            }
         }

         return arr[idxFound];
      }

      private static string getLargestWord(string sentence)
      {
         string[] arr = sentence.Split(" ");
         int idxFound = 0;
         string element = arr[0];

         for (int i = 1; i < arr.Length; i++)
         {
            if (element.Length < arr[i].Length)
            {
               idxFound = i;
               element = arr[i];
            }
         }

         return arr[idxFound];
      }

      private static int getSumOfDigits(int number)
      {
         int sum = 0;
         while (number > 0)
         {
            sum += number % 10;
            number = number / 10;
         }
         return sum;
      }

      private static int[,] getUserArrayValues()
      {
         int[,] array = { { 0, 0}, { 0, 0 } };
         int r, c;
         for (r = 0; r < 2; r++)
         {
            for (c = 0; c < 2; c++)
            {
               Console.WriteLine($"[{r}][{c}] = ");
               array[r, c] = Convert.ToInt32(Console.ReadLine());
            }
         }
         return array;
      }

      private static int[,] sumTwoDimentionalArray(int[,] arrayA, int[,] arrayB)
      {
         int[,] arraySum = new int[2, 2];
         int r, c;
         for (r = 0; r < 2; r++)
         {
            for (c = 0; c < 2; c++)
            {
               arraySum[r, c] = arrayA[r, c] + arrayB[r, c];
            }
         }
         return arraySum;
      }

      static void printInt2DArray(int[,] arr)
      {
         int r, c;
         for (r = 0; r < 2; r++)
         {
            for (c = 0; c < 2; c++)
            {
               Console.WriteLine($"[{r}][{c}] = [{arr[r, c]}]");
            }
         }
         Console.WriteLine();
      }

      private static void separator()
      {
         Console.WriteLine("=========================================================");
      }

   }
}
