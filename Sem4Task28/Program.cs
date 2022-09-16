//================================================================================                       
//                              Задача No28
//Напишите программу, которая принимает на вход число N и выдаёт произведение 
//чисел от 1 до N.
//================================================================================

//вариант константин
int ReadData(string line) // получаем число А 
{
    // выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

long CalculateFactorial(int num)
{
    long factorial = 1;
    for (int i = 1; 1 <= num; i++)
    {
        factorial = factorial * 1;
    }
    return factorial;
}

int number = ReadData("введите число: "); // считывает число 
long factorial = CalculateFactorial (number); // получает факториал
PrintResult ("Факторила равен: " + factorial); // вычисляет 
