// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет (формат ввода произвольный, не обязательно через запятую)

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

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

Console.WriteLine("Введите число строк массива (целое положительное число) 'm': "); 
int m; 
while (!Int32.TryParse(Console.ReadLine(), out m) || m <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число строк массива (целое положительное число) 'm': ");
Console.WriteLine("Введите число строк массива (целое положительное число) 'n': "); 
int n; 
while (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число строк массива (целое положительное число) 'n': ");

Console.WriteLine("Введите позиции элемента в двумерном массиве (через пробел, запятую или точку): ");
string elements = Console.ReadLine()!;
string[] numberStrings = elements.Split(" ");
if (numberStrings.Length == 1) 
    numberStrings = elements.Split(".");
if (numberStrings.Length == 1) 
    numberStrings = elements.Split(",");
int[] numbers = new int[numberStrings.Length];

for (int i = 0; i < numbers.Length; i++)
    numbers[i] = int.Parse(numberStrings[i]);

Console.WriteLine("Сгенерирован следующий двумерный массив: ");
var array = GenerateArray(m, n);
PrintArray(array);

if (numbers[0] < 1 || numbers[0] > m || numbers[1] < 1 || numbers[1] > n)
    Console.WriteLine("Такого числа в массиве нет.");
else 
    Console.WriteLine($"Число в массиве по указанным вами элементам: {array[numbers[0]-1,numbers[1]-1]}");