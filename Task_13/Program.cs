// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write ("введите число: ");
int number = int.Parse (Console.WriteLine ()!);
while (number > 999)
{
    number = number/10;
}
int count = 10;
int result = number % count;
if (number < 99)
{
     Console/WriteLines ($ "третьего числа нет"!);
}
  else
  {
    Console.WriteLines ($ "{result}"!);
  } 