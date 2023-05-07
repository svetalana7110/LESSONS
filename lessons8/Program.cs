// See https://aka.ms/new-console-template for more information
/*Задача 53: Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
int[,] array = Generate2DArray(3, 4);
Print2DArray(array);
ReversArray(array);
Console.WriteLine();
Print2DArray(array);

int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" "); //-необходимо для того, чтобы они строчки 
        }                        //переносил, когда столбец заканчивается

        Console.WriteLine();
    }
}
void ReversArray(int[,] array)
{
    //array[0,0]
    //array[0,1]
    //array[0,2]
    //array[0,3]

    //array[2,0]
    //array[2,1]
    //array[2,2]
    //array[array.GetLength(0)-1,3]
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[0, i];
        array[0, i] = array[array.GetLength(0)-1,i];
        array[array.GetLength(0)-1,i] = tmp;
    }
}
//Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно,
программа должна вывести сообщение для пользователя.
int[,] array = Generate2DArray(4, 4);
Print2DArray(array);

ChangeRowsArray(array);
Console.WriteLine();
Print2DArray(array);

int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" "); 
        }                        

        Console.WriteLine();
    }
}
void ChangeRowsArray(int[,] array)
{
    //array[0,0]=array[0,0]
    //array[0,1]=array[1,0]
    //array[0,2]=array[2,0]
   
    //array[0,0]=array[0,0]
    //array[1,0]=array[0,1]
    //array[2,0]=array[0,2]
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j <  j++)
        {
            int tmp = array[i,j];
            array[j,i] = array[i,j];
            array[j,i] = tmp;
        }                 
    }
}
Задача 57: Составить частотный словарь элементов двумерного
массива. Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.
Dictionary<int, int> - указывает тот тип данных, который будет 
лежать в коллекциях
HashSet<Random>
List<string>
Stopwatch -время работы метода 
using System;
using System.Diagnostics;
using System.Threading;
 
public class Example
{
    public static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
 
        stopwatch.Start();
        Thread.Sleep(5000);
        stopwatch.Stop();
 
        Console.WriteLine("Elapsed Time is {0} ms", 
    stopwatch.ElapsedMilliseconds);
    }
}
 
/*
    результат: Elapsed Time is 5000 ms


Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3 4, 6, 1 2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза*/
int[,] array = Generate2DArray(2, 20);
PrintArray(array);
Dictionary<int, int> result = FrequencyDictionaryElements(array);
foreach (var row in result)
{
    Console.WriteLine($":{row.Key} встречается :{row.Value} раз ");    
}
int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 15);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
Dictionary<int, int> FrequencyDictionaryElements(int[,] array)
{
    Dictionary<int, int> dic = new Dictionary<int, int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (!dic.TryAdd(array[i, j], 1))
            {
                dic[array[i, j]] += 1;
            }
        }
    }
    return dic;
}
Задача: как создать массив и вывести его на печать (CreateArray -создай массив,
WriteArray -написать массив)

Console.WriteLine("Введите размеры матриц: ");
int m = InputNumbers("Введите число строк матрицы: ");
int n = InputNumbers("Введите число столбцов матрицы: "); 
int[,] Martrix = new int[m, n];
CreateArray(Martrix); 
WriteArray(Martrix);
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,10);
    }
  }
}
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}