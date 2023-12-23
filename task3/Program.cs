// Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int[] array = new int[6];
void PrintArray(int[] arr, int i)
{
    if (i == arr.Length)
    {
        return;
    }
    array[i] = new Random().Next(1,51);
    Console.Write(arr[i]+ " ");
    PrintArray(arr, i +1);
}
void Reverse(int[] arr, int i)
{
    if (i == arr.Length)
    {
        return;
    }
    Console.Write(arr[arr.Length - 1 -i]+ " ");
    Reverse(arr, i +1);
}


PrintArray(array,0);
Console.WriteLine();
Reverse(array,0);

