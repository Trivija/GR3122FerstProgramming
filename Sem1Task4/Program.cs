//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7    ;  44 5 78 -> 78


// int a = 2;
// int b = 3;
// int c = 7;

// int max = a;
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;

// Console.Write("максимальное число = ");
// Console.WriteLine(max)


int num1 = 44, num2 = 5, num3 = 78;
 int max;
 if (num1 >= num2)
 {
    if (num3 >= num1)
    {
       max = num3;
    }
    else
    {
       max = num1;
    }
 }
 else
 {
    if (num3 >= num2)
    {
       max = num3;
    }
    else
    {
       max = num2;
    }
 }
 Console.Write("максимальное число = ");
Console.WriteLine(max);