// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк массивов (целое положительное число) 'm': "); 
int m; 
while (!Int32.TryParse(Console.ReadLine(), out m) || m <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число строк массивов (целое положительное число) 'm': ");
Console.WriteLine("Введите число столбцов массивов (целое положительное число) 'n': "); 
int n; 
while (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число столбцов массивов (целое положительное число) 'n': ");

int[,] GenerateArray(int m, int n){
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = random.Next(1,10);
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

void PrintDoubleArray(double[,] array){
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

double[,] MultiplyArray(int[,] array, int[,] array2){
    double[,] arrayResult = new double[m,n];
    for (int i = 0; i < array2.GetLength(0); i++) {
        for (int j = 0; j < array2.GetLength(1); j++) {
            arrayResult[i,j] = array[i,j] * array2[i,j];
            }
        }
    return arrayResult;
    }

var array = GenerateArray(m, n);
Console.WriteLine("Сформирован массив1: ");
PrintArray(array);
var array2 = GenerateArray(m, n);
Console.WriteLine("Сформирован массив2: ");
PrintArray(array2);
var arrayResult = MultiplyArray(array, array2);
Console.WriteLine("Массивы перемножены: ");
PrintDoubleArray(arrayResult);