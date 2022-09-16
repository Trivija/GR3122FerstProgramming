// 16. Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
//=======================================================================
//чтение данных из консли
int ReadData(string line) // меотод чтения данных, общение с ользователем
{
    // выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine()?? "0");// возвращаем значение, 
    //если пользовательничего не введет то будет просто 0
    
    return number; //метод должен что-то возвращать,возвращаем значение
}
//тест на квадрат. Является ли первое число квадратом или нет(int firstNum - 1 число, int secondNum - 2 число)
bool SqrTest(int firstNum, int secondNum) //метод опреления квадрата
// bool - вернуть либо true,false
{
    if (firstNum == secondNum * secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}
//вывод данных
void PrintData(int firstNum, int secondNum)// метод печати
// в метод void, вносим те же данные что и в метод SqrTest
{
    if (SqrTest(firstNum, secondNum))
    {
        Console.WriteLine("Число" + firstNum + "квадрат числа"  + secondNum);
    }
    else
    {
        Console.WriteLine("Число" + firstNum + "не квадрат числа" + secondNum);
    }
}
int num1 = ReadData("Введите число 1: ");//вводим 1 число
int num2 = ReadData("Введите число 2: ");//вводим 2 число
PrintData(num1, num2);//сразу вызываем на печать, сначало 1 число
PrintData(num2, num1);// потом 2(предполагаем что 2 число является квадратом 1)