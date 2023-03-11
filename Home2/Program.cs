Console.Clear();
try
{
    int x1 = ReadCoordinate("Введите координату X первой точки: ");
    int y1 = ReadCoordinate("Введите координату Y первой точки: ");
    int z1 = ReadCoordinate("Введите координату Z первой точки: ");
    int x2 = ReadCoordinate("Введите координату X второй точки: ");
    int y2 = ReadCoordinate("Введите координату Y второй точки: ");
    int z2 = ReadCoordinate("Введите координату Z второй точки: ");

    int NumA = x2 - x1;
    int NumB = x2 - y1;
    int NumC = z2 - z1;
    double length = Math.Sqrt(NumA * NumA + NumB * NumB + NumC * NumC);
    Console.WriteLine($"Длинна отрезка {length}");
    int ReadCoordinate(string message)
    {
        Console.Write(message);
        return int.Parse(Console.ReadLine() ?? "");
    }
}
catch (Exception exc)
{
    Console.WriteLine($"Ошибка буквы не принимаем: {exc.Message}");
}



