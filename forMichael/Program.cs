// Задача: Задайте значения M и N. Напишите программу, которая расставит числа по возрастанию 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите количество чисел, натуральное число (целое положительное число больше 0) 'M': "); 
int M; 
while (!Int32.TryParse(Console.ReadLine(), out M) || M <= 1)
    Console.WriteLine("Введены некорретные данные. Введите количество чисел, натуральное число (целое положительное число больше 0) 'M': ");
Console.WriteLine("Введите количество чисел, натуральное число (целое положительное число больше 0) 'N': "); 
int N; 
while (!Int32.TryParse(Console.ReadLine(), out N) || N <= 1)
    Console.WriteLine("Введены некорретные данные. Введите количество чисел, натуральное число (целое положительное число больше 0) 'N': ");

void PrintDigitRow(int M, int N) {
    
    if (M == N) {
        Console.Write($"{M}");
    }
    else if (M > N) {
        Console.Write($", {M}");
        PrintDigitRow(M - 1, N);
    }
    else if (M < N) {
        Console.Write($", {N}");
        PrintDigitRow(M, N - 1);
        }
    }

PrintDigitRow(M, N);
