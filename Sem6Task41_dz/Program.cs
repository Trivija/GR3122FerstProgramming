// ---------------------------------------------------------------------
//                                 Задача 41
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
//больше 0 ввёл пользователь.
// ---------------------------------------------------------------------

Console.Clear();
int m;
PrintResult(ColculateTask(Read()));

//метод чтения данных
int[] Read()
{
    Console.WriteLine($"Сколько чисел введете ?: ");
    m = int.Parse(Console.ReadLine() ?? ""); ;
    int[] array = new int[m];
    int i = 0;
    Console.WriteLine("Введите числа. ");
    while (i < m)
    {
        Console.Write($"{i + 1} число: ");
        array[i] = int.Parse(Console.ReadLine() ?? "");
        i++;
    }
    return array;
}
//метод вычисления
int ColculateTask(int[] array)
{
    int countPosNum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
        {
            countPosNum++;
        }
    return countPosNum;
}
//метод печати
void PrintResult(int countPosNum)
{
    Console.WriteLine($"Кол-во введенных чисел больше нуля: {countPosNum} ");
}














// // Чтение данных из консоли
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Печать результата
// void PrintResult(string prefix, string data)
// {
//     Console.WriteLine(prefix + data);
// }

// // Считаем положительные числа
// int Count(int m)
// {
//     int res = 0;
//     for (int i = 0; i < m; i++)
//     {
//         int num = ReadData("Введите число: ");
//         if (num > 0) res++;
//     }

//     return res;
// }

// PrintResult("Пользователь ввёл чисел больше ноля: ", Count(ReadData("Введите количество чисел: ")).ToString());