﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i<=num){
    Console.Write($"{i} ");
    int quad = i*i*i;
    Console.WriteLine(quad);
    i++;
}