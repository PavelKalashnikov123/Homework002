// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введи число: ");

int Number = Convert.ToInt32(Console.ReadLine());
string Number1 = Convert.ToString(Number);

if (Number1.Length > 2)
{
  Console.WriteLine("третья цифра  " + Number1[2]);
}
else 
{
  Console.WriteLine(" третьей цифры нет");
}
