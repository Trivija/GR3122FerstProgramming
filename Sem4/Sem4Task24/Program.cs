//================================================================================
//                             Задача No24
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму 
// чисел от 1 до А.
//=============================================================================

int ReadData(string line) // метод который выведет число А (везде его копируем)
{
    // выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int numberA = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return numberA;
}
// метод который выводит результата (везде один)
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int VariantSumSimple(int numA) //метод выдаст сумму,
// передаем ему число от какого и до какого
{
    int sumOfNumbers =0; //переменная в которую будем накапливать
    for (int i=1;i<=numA;i++)//по такое число пока мы его не достигнем по 1
    {
        sumOfNumbers+=i;
        }
return sumOfNumbers;//вернет
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
PrintResult("Сумма чисел от 1 до А равна( метод гауса): " + res1); // это что выведится 
PrintResult("Сумма чисел от 1 до А равна(простой метод): " + res2);