string[] UserArray(int N) {
    string[] array = new string[N];
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"Введите элемент номер {i+1}: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

string[] ThreeSymbolArray(string[] userArray) {
    int count = 0;
    for (int i = 0; i < userArray.Length; i++) {
        if (userArray[i].Length <= 3)
            count++;
        }
    string[] array2 = new string[count];
    count = 0;
    for (int j = 0; j < userArray.Length; j++) {
        if (userArray[j].Length <= 3) {
            array2[count] = userArray[j];
            count++;
        }
    }    
    return array2;
}

void PrintArray(string[] printArr) {
    Console.Write("[");
    for (int i = 0; i < printArr.Length; i++) {
        if (i == printArr.Length - 1)
            Console.Write($"{printArr[i]}");
        else
            Console.Write($"{printArr[i]}, ");
    }
    Console.WriteLine("]");
}

Console.Write("Введите количество элементов массива (целое, больше 0): ");
int.TryParse(Console.ReadLine(), out int N);
while (N <= 0) {
    Console.WriteLine("Введите корректное число (целое, боьше 0): ");
    int.TryParse(Console.ReadLine(), out N);
}
string[] userArray = UserArray(N);
string[] threeSymbolArray = ThreeSymbolArray(userArray);
Console.WriteLine("Полученный массив:");
PrintArray(threeSymbolArray);