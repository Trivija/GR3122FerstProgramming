// ---------------------------------------------------------------------
//                                 Задача 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// * При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)
// ---------------------------------------------------------------------

// Задаем цвета
ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};



int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Универсальный метод генерации двумерного массива
double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
// вставляем в [] строки и столбцы (указываем, что массив двумерный)
    double[,] array2D = new double[countRow, countColumn];
// Проходим все строки
    for (int i = 0; i < countRow; i++)
//Проходим все столбцы
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1) * rand.NextDouble();
        }
    }
    return array2D;
}
//Печать двумерного массива цветом
void Print2DArrayColored(double[,] matr)
// Проходим все строки
{
    for (int i = 0; i < matr.GetLength(0); i++)
//Проходим все столбцы
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            PrintStringColor($"{Math.Round(matr[i, j], 2)} \t");
        }
        Console.WriteLine();
    }
}
void PrintStringColor(string data)
{
    foreach (char sign in data)
 // Рандомный выбор цвета 
   {
        Console.ForegroundColor = col[new System.Random().Next(0, 16)];
        Console.Write(sign);
        Console.ResetColor();
    }
}
int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

double[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColored(arr2D);