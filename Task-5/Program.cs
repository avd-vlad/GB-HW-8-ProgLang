/*-----------------------------------------------------------------------------------------
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
-----------------------------------------------------------------------------------------*/

string[,] FillSpiral2dArray()
{
    Console.Write("Input rows number: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input columns number: ");
    int cols = Convert.ToInt32(Console.ReadLine());

    string[,] newArray = new string[rows, cols];
    int N = rows;

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            int swch = (j - i + N) / N;
            int Ic = Math.Abs(i - N / 2) + (i) / (N / 2) * ((N - 1) % 2);
            int Jc = Math.Abs(j - N / 2) + (j) / (N / 2) * ((N - 1) % 2);
            int Ring = N / 2 - (Math.Abs(Ic - Jc) + Ic + Jc) / 2;
            int Xs = i - Ring + j - Ring + 1;
            int Coef = 4 * Ring * (N - Ring);
            newArray[i, j] = String.Format("{0:D2}", Coef + swch * Xs + Math.Abs(swch - 1) * (4 * (N - 2 * Ring) - 2 - Xs));
        }
    return newArray;
}

void Show2dArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();

    }
    Console.WriteLine();

}



string[,] newArr = FillSpiral2dArray();
Show2dArray(newArr);
