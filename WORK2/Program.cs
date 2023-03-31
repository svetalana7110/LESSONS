/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе
показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

if (a > 99 & a < 1000){
    Console.WriteLine(a % 100 / 10);
}
else{   
    Console.WriteLine("Введите трехзначное число");
}
Напишите программу, которая принимает на вход цифру, обозначающую день
недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
Console.WriteLine("Введите номер дня недели");
int a = int.Parse(Console.ReadLine());

if (a == 6 | a == 7){
    Console.WriteLine("Да");
 }
if (a < 0 | a < 6){
    Console.WriteLine("Нет");
}
if (a < 1 | a > 7){
    Console.WriteLine("Это не день недели");
}
Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
string input = Console.ReadLine(); 
int number = int.Parse(input);
if (number > 99){
    while (number > 999){
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}
    else if(number > 99 & number < 1000)
    {
        Console.WriteLine(number % 10);
}
if (number < 100){
    Console.WriteLine("Третьей цифры нет");
}