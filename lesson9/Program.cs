using System.Collections.Generic;
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