/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

// 1. Initialization random array.
double [] CreateArray()
{
    double [] Array = new double [8];
    Random number = new Random();
    int minimum = -100;
    int maximum = 100;
    for(double i = 0; i < Array.Length; i++)
    {
        Array[(int)i] = number.NextDouble() * (maximum - minimum) + minimum;
    }
    return Array;
} 
double [] a = CreateArray();

// 2. Print array.
void PrintArray(double [] array)
{
    for (double i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [(int)i]} + . ");
    }
}

PrintArray(a);
Console.WriteLine();

// 3. Max and Min. 
double Min(double [] array)
{
    int min = (int)array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = (int)array[i];
        }
    }
    return min;
}

double Max(double [] array)
{
    int max = (int)array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = (int)array[i];
        }
    }
    return max;
}

double b = Min(a);
Console.WriteLine($"Минимальное число: {b}");
double c = Max(a);
Console.WriteLine($"Максимальное число: {c}");

// 4. Difference between max and min
double result = c - b;
Console.WriteLine($"Разница между максимальным и минимальным числом: {result}");