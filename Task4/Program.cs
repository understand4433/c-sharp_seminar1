// Напишите программу вычисления модуля числа.
// 2 -> 2
// -3 -> 3
// -7 -> 7

Console.WriteLine("Введите число:");
int inputData = int.Parse(Console.ReadLine());
if (inputData < 0)
{
    inputData = -1 * inputData;
}
Console.WriteLine(inputData);
