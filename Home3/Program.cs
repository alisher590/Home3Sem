Console.Clear();
try
{
    Console.Write("Введите число N: ");
    int num = int.Parse(Console.ReadLine() ?? "");
    for (int n = 1; n <= num; n++)
    {
        int i = n * n * n;
        Console.WriteLine($"Таблица кубов:{i}");
    }
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка буквы и 'вещественые числа' не принимаем: {exc.Message}");
}

