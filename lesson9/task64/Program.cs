// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите количество чисел, натуральное число'N': "); 
int N; 
while (!Int32.TryParse(Console.ReadLine(), out N))
    Console.WriteLine("Введены некорретные данные.");

void PrintDigitRow(int N) {
    if (N <= 0) {
        return;
    }
    else if (N == 1)
        Console.Write($"{N}.");
    else
        Console.Write($"{N}, ");
        PrintDigitRow(N - 1);
        }

Console.Write($"N = {N} ->  ");
PrintDigitRow(N);
