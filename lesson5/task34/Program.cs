// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.WriteLine("Введите количесто элементов массива (целое положительное число): "); 
int len; 
while (!Int32.TryParse(Console.ReadLine(), out len) || len > 0);
    Console.WriteLine("Введены некорретные данные. Введите количесто элементов массива (целое положительное число): ");
int[] mass = new int [len];
int i;
Console.Write("Массив: ");
for (i=0; i < len; i++){
    mass[i] = new Random().Next(100,1000);
    Console.Write($" {mass[i]} ");
    }

int SUM = 0;

void CHET(){
    for (i = 0; i < len; i++){
        if (mass[i] % 2 == 0) SUM = SUM + mass[i];
    }
    Console.WriteLine($"Сумма четных чисел в массиве: {SUM}");
    return;
    }

CHET();