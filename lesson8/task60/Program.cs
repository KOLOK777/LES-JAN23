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
Console.WriteLine("Введите число - третий параметр трехмерного массива (целое положительное число) 'k': ");
int k;
while (!Int32.TryParse(Console.ReadLine(), out k) || k <= 0)
    Console.WriteLine("Введены некорретные данные. Введите число - третий параметр трехмерного массива (целое положительное число) 'k': ");

int[,,] GenerateArray(int m, int n, int k){
    int[,,] array = new int[m, n, k];
    Random random = new Random();
    bool check;
    int unique = 0;
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int l = 0; l < array.GetLength(2); l++) {
                check = false;
                while (check == false) {
                    check = true;
                    unique = random.Next(-99,100);
                        foreach (int p in array) {
                            if (p == unique) {
                                check = false;
                        }
                    }
                }
                array[i,j,l] = unique;
            }
        }
    }
    return array;
}


void PrintArray(int[,,] array){
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int l = 0; l < array.GetLength(2); l++) {
                Console.Write($"{array[i,j,l]}({i},{j},{l})  ");
        }
        Console.WriteLine();
    }
    }
}

if (m*n*k <= 199) {
    var array = GenerateArray(m, n, k);
    Console.WriteLine("Сформирован массив неповторяющихся чисел: ");
    PrintArray(array);
    }
else
    Console.WriteLine("Введенные значения не позволяют сформировать двузначные уникальные числа !");