Console.Clear();

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine()!);

int i = 1;
while (i <= num)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"Все чётные числа от 1 до {num} = {i}");
    }
    i++;
}