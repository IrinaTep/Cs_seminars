/*
Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
*/

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

int divByTwo = number % 2;
if (divByTwo == 0)
{
    Console.Write($"{number} является четным числом");
}
else
{
    Console.Write($"{number} не является четным числом");
}
