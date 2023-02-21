// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введите число строк/столбцов массива (целое положительное число) 'm': "); 
int N; 
while (!Int32.TryParse(Console.ReadLine(), out N) || N <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число строк/столбцов массива (целое положительное число) 'm': ");
int M = N;
int[,] GenerateSpyralArray(int N, int M){
    int[,] array = new int[N, M];
    for (int ik = 0; ik < array.GetLength(0); ik++) {
        for (int jk = 0; jk < array.GetLength(1); jk++) {
            int i = ik + 1;
            int j = jk + 1;
            int switcher =  (j - i + N) / N;
            int Ic = Math.Abs(i - N / 2  - 1) + (i - 1)/(N /2) * ((N-1) % 2);
            int Jc = Math.Abs(j - N / 2  - 1) + (j - 1)/(N /2) * ((N-1) % 2);
            int Ring = N / 2 - (Math.Abs(Ic - Jc) + Ic + Jc) / 2;
            int Xs = i - Ring + j - Ring - 1;    
            int Coef =  4 * Ring * (N - Ring);
            array[ik,jk] =  Coef + switcher * Xs + Math.Abs(switcher - 1) * (4 * (N - 2 * Ring) - 2 - Xs);    
            }
        }
    return array;
}

void PrintSpyralArray(int[,] array){
    int digitCountLast;
    digitCountLast = (int)Math.Log10(N * M) + 1;
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            int p = (int)Math.Log10(array[i,j]) + 1;
            for (int k = 1; k <= (digitCountLast - p); k++) {
                Console.Write("0");
                }
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
}

var array = GenerateSpyralArray(N, M);
Console.WriteLine("Сформирован спиральный массив: ");
PrintSpyralArray(array);