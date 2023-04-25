
/*int x = int.Parse(Console.ReadLine());

int y = int.Parse(Console.ReadLine());

 false -  не правильно (и), то второе не проверяет
if           (x == 0 && y == 0){
     true - правильно (или), то второе не проверяет
if           (x == 0 || y == 0){
    Console.WriteLine("Х или У равны нулю. Данные введены не правильно");
    return;
}
Console.WriteLine("23456");

Напишите программу, которая принимает на вход координаты
точки (X и Y), причем X и Y не равны 0 и выдает номер
четверти плоскости, в которой находится эта точка.
Console.WriteLine("Введите Х");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите У");
int y = int.Parse(Console.ReadLine());

int result = GetNumberOfQuarter(x, y);
if (result == 0)
{
    Console.WriteLine("Х или У равны нулю. Данные введены не правильно");
    return;
}
Console.WriteLine(result);
int GetNumberOfQuarter(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }

    if(y > 0 && x < 0)
    {
        return 2;
    }

    if(y < 0 && x < 0)
    {
        return 3;
    }

    if(x > 0 && y < 0)
    {
        return 4;
    }

    return 0;
}
Напишите программу, которая по заданному номеру четверти,
показывает 
диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int N = int.Parse(Console.ReadLine());
string range = GetRangeByQuarter(N);
Console.WriteLine(range);
string GetRangeByQuarter(int N)
{
    if (N == 1)
    {
        return "y > 0 и x > 0 ";
    }

    if (N == 2)
    {
        return "y > 0 и x < 0 ";
    }
    if (N == 3)
    {
        return "y < 0 и x < 0 ";
    }
    if (N == 4)
    {
        return "y < 0 и x > 0 ";
    }
        return " ";
}

Напишите программу, которая принимает на вход координаты двух
точек и находит расстояние между ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21
AB = √(xb - xa)2 + (yb - ya)2
Math.Sqrt
Math.Pow(5, 2)

Console.WriteLine("Введите X координату точки А ");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y координату точки А ");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X координату точки В ");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y координату точки В ");
int yb = int.Parse(Console.ReadLine());


double result = Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya));

Console.WriteLine(result);

Console.WriteLine("Введите X координату точки А ");
int xa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y координату точки А ");
int ya = int.Parse(Console.ReadLine());
Console.WriteLine("Введите X координату точки В ");
int xb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y координату точки В ");
int yb = int.Parse(Console.ReadLine());

double distance  = GetDistance(xa,xb,ya,yb);

Console.WriteLine($"Расстояние между двумя точками {distance}" );

double GetDistance(double xa,double xb,double ya,double yb)
{
    return Math.Sqrt(Math.Pow((xb - xa),2) + Math.Pow((yb - ya),2));
}
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    Console.WriteLine(i * i);
}
*/
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
Squar(a);
void Squar (int a){
    
    for (int i = 1; i <= a; i++)
    {
        Console.WriteLine(i * i);   
    }
}
    
