// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("вводим число от 1 до 7:");
int Day=int.Parse(Console.ReadLine()!);

if(Day==6 || Day==7)
{
    Console.WriteLine($"Yes!");
}
else
{
    Console.WriteLine($"No!");
}