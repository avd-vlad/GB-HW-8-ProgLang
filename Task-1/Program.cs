/*-----------------------------------------------------------------------------------------
Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
-----------------------------------------------------------------------------------------*/

int[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];

    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            newArray[i, j] = rnd.Next(minValue, maxValue + 1);
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] > 0)
                Console.Write($" {array[i, j]} ");
            else
                Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortArray(int[] array, bool desc)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = i; j < array.Length; j++)
            if (desc)
                if (array[i] < array[j])
                {
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                }
                else
                if (array[i] > array[j])
                {
                    int tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;
                }
}
void SortRows(int[,] array, bool desc = true)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
                if (desc)
                {
                    if (array[k, i] < array[k, j])
                    {
                        int tmp = array[k, i];
                        array[k, i] = array[k, j];
                        array[k, j] = tmp;
                    }
                }
                else
                {
                    if (array[k, i] > array[k, j])
                    {
                        int tmp = array[k, i];
                        array[k, i] = array[k, j];
                        array[k, j] = tmp;
                    }
                }
    }
}

int[,] newArr = CreateRandom2dArray();
Show2dArray(newArr);
SortRows(newArr);
Show2dArray(newArr);
