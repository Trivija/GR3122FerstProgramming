﻿//                          Задача No25 
//Напишите цикл, который принимает на вход два числа (A и B) и возводит 
//число A в натуральную степень B.

// 3 метода:
//1)ReadData()
//2) Pow(int A; int B)степень 
//{
// long res = 1; т.к степень поэтому long он большеи int, результат пока = 1
// и ее (1) возвращаем (return res)
// Далее должны умножить столько раз сколько число B
//for (int i = 0; i < B; 1++)
// {
//     res = res * A;
// }
//3)PrintData ()
//==============================================================================

int ReadData(string line) // получаем данные,  на какое число в какую степень возводить
{
    
Console.WriteLine(line);// выводим сообщение
    
int number = int.Parse(Console.ReadLine() ?? "0");//считываем число
    
return number;// возвращаем значение
}
// степень. Указываем два числа. Так как результат возведения в степень получится длинным, указваем long 
//т.к степень поэтому long он большеи int, результат пока = 1
long Pow (int numА, int numB) 
{
long res = 1; // создаем переменную, 
for (int i = 0; i < numB; i++) // тут * столько раз сколько число В
res = res * numА;
return res; // возвращаем результат переменной long res
}
void PrintData (long line)
{
Console.WriteLine(line);
}
// программу 
int numА = ReadData ("Введите число: ");
int numB = ReadData ("Введите число для возведения в степень: ");
long numPow = Pow (numА, numB);
PrintData (numPow);