/*
Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
*/

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int DivByTwo = number % 2;
    if (DivByTwo == 0)
    {
        Console.Write($"{number} является четным числом");
    }
    else
    {
        Console.Write($"{number} не является четным числом");
    }
}
else
{
    Console.WriteLine("Введено не натуральное число!");
}