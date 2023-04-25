/*// Задача 25: Напишите цикл, который принимает на вход два числа
 (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/
Console.WriteLine("Введите число A  ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа  ");
int exponent = int.Parse(Console.ReadLine());

bool Exponent(int exponent)
{
    if(exponent < 0)
    {
        Console.WriteLine("Степень не должна быть меньше нуля  ");  
        return false;
    }
    return true;
}
int degree = DegreeNumber(number, exponent);
Console.WriteLine(degree);
int DegreeNumber(int number, int exponent)
{
    int degree = 1;
    for (int i = 0; i < exponent; i++)
    {
        degree *= number;
    }
    return degree;
}
