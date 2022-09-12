//=============================================================
//Напишите программу, которая выводит случайное число 
//из отрезка [10, 99] и показывает наибольшую цифру числа
//===================================================================================================


void MyVariant() //  метод который ничего не возвращает, оборачиваем как конфету содержимое
{
System.Random numberGenerator = new System.Random(); //System.Random - тип, numberGenerator-название new - создаем System.Random()- вызвали оперативную память и создали место

int number = numberGenerator.Next(10,100); //Next(10,100) - выдай следующее.Ген-тор. Создали переменную и попросили выдать число которое положили

Console.WriteLine(number); // смотрим чтот выдал ген-тор

int ferstDigit = number/10; //число 1 делем на 10
int secondDigit = number%10; // число с остатком


// Вариант Евгения тернарный оператор
Console.WriteLine((ferstDigit > secondDigit) ? ferstDigit : secondDigit);

// Вариат char
char[] charArray = number.ToString().ToCharArray();
Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);