// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

int[,] SortLineArray(int[,] array){
    int[,] array2 = array;
    int maxIndex;
    int max;
    int count; 
    for (int i = 0; i < array2.GetLength(0); i++) {
        for (int j = 1; j < array2.GetLength(1); j++) {
            maxIndex = j - 1;
            count = j;
            max = array2[i,j - 1];
            while (count < array2.GetLength(1)) {
                if (array2[i,count] > max) {
                max = array2[i,count];
                maxIndex = count;
                }
                array2[i,maxIndex] = array2[i,j - 1];
                array2[i,j - 1] = max;
                count++;
            }
        }
    }
return array2;
}

var array = GenerateArray(m, n);
Console.WriteLine("Сформирован массив: ");
PrintArray(array);
var array2 = SortLineArray(array);
Console.WriteLine("Массив отсортирован: ");
PrintArray(array2); 