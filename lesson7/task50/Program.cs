// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет (формат ввода произвольный, не обязательно через запятую)

Console.WriteLine("Введите число строк массива (целое положительное число) 'm': "); 
int m; 
while (!Int32.TryParse(Console.ReadLine(), out m) || m <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число строк массива (целое положительное число) 'm': ");
Console.WriteLine("Введите число строк массива (целое положительное число) 'n': "); 
int n; 
while (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число строк массива (целое положительное число) 'n': ");

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
    if 

    }
    return;
}

twoArray();

Console.WriteLine("Введите число из массива: "); 
double X; 
while (!Int32.TryParse(Console.ReadLine(), out X))
    Console.WriteLine("Введены некоректные данные. Введите число из массива: ");


array[1,2]
