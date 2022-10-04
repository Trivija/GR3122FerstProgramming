//==================================================================================================
//                               No19 
//Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
//==================================================================================================

int ReadData(string line) // метод который читает данные для всего
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
// вывод результата
void PrintPalin(bool line) // печатать в консоли
{
    Console.WriteLine("Верно, введенное число является - числовым палиндром");

}
int Palyndrome = ReadData("введите число: "); // просит ввести число
bool result = TestPalin (Palyndrome); // ввод числа
PrintPalin (result); // вывод результата

//===================================================================================
//  
// 2 вариант
//===================================================================================================
// 
//void Palindrom()
// {
//     int num = int.Parse(Console.ReadLine());
//     int D1 = num / 10000;
//     int D2 = (num / 1000) % 10;
//     int D3 = (num / 100) % 10;
//     int D4 = (num / 10) % 10;
//     int D5 = num % 10;

//     if (D1 == D5 && D2 == D4)
//     {
//         Console.WriteLine($"Число {num} является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine($"Число {num}  не является  палиндромом");
//     }
// }
//========================================================================
// // 3 вариант решения
//=======================================================================
// void Variant2()
// {
//     Console.WriteLine("Введите пятизначное число: ");
//     string? inputLine = Console.ReadLine();
//     if (inputLine != null)
//     {
//         char[] arr = inputLine.ToCharArray();// превращаем в символы
//         if (arr.Length >= 5)
//         {
//             if ((arr[0] == arr[4]) && (arr[1] == arr[3]))
//             {
//                 Console.Write($"Число {inputLine} является палиндромом");
//             }
//             else
//             {
//                 Console.WriteLine($"Число {inputLine}  не является  палиндромом");
//             }
//         }
//     }
// }

// Console.WriteLine("Введите пятизначное число: ");

// Palindrom();
// Variant2();
//=============================================================================
//  4 вариант
//============================================================================
//запрос данных у пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP; //возвращаем значение
}

// тест на пятизначность и полиндром
bool TestPolin(int numberP)
{
    if ((numberP > 9999) && (numberP < 100000))
    {
        if ((numberP / 10000) == (numberP % 10) && (numberP / 1000) % 10 == ((numberP / 10) % 10))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        Console.WriteLine("Try again!");
        return false;
    }
}

//вывод результата
void PrintData(int numberP)
{
    if (TestPolin(numberP)) // сам тест внутри условного оператора
    //вызываем тест и он выдает правда или лож
    {
        Console.WriteLine("This's Polindrom. Well done!");// если правда то - полиндром
    }
    else
    {
        Console.WriteLine("This isn't Polindrom. Sorry!");
    }
     if ((numberP < 9999) && (numberP > 100000))
     {
         Console.WriteLine("Try again!");
    }
}

//собираем данные, то есть программируем свою программу
int numberP = ReadData("input five-digit number Polindrom: "); // считывакм данные и передаем в метод void PrintData(int numberP)

PrintData(numberP);


// делаем прверку по времени

int palindrom = ReadData("Введите палиндром:");

DateTime d1 = DateTime.Now;
TestPalin(palindrom);
Console.WriteLine(d1);