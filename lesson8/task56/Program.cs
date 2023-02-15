// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите число строк/столбцов массива (целое положительное число) 'm': "); 
int m; 
while (!Int32.TryParse(Console.ReadLine(), out m) || m <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число/столбцов строк массива (целое положительное число) 'm': ");
int n = m;

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

void PrintSingleArray(int[] array){
    for (int i = 0; i < array.GetLength(0); i++) {
        Console.WriteLine($"{array[i]}  ");
        }
    }

int[] SumArray(int[,] array){
    int[] sum = new int[m];
    for (int i = 0; i < array.GetLength(0); i++) {
        sum[i] = array[i,0];
        for (int j = 1; j < array.GetLength(1); j++) {
            sum[i] = sum[i] + array[i,j];
            }
        }
    return sum;
}

void SearchMin(int[] sum){
    int minIndex = 0;
    int min = sum[0];
    for (int i = 1; i < sum.GetLength(0); i++) {
        if (sum[i] < min) {
            minIndex = i;
            min = sum[i];
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой: {minIndex+1}");
    return;
}

var array = GenerateArray(m, n);
Console.WriteLine("Сформирован массив: ");
PrintArray(array);
var sum = SumArray(array);
Console.WriteLine("Суммы по строкам: ");
PrintSingleArray(sum);
SearchMin(sum);