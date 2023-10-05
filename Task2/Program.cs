Console.Write("Введите число от 1 до 7 : ");
int nuber1 = int.Parse(Console.ReadLine());
string[] days = { "Понеделник", "Вторник", "Среда", "Четверг", "ПТ", "СБ", "ВС" };
if (nuber1 >= 1 && nuber1 <= 7)
{
    Console.Write(days[nuber1 - 1]);
}
else
{
    Console.Write("Ввели число отличное от 1-7");
}
// if (nuber1==1)
// {
//     Console.Write("Понедельник");
// }
// else if (nuber1==2)
// {
//     Console.Write("Вторник");
// }
// else if (nuber1==3)
// {
//     Console.Write("Среда");
// }
// else if (nuber1==4)
// {
//     Console.Write("Четверг");
// }
// else if (nuber1==5)
// {
//     Console.Write("Пятница");
// }
// else if (nuber1==6)
// {
//     Console.Write("Суббота");
// }
// else if (nuber1==7)
// {
//     Console.Write("Воскресение");
// }
// else 
// {
//     Console.Write("Это не день недели");
// }