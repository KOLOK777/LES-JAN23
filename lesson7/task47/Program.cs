// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите число строк массива (целое положительное число) 'm': "); 
int m; 
while (!Int32.TryParse(Console.ReadLine(), out m) || m <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число строк массива (целое положительное число) 'm': ");
Console.WriteLine("Введите число столбцов массива (целое положительное число) 'n': "); 
int n; 
while (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число столбцов массива (целое положительное число) 'n': ");

double[,] array = new double [m,n];
void twoArray()
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
            array[i,j] = new Random().Next();
            Console.Write($"{array[i,j]}  ");
            }
        Console.WriteLine();
    }
    return;
}

twoArray();