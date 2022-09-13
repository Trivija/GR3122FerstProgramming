//==================================================================================================
// Задача No22
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
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
string LineNumbers(int numberN,int pow)
{
int i = 1;
string outline = string.Empty;
while (i < numberN)
{
 outline = outline + Math.Pow(i,pow) + "\t";
 ++i;
}
outline = outline + i + Math.Pow(numberN,pow);
return outline;
}
void PrintResult(string line)
{
Console.WriteLine(line);
}
int num = ReadData("Введите число N: ");
PrintResult(LineNumbers(num,1));
PrintResult(LineNumbers(num,2));