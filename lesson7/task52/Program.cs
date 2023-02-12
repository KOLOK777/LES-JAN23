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

int[,] GenerateArray(int m, int n){
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = random.Next();
        }
    }
    return array;
}

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void PrintSingleArray(int[] average){
    for (int i = 0; i < average.GetLength(0); i++) {
        Console.Write($"{average[i]}  ");
        }
    }

int[] SumColumn(int[,] array){
    int[] average = new int[n];
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++) {
        sum = array[0,j];
        for (int i = 1; i < array.GetLength(0); i++) {
            sum = sum + array[i,j];
            }
        average[j] = sum / m;
        }
    return average;
}

var array = GenerateArray(m, n);
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого cтолбца: ");
var average = SumColumn(array);
PrintSingleArray(average); 