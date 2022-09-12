//11. Напишите программу, которая выводит 
//случайное трёхзначное число и удаляет вторую цифру этого числа
//================================================================

int A = new Random().Next(100, 1000);

Console.WriteLine(A); // печатаем это число

int B = A/100;

int C = A%10;  //последнее число

A = B*10+C;
Console.WriteLine (A); // или Console.WriteLine (B*10+C); 

// Вадиант 2
void Variant1()
{
    Console.WriteLine("Вариант 1:");
    int number = new Random().Next(100, 1000); // прлучили число 
    Console.WriteLine(number);// вывели это число 
    char[] charArray = number.ToString(). ToCharArray(); //превратили в масив символов
    Console.Write(charArray[0]);   //напечатал первый и
    Console.WriteLine(charArray[2]);   //последний
}
Variant1();

// Вариант 3

void MyVariant()
{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);
    char [] charArray = number.ToString().ToCharArray();
    Console.WriteLine(""+ charArray[0]+charArray[2]);
}
MyVariant();