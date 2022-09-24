/* 
Напишите программу, 
1. которая принимает на вход координаты двух точек 
2. находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
System.Console.WriteLine("Введите координаты точки А:");

int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
int az = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите координаты точки B:");

int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());
int bz = int.Parse(Console.ReadLine());

void courseFinding(int ax1, int ay1, int az1, int ax2, int ay2, int az2)
{
    double coordinate = Math.Sqrt(Math.Pow((ax2 - ax1), 2) + Math.Pow((ay2 - ay1), 2)
       + Math.Pow((az2 - az1), 2));
       System.Console.WriteLine($"{coordinate:f2}");
}
courseFinding(ax, ay, az, bx, by, bz);