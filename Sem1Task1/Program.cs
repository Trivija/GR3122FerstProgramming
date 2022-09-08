//===========================================================================================================
// Задача No1
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//Например:
//a = 25; b = 5 -> да a = 2 b = 10 -> нет
//a = 9; b = -3 -> да a = -3 b = 9 -> нет
//===========================================================================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine(); //ввести значение //
if (inputLineA != null&&inputLineB != null)   //оба числа сравнить на 0 //
{
    int inputNamberA = int.Parse(inputLineA);  // int inputNamber выбор переменной////int.Parse(inputLine - преврати строкус в число //
    int inputNamberB = int.Parse(inputLineB); // превратить в целые числа//
    
    //bool outResult = (inputNamberA*inputNamberA==inputNamberB); // Сравнить два числа. Будет вычесленно значение внутри и положено outResult//
    bool outResult = (inputNamberB/inputNamberA == inputNamberA);

Console.WriteLine(outResult);      // вывести пользователю результат//
}
// False - не правда, True - правда//
// ctrl+S - сохранить,   alt + shift + S - выровнить//
