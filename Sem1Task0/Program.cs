//===========================================================================================================
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
//Например: 4 -> 16 -3 -> 9 -7 -> 49//
//===========================================================================================================

string? inputLine = Console.ReadLine(); //ввести значение //
if (inputLine != null)   //!= не равно//
{
    int inputNamber = int.Parse(inputLine);  // int inputNamber выбор переменной////int.Parse(inputLine - преврати строкус в число //
    int outNumber = 0;

    DateTime d1 = DateTime.Now;
    for (int i = 0; i < 10000000; i++)
    {
       outNumber = inputNamber * inputNamber;     //inputNamber*inputNamber -  число умноженное на само себя//
    }

DateTime d2 = DateTime.Now;
Console.WriteLine(d2 - d1);

Console.WriteLine(outNumber);      // вывести пользователю результат//
}

// ctrl+S - сохранить,   alt + shift + S - выровнить//
