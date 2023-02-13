// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите параметр b1: "); 
int b1; 
while (!Int32.TryParse(Console.ReadLine(), out b1))
    Console.WriteLine("Введены некорретные данные. Введите параметр b1: ");
Console.WriteLine("Введите параметр k1: "); 
int k1; 
while (!Int32.TryParse(Console.ReadLine(), out k1))
    Console.WriteLine("Введены некорретные данные. Введите параметр k1: ");
Console.WriteLine("Введите параметр b2: "); 
int b2; 
while (!Int32.TryParse(Console.ReadLine(), out b2))
    Console.WriteLine("Введены некорретные данные. Введите параметр b2: ");
Console.WriteLine("Введите параметр k2: "); 
int k2; 
while (!Int32.TryParse(Console.ReadLine(), out k2))
    Console.WriteLine("Введены некорретные данные. Введите параметр k2: ");

void CrossPoint() {
    double x;
    double y;
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
Console.WriteLine($"Координаты точки переечения : ({x};{y}).");
}

CrossPoint();