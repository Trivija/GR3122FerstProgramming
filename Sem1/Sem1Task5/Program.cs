//===========================================================================================================
// Задача No5
//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.//
//===========================================================================================================

string? inputLineN = Console.ReadLine(); //ввести значение //

if (inputLineN != null)                               //!= не равно//
{
    int inputNumberN = int.Parse(inputLineN);          // int inputNamber выбор переменной////int.Parse(inputLine - преврати строкус в число //
    if (inputNumberN > 0)
   {
    int startNumber = (-1) * inputNumberN;
    while (startNumber < inputNumberN)

{
    Console.Write(startNumber + ", ");
    startNumber = startNumber + 1;
}
Console.Write(inputNumberN);
}
}



// ctrl+S - сохранить,   alt + shift + S - выровнить//
