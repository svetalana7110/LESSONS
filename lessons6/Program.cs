//Задача 39: Напишите программу, которая перевернёт одномерный 
//массив (последний элемент будет на первом месте, а первый - 
//на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
int[] arr = new int[]{ 1, 2, 7 ,8 ,9 ,10};

PrintArray(arr);
Reverse(arr);
PrintArray(arr);

int[] Reverse(int[] array)
{
    int[] reversed = new int[array.Length];
    for (var i = 0; i < array.Length; i++)
    {
        reversed[i] = array[array.Length - 1 - i];
    }
    return reversed;
}

/*void Reverse(int[] array)
{
    for (var i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
}
*/
void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(",", arr));
} 
