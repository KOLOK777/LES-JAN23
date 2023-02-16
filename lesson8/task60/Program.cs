// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите число - первый параметр трехмерного массива (целое положительное число) 'm': "); 
int m; 
while (!Int32.TryParse(Console.ReadLine(), out m) || m <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число - первый параметр трехмерного массива (целое положительное число) 'm': ");
Console.WriteLine("Введите число - второй параметр трехмерного массива (целое положительное число) 'n': "); 
int n; 
while (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число - второй параметр трехмерного массива (целое положительное число) 'n': ");
Console.WriteLine("Введите число - третий параметр трехмерного массива (целое положительное число) 'm': ");
int k;
while (!Int32.TryParse(Console.ReadLine(), out k) || k <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число - третий параметр трехмерного массива (целое положительное число) 'n': ");

int[,,] GenerateArray(int m, int n, int k){
    int[,,] array = new int[m, n, k];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int l = 0; l < array.GetLength(2); l++) {
                array[i,j,l] = random.Next(0,15);
                    for (int p = 0; p < i; p++) {
                        for (int q = 0; q < j; q++) {
                            for (int r = 0; r < l; r++) {
                                if (array[i,j,l] == array[p,q,r])  {
                                    array[i,j,l] = random.Next(0,50);
                                    p = 0;
                                    q = 0;
                                    r = 0;
                                }
                                }
                        }
                    }
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int l = 0; j < array.GetLength(2); j++) {
                Console.Write($"{array[i,j,l]}({i},{j},{l})  ");
        }
        Console.WriteLine();
    }
    }
}

var array = GenerateArray(m, n, k);
Console.WriteLine("Сформирован массив: ");
PrintArray(array);