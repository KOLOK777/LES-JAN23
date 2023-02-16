// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите число строк/столбцов массива (целое положительное число) 'm': "); 
int m; 
while (!Int32.TryParse(Console.ReadLine(), out m) || m <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число строк/столбцов массива (целое положительное число) 'm': ");
int n = m;
int[,] GenerateSpyralArray(int m, int n){
    int[,] array = new int[m, n];
    array[0,0] = 0;
    int sum = -1;
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = sum + 1; 
            sum++;
            if (i == array.GetLength(0)- 1){
                

            }
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

var array = GenerateSpyralArray(m, n);
Console.WriteLine("Сформирован спиральный массив: ");
PrintArray(array);