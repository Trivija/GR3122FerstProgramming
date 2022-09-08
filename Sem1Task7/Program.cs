// Задача No7
//Напишите программу, которая принимает на вход трёхзначное число и на выходе
//показывает последнюю цифру этого числа.


string? inputLine = Console.ReadLine();              //ввести значение //

if (inputLine != null)                               //!= не равно//
{
    int inputNumber = int.Parse(inputLine);          // int inputNamber выбор переменной////int.Parse(inputLine - преврати строкус в число //
    if (inputNumber > 99 && inputNumber < 1000)
   {
    int lastDigit = inputNumber % 10;
    Console.Write(lastDigit);
   }         
}



// ctrl+S - сохранить,   alt + shift + S - выровнить//
