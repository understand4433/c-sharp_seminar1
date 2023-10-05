// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого. 
// a = 5; b = 25 -> да 
// a = 2 b = 10 -> нет 
// a = 9; b = -3 -> нет 
// a = -3 b = 9 -> да

Console.WriteLine("Введите первое число: ");
int inputData0 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int inputData1 = int.Parse(Console.ReadLine());
if (inputData1 == inputData0 * inputData0)

Console.WriteLine("Является");
else Console.WriteLine("Не является");

