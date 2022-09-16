//================================================================================
//                                 Задача No29 
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на 
//экран. 
//* Ввести с клавиатуры длину массива и диапазон значений элементов
//================================================================================

int ReadData(string line) // получаем данные 
{
    
     Console.WriteLine(line);// выводим сообщение
   
     int number = int.Parse(Console.ReadLine() ?? "0"); //считываем число
    
    return number;// возвращаем зн-е
}
int [] GenArr (int num, int start, int stop) // границы массива (2)
{
    Random ren = new Random (); // создаем рандом
    int [] outArr = new int [num]; // заполнение массив
    for (int i = 0; i < outArr.Length - 1; i++) // заполнение цикла
{
outArr [ i ] = ren. Next (start, stop);
}
return outArr; //результат
}

void PrintArr (int [] outArr)// результат
{
    for (int i = 0; i < outArr.Length; i++)
    {
      Console.Write ( outArr [i] + ",");
    }
  Console.WriteLine ( outArr [outArr.Length - 1]);
}
int arrLen = ReadData ("Введите длинну массива: ");//  число, длинну массива, которую хотим сделать
int start = ReadData ("Введите границу начала массива: "); // переменная 1 числа
int stop = ReadData ("Введите границу конца массива: ");// переменная 2 числа
int [] array = GenArr(arrLen, start, stop);//  переменная для массива
PrintArr (array); // массив передали

