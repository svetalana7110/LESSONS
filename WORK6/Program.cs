// See https://aka.ms/new-console-template for more information
/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
int Prompt(string message);
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    
    return result;
}
int Length = Prompt("Введите количество элементов ");

array = InputArray(Length); 
PrintArray(array);
int count = CountNumbersGreaterZero(array);
Console.WriteLine($"Количество чисел больше 0 {count}");

int[] InputArray = (int Length)
 {
   int [] array = new int [Length];
    for (int i = 0; i < array.Length; i++)
    {
       array[i]= Prompt($"Введите {i + 1}-й элемент");
    }
    return array; 
 }
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     Console.WriteLine(string.Join(",", array));   
    }
}
int CountNumbersGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += array[i];
        }
    }

    return count;
}