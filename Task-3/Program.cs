/*-----------------------------------------------------------------------------------------
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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

    for(int i = 0; i< rows; i++)
        for(int j = 0; j < cols; j++)
            newArray[i,j] = new Random().Next(min, max+1);
    return newArray;
}

int DigitQty(int x)
{
    int qty =0;
    while(x>0)
    {
        x/=10;
        qty++;
    }
    return qty;
}

int GetArrMax(int[,] array)
{
    int max = array[0,0];
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(array[i,j]>max) max = array[i,j];
    return max;
}


void Show2dArray(int[,] array)
{
    int maxDgt = DigitQty(GetArrMax(array));
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            string outStr = Convert.ToString(array[i,j]);
            int dgt = DigitQty(array[i,j]);
            for(int k = 0; k < maxDgt+1-dgt; k++)
                outStr=" " + outStr;
            Console.Write(outStr);
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

int[,] MulArray(int[,] a, int[,] b)
{
    if(a.GetLength(1)!=b.GetLength(0))
    {
        Console.WriteLine("Произведения матриц не существует. Не совпадают размерности");
        return null;
    }
    int[,] resArray = new int[a.GetLength(0), b.GetLength(1)];
    for(int i = 0; i < resArray.GetLength(0); i++)
        for(int j = 0; j <resArray.GetLength(1); j++)
        {
            resArray[i,j] = 0;
            for(int k =0; k < a.GetLength(1); k++)
                resArray[i,j]+=a[i,k]*b[k,j];
        }
    return resArray;
  
}

int[,] newArrA=CreateRandom2dArray();
Show2dArray(newArrA);
int[,] newArrB=CreateRandom2dArray();
Show2dArray(newArrB);
Show2dArray(MulArray(newArrA,newArrB));


