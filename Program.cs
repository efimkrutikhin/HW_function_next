// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Prompt(string message)
// {
//     Console.Write(message);
//     string readInput = Console.ReadLine();
//     int result = int.Parse (readInput);
//     return result;
// }

// int Power(int powerBase, int exponent)
// {
//     int power = 1;
//     for (int i = 0; i < exponent; i++){
//         power *= powerBase;
//     }
//     return power;
// }

// bool ValidateExponent(int exponent)
// {
//     if (exponent < 0)
//     {
//         Console.WriteLine("Показатель не должен быть меньше нуля");
//         return false;
//     }
//     return true;
// }

// int powerBase = Prompt ("Введите основание: ");
// int exponent = Prompt ("Введите показатель: ");
// if (ValidateExponent(exponent)){
//     Console.WriteLine($"Число {powerBase} в степени {exponent } равно {Power(powerBase, exponent)}");
// }




// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Prompt(string message)
// {
//     Console.Write(message); //Выводим приглашение ко вводу
//     string readInput = Console.ReadLine(); 
//     int result = int.Parse(readInput); //приводим к числу
//     return result; //возвращаем результат
// }

// int SumAllDigit(int number)
// {
//     int result = 0;
//     while (number > 0)
//     {
//         result += number % 10;
//         number = number / 10;
//     }
//     return result;
// }

// int number = Prompt ("Введите число: ");
// Console.WriteLine ($"Сумма всех чисел в цифре  {number} = {SumAllDigit(number)}");




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Ввод числа с экрана
// using System;

// class Program
// {
//     static void Main()
//     {
//         int length = Prompt("Длина массива: ");
//         int min = Prompt("Начальное значение для диапазона случайного числа: ");
//         int max = Prompt("Конечное значение для диапазона случайного числа: ");

//         int[] array = GenerateArray(length, min, max);
//         PrintArray(array);

//         Console.ReadLine();
//     }

//     static int Prompt(string message)
//     {
//         Console.Write(message); // Выводим приглашение к вводу
//         string readInput = Console.ReadLine();
//         int result = int.Parse(readInput);
//         return result;
//     }

//     static int[] GenerateArray(int length, int minValue, int maxValue)
//     {
//         int[] array = new int[length]; // Объявляем массив
//         Random random = new Random();
//         for (int i = 0; i < length; i++)
//         {
//             array[i] = random.Next(minValue, maxValue + 1);
//         }
//         return array;
//     }

//     static void PrintArray(int[] array)
//     {
//         Console.Write("[");
//         for (int i = 0; i < array.Length - 1; i++)
//         {
//             Console.Write($"{array[i]}, ");
//         }
//         Console.Write($"{array[array.Length - 1]}");
//         Console.WriteLine("]");
//     }
// }
