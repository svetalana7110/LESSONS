/*
//Задача. Напишите программу, которая на вход принимает число и выдает его
 квадрат
/*

string input = Console.ReadLine(); 
int number = int.Parse(input); 
Console.WriteLine(number * number);
/*
//Задача No1. Напишите программу, которая на вход принимает два числа и проверяет, является ли
 первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет a = 9, b = -3 -> да a = -3 b = 9 -> нет

Console.WriteLine("Введите две цифры "); 
int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Первое число является квадратом второго");
}
else{
    Console.WriteLine("Первое число не является квадратом второго");
}
//Задача No3. Напишите программу, которая будет выдавать название дня
недели по заданному номеру.
3 -> Среда
5 -> Пятница
20 минут
Console.WriteLine("Введите номер дня недели"); 
int a = int.Parse(Console.ReadLine()); 

if (a == 1){
     Console.WriteLine("Это понедельник");
 }
if (a == 2){
     Console.WriteLine("Это вторник");
}
if (a == 3){
     Console.WriteLine("Это среда");
}
if (a == 4){
    Console.WriteLine("Это четверг");
} 
if (a == 5){
    Console.WriteLine("Это пятница");
}
if (a == 6){
    Console.WriteLine("Это суббота");
}
if (a < 1| a > 7){
    Console.WriteLine("Это не день недели");
}
//Задача No5. Напишите программу, которая на вход принимает
 одно число (N), а на выходе показывает
 все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"

int a = 0;

while (a < 20){
    a = a + 1;
    Console.WriteLine (a);
}

int  N = int.Parse(Console.ReadLine()); 

int a = -N;

while (a <= N){
    Console.Write($"{a} ");
    a = a + 1;
}
//Задача No7. Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает последнюю цифру этого числа.
456 -> 6 782 -> 2 918 -> 8
 
Console.WriteLine("Введите трехзначное число");
int N = int.Parse(Console.ReadLine());

if (N > 99 & N < 1000){
    Console.WriteLine(N % 10);
 }
else{
    Console.WriteLine("Введите трехзначное число");
}
*/
string input = Console.ReadLine(); 
int number = int.Parse(input); 
Console.WriteLine(number * number);