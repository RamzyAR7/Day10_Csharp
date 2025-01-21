using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Csharp
{
    internal class SortingAlgorithm<T> where T : IComparable<T>, ICloneable
    {
        public static void Sort(T[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("Array is null or empty");
            }
            for (int i = 0; i < arr?.Length - 1; i++)
            {
                for (int j = 0; j < arr?.Length - 1 - i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1)
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
        public static T[] CloneArray(T[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr), "Array is null");
            }

            T[] clonedArray = new T[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                clonedArray[i] = (T)arr[i].Clone();
            }
            return clonedArray;
        }
    }
}
