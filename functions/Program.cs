using System;
using System.Linq;

class Program
{
    // 1. Функция для суммы двух целых чисел
    static int SumTwoNumbers(int a, int b)
    {
        return a + b;
    }

    // 2. Функция для вычисления площади окружности
    static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // 3. Функция для получения длины строки
    static int StringLength(string s)
    {
        return s.Length;
    }

    // 4. Функция для нахождения наибольшего значения в массиве
    static int MaxInArray(int[] arr)
    {
        if (arr.Length == 0)
        {
            throw new ArgumentException("Array is empty");
        }
        return arr.Max();
    }

    // 5. Функция для вычисления факториала числа
    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    // 6. Функция для проверки строки на палиндром
    static bool IsPalindrome(string s)
    {
        return s == new string(s.Reverse().ToArray());
    }

    // 7. Функция для объединения двух массивов
    static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        return arr1.Concat(arr2).ToArray();
    }

    // 8. Функция для проверки, является ли число простым
    static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    // 9. Функция для реверсирования строки
    static string ReverseString(string s)
    {
        return new string(s.Reverse().ToArray());
    }

    // 10. Функция для суммы всех элементов в двумерном массиве
    static int Sum2DArray(int[,] arr)
    {
        int total = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                total += arr[i, j];
            }
        }
        return total;
    }

    static void Main(string[] args)
    {
        
        Console.WriteLine(SumTwoNumbers(3, 5));  
        Console.WriteLine(CircleArea(5));  
        Console.WriteLine(StringLength("Hello"));  
        Console.WriteLine(MaxInArray(new int[] { 1, 2, 3, 4, 5 }));  
        Console.WriteLine(Factorial(5));  
        Console.WriteLine(IsPalindrome("racecar")); 
        Console.WriteLine(string.Join(", ", MergeArrays(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 })));  
        Console.WriteLine(IsPrime(7));  
        Console.WriteLine(ReverseString("Hello"));  
        Console.WriteLine(Sum2DArray(new int[,] { { 1, 2 }, { 3, 4 } }));  

        Console.ReadKey();
    }
}
