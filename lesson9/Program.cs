/* using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.Threading;
//int[,,] array = GenerateArray3D();
//PrintArray(array);



int[,,] GenerateArray3D()
{
    int[,,] result = new int[3, 3, 3];

    HashSet<int> hashSet = new HashSet<int>();
    Dictionary<int,int> dictionary = new Dictionary<int, int>();

    Random random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            for (var k = 0; k < result.GetLength(2); k++)
            {
                while (true)
                {
                    int number = random.Next(10, 100);
                    bool isExists = hashSet.TryGetValue(number, out int _);
                    dictionary.TryGetValue(number, out int _);

                    if (!isExists)
                    {
                        result[i, j, k] = number;
                        hashSet.Add(number);

                        dictionary.Add(number,1);
                        break;
                    }
                }
            }
        }
    }

    return result;
}


void PrintArray(int[,,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }

            Console.WriteLine();
        }
    }
}
int number = 100000;
//Print(number);

Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
Print(number);
Console.WriteLine();
stopWatch.Stop();
long tmp = stopWatch.ElapsedMilliseconds;

Stopwatch stopWatch2 = new Stopwatch();
stopWatch2.Start();
PrintCycle(number);
Console.WriteLine();
stopWatch2.Stop();
Console.WriteLine(tmp);
Console.WriteLine(stopWatch2.ElapsedMilliseconds);

void Print(int number){
    if(number ==0 ){
        return;
    }

    Console.Write(".");
    number--;

    Print(number);
}

void PrintCycle(int number){
    
    for (var i = 0; i <= number; i++)
    {
        Console.Write(".");
    }
}
Задача 63.Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. 
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Print(5, 1);
void Print(int number, int i)
{
    if (i <= number)
    {
        Console.Write($"{i},");
        Print(number, i + 1);
    }
}
int n = InputInt("Введите положительное число");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Ввели не положительное число");
}
Console.WriteLine(NaturalNumber(n, m));

int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
Задача 65: Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1,  2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8"*/
/* int m = DataInput();
int n = DataInput();
int DataInput(){
    Console.WriteLine("Введите число");
    int a = int.Parse(Console.ReadLine());
    return a;
}
Print(n, m);
void Print(int number, int i)
{
    if (i <= number)
    {
        Console.Write($"{i} ");
        Print(number, i + 1);
    }
}
Задача 67: Напишите программу, которая будет принимать на вход 
число и возвращать сумму его цифр.
453 -> 12 45 -> 9 */
/* int number = DataInput();
int DataInput(){
    Console.WriteLine("Введите число");
    int a = int.Parse(Console.ReadLine());
    return a;
}
int sum = SummaNumber(number);

Console.WriteLine($"{number} => {sum}");
int SummaNumber(int number)
{
    if (number > 0)
    {
        int sum = number % 10;
        number = number / 10;
        return SummaNumber(number) + sum;        
    }
    return 0;
}
Задача 69: Напишите программу, которая на вход принимает два 
числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8 */
int a = DataInput();
int b = DataInput();
int sum = DegreeNumber( a, b);
Console.WriteLine($"{a},{b} => {sum}");

int DataInput(){
    Console.WriteLine("Введите число");
    int a = int.Parse(Console.ReadLine());
    return a;
}
int DegreeNumber(int a, int b){
    if (b>0)
    {
       int degree = a; 
       b = b - 1;
       return DegreeNumber(a, b) * degree;
    }
    return 1;
}


