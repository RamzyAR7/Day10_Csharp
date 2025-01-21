using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Csharp
{
    public delegate TResult ArraySortingDelegate<in T, out TResult>(T a, T b);
    internal class SortingDelegate<T>
    {
        public static void Sort(T[] arr, ArraySortingDelegate<T, bool> sortingdelegate)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is null or empty");
            }
            for (int i = 0; i < arr?.Length - 1; i++)
            {
                for (int j = 0; j < arr?.Length - 1 - i; j++)
                {
                    if (sortingdelegate(arr[j], arr[j + 1]))
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        public static void Sort2(T[] arr, Func<T, T, bool> compare)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is null or empty");
            }
            for (int i = 0; i < arr?.Length - 1; i++)
            {
                for (int j = 0; j < arr?.Length - 1 - i; j++)
                {
                    if (compare(arr[j], arr[j + 1]))
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        public static void Swap(ref T a, ref T b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentNullException("A OR B is null");
            }
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
