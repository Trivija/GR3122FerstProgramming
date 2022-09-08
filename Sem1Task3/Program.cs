//===========================================================================================================
// Задача No3
//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//Например: 3 -> Среда
//5 -> Пятница
//===========================================================================================================


string? inputLine = Console.ReadLine(); //ввести значение //

if (inputLine != null)   //!= не равно//
{
  int inputDayOfweek = int.Parse(inputLine);  // int inputNamber выбор переменной////int.Parse(inputLine - преврати строкус в число //

//string[] dayOfWeek = new string[7];       //[] - указывпет на массив  dayOfWeek - название = new string[7] - значение,сколько//
   // dayOfWeek[0] = "Понедельник";
    //dayOfWeek[1] = "Вторнк";
   // dayOfWeek[2] = "Среда";
   // dayOfWeek[3] = "Четверг";
   // dayOfWeek[4] = "Пятница";
    //dayOfWeek[5] = "Суббота";
   // dayOfWeek[6] = "Воскресенье";

//if (inputDayOfweek > 7 || inputDayOfweek < 1) // || - или //
//{
   // Console.WriteLine("Такого дня нет");
// }
  //else
//{
//Console.WriteLine(dayOfWeek[inputDayOfweek - 1]); // вывести пользователю результат//
//}
//}
    

string outDayOfweek = string.Empty;//"" // string.Empty;//"" - пустая строка//

switch(inputDayOfWeek)
{
     case 1: outDayOfWeek = "Понедельник"; break;
     case 2: outDayOfWeek = "Вторник"; break;
     case 3: outDayOfWeek = "Среда"; break;
     case 4: outDayOfWeek = "Четверг"; break;
     case 5: outDayOfWeek = "Пятница"; break;
     case 6: outDayOfWeek = "Суббота"; break;
     case 7: outDayOfWeek = "Воскресенье"; break;
    default: outDayOfWeek = "Такого дня нет"; break;
}

Console.WriteLine(outDayOfWeek);

}






// False - не правда, True - правда//
// ctrl+S - сохранить,   alt + shift + S - выровнить//
