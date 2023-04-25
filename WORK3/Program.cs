/* Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
AB = √(xb - xa)2 + (yb - ya)2 +(zb - za)2
Math.Sqrt
Math.Pow(5, 2, 6)

Console.WriteLine("Введите X координату точки А ");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y координату точки А ");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z координату точки А ");
int za = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X координату точки В ");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y координату точки В ");
int yb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z координату точки В ");
int zb = int.Parse(Console.ReadLine());

double distance  = GetDistance(xa,xb,ya,yb,za,zb);

Console.WriteLine($"Расстояние между двумя точками {distance}" );

double GetDistance(double xa,double xb,double ya,double yb,double za,double zb)
{
    return Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2)+ Math.Pow((zb - za),2));
}

Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число  ");
int N = int.Parse(Console.ReadLine());

Cube(N);
void Cube (int N){
    
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(i * i * i);   
    }
}

Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

Console.WriteLine("Введите число:  ");
int i = int.Parse(Console.ReadLine());
if (i > 9999 & i < 100000)
{
    int number1 = i / 1000;
    int number2 = i % 100;
    int reversNumder2 =((number2 % 10) * 10 + (number2 / 10));
    if (number1 == reversNumder2)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
       Console.WriteLine("Это не палиндром");
    } 
}
else
{   
    Console.WriteLine("Введите пятизначное число ");
}
Продвинутый уровень искать полиндромы
string tmp = "12321";

string reversed = tmp.Reverse();

Console.WriteLine(tmp.Equals(reversed,StringComparison.
CurrentCultureIgnoreCase));
Метод, который переводит в массив  число
int[] ConvertToArray(int number)
{
    int length = GetLengthNumber(number);
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = number % 10;
        number = number / 10;
    }
    return result;
}*/
int number = int.Parse(Console.ReadLine());
bool result = CheckPolindrom(number);
Console.WriteLine(result);
bool CheckPolindrom(int number)
{
    int[] array = ConvertToArray(number);
    int[] reverseArray = ReverseArray(array);
    bool result = Equals(array, reverseArray);
    return result;
}
void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
bool Equals(int[] array1, int[] array2)
{
    if (array1.Length != array2.Length)
    {
        return false;
    }
    for (var i = 0; i < array1.Length; i++)
    {
        if (array1[i] != array2[i])
        {
            return false;
        }
    }
    return true;
}
int[] ReverseArray(int[] array)
{
    int[] result = new int[array.Length];
    for (var i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length - 1 - i];
    }
    return result;
}
int[] ConvertToArray(int number)
{
    int length = GetLengthNumber(number);
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = number % 10;
        number = number / 10;
    }
    return result;
}
int GetLengthNumber(int number)
{
    int length = 0;
    while (number != 0)
    {
        number = number / 10;
        length++;
    }
    return length;
}