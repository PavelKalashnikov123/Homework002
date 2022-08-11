// Напишите программу, которая принимает на вход трехзначное число и на выход показывает
//вторую цифру этого числа
//456->5
//782->8
//918->1

Console.WriteLine("Введите трезначное чило");
string? threeDigitNumber = Console.ReadLine();
var number = Convert.ToString(threeDigitNumber!);
Console.WriteLine("Вторая цифра этого числа " +number[1]);
