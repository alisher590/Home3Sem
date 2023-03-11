Console.Clear();
try
{
    int Number, Sum = 0, Result, Tick;
    Console.Write("Введите пятизначное число: ");
    Number = int.Parse(Console.ReadLine() ?? "");

    if (Number > 9999 && Number < 100000)
    {
        for (Tick = Number; Number != 0; Number = Number / 10)
        {
            Result = Number % 10;
            Sum = Sum * 10 + Result;
        }
        if (Tick == Sum)
            Console.WriteLine($"{Tick} является полиндромом");
        else
        {
            Console.WriteLine($"не {Tick} является полиндромом");
        }
    }
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка буквы не принимаем: {exc.Message}");
}


