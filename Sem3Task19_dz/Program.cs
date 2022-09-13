//==================================================================================================
// No19 
//Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
//==================================================================================================

int ReadData(string line) // получение данных 
{
    
    Console.WriteLine("Введите палиндром из 5 цифр:");// Сообщение
    
    int Palyndrome = int.Parse(Console.ReadLine() ?? "0");// считываем число
    
    return Palyndrome;// возвращаем значение
}
bool TestPalin(int Palyndrome) // проверяет число на полидром
{
    if ((Palyndrome / 10000 == Palyndrome % 10) && ((Palyndrome / 1000) % 10) == (Palyndrome / 10) % 10)
    {
        return true;  // если число полидром, значит - true
    }
    else
    {
        return false; // если число не полидром, false
    }
}
void PrintPalin(bool line) // печатать в консоли
{
    Console.WriteLine("Верно, введенное число является - числовым палиндром");

}
int Palyndrome = ReadData("введите число: "); // просит ввести число
bool result = TestPalin (Palyndrome); // ввод числа
PrintPalin (result); // вывод результата
