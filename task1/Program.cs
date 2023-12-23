// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.WriteLine("Введите значение М: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
PrintNumbers(M,N);
void PrintNumbers(int M, int N)
{
    Console.WriteLine(M);
    if (M == N)
    {
        return;
    }
    PrintNumbers(M+1, N);
}
