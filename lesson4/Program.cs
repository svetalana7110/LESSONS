// See https://aka.ms/new-console-template for more information
/*Напишите программу, которая принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24 5 -> 120
Напишите программу, которая принимает на вход число N и выдаёт 
сумму чисел от 1 до N.
4 -> 10 7 -> 28 8 -> 36 
Console.WriteLine("Введите число:  ");
int n = int.Parse(Console.ReadLine());

int sum = GetSumToNumber(n);
Console.WriteLine(sum);
int GetSumToNumber(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum+=i;
    }
    return sum;
}
Напишите программу, которая принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24 5 -> 120
Console.WriteLine("Введите число:  ");
int n = int.Parse(Console.ReadLine());

int fact = Factorial(n);

Console.WriteLine(fact);

int Factorial(int n)
{
    int factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial = factorial * i ;  
    }
    return factorial;
}
Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
int[] array = new int[8];

Random rand = new Random();
for (int i = 0; i < array.Length; i++)
    array [i] = rand.Next(0,2); 
for (int i = 0; i < array.Length; i++)
{
  Console.WriteLine(array[i]); 
}
новый код 
int[] array = RandomArray();
PrintArray(array);
int[] RandomArray()
{
    int[] array = new int[8];

    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
        array [i] = rand.Next(0,2); 
      return array;
}
void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);   
    }
}
Cоздать массив, чтобы он умел 1.принимать 
длину массива, не только 8, но любую другую
котррую захотим. 2. Чтобы можно было передавать
диапазон цифр, например от 1 до 100.
int[] array = RandomArray();*/
Console.WriteLine("Длина массива");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Минимальное");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Максимальное");
int max = int.Parse(Console.ReadLine());

int[] array = RandomArray(size,min,max);
PrintArray(array);
int[] RandomArray(int size,int min,int max)
{
    int[] array = new int[size];

    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
        array [i] = rand.Next(min,max); 
      return array;
}
void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);   
    }
}

    





