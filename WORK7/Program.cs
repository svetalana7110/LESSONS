/*Задайте двумерный массив размером m×n, заполненный случайными
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 

double[,] matrix = Generate2DArray(3,4);
PrintArray(matrix);
void PrintArray(double[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}

double[,] Generate2DArray(int m, int n)
{
    double[,] array = new double[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine($"{i}, {j}");
            array[i, j] = random.NextDouble( ),1;
        }
    }
    return array;
}
//Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же 
//указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет */
int[,] matrix = new int[3, 3];
Console.WriteLine($"Введите индексы элемента: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
FillArray(matrix);
PrintArray(matrix);
int element = FindMatrixElement(matrix);
Console.WriteLine($"{element} ");
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
        Console.WriteLine();
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
} 
// я понимаю, что не правильно, но как исправить, или в этом методе нельзя 
//решить задачу?
int FindMatrixElement(int[,] matr)
{
    int element = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            if (x <= i && y <= j)
            {
                element = matrix[x, y];             
            }
            if( x> i || y > j)
            {
              Console.WriteLine($"Такого элемента нет ");  
            } 
        }
    }
    return element;    
}
//Задача 52. Задайте двумерный массив из целых чисел. Найдите
/*среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] matrix = new int[3,3];

FillArray(matrix);
PrintArray(matrix);
ArithmeticMeanColumnElements(matrix);
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0);i++)
    {
        for (int j = 0; j < matr.GetLength(1);j++)
        {
            matr[i,j] = new Random().Next(1,10);
        }
    Console.WriteLine();
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0);i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j]);
            Console.Write(" ");   
        }                       
    Console.WriteLine();
    }
}
//[0 0] [0 1][0 2]
//[1 0] [1 1][1 2]
//[2 0] [2 1][2 2]

void ArithmeticMeanColumnElements(int[,] matr)
{   
    for (int j = 0; j < matr.GetLength(1);j++)
    {
        double result = 0;
        for (int i = 0; i < matr.GetLength(0);i++)
        {
           result +=  matr[i,j];           
        }
        Console.Write($"{ result / matr.GetLength(0)} "); 
        Console.WriteLine();               
    }   
}*/
//Как сделать, чтобы в консоль выводило ответ с одной цифрой 
//после запятой?