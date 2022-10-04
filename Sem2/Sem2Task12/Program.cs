// 12 Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если второе число некратно первому, 
// то программа выводит остаток от деления.
//=================================================================================



// A = Console.WriteLine(); // печатаем это число
// B = Console.WriteLine();
// int Parse();
// bool R = (B%A == 0);
// if(R)
// Console.WriteLine ("число В кратно А");
// else
// Console.WriteLine ("не кратнo + В%A ");
// Console.WriteLine (A); // или Console.WriteLine (B*10+C); 

//2
// void Variant1()

// {
//     Console.Write("Введите первое число: "); // A
//     string? inputLineA = Console.ReadLine();
//     Console.Write("Введите второе число: ");  //B
//     string? inputLineB = Console.ReadLine();

//     int inputNumberA = int.Parse(inputLineA); //распарсили его
//     int inputNumberB = int.Parse(inputLineB);
    //использован тернарный оператор, сначала сравниваеи делится B на A?  (inputNumberB % inputNumberA == 0)
    // если делится то второе кратно первому
    // если не делится то "Остаток от деления: " + inputNumberB % inputNumberA ));
//     Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Вторе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA ));
// }
// Variant1()
// //=================================================================================
// // 3

// string? inputLineA = Console.ReadLine(); // Ввели значение
// string? inputLineB = Console.ReadLine();

// if (inputLineA != null && inputLineB != null) // порверили что не пустые
// {
// int inputNumberA = (int)int.Parse(inputLineA); // перевели
// int inputNumberB = (int)int.Parse(inputLineB);

// Console.WriteLine(inputNumberB%inputNumberA==0? "Является кратным":inputNumberB%inputNumberA);
// }
// Variant1();
//====================================================================================




int inputNumberA = 0; // обьявляем глобальные перемеменные 
int inputNumberB = 0; //отсбда эти данные будут браться для всей задачи
bool result = false; // положим переменную результата, пока пустую

//вызываем все эти данные
ReadData();
ConculateData();
PrintData();

// получаем 2 числа от пользователя
void ReadData() // считаем данные int не пишем, т.к. есть метод
{
Console.Write("Введите первое число: "); // A
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");  //B
    string? inputLineB = Console.ReadLine();

    int inputNumberA = int.Parse(inputLineA); //распарсили его
    int inputNumberB = int.Parse(inputLineB);
}
// Вычисление, определяем кратность чисел
void ConculateData() 
{
result = (inputNumberB % inputNumberA == 0); // посчитали кратно ли В числу А
}

// вывод данные вычисления, блок печаи результата
void PrintData() 
{
    if(result)
    {
        Console.WriteLine ("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления: " + inputNumberB % inputNumberA);
    }
}