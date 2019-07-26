using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE_Console
{
    class Program
    {
        static int equilibrium(int[] arr, int n)
        {
            int i, j;
            int leftsum, rightsum;
            for (i = 0; i < n; ++i)
            {
                leftsum = 0;
                rightsum = 0;
                for (j = 0; j < i; j++)
                    leftsum += arr[j];
                for (j = i + 1; j < n; j++)
                    rightsum += arr[j];
                if (leftsum == rightsum)
                    return i;
            }
            return -1;
        }
        static void printRepeating(int[] arr, int size)
        {
            int i, j;
            Console.Write("Repeated Elements are :");
            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                        Console.Write(arr[i] + " ");
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arrPOE = { -7, 5, 5, 2, -4, 3, 0 };
            int arr_size = arrPOE.Length;
            Console.Write(equilibrium(arrPOE, arr_size));
            Console.WriteLine("\n");
            int[] arrRepaeting = { 4, 2, 4, 5, 2, 3, 1 };
            int arr_sizeRep = arrRepaeting.Length;
            printRepeating(arrRepaeting, arr_sizeRep);

            Console.ReadLine();
        }
    }
}
