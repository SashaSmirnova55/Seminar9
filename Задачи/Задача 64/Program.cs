﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Numbers(int M, int N)
{
    if (M > N) return;
    System.Console.Write(M + " ");
    Numbers(M + 1, N);
}

int M = ReadInt("Введите начальное число: ");
int N = ReadInt("Введите конечное число: ");

if (M < N)
{
    Numbers(M, N);
}
else 
{
    Numbers(N, M);
}