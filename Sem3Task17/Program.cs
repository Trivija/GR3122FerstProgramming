//==================================================================================================
// Задача No17
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
// в которой находится эта точка.
//==================================================================================================
int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}
int QoterTest(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;
    return -1;
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}
int x = ReadData("Введите координату Х: ");
int y = ReadData("Введите координату Y: ");
int res = QoterTest(x, y);
PrintResult("Точка находится в четверти №: " + res);