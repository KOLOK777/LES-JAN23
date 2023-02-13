// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4

Console.WriteLine("Введите позиции массива (через пробел, запятую или точку): ");
string elements = Console.ReadLine()!;
string[] numberStrings = elements.Split(" ");
if (numberStrings.Length == 1) 
    numberStrings = elements.Split(".");
if (numberStrings.Length == 1) 
    numberStrings = elements.Split(",");

void PlusNumbersCheck() {       
    int[] numbers = new int[numberStrings.Length];
    int count = 0;
    for (int i = 0; i < numbers.Length; i++){
        numbers[i] = int.Parse(numberStrings[i]);
        if (numbers[i] > 0) 
            count = count + 1;
    }
    Console.WriteLine($"Количество положительных элементов: {count}");
    return;
}

PlusNumbersCheck();