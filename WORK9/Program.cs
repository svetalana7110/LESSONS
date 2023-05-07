/* Задача 64.Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с 
помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Print(1, 9);
void Print(int number, int i)
{
    if (i >= number)
    {
        Console.Write($"{i} ");
        Print(number, i - 1);
    }
}
/* Задача 66.Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.Выполнить с 
помощью рекурсии.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30 
int m = DataInput();
int n = DataInput();

Console.WriteLine($"Сумма элементов от {m} до {n} = {SummaNaturalNumber(m, n)}");

int DataInput(){
    Console.WriteLine("Введите число");
    int a = int.Parse(Console.ReadLine());
    return a;
}
int SummaNaturalNumber(int m, int n){
    if (m == n)    
       return n;
    return n + SummaNaturalNumber(m, n - 1);    
} 

/*3.Напишите программу вычисления функции Аккермана с помощью 
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 
        n+1             m=0
А(m,n)= A(m-1,1)        m>0,n=0
        A(m-1,A(m,n-1)) m>0,n>0

Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int numberN = int.Parse(Console.ReadLine());
int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}
Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");*/
