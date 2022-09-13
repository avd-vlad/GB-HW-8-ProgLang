/*-----------------------------------------------------------------------------------------
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
-----------------------------------------------------------------------------------------*/
int[,] CreateRandom2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, cols];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            newArray[i, j] = new Random().Next(min, max + 1);
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();

    }
    Console.WriteLine();
}

void ShowArr(int[] arr)
{

    Console.Write("[");
    for(int i=0; i<arr.Length;i++)
        if(i==arr.Length-1)
            Console.Write($"{arr[i]} ]");
        else
            Console.Write($"{arr[i]}, ");
    Console.WriteLine();
}

int FindMinInd(int[] array)
{
    int minInd = 0;
    int min = array[0];

    for (int i = 1; i < array.Length; i++)
        if (array[i] < min)
        {
            min = array[i];
            minInd = i;
        }
    return minInd;
}

int[] RowsSumm(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum[i]+=array[i,j];
    }
    return sum;
}

int[,] newArr=CreateRandom2dArray();
Console.WriteLine("Сгенерированный массив:");
Show2dArray(newArr);
int[] rowsSum = RowsSumm(newArr);
Console.WriteLine("Построчная сумма элементов массива:");
ShowArr(rowsSum);
Console.WriteLine($"Номер строки с наименьшей суммой элементов - {FindMinInd(rowsSum)+1}");