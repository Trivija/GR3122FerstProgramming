// 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе
//  показывает вторую цифру этого числа.
//============================================================================

string? Thirdnumber; //переменная

inputNumber(); //вызов метода
Print();
void inputNumber() // ввод числа
{
    Console.WriteLine( "Введите трезхначное число,а я покажу вторую цифру в нем : ");
    Thirdnumber = Console.ReadLine();
}
void Print() // печать результата
{
if (Thirdnumber != null) //есть значение, не пустая строка
{
    if (Thirdnumber.Length == 3)// если = 3, то продолжаем действия
    {
        char[] Array = Thirdnumber.ToCharArray();// этот метод превратит строку в массив
                Console.Write("вторая цифра:  ");
                Console.WriteLine(Array[1]);
    }
    else // если не равно 3
    {
        Console.WriteLine("число не трехзначное"); 
    }
}
}