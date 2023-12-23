//  Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29


Console.WriteLine("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());

int akkerman(int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    else if (n == 0)
    {
        return akkerman(m - 1, 1);
    }
    else
    {
        return akkerman(m - 1, akkerman(m,n - 1));
    }  
}
Console.WriteLine($"Функция Аккермана равно {akkerman(m,n)}");