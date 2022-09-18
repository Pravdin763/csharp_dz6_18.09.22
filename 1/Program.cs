Console.WriteLine("Введите колличество чисел: ");
int m = int.Parse(Console.ReadLine()!);


int CheckFor0(int m1)
{
    int count = 0;
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите число {i + 1} из {m1}");
        float input = float.Parse(Console.ReadLine()!);
        if (input > 0)
        {
            count += 1;
        }
    }
    return count;
}

void Print()
{
    Console.WriteLine($"Колличество чисел больше 0 введенных пользователем  = {CheckFor0(m)}");
}

Print();
