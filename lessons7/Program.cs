/*int[,] array = Generate2DArray(3,4);
PrintArray(array);
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            Console.Write(" "); //-необходимо для того, чтобы онм строчки 
        }                        //переносил, когда столбец заканчивается

        Console.WriteLine();
    }
}

int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine($"{i}, {j}");
            array[i, j] = random.Next(1, 15);
        }
    }

    return array;
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0  1 2  3
1 -2 3 -4
2  3 4  5 
int[,] table = new int[3,4];

FillArray(table);
PrintArray(table);
Console.WriteLine();
PrintArray(table);

void PrintArray(int[,] tab) //вывод массива
{
    for (int rows = 0; rows < tab.GetLength(0); rows++)
    {
        for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        Console.Write($" {table[rows,columns]} ");
            
    }                       
Console.WriteLine();
    }
}

void FillArray(int[,] tab) //заполняем массив случайными числами
{
for (int rows = 0; rows < tab.GetLength(0); rows++)
{
    for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        tab[rows,columns] = rows + columns;
    }
Console.WriteLine();
}
}
 Задайте двумерный массив. Найдите элементы, у
которых оба индекса нечётные, и замените эти элементы на их
квадраты.
Например, изначально массив выглядел вот так:
1 47 2
5 92 3
8 42 4
Новый массив будет выглядеть вот так:
1 47 2
5 81 9
8 42 4

int[,] table = new int[3,4];

FillArray(table);
PrintArray(table);
Console.WriteLine();
СhangeNumberArray(table);
PrintArray(table);

void СhangeNumberArray(int[,] tab)// заменяем ячейку с нечетным 
                                    // индексом на квадрат
{
    for (int i  = 0; i < tab.GetLength(0); i++)
    {
        if (i%2 != 0)
        {
            for (int j = 0; j < tab.GetLength(1); j++)
            {
                if (j%2 != 0)
                {
                    table[i,j] = table[i,j] * table[i,j];
                }   
            }
        }  
    }
}
void PrintArray(int[,] tab) //вывод массива
{
    for (int rows = 0; rows < tab.GetLength(0); rows++)
    {
        for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        Console.Write($" {table[rows,columns]} ");
            
    }                       
Console.WriteLine();
}
}

void FillArray(int[,] tab) //заполняем массив случайными числами
{
for (int rows = 0; rows < tab.GetLength(0); rows++)
{
    for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        tab[rows,columns] = new Random().Next(10,100);
    }
Console.WriteLine();
}
}

Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 47 2
5 92 3
8 42 4
Сумма элементов главной диагонали: 1+9+2 = 12*/

// заполняем массив нужными числами
//table[0,0]=3;table[0,1]=8;table[0,2]=6;table[0,3]=9;
//table[1,0]=3;table[1,1]=3;table[1,2]=3;table[1,3]=3;
//table[2,0]=3;table[2,1]=3;table[2,2]=3;table[2,3]=3;
int[,] table = new int[4,4];
FillArray(table);
PrintArray(table);
Console.WriteLine();
int sumDiagonalElements = FindSumDiagonalElements(table);
Console.WriteLine($"Сумма элементов главной диагонали :{sumDiagonalElements}");

void PrintArray(int[,] tab)
{
for (int rows = 0; rows < tab.GetLength(0); rows++)
{
    for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        Console.Write($" {table[rows,columns]} ");
        Console.Write("");   
    }                       
Console.WriteLine();
}
}
void FillArray(int[,] tab)
{
for (int rows = 0; rows < tab.GetLength(0); rows++)
{
    for (int columns = 0; columns < tab.GetLength(1); columns++)
    {
        tab[rows,columns] = new Random().Next(1,10);
    }
Console.WriteLine();
}
}

int FindSumDiagonalElements(int[,] tab)
{
    int sumDiagonalElements = 0;
    for (int rows = 0; rows < tab.GetLength(0); rows++)
    {
        for (int columns = 0; columns < tab.GetLength(1); columns++)
        {
            if (rows == columns)
            {
              sumDiagonalElements = sumDiagonalElements + table[rows,columns];     
            }
        }   
    }
    return sumDiagonalElements;
} 