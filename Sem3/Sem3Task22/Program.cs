//==================================================================================================
//                            Задача No22
// Напишите программу, которая принимает на вход число (N)и выдаёт таблицу 
//квадратов чисел от 1 до N.
//Нужен метод который соберет таблицу и метод который
//1 2 3 4 5 6
//1 4 9 16 25 36
//==================================================================================================


int ReadData(string line)// метод
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
while (i < numberN) // цикл
{
 outline = outline + Math.Pow(i,pow) + "\t"; // не пробел а табуляцию "\t" лучше использовать
 ++i; // если идет увеличение то нужно добавить ++i, выйти из нее ctrl + c
}
outline = outline + i + Math.Pow(numberN,pow);
return outline;
}
void PrintResult(string line)
{
Console.WriteLine(line);
}
int num = ReadData("Введите число N: "); //от пользователя
PrintResult(LineNumbers(num,1));
PrintResult(LineNumbers(num,2));