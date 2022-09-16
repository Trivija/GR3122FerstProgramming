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
