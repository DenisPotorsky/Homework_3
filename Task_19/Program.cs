/*
Напишите программу, 
1. которая принимает на вход пятизначное число 
2. проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
System.Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());

int remain = 0;
int reversNumber = 0;

if (number < 9999 || number > 99999)
{
    System.Console.WriteLine("Необходимо ввести пятизначное число");
    return;
}

int PalindromeСheck (int x)
{
    while (x > 0)
    {
        remain = x % 10;
        reversNumber = reversNumber * 10 + remain;
        x /= 10;
    }
    int reversDigit = reversNumber;
    return reversDigit;
}

int palindromeNum = PalindromeСheck(number);

if (number == palindromeNum)
{
    System.Console.WriteLine("Число является палиндромом");
}
else System.Console.WriteLine("Число не является палиндромом");
