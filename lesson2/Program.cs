/*
int a = 7;
int b = 8;

int c = 4;
int g = 3;

int h = 3;
int f = 2;

int result1 = Calculate(a, b);
Show(a,b);

int result2 = Calculate(c, g);
Show(c,g);

int result3 = Calculate(h, f);
Show(h,f);

Console.WriteLine(result1);
Console.WriteLine(result2);
Console.WriteLine(result3);


int Calculate(int a, int b)
{
    int result = a * (a * b) - 5;
    
    return result;
    
}
void Show(int a, int b)
{
    Console.WriteLine($"{a} , {b}");
}

int y = 10;
string str = "lalalal";
char ch = 'c';
double db = 1.4;
bool bl = false;
string tmp = $"{y} - лалалал {str} fldsfdsfsdf {ch} - sdflnsdf s{db} {bl}";
string tmp2 = y + " - лалалал " + str + " fldsfdsfsdf " + " - sdflnsdf s";
Console.WriteLine(tmp);

// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// Например:
// ● 78 -> 8
// ● 12-> 2
// ● 85 -> 8
Random random = new Random();
int randomValue = random.Next(10, 100);
int lastDigit = randomValue % 10;
int firstDigit = randomValue / 10;

Console.WriteLine(randomValue);
  
 if(lastDigit > firstDigit)
{
    Console.WriteLine(lastDigit);
}
else{
    Console.WriteLine(firstDigit);
}
int b = 5;
//Напишите программу, которая выводит случайное трехзначное число и удаляет
 вторую цифру этого числа.
● 456 -> 46
● 782 -> 72
● 918 -> 98

Random random = new Random();
int randomValue = random.Next( 100, 1000);
int firstDigit = randomValue / 100 ;
int secondDigit = randomValue % 10;
Console.WriteLine(randomValue);
Console.WriteLine($"{randomValue} -> {firstDigit} {secondDigit}");
*/
Random random = new Random();
int randomValue = random.Next( 100, 1000);
int firstDigit = randomValue / 100 * 10;
int secondDigit = randomValue % 10;
Console.WriteLine(randomValue);

Console.WriteLine(firstDigit + secondDigit);
/*
//Напишите программу, которая будет принимать на вход два числа и выводить,
 является ли второе число кратным первому. Если число 2 не кратно числу 1,
 то программа выводит остаток 
от деления. 
● 34, 5 -> не кратно, остаток 4
● 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine());
int result = number1 % number2;

if (result == 0)
{ 
    Console.WriteLine(result);
    Console.WriteLine("кратно");
} 
else
{Console.WriteLine(result);
Console.WriteLine("не кратно");
}
Напишите программу, которая принимает на вход число и проверяет, кратно ли
 оно одновременно 7 и 23.
● 14 -> нет
● 46 -> нет
● 161 -> да

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if (a % 7 == 0 & a % 23 == 0 )
{ 
    Console.WriteLine($"{a} -> да");
    
} 
else
{
    Console.WriteLine($"{a} -> нет");
}

//Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.
//● 5, 25 -> да ● -4, 16 -> да ● 25, 5 -> да ● 8,9 -> нет

Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine()); 

if (a == b * b | b == a * a ){
    Console.WriteLine($"{a},{b} -> да");
}
else{
    Console.WriteLine($"{a},{b} -> нет");
}
*/