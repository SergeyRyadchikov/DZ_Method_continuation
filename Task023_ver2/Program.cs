void num_cub (int num)
{
    for (int x = 1; x <= num; x++)
    {
        Console.Write(Math.Pow(x, 3) + ", ");
    }
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
num_cub(N);
