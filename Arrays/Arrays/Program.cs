using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Arrays
{
   class Program
   {
      static void Main(string[] args)
      {
         //arraysMethod1();
         Console.WriteLine("=================================================");
         addingTwoArrays();
         Console.WriteLine("=================================================");
         copyOneArrayToAnother();
         Console.WriteLine("=================================================");
         sortingAscendingOrder();
         Console.WriteLine("=================================================");
         sortingDescendingOrder();
         Console.WriteLine("=================================================");
         mergeTwoArrays();
      }

      static void mergeTwoArrays()
      {
         int[] a = new int[4] { 2, 4, 6, 8 };
         int[] b = new int[4] { 3, 5, 7, 9 };

         Console.WriteLine("Array Printing a: ");
         printIntArray(a);
         Console.WriteLine("Array Printing b: ");
         printIntArray(b);

         int sizeNewArray = a.Length + b.Length;

         int[] c = new int[sizeNewArray];
         Console.WriteLine(sizeNewArray);

         int k = 0;
         for (int i = 0; i < c.Length; i++)
         {
            if (i < a.Length)
               c[i] = a[i];
            else
            {
               c[i] = b[k];
               k++;
            }
         }

         Console.WriteLine("Array Printing C: ");
         printIntArray(c);
      }

      static void sortingAscendingOrder()
      {
         int[] a1 = new int[10];
         int i, j, t;
         Console.WriteLine("Enter Values");
         for (i = 0; i < 10; i++)
         {
            Console.WriteLine($"Element - {i}");
            a1[i] = Convert.ToInt32(Console.ReadLine());
         }
         for (i = 0; i < 10; i++)
         {
            for (j = i + 1; j < 10; j++)
            {
               if (a1[j] < a1[i])
               {
                  t = a1[i];
                  a1[i] = a1[j];
                  a1[j] = t;
               }
            }
         }

         Console.WriteLine("Ascending order:");
         for (i = 0; i < 10; i++)
            Console.WriteLine($"{i} - {a1[i]}");
         Console.WriteLine();
      }

      static void sortingDescendingOrder()
      {
         int[] a1 = new int[10];
         int i, j, t;
         Console.WriteLine("Enter Values");
         for (i = 0; i < 10; i++)
         {
            Console.WriteLine($"Element - {i}");
            a1[i] = Convert.ToInt32(Console.ReadLine());
         }
         for (i = 0; i < 10; i++)
         {
            for (j = i + 1; j < 10; j++)
            {
               if (a1[j] > a1[i])
               {
                  t = a1[j];
                  a1[j] = a1[i];
                  a1[i] = t;
               }
            }
         }

         Console.WriteLine("Descending order:");
         for (i = 0; i < 10; i++)
            Console.WriteLine($"{i} - {a1[i]}");
         Console.WriteLine();
      }
      static void copyOneArrayToAnother()
      {
         int[] first = new int[8] { 16, 14, 12, 10, 7, 5, 3, 1 };
         int size = first.Length;
         int[] second = new int[size];

         for (int i = 0; i < size; i++)
            second[i] = first[i];

         Console.WriteLine("Copy one array into another one");
         Console.WriteLine("Elements of the first array: ");
         printIntArray(first);
         Console.WriteLine("Elements of the second array: ");
         printIntArray(second);

      }

      static void addingTwoArrays()
      {
         int[] a = new int[4] { 2, 4, 6, 8 };
         int[] b = new int[4] { 3, 5, 7, 9 };

         Console.WriteLine("Array Printing a: ");
         printIntArray(a);
         Console.WriteLine("Array Printing b: ");
         printIntArray(b);

         int[] c = new int[4];

         for (int i = 0; i < a.Length; i++)
            c[i] = a[i] + b[i];

         Console.WriteLine("Array Printing C: ");
         printIntArray(c);
      }

      static void printIntArray(int[] arr)
      {
         foreach(int e in arr)
            Console.Write(e + " ");
         Console.WriteLine();
      }

      static void arraysMethod1()
      {
         int[] a = new int[100];
         int i, n, sum = 0;
         Console.WriteLine("Input the number of elements to be stored in the array: ");

         n = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Input {0} elements in the array ", n);
         for (i = 0; i < n; i++)
         {
            Console.Write("element - {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
         }
         for (i = 0; i < n; i++)
         {
            sum += a[i];
         }
         Console.Write($"Sum of all elements stored in the array is : {sum}");
      }
   }

}
