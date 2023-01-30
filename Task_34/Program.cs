/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 28*/


// 1. Set Random Array with 3 digit number.
int [] CreateArray()
{
    int [] Array = new int [10];
    Random number = new Random();
    for(int i = 0; i < Array.Length; i++)
    {
        Array[i] = number.Next(100,999);
    }
    return Array;
} 
int [] a = CreateArray();

// 2. Print Array.
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [i]} ");
    }
}

PrintArray(a);

// 3. The number of even numbers in the Array.
int EvenNumbers(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            even += 1;
        }
    }
    return even;
}

// 4. Console 
int b = EvenNumbers(a);
Console.WriteLine($". Количество четных чисел = {b}");