using System;
using System.Linq;

namespace ArraysAssignment
{
   class Program
   {
      static void Main(string[] args)
      {
         int[] array1 = new int[12] { 23, 8, 14, 105, 7, 78, 2, 23, 65, 19, 43, 38 };
         Console.WriteLine("Original Array: ");
         printIntArray(array1);
         printSeparator();
         array1 = new int[12] { 23, 8, 14, 105, 7, 78, 2, 23, 65, 19, 43, 38 };
         findMaxAndMinInArray(array1);
         printSeparator();
         array1 = new int[12] { 23, 8, 14, 105, 7, 78, 2, 23, 65, 19, 43, 38 };
         sortingAscendingOrderAndInsertElementAtTheEnd(array1, 15);
         printSeparator();
         array1 = new int[12] { 23, 8, 14, 105, 7, 78, 2, 23, 65, 19, 43, 38 };
         sortingAscendingOrderAndDeleteASpecifiedElement(array1, 4);
         printSeparator();
         array1 = new int[12] { 23, 8, 14, 105, 7, 78, 2, 23, 65, 19, 43, 38 };
         findFirstSecondLargestElement(array1);
         printSeparator();
         array1 = new int[12] { 23, 8, 14, 105, 7, 78, 2, 23, 65, 19, 43, 38 };
         insertNewElementInArray(array1);

      }

      static void findMaxAndMinInArray(int[] arr)
      {
         // 1.	Write a C# program and find minimum and maximum elements in a array 
         int minNumber, maxNumber;
         minNumber = maxNumber = arr[0];

         for(int i = 1; i < arr.Length; i++)
         {
            if (minNumber > arr[i])
               minNumber = arr[i];

            if (maxNumber < arr[i])
               maxNumber = arr[i];
         }

         Console.WriteLine($"The maximum number in the array is {maxNumber}");
         Console.WriteLine($"The minimum number in the array is {minNumber}");
      }

      static void sortingAscendingOrderAndInsertElementAtTheEnd(int[] arr, int newElement)
      {
         //2.Sort a array in ascending order than insert a element at the end
         int i, j, t;

         for (i = 0; i < arr.Length; i++)
         {
            for (j = i + 1; j < arr.Length; j++)
            {
               if (arr[j] < arr[i])
               {
                  t = arr[i];
                  arr[i] = arr[j];
                  arr[j] = t;
               }
            }
         }

         Array.Resize(ref arr, arr.Length + 1);
         arr[arr.Length - 1] = newElement;

         Console.WriteLine($"Sorting Ascending Order Array and adding {newElement} at the end of the array.");
         printIntArray(arr);
      }

      static void sortingAscendingOrderAndDeleteASpecifiedElement(int[] arr, int idxDelete)
      {
         //3.Sort a array in ascending order than delete element
         int i, j, t, numberDeleted;

         numberDeleted = arr[idxDelete];

         // Sorting ascending 
         for (i = 0; i < arr.Length; i++)
         {
            for (j = i + 1; j < arr.Length; j++)
            {
               if (arr[j] < arr[i])
               {
                  t = arr[i];
                  arr[i] = arr[j];
                  arr[j] = t;
               }
            }  
         }

         // deleting the element
         for (int a = idxDelete; a < arr.Length - 1; a++)
         {
            // shifting elements backwards, to fill the gap at [idxElement]
            arr[a] = arr[a + 1];
         }
         // Reduce the size of the array
         Array.Resize(ref arr, arr.Length - 1);

         Console.WriteLine($"Sorting Ascending Order Array and then deleting the element: Array[{idxDelete}] = {numberDeleted} ");
         printIntArray(arr);
      }

      static void findFirstSecondLargestElement(int[] arr)
      {
         //4.	Find a first and second largest element in the array
         int i, j, t;

         int firstLargestNumber, secondLargestNumber;

         // Sorting ascending 
         for (i = 0; i < arr.Length; i++)
         {
            for (j = i + 1; j < arr.Length; j++)
            {
               if (arr[j] < arr[i])
               {
                  t = arr[i];
                  arr[i] = arr[j];
                  arr[j] = t;
               }
            }
         }

         printIntArray(arr);

         firstLargestNumber = arr[arr.Length - 1];
         secondLargestNumber = arr[arr.Length - 2];

         Console.WriteLine($"The first largest number in the array is {firstLargestNumber}");
         Console.WriteLine($"The second largest number in the array is {secondLargestNumber}");
      }

      static void insertNewElementInArray(int[] arr)
      {
         int newElement, idxNewElement;
         Console.WriteLine("Original Array:");
         printIntArray(arr);

         Console.WriteLine("Enter the value you want to insert in the array:");
         newElement = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine($"Enter the index where you want to insert the value {newElement}");
         idxNewElement = Convert.ToInt32(Console.ReadLine());

         // Amplifying the size of the array
         Array.Resize(ref arr, arr.Length + 1);

         // deleting the element
         for (int a = arr.Length - 1; a > idxNewElement; a--)
         {
            // shifting elements backwards, to fill the gap at [idxNewElement]
            arr[a] = arr[a - 1];
         }
         // insert the element
         arr[idxNewElement] = newElement;
         Console.WriteLine("After inserting the element");
         printIntArray(arr);
      }
      //5.	Insert a new number at the specified index by the user

      static void printIntArray(int[] arr)
      {
         for (int i = 0; i < arr.Length; i++)
            Console.WriteLine($"{i} - {arr[i]}");
         Console.WriteLine();
      }

      static void printSeparator()
      {
         Console.WriteLine("#######################################################################");
      }
   }
}
