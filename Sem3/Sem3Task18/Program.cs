//==================================================================================================
//                            Задача No18
// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).
//==================================================================================================

int ReadData(string line)
{
    // выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
    return number;
}
string QoterBorderAsk(int numQoter) //меняем QoterTest на QoterBorderAsk, 
//вопрос о границы четверти (int numQoter)- просто указывается номер четверти
//пишем в текствовом string формате которую потом выведем пользователю
{
    if (numQoter == 1)//1 четверть 
        return "x>0 y>0";// вернем то условие которе было для 1 четверти
    if (numQoter == 2)//2 четверть
        return "x<0 y>0";
    if (numQoter == 3)
        return "x<0 y<0";
    if (numQoter == 4)
        return "x>0 y<0";
    return "";// т.к. не число выводим а текст поэтому вводи пустую строчку
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}
int num = ReadData("Введите номер четверти: ");//решение
string res = QoterBorderAsk(num);// нужен тест, вызываем его QoterBorderAsk
PrintResult(res);// вывести результат