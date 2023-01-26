// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количесто элементов массива (целое число - больше 1): "); 
int len; 
while (!Int32.TryParse(Console.ReadLine(), out len) || len <= 1)
    Console.WriteLine("Введены некорретные данные. Введите количесто элементов массива (целое положительное число): ");
int[] mass = new int [len];
int i;
Console.Write("Cформирован массив:");
for (i = 0; i < len; i++)
    {
    mass[i] = new Random().Next(0, 10);
    Console.Write($" {mass[i]} ");
    }

int max;
int min;

void RAZN()
    {
    max = mass[0];
    min = mass[0];
    Console.WriteLine();
    for (i = 1; i < len; i++)
        {
        if (mass[i] > max) max = mass[i];
        if (mass[i] < min) min = mass[i];
        }
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива (макс: {max} и мин: {min}): '{max - min}'");
    return;
    }
    
RAZN();