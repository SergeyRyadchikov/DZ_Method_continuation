void num_cub (int num)
{
    for (int x = 1; x <= num; x++)
    {
        Console.Write(x * x * x + ", ");
    }
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
num_cub(N);
