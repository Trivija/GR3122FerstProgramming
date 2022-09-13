//==================================================================================================
// No21 
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
//==================================================================================================
int ReadData(string line)// считываем данные из консоли
{
    
    Console.WriteLine(line);// выводим сообщение
    
    int number = int.Parse(Console.ReadLine() ?? "0");//считываем число
   
    return number; // возвращаем значение
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}

double Colculite(int х1, int y1, int z1, int х2, int y2, int z2)// расстояние между строками
{
    return Math.Sqrt((х2 - х1) * (х2 - х1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
}
// собираем данные
int х1 = ReadData("Введите число х1: ");
int y1 = ReadData("Далее введите y1: ");
int z1 = ReadData("Затем введите z1: ");
int х2 = ReadData("Потом введите х2: ");
int y2 = ReadData("Введите y2: ");
int z2 = ReadData("И последнее z2: ");


// выводим результат
PrintResult(Math.Round(Colculite(х1, y1,z1, х2, y2,z2),2).ToString());