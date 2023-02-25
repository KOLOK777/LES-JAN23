// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите число строк массива1 (целое положительное число) 'm': "); 
int m; 
while (!Int32.TryParse(Console.ReadLine(), out m) || m <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число строк массива1 (целое положительное число) 'm': ");
Console.WriteLine("Введите число столбцов массива1 (целое положительное число) 'n': "); 
int n; 
while (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число столбцов массива1 (целое положительное число) 'n': ");
Console.WriteLine("Введите число строк массива2 (целое положительное число) 'p': "); 
int p; 
while (!Int32.TryParse(Console.ReadLine(), out p) || p <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число строк массива2 (целое положительное число) 'p': ");
Console.WriteLine("Введите число столбцов массива2 (целое положительное число) 'q': "); 
int q; 
while (!Int32.TryParse(Console.ReadLine(), out q) || q <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число столбцов массива2 (целое положительное число) 'q': ");

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
    if (array.GetLength(0) == array2.GetLength(0) & array.GetLength(1) == array2.GetLength(1)) {
        for (int i = 0; i < array2.GetLength(0); i++) {
            for (int j = 0; j < array2.GetLength(1); j++) {
                arrayResult[i,j] = array[i,j] * array2[i,j];
            }
        }
            return arrayResult;
        }
    else if (array.GetLength(0) == array2.GetLength(1) & array.GetLength(1) == array2.GetLength(0)) {
        for (int i = 0; i < array2.GetLength(1); i++) {
            for (int j = 0; j < array2.GetLength(0); j++) {
                arrayResult[i,j] = array[i,j] * array2[j,i];
            }
        }
        return arrayResult;
        }
        else 
            return arrayResult;
        }

var array = GenerateArray(m, n);
Console.WriteLine("Сформирован массив1: ");
PrintArray(array);
var array2 = GenerateArray(p, q);
Console.WriteLine("Сформирован массив2: ");
PrintArray(array2);
if (m + n == p + q) {
    var arrayResult = MultiplyArray(array, array2);
    Console.WriteLine("Массивы перемножены: ");
    PrintDoubleArray(arrayResult);
    }
else
    Console.WriteLine("Массивы не совпадают !");
