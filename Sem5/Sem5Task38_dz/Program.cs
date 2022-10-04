// ---------------------------------------------------------------------
//                                 Задача 38
// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// * +2 метода сортировки (Вставкой и подсчетом)
// ---------------------------------------------------------------------

// Метод считывания данных пользователя
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double [] FillArray (int arrLength, int arrMaxNum, int arrMinNum)
//Генератор случайных чисел
 {
    Random rand = new Random(); 
    double[] array = new double[arrLength];

// идем по всему массиву
    for (int i = 0; i < arrLength; i++) 
    {
        array[i] = Math.Round (rand.NextDouble() *100,2);
    }
    return array;
 }
// печать массива
void Print1DArray(double[] arr)
 {
     Console.Write("[" + arr[0] + ", ");
     for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
     Console.WriteLine(arr[arr.Length - 1] + "]");
     Console.WriteLine();
 }
// считаем разницу между min и мах элементом
double MaxMin (double[] arr)
{
   double махNum = int.MinValue;
   double minNum =  int.MaxValue;
    for (int i = 0; i < arr.Length; i++)// 
    {
         if (arr[i] > махNum) // если элемент массива больше мах числа
         {
         махNum  = arr[i]; // мах становится этот элемент массива
         }
        if (arr[i] < minNum )
        {
        minNum = arr[i];
        }
    }
   return (махNum  - minNum); // возвращает разницу между мах и min значением
}


// вывод в консоль
void PrintData(string line)
 {
    Console.WriteLine(line);
 }
double[] array = FillArray (20,10,2);
Print1DArray (array); // печать массива
double sumArray = MaxMin (array); 
PrintData ("Разница максимального и минимального элементов: " + sumArray);