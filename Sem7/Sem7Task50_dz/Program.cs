// ---------------------------------------------------------------------
//                                 Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет
// * Заполнить числами Фиббоначи и выделить цветом найденную цифру
// ---------------------------------------------------------------------

//запрос данных у пользователя 
int ReadData(string line)
{
// Выводим сообщение
    Console.Write(line);
// Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
// Возвращаем значение
    return number;
// Заполняем массив случайными числами
}
int[,] Fill2DArray(int row, int column, int min, int max)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array2D[i, j] = new Random().Next(min, max + 1);
        }
    }
      return  array2D;
}
// Печать двумерного массива 
void Print2DArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write($"{array2D[i, j]} \t ");
        }
        Console.WriteLine();
    }
}
// поиск элемента
int FindElement(int y, int x, int[,] array2D)
{
    if (y < array2D.GetLength(0) && x < array2D.GetLength(1))
    {
        return array2D[y, x] ; // y = строка; х = столбец
    }
    else
    {
        return -1;
    }
}
// Печать результата
void PrintResult(int y, int x, int[,] array2D)
{
    if (y < array2D.GetLength(0) && x <  array2D.GetLength(1))
    {
        Console.WriteLine($"Элемент {array2D[y, x]}");
    }
    else
    {
        Console.WriteLine("Нет элемента");
    }
}
int row = ReadData("Введите количество столбцов M: ");
int column = ReadData("Введите количество строк N: ");
Console.WriteLine();
int[,] array = Fill2DArray(row, column, 1, 99);
Print2DArray(array);
Console.WriteLine(); 
int y = ReadData("Введите количество столбцов M: ") - 1;
int x = ReadData("Введите количество строк N: ") -1;
int element = FindElement(y, x, array);
PrintResult(y, x, array);