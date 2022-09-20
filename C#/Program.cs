// if     else. {}.   ==  ||. пример ввода

// ExploreIf();

// void ExploreIf()
// {
//     int a = 5;
//     int b = 3;
//     if (a + b > 10)
//     {
//         Console.WriteLine("его ответ больше 10");
//     }
//     else
//     {
//         Console.WriteLine("его ответ не превышает 10");
//     }

//     int c = 4;
//     if ((a + b + c > 10) && (a > b))
//     {
//         Console.WriteLine("Ответ больше 10");
//         Console.WriteLine("И первое число больше второго");
//     }
//     else
//     {
//         Console.WriteLine("Ответ не превышает 10");
//         Console.WriteLine("Или первое число не больше второго");
//     }

//     if ((a + b + c > 10) || (a > b))
//     {
//         Console.WriteLine("Ответ больше 10");
//         Console.WriteLine("Или первое число больше второго");
//     }
//     else
//     {
//         Console.WriteLine("Ответ не превышает 10");
//         Console.WriteLine("И первое число не больше второго");
//     }
// }

Console.Write ("Введите три числа:" ); 

string inputLine = Console.ReadLine()??"";  
int inputNumber = int.Parse(inputLine);  
    if (inputNumber > 99 && inputNumber<1000);
Console.WriteLine(inputNumber[1]);




int ReadData(string line) // получаем число 
{
    
    Console.WriteLine(line);// сообщнение
   
    int numberA = int.Parse(Console.ReadLine() ?? "0"); //считываем число
    
    return numberA;// возвращаем значение
}

void PrintResult(string line)// метод вывода результата
{
    Console.WriteLine(line);
}

int VariantSumSimple(int numA)
{
    int sumOfNumbers =0;
    for (int i=1;i<=numA;i++)
    {
        sumOfNumbers+=i;
        }
return sumOfNumbers; // возвращаем
}

int VariantSumGaus (int numA)
{ 
int sumOfNumbers = 0;
sumOfNumbers  = ((1  + numA) * numA) /2; 
return sumOfNumbers;
}

int numberА =ReadData("введите число А: ");
int res1 = VariantSumGaus (numberА); // это вычисление в ментоде int VariantSumSimple(int numA)
int res2 = VariantSumSimple (numberА); 
PrintResult("Сумма чисел от 1 до А равна( метод гауса): " + res1); // это что покажет
PrintResult("Сумма чисел от 1 до А равна(простой метод): " + res2);

//========================================================================================
//челенж
//запрос данных у пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.Write(line);
    //считываем число
    int numberP = int.Parse(Console.ReadLine() ?? "0");
    return numberP; //возвращаем значение
}

Dictionary<int, int> GenerateDicPoli()
{
    Dictionary<int, int> palidrom = new Dictionary<int, int>();

    for (int i = 10; i < 100; i++)
    {
        int polik = (i) * 100 + (i % 10) * 10 + i / 10;
        palidrom.Add(polik,0);
        Console.WriteLine(polik);
    }
    return palidrom;
}

// тест на пятизначность и полиндром Лилия
bool TestPolinHash(int numberP , Dictionary<int, int> dict)
{
    if (dict.ContainsKey(numberP))
    {
        return true;
    }
    else
    {
        return false;
    }
}

// тест на пятизначность и полиндром Лилия
bool TestPolin(int numberP)
{
    if ((numberP / 1000) == (numberP % 100))
    {
        return true;
    }
    else
    {
        return false;
    }
}

// Метод проверки палиндрома Кирилла
bool PalindromeTest(double a)
{
    char[] charArray = a.ToString().ToCharArray();
    Array.Reverse(charArray); // Тут просто разворачиваем массив
    double reversedArray = double.Parse(charArray);
    if (reversedArray == a) // Проверка на палиндром
    {
        return true;
    }
    else
    {
        return false;
    }

}



int polindrom = ReadData("Введите полиндром:");

Dictionary<int, int> palidromDic = GenerateDicPoli();


DateTime d1 = DateTime.Now;
TestPolin(polindrom);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
PalindromeTest(polindrom);
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
TestPolinHash(polindrom,palidromDic);
Console.WriteLine(DateTime.Now - d3);