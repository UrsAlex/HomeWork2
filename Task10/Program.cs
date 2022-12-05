// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine($"Введите число ");
int number = int.Parse(Console.ReadLine());
int numberA = (number / 10);
int result = (numberA % 10);
Console.WriteLine(result);
