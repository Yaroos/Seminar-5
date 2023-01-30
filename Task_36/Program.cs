/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

// 1. Initialization random array.
int [] CreateArray()
{
    int [] Array = new int [8];
    Random number = new Random();
    for(int i = 0; i < Array.Length; i++)
    {
        Array[i] = number.Next(1,999);
    }
    return Array;
} 
int [] a = CreateArray();

// 2. Print array.
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [i]} ");
    }
}

PrintArray(a);

// 3. Find sum element on odd position.
int SumOddNumbers(int[] array)
{
    int odd = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            odd = odd + array[i];
        }
    }
    return odd;
}

int b = SumOddNumbers(a);

// 4. Console
Console.WriteLine($". Сумма нечетных чисел = {b}");