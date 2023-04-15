/*Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
int[] array = new int[8];

FillArray(array);

PrintArray(array);

NumberEvenNumbers(array);
int number = NumberEvenNumbers(array);
Console.WriteLine($"Количество четных чисел {number}");

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length;i++)
    {
        array[i] = rand.Next(99,1000);
    }
}

int NumberEvenNumbers(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] % 2 == 0)
        number++;
    }
    return number;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
///*Задайте одномерный массив, заполненный 
 //случайными  числами. Найдите сумму элементов,
 //стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] array = new int[8];

FillArray(array);
PrintArray(array);

int sum = CalculateOddPositionsSum(array);
Console.WriteLine($"Сумма элементов нечетных позиций равна {sum}");

void FillArray(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length;i++)
    {
        array[i] = rand.Next(99,1000);
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}
int CalculateOddPositionsSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
    }
Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива
difference
[3 7 22 2 78] -> 76 double*/

double[] array = new double[4];
FillArray(array);

PrintArray(array);

CalculateMaxMinDiff(array);
double diff = CalculateMaxMinDiff(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {diff}");

void FillArray(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length;i++)
    {
        array[i] = rand.NextDouble();
    }
}
double CalculateMaxMinDiff(double[] array)
{
    double diff = 0;    
        for (int i = 0; i < array.Length; i++)
        {
            double max = array[0];
            double min = array[0];
            if(array[i] > max) max = array [i];              
            if(array[i] < min) min = array [i];
            diff = max - min;
        }                 
        return diff;
}
void PrintArray(double[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}