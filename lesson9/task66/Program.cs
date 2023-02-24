// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите количество чисел, натуральное число (целое положительное число больше 0) 'N': "); 
int N; 
while (!Int32.TryParse(Console.ReadLine(), out N) || N < 1)
    Console.WriteLine("Введены некорретные данные. Введите количество чисел, натуральное число (целое положительное число больше 0) 'N': ");
Console.WriteLine("Введите количество чисел, натуральное число (целое положительное число больше 0) 'M': "); 
int M; 
while (!Int32.TryParse(Console.ReadLine(), out M) || M < 1)
    Console.WriteLine("Введены некорретные данные. Введите количество чисел, натуральное число (целое положительное число больше 0) 'M': ");

int CalcAmount(int N, int M) {
    if (M > N) {
        return M + CalcAmount(N, M - 1);
        }
    else if (N > M) {
        return N + CalcAmount(N - 1, M);
        }
    else if (N == M) {
        return Math.Min(M, N);    
    }
}

Console.WriteLine($"Сумма числового рядо между числами {M} и {N} равна : {CalcAmount(N, M)}");