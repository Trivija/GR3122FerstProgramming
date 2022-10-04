// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
//===============================================================================
string? Threedigit; //переменная
inputNumber(); //вызов метода
Print();
void inputNumber() // ввод числа
{
    Console.WriteLine( "Введите трезхначное число,а я покажу третью цифру в нем : ");
    Threedigit = Console.ReadLine();
}
void Print() // печать результата
{
if (Threedigit != null)
{
    if (Threedigit.Length >= 3)// если >= 3, то продолжаем действия
    {
        char[] Array = Threedigit.ToCharArray();// этот метод превратит строку в массив символов
                Console.Write("третья цифра:  ");
                Console.WriteLine(Array[2]); //т.к. уже масив,то счет начинается с 0, поэтому индекс - 2
    }
    else // если не равно 3
    {
        Console.WriteLine("Это не трехзначное число!"); 
    }
}
}




//int n = int.Parse(Console.ReadLine()); int k = (int)Math.Log10(n)-2; Console.WriteLine(k < 0 ? "No such digit" : (n % (int)Math.Pow(10, k + 1) / (int)Math.Pow(10, k)).ToString()); Console.ReadLine();