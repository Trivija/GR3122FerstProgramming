// 14 Напишите программу, которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 7 и 23.


// 1) А = Console.ReadLine()
// 2) R1 = (A % 7 == 0 );
//    R2 = (A % 23 == 0);
//    выводим результат
// 3) if (R1 && R2) && - логическая "и" требует чтобы,было и первое верно и второе верно
// || - логическая или разрешает и то и то
// Console.WriteLine ( "Число кратное 7 и 23") ;
// else
// {
//     Console.WriteLine ("Не кратно 7 и 23")ж 
// }
// =================================================================================

void Variant1()
{
Console.Write("Введите первое число: ");
string? inputLineA = Console.ReadLine();
Console.Write("Введите второе число: ");
string? inputLineB = Console.ReadLine();

int inputNumberA = int.Parse(inputLineA);
int inputNumberB = int.Parse(inputLineB);

Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA));
}

Variant1();

//============================================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
int inputNumberA = (int)int.Parse(inputLineA);
int inputNumberB = (int)int.Parse(inputLineB);

Console.WriteLine(inputNumberB%inputNumberA==0?"Является кратным":inputNumberB%inputNumberA);
}

//============================================================================
int number, resultA, resultB;
// // запрашиваем число у пользователя
// int RequestNumber(string text = "Enter number", string exitCmd = "q")
// {
//     while (true) //выполняется пока польз-ль не введет целое число/этот бесконечный цикл
//     {
//         Console.Write(text + ": ");
//         string? inputLine = Console.ReadLine();
//         if (inputLine == null)
//         {
//             continue;
//         }
//         if (inputLine.ToLower() == exitCmd)

//     }
// }

//Чтение данных их консоли
// void CalculateData()


// //Ввод данных
// void PrintData



