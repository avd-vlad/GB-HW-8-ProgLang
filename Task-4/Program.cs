/*-----------------------------------------------------------------------------------------
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
-----------------------------------------------------------------------------------------*/

int[,,] CreateRandom3dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input layers number: ");
    int layers = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input max possible value: ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[,,] newArray = new int[rows, cols, layers];
    List<int> generated = new List<int>();
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            for (int k = 0; k < layers; k++)
            {
                int num = new Random().Next(min, max + 1);
                while (generated.Contains(num))
                    num = new Random().Next(min, max + 1);
                newArray[i, j, k] = num;
                generated.Add(num);
            }
    return newArray;
}

int DigitQty(int x)
{
    int qty = 0;
    while (x > 0)
    {
        x /= 10;
        qty++;
    }
    return qty;
}

int GetArrMax(int[,,] array)
{
    int max = array[0, 0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if (array[i, j, k] > max) max = array[i, j, k];
    return max;
}

void Show3dArray(int[,,] array)
{
    int maxDgt = DigitQty(GetArrMax(array));
    for (int k = 0; k < array.GetLength(2); k++)
    {
        Console.WriteLine($"Layer {k}:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                string outStr = Convert.ToString(array[i, j, k]);
                int dgt = DigitQty(array[i, j, k]);
                for (int p = 0; p < maxDgt - dgt; p++)
                    outStr = "0"+ outStr;
                Console.Write(outStr+" ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}


int[,,] newArr = CreateRandom3dArray();
Show3dArray(newArr);
