using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_Csharp
{
    public delegate string StringTransformer(string input);
    public delegate int MathOperation(int a, int b);
    public delegate R Converter<in T, out R>(T input);

    internal class DelegateOperations
    {
        public static List<string> TransformStrings(List<string> inputList, StringTransformer transformer)
        {
            List<string> transformedList = new List<string>();
            foreach (var item in inputList)
            {
                transformedList.Add(transformer(item));
            }
            return transformedList;
        }
        public static int PerformMathOperation(int a, int b, MathOperation operation)
        {
            return operation(a, b);
        }

        public static List<R> ConvertList<T, R>(List<T> inputList, Converter<T, R> converter)
        {
            List<R> convertedList = new List<R>();
            foreach (var item in inputList)
            {
                convertedList.Add(converter(item));
            }
            return convertedList;
        }
        public static List<int> FunctionToList(List<int> InputList, Func<int, int> func)
        {
            List<int> result = new List<int>();
            foreach (int item in InputList)
            {
                result.Add(func(item));
            }
            return result;
        }
        public static void ActionToList(List<string> InputList, Action<string> action)
        {
            foreach (string item in InputList)
            {
                action(item);
            }
        }
        public static List<int> FilterList(List<int> InputList, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (int item in InputList)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static List<string> FilterStrings(List<string> InputList, Func<string, bool> condition)
        {
            List<string> result = new List<string>();
            foreach (string item in InputList)
            {
                if (condition(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        public static R PerformOperation<T,R>(in T a, in T b, Func<T, T, R> operation)
        {
            return operation(a, b);
        }
    }
}
