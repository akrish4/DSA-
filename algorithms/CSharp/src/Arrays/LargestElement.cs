/******************************************************************************
            Program to compute the largest element in array
******************************************************************************/

using System;

class LargestElementFinder
{
    static void Main()
    {
        const int maxSize = 100;
        int[] array = new int[maxSize];
        int size;
        int max;

        // Reading the size of the array
        Console.Write("Enter the size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());

        // Reading the elements of array
        Console.WriteLine($"Enter the {size} elements of the array: ");
        for (int i = 0 ; i < size ; i++)
        {
            Console.Write($"Element [{i}]: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Printing the array
        Console.WriteLine("The input array: ");
        for (int i = 0 ; i < size ; i++)
        {
            Console.Write(array[i] + " ");
        }

        // Assigning the first element of the array to max variable
        max = array[0];

        // Checking for elements greater than the value of max variable
        for (int i = 1 ; i < size ; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }

        // Printing out the result
        Console.WriteLine($"\nThe largest element of the array: {max}");
    }
}

/******************************************************************************
                              OUTPUT SAMPLE
    Enter the size of the array: 5
    Enter the 5 elements of the array:
    Element [0]: 1
    Element [1]: 7
    Element [2]: 2
    Element [3]: 5
    Element [4]: 4
    The input array:
    1 7 2 5 4
    The largest element of the array: 7
******************************************************************************/