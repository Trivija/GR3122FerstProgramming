//================================================================================   
//                               Задача No27 *
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
//в числе.
//================================================================================

int ReadData(string line) // получаем данные 
{
    
 Console.WriteLine(line);//  сообщение
    
int number = int.Parse(Console.ReadLine() ?? "0");//считываем число
    
return number;// возвращаем значение
}

int DigitCount(int num)// вычисление
{
int sum = 0; // переменная  будет накапливать результат
while (num > 0) // цикл,число будет уменьшаться пока не станет 0, потом остановится
{
sum += num % 10; 
 num = num / 10; 
}
return sum; // результата числа
}
void PrintResult(string line)//  результата
{
Console.WriteLine(line);
}
// программа 
int num = ReadData("Введите число: ");
int sumDigit = DigitCount(num);
PrintResult("Сумма цифр: " + sumDigit);