﻿//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetDistanceTwoPoint(int x1, int y1, int z1, int x2, int y2, int z2) 
{
    double distan = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

    return distan;
}

Console.Write("Введите X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = GetDistanceTwoPoint(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) равно {Math.Round (result, 2,MidpointRounding.ToNegativeInfinity)}");
