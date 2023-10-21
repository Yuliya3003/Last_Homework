﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

void GetNum(int num) {
     if (num == 1) {
        Console.Write(num);
     }
     else {
        Console.Write(num + " ");
        GetNum(num-1);
     }
}
GetNum(N);