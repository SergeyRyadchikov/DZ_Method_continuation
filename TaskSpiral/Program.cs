void FillArray(int[,] arr)
{
    int finalPosition = arr.GetUpperBound(0) + 1;
    int startPosition = 0;
    int start = 1;
    int i = 0;
    int j = 0;
    while (start <= arr.Length)
    {
        while (j < finalPosition)
        {
            arr[i, j] = start;
            start++;
            j++;
        }
        i++;
        while (i < finalPosition)
        {
            arr[i, j-1] = start;
            start++;
            i++;
        }
        j--;
        while (j > startPosition)
        {
            arr[i-1, j-1] = start;
            start++;
            j--;
        }
        finalPosition--;
        startPosition++;
        i = i - 1;
        while (i > startPosition)
        {
            arr[i-1, j] = start;
            start++;
            i--;
        }
        j++;
    }
}

void PrintArray(int[,] coll)
{
    int lines = coll.GetUpperBound(0) + 1;
    int columns = coll.Length / lines;
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(coll[i, j] + "\t");
        }
        Console.WriteLine();
    }
}




Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];
FillArray(array);
PrintArray(array);



