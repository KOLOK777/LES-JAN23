// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количесто элементов массива (целое положительное число): "); 
int len; 
while (!Int32.TryParse(Console.ReadLine(), out len) || len <= 0)
    Console.WriteLine("Введены некорретные данные. Введите количесто элементов массива (целое положительное число): ");
if (len == 1)
    {
    Console.WriteLine("Нет элементов с нечетными позициями !");
    }
else{
    int[] mass = new int [len];
    int i;
    Console.Write("Cформирован массив:");
    for (i=0; i < len; i++){
        mass[i] = new Random().Next();
        Console.Write($" {mass[i]} ");
        }
    Console.WriteLine();
    int SUM = 0;
    
    void NECHET(){
        for (i = 1; i < len; i = i + 2){
            SUM = SUM + mass[i];
        }
        Console.WriteLine($"Cумма элементов массива, стоящих на нечётных позициях: {SUM}");
        return;
        }

    NECHET();
    }