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
*/
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

