Console.Clear();
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0)
    Console.WriteLine($"Число является четным {number}");
else Console.WriteLine($"Число является HE четным {number}");