//================================================================================
//                                 Задача 26
// Напишите программу, которая принимает на вход число и выдаёт количество 
//цифр в числе
//================================================================================

// Чтение данных из консоли
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.WriteLine(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Печать результата
// void PrintResult(string line)
// {
//     Console.WriteLine(line);
// }

// int DigitCount(int num)// берем чисоло
// {
//     int sum = 0; // обьявляем переменную в которую будем накапливать сумму
//     while (num > 0)// и цикл пока наше число больше 0
//     {
//         sum += 1;
//         num = num / 10; // это число делим на 10, уменьшаем его на каждом шаге
//     }
//     return sum;// выдает на выход
// }

// // Вариант с логарифмом
// int CalculateDigits(int num)
// {
//     return (int)(Math.Log10(num) + 1);
// }

// int number = ReadData("Введите число: ");
// int numberOfDigits = CalculateDigits(number);
// PrintResult("Количество цифр в числе: " + numberOfDigits);
// PrintResult("Количество цифр в числе: " + DigitCount(number));

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Вариант с длиной строки
 int CalculateDigitsString(int num)
 {
     string numString = num.ToString();
     return numString.Length;
 }

// Вариант с логарифмом
int CalculateDigits(int num)
{
    return (int)(Math.Log10(num) + 1);
}

int DigitCount(int num)
{
    int sum=0;
    while(num>0)
    {
        sum+=1;
        num=num/10;
    }
    return num;
}

int number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int numberOfDigits = CalculateDigits(number);
Console.WriteLine(DateTime.Now - d1);

PrintResult("Количество цифр в числе: " + numberOfDigits);

DateTime d2 = DateTime.Now;
 numberOfDigits = CalculateDigitsString(number);
 Console.WriteLine(DateTime.Now - d2);

PrintResult("Количество цифр в числе: " + numberOfDigits);

DateTime d3 = DateTime.Now;
 numberOfDigits = CalculateDigits(number);
 Console.WriteLine(DateTime.Now - d3);

PrintResult("Количество цифр в числе: " + numberOfDigits);