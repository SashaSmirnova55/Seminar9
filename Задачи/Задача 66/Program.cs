// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int X)
{
    if (X == 0) return 0;
    return X % 10 + SumNumbers(X / 10);
}



int X = ReadInt("Введите число: ");
System.Console.WriteLine($" Сумма цифр введённого числа равна: {SumNumbers(X)}");