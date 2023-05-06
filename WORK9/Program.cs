/* 1.Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с 
помощью рекурсии.
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
/* 2.Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30 */ 
Print(5, 1);
void SummaNumber(int number, int i)
{
    if (i <= number)
    {
        Console.Write($"{i},");
        Print(number, i + 1);
    }

}

/* 3.Напишите программу вычисления функции Аккермана с помощью 
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
