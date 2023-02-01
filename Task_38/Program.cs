/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

// 1. Initialization random array.
double [] CreateArray()
{
    double [] Array = new double [8];
    Random number = new Random();
    for(double i = 0; i < Array.Length; i++)
    {
        Array[(int)(double)i] = number.Next(1,999);
    }
    return Array;
} 
double [] a = CreateArray();

// 2. Print array.
void PrintArray(double [] array)
{
    for (double i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [(int)i]} ");
    }
}

PrintArray(a);

// 3. Max and Min. 
double Min(double [] array)
{
    int min = (int)array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = (int)array[i];
            Console.WriteLine(min);
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
            Console.WriteLine(max);
        }
    }
    return max;
}

double b = Min(a);
Console.WriteLine(b);
double c = Max(a);
Console.WriteLine(c);