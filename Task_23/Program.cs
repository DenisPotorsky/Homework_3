/* 
Напишите программу, 
1. которая принимает на вход число (N) и 
2. выдаёт таблицу 
кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 
*/
Console.Clear();
System.Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int digit = 1;

if (number < 1)
{
    System.Console.WriteLine("Некорректный ввод");
    return;
}

void CubeSearch(int x)
{
    while (digit <= x)
    {
        System.Console.WriteLine($"{digit}. {Math.Pow(digit, 3),3}");
        digit += 1;
    }
}
CubeSearch(number);