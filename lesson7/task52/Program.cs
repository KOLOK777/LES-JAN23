// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите число строк массива (целое положительное число) 'm': "); 
int m; 
while (!Int32.TryParse(Console.ReadLine(), out m) || m <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число строк массива (целое положительное число) 'm': ");
Console.WriteLine("Введите число столбцов массива (целое положительное число) 'n': "); 
int n; 
while (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число столбцов массива (целое положительное число) 'n': ");

int[,] array = new int [m,n];
void FillArray()
{
    double[] AVG = new double [n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
            array[i,j] = new Random().Next(0,5);
            Console.Write($"{array[i,j]}  ");
            if (i==0) AVG[j] = array[i,j];
            else AVG[j] = AVG[j-1] + array[i,j];
            }
        Console.WriteLine();
    for (int k = 0; k < n; k++){
        Console.Write($"{AVG[k] = AVG[k] / m}; ");
    return;
    }
    }
return;
}

FillArray();