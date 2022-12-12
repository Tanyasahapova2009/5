//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 69.4 -22 0.4 78] ->56
//Диапазон любой, ввод зависит от пользователя. (размер, значения)
using System;
using System.Globalization;

Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите массив");

double[] array = new double[n];

for (int i = 0; i < n; i++)
{
    NumberFormatInfo formatProvider = new NumberFormatInfo();
    formatProvider.NumberDecimalSeparator = ".";
   // formatProvider.NumberGroupSeparator = ",";
    array[i] = Convert.ToDouble(Console.ReadLine(), formatProvider);
    //Console.WriteLine(array[i]);
}
NumberFormatInfo nfi = new NumberFormatInfo();
nfi.NumberDecimalSeparator = ".";
Console.WriteLine(SumOdd(array).ToString(nfi));

double SumOdd (double[] array)
{   double max = 0;
    double min = 0;
    double sum = 0;

    for (int i = 0; i < n; i ++)
    {
      if (array[i] > max) max = array[i];
      
      if (array[i] < min) min = array[i];

    }
    sum = max + min;
    return sum;
}
